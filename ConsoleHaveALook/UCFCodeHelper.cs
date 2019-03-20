using System;
using System.Collections.Generic;
using System.Text;

namespace UCFHelper {


	public class UCFCodeHelper
	{


		public IList<string> inputsList = new List<string>();
		public IList<string> outputsList = new List<string>();
		public static void Main()
		{
			// TODO Auto-generated method stub
			string line1 = Console.ReadLine();
			string line2 = Console.ReadLine();
			UCFCodeHelper helper = new UCFCodeHelper(line1,line2);
			Console.WriteLine(helper);
		}

		public UCFCodeHelper()
		{
		}
		public UCFCodeHelper(string inputs, string outputs)
		{
			this.Inputs = inputs;
			this.Outputs = outputs;
		}

		public virtual string Inputs
		{
			set
			{
				inputsList.Clear();
				string[] inputs = value.Split(" ", true);
				foreach (string input in inputs)
				{
					string[] fixedInputs = transform(input).Split(" ", true);
					foreach (string fixedInput in fixedInputs)
					{
						inputsList.Add(fixedInput);
					}
				}
			}
		}
		public virtual string Outputs
		{
			set
			{
				outputsList.Clear();
				string[] outputs = value.Split(" ", true);
				foreach (string output in outputs)
				{
					string[] fixedOutputs = transform(output).Split(" ", true);
					foreach (string fixedOutput in fixedOutputs)
					{
						outputsList.Add(fixedOutput);
					}
				}
			}
		}
		public override string ToString()
		{
			// TODO Auto-generated method stub
			StringBuilder finalBuilder = new StringBuilder();
			int index = 0;
			foreach (string str in inputsList)
			{
				finalBuilder.Append("NET \"" + str + "\" LOC = " + swSet[index++] + ";\n");
			}
			index = 0;
			foreach (string str in outputsList)
			{
				finalBuilder.Append("NET \"" + str + "\" LOC = " + ledSet[index++] + ";\n");
			}
			finalBuilder.Append('\n');
			foreach (string str in inputsList)
			{
				finalBuilder.Append("NET \"" + str + "\" IOSTANDARD = LVCMOS18;\n");
			}
			foreach (string str in outputsList)
			{
				finalBuilder.Append("NET \"" + str + "\" IOSTANDARD = LVCMOS18;\n");
			}
			finalBuilder.Append('\n');
			foreach (string str in inputsList)
			{
				finalBuilder.Append("NET \"" + str + "\" PULLDOWN;\n");
			}
			return finalBuilder.ToString();
		}


		public static string[] swSet = new string[] {"T3","U3","T4","V3","V4","W4","Y4","Y6", "W7","Y8","Y7","T1","U1"};
		public static string[] ledSet = new string[] {"R1","P2","P1","N2","M1","M2","L1","J2", "G1","E1"};
		public static StringBuilder attribNameBuffer = new StringBuilder(), leftNumberBuffer = new StringBuilder(), rightNumberBuffer = new StringBuilder();
		public virtual string transform(string str)
		{
			bool isComplex = false;
			int index = 0;
			int status = statusTable[0][(int)getStatus(str[index])];
			onStatuChange(0,status,str[index]);
			while (status != T && status != F)
			{
				int tempStatu = status;
				index++;

				status = (index < str.Length)?statusTable[status][(int)getStatus(str[index])]: statusTable[status][(int)Statu.End];
				if (index < str.Length)
				{
					onStatuChange(tempStatu,status,str[index]);
				}
			}
			return (status == T)?strBuild():str;
		}
		public virtual string strBuild()
		{
			StringBuilder builder = new StringBuilder();
			int leftNumber = int.Parse(leftNumberBuffer.ToString());
			int rightNumber = int.Parse(rightNumberBuffer.ToString());
			string attribName = attribNameBuffer.ToString();
			int i = leftNumber;
			int pos = (rightNumber - leftNumber) / Math.Abs(leftNumber - rightNumber);
			for (i = leftNumber;i != rightNumber + pos;i += pos)
			{
				builder.Append(attribName + outputLeftBracket + i + outputRightBracket);
				if (i != rightNumber)
				{
					builder.Append(' ');
				}
			}
			leftNumberBuffer.Remove(0, leftNumberBuffer.Length);
			rightNumberBuffer.Remove(0, rightNumberBuffer.Length);
			attribNameBuffer.Remove(0, attribNameBuffer.Length);
			return builder.ToString();
		}
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

}