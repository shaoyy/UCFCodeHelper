using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCodeString {
    class Program {
        static void Main(string[] args) {
            //Console.Write($"	assign inData = {{");
            Random rnd = new Random();
            for(int i = 31; i >=0; i--) {
                Console.WriteLine($"\t   Reg_Files[{i}]<=0;");
            }
            Console.WriteLine($"");
            Console.Read();
            
        }
    }
}
/*
 Console.Write($"assign OPBuffer[{i}] = {{");
                for (int j = 0; j < 31; j++) {
                    Console.Write($"OPout[{i}],");
                }
                Console.WriteLine($"OPout[{i}]}};");
     
     */
