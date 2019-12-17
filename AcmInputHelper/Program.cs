using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmInputHelper {
    class Program {
        static List<string> strList = new List<string>();
        static void Main(string[] args) {
            openInput();
        }
        static void openInput() {
            string str;
            while((str = Console.ReadLine()) != "end") {
                strList.Add(str);
            }
        }
    }
}
