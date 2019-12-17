using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmInputHelper {

    public class AcmInputCodeHelper {
        List<string> line;
        StringBuilder builder = new StringBuilder();
        public AcmInputCodeHelper(List<string> strList) {
            line = strList;
        }

        string buildCode() {
            builder.Clear();


            return builder.ToString();
        }
        bool ifPart(string str) {
            return str.Equals("part");
        }
        bool ifParts(string str) {
            return str.Equals("parts");
        }
        bool ifVar(string str) {
            return true;
        }
        bool ifConst(string str) {
            return true;
        }
        bool ifEndwith(string str) {
            return str.Equals("endwith");
        }
        bool ifBlockStart(string str) {
            return str.Equals("{");
        }
        bool ifBlockEnd(string str) {
            return str.Equals("}");
        }
        public override string ToString() {
            
            return base.ToString();
        }
    }
}
