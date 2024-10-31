using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Static_Data
{
    public static class PureFunction
    {
        public static string ToSentenseCase(string s)
            => s.ToUpper()[0] + s.ToLower().Substring(1);

        public static List<string> Format(List<string> list)
            => list
                .Select(ToSentenseCase)
                .ToList();
        // vs
        public static List<string> Format2(List<string> list)
         => list
             .Select(s => s.ToUpper()[0] + s.ToLower().Substring(1))
             .ToList();
    }
}
