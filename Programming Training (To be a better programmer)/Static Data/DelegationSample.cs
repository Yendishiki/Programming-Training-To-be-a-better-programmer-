using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Static_Data
{
    public static class DelegationSample
    {
        public static Func<int, bool> odd = (int x) => x % 2 != 0;
        public static Func<int, bool> even = (int x) => x % 2 == 0;
        private static Predicate<int> _predicateEven = (int x) => x % 2 == 0;

    }
}
