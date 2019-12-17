using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace UCFHelper
{


    public class UCFCodeHelper
    {
        public Dictionary<string, string> sourceMap = new Dictionary<string, string>();

        public CodeType TargetCodeType { get; set; } = CodeType.UCF;
        Pool<Variable> pool = new Pool<Variable>();
        public IList<Variable> variables = new List<Variable>();
        public bool compress = true;

        static void Main()
        {
            // TODO Auto-generated method stub
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            //UCFCodeHelper helper = new UCFCodeHelper(line1,line2);
            //Console.WriteLine(helper);
        }

        public static readonly string[] swSet, ledSet, btnSet, segSet, clkSet, keySet;
        public static string[][] sets;
        static UCFCodeHelper()
        {
            swSet = new string[] {
                "T3","U3","T4","V3","V4","W4","Y4","Y6",
                "W7","Y8","Y7","T1","U1","U2","W1","W2",
                "Y1","AA1","V2","Y2","AB1","AB2","AB3","AB5",
                "AA6","R2","R3","T6","R6","U7","AB7","AB8"};
            ledSet = new string[] {
                "R1","P2","P1","N2","M1","M2","L1","J2",
                "G1","E1","D2","A1","L3","G3","K4","G4",
                "K1","J1","H2","G2","F1","E2","D1","B1",
                "B2","N3","M3","K3","H3","N4","L4","J4"};
            btnSet = new string[] {
                "V8","AA8","AB6","T5","R4","AA4"
            };
            segSet = new string[] {
                "H19","G20","J22","K22","K21","H20","H22","J21",//seg
                "N22","M21","M22",//which
                "L21"//enable
            };
            clkSet = new string[] { "H4" };
            keySet = new string[] {
                "sw","led","btn","seg","clk","false"
            };
            sets = new string[6][];
            sets[0] = swSet;
            sets[1] = ledSet;
            sets[2] = btnSet;
            sets[3] = segSet;
            sets[4] = clkSet;
            sets[5] = keySet;
        }
        public UCFCodeHelper()
        {
            foreach (string key in keySet) sourceMap[key] = "";
        }

        public UCFCodeHelper(Dictionary<string, string> map)
        {
            sourceMap = map;
        }
        /// <summary>
        /// 调用ToString得在Work之后
        /// </summary>
        public void Work()
        {
            foreach(var v in variables) {
                v.Active = false;
            }
            variables.Clear();
            for (int i = 0; i < keySet.Length; i++)
            {
                WorkWith(sourceMap[keySet[i]],(VariableType)i);
            }
        }
        public void WorkWith(string src, VariableType variableType)
        {
            string[] srcSplited = src.Split(" ", true);
            foreach (string word in srcSplited) {
                Variable v = transform2Var(word);
                if (v != null) {
                    v.VariableType = variableType;
                    variables.Add(v);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder finalBuilder = new StringBuilder();
            if(TargetCodeType == CodeType.XDC && compress) {
                finalBuilder.AppendLine("set_property BITSTREAM.GENERAL.COMPRESS TRUE [current_design]");
                finalBuilder.AppendLine();
            }

            int[] offset = new int[5];
            foreach(Variable v in variables) {
                if (v.VariableType == VariableType.False) break;
                int index = (int)v.VariableType;
                finalBuilder.Append(v.getLocStr(TargetCodeType, sets[index], offset[index]));
                offset[index] += v.Length;
            }
            finalBuilder.AppendLine();
            foreach (Variable v in variables) {
                finalBuilder.Append(v.getIOStandardStr(TargetCodeType));
            }
            finalBuilder.AppendLine();
            foreach (Variable v in variables) {
                finalBuilder.Append(v.getPulldownStr(TargetCodeType));
            }
            finalBuilder.AppendLine();
            foreach (Variable v in variables) {
                finalBuilder.Append(v.getFalse(TargetCodeType));
            }
            //if ((check = checkOverflow()) != -1)
            //{
            //    finalBuilder.Append(getOverflowInfo(check));
            //    return finalBuilder.ToString();
            //}
            //int index = 0;
            //if (TargetCodeType == CodeType.UCF)
            //{
            //    for (int j = 0; j < lists.Length - 1; j++)
            //    {
            //        foreach (string str in lists[j])
            //        {
            //            finalBuilder.Append($"NET \"{str}\" LOC = {sets[j][index++]};\r\n");
            //        }
            //        index = 0;
            //    }
            //    finalBuilder.Append("\r\n");

            //    for (int j = 0; j < lists.Length - 1; j++)
            //    {
            //        foreach (string str in lists[j])
            //        {
            //            finalBuilder.Append($"NET \"{str}\" IOSTANDARD = LVCMOS18;\r\n");
            //        }
            //        index = 0;
            //    }
            //    finalBuilder.Append("\r\n");

            //    foreach (string str in swList)
            //    {
            //        finalBuilder.Append($"NET \"{str}\" PULLDOWN;\r\n");
            //    }

            //    foreach (string str in falseList)
            //    {
            //        finalBuilder.Append("NET \"");
            //    }
            //}
            //else if (TargetCodeType == CodeType.XDC)
            //{

            //}
            return finalBuilder.ToString();
        }
        //public string getForeName(string s)
        //{
        //    return s.Split('[')[0];
        //}
        //public List<string> ToNameList(IList<string> lst)
        //{
        //    List<string> result = new List<string>();
        //    foreach (string str in lst)
        //    {
        //        string temp = getForeName(str);
        //        if (!result.Contains(temp)) result.Add(temp);
        //    }
        //    return result;
        //}
        public static StringBuilder attribNameBuffer = new StringBuilder(), leftNumberBuffer = new StringBuilder(), rightNumberBuffer = new StringBuilder();
        public virtual Variable transform2Var(string str) {
            if (str.Length == 0) return null;
            int endState = startStateMachine(str);
            Variable result = (endState == T) ? variableBuildFromBuffer() : variableBuild(str) ;
            clearBuffer();
            return result;
        }
        /// <summary>
        /// <para>把输入的字符串解析为多个</para>
        /// <para>A[2:0]   -->   A[2] A[1] A[0]</para>
        /// <para>B        -->   B</para>
        /// <para>Y[0:3]   -->   Y[0]</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [Obsolete]
        public virtual string transform(string str)
        {
            if (str.Length == 0) return str;
            int endState = startStateMachine(str);
            string result = (endState == T) ? strBuild() : str;
            clearBuffer();
            return result;
        }
        public int startStateMachine(string str) {
            int index = 0;
            int status = statusTable[0][(int)getStatus(str[index])];
            onStatuChange(0, status, str[index]);
            while (status != T && status != F) {
                int tempStatu = status;
                index++;

                status = (index < str.Length) ? statusTable[status][(int)getStatus(str[index])] : statusTable[status][(int)Statu.End];
                if (index < str.Length) {
                    onStatuChange(tempStatu, status, str[index]);
                }
            }
            return status;
        }
        /// <summary>
        /// 根据当前已读取的字符串信息，从创建Variable
        /// A[2:0]   -->   Variable{name = A,start = 2,end = 0}
        /// </summary>
        /// <returns></returns>
        public virtual Variable variableBuildFromBuffer() {
            Variable v = pool.GetPooledObject();
            v.name = attribNameBuffer.ToString();
            v.start = int.Parse(leftNumberBuffer.ToString());
            v.end = int.Parse(rightNumberBuffer.ToString());
            return v;
        }
        public virtual Variable variableBuild(string name,int start = -1,int end = -1) {
            Variable v = pool.GetPooledObject();
            v.name = name;
            v.start = start;
            v.end = end;
            return v;
        }
        /// <summary>
        /// 根据当前已读取的字符串信息，扩展成长字符串
        /// A[2:0]   -->   A[2] A[1] A[0]
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public virtual string strBuild()
        {
            StringBuilder builder = new StringBuilder();
            int leftNumber = int.Parse(leftNumberBuffer.ToString());
            int rightNumber = int.Parse(rightNumberBuffer.ToString());
            string attribName = attribNameBuffer.ToString();
            int i = leftNumber;
            int pos = (rightNumber - leftNumber) / Math.Abs(leftNumber - rightNumber);
            for (i = leftNumber; i != rightNumber + pos; i += pos)
            {
                builder.Append(attribName + outputLeftBracket + i + outputRightBracket);
                if (i != rightNumber)
                {
                    builder.Append(' ');
                }
            }
            return builder.ToString();
        }
        void clearBuffer()
        {
            leftNumberBuffer.Remove(0, leftNumberBuffer.Length);
            rightNumberBuffer.Remove(0, rightNumberBuffer.Length);
            attribNameBuffer.Remove(0, attribNameBuffer.Length);
        }
        /// <summary>
        /// 状态改变的回调
        /// </summary>
        /// <param name="before">前个状态</param>
        /// <param name="after">改变后的状态</param>
        /// <param name="nowChar">导致状态改变的字符</param>
		public virtual void onStatuChange(int before, int after, char nowChar)
        {
            if (after == 1)
            {
                attribNameBuffer.Append(nowChar);
            }
            if (after == 3)
            {
                leftNumberBuffer.Append(nowChar);
            }
            if (after == 5)
            {
                rightNumberBuffer.Append(nowChar);
            }
        }
        public virtual Statu getStatus(char s)
        {
            if (s >= '0' && s <= '9')
            {
                return Statu.Number;
            }
            else if (s == '(' || s == '<' || s == '[' || s == '{')
            {
                return Statu.LeftBracket;
            }
            else if (s == ')' || s == '>' || s == ']' || s == '}')
            {
                return Statu.RightBracket;
            }
            else if (s == ':')
            {
                return Statu.Colon;
            }
            else
            {
                return Statu.Charactor;
            }
        }
        public static char outputLeftBracket = '[';
        public static char outputRightBracket = ']';
        public const int F = 100;
        public const int T = 101;
        internal static int[][] statusTable = new int[][]
        {
            new int[] {F,1,F,F,F,F},
            new int[] {1,1,2,F,F,F},
            new int[] {3,F,F,F,F,F},
            new int[] {3,F,F,F,4,F},
            new int[] {5,F,F,F,F,F},
            new int[] {5,F,F,T,F,F}
        };
        public enum Statu
        {
            Number,
            Charactor,
            LeftBracket,
            RightBracket,
            Colon,
            End
        }

    }
    public enum CodeType
    {
        UCF,
        XDC
    }
    public class Variable :CanBePooled{
        public string name;
        public int start =-1;
        public int end =-1;
        StringBuilder builder = new StringBuilder();
        public VariableType VariableType { get; set; }
        public int Length { get { return Math.Abs(end - start) + 1; } }
        public bool Active { get; set; } = false;
        public int Forward { get {
                return (start != end) ? (end - start) / Math.Abs(end - start) : 1;
            }
        }
        public string getLocStr(CodeType codeType,string[] set,int offset) {
            if (VariableType == VariableType.False) return "";
            if (offset + Math.Abs(end - start) + 1 > set.Length) return "";
            builder.Clear();
            if(codeType == CodeType.UCF) {
                if (start == end) return $"NET \"{name}\" LOC = {set[offset]};\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"NET \"{name}[{start + i * Forward}]\" LOC = {set[offset+i]};\r\n");
                }
            }else if(codeType == CodeType.XDC) {
                if (start == end) return $"set_property PACKAGE_PIN {set[offset]} [get_ports {name}]\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"set_property PACKAGE_PIN {set[offset + i]} [get_ports {{{name}[{start + i * Forward}]}}]\r\n");
                }
            }
            return builder.ToString();
        }
        public string getIOStandardStr(CodeType codeType) {
            if (VariableType == VariableType.False) return "";
            builder.Clear();
            if (codeType == CodeType.UCF) {
                if (start == end) return $"NET \"{name}\" IOSTANDARD = LVCMOS18;\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"NET \"{name}[{start + i * Forward}]\" IOSTANDARD = LVCMOS18;\r\n");
                }
            } else if (codeType == CodeType.XDC) {
                builder.Append($"set_property IOSTANDARD LVCMOS18 [get_ports {name}]\r\n");
            }
            return builder.ToString();
        }
        public string getPulldownStr(CodeType codeType) {
            if (VariableType != VariableType.SwitchButton) return "";
            builder.Clear();
            if (codeType == CodeType.UCF) {
                if (start == end) return $"NET \"{name}\" PULLDOWN;\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"NET \"{name}[{start + i * Forward}]\" PULLDOWN;\r\n");
                }
            } else if (codeType == CodeType.XDC) {
                builder.Append($"set_property PULLDOWN true [get_ports {name}]\r\n");
            }
            return builder.ToString();
        }
        public string getFalse(CodeType codeType) {
            if (VariableType != VariableType.False) return "";
            builder.Clear();
            if (codeType == CodeType.UCF) {
                if (start == end) return $"NET \"{name}\" CLOCK_DEDICATED_ROUTE = FALSE;\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"NET \"{name}[{start + i * Forward}]\" CLOCK_DEDICATED_ROUTE = FALSE;;\r\n");
                }
            } else if (codeType == CodeType.XDC) {
                if (start == end) return $"set_property CLOCK_DEDICATED_ROUTE FALSE [get_nets {name}_IBUF]\r\n";
                for (int i = 0; i <= Math.Abs(end - start); i++) {
                    builder.Append($"set_property CLOCK_DEDICATED_ROUTE FALSE [get_nets {name}_IBUF[{start + i * Forward}]]\r\n");
                }
            }
            return builder.ToString();
        }
        //public string 
    }
    public enum VariableType {
        SwitchButton, Led, Button, Seg, Clk, False
    }
    public interface CanBePooled {
        bool Active { get; set; }
    }
    public class Pool<T> where T : class,CanBePooled,new () {
        List<T> lst;
        public int PooledAmount { get; set; } = 32;
        public int Count { get { return lst.Count; } }
        public bool willGlow = true;

        public Pool(){
            lst = new List<T>();
            for(int i = 0; i < PooledAmount; i++) {
                lst.Add(new T {Active = false});
            }
        }

        public void Clear() {lst.Clear();}

        public T GetPooledObject() {
            foreach(T obj in lst) {
                if (!obj.Active) { obj.Active = true; return obj; }
            }
            if (willGlow) {
                T obj = new T();
                lst.Add(obj);
                obj.Active = true;
                return obj;
            }
            return null;
        }

        
    }
}