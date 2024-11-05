using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Base
{
    public class Child : Parent
    {
        public Child() : base() => Console.WriteLine("Default Child");

        public Child(string addSub) : this() => Console.WriteLine("Call the default messages");

        public Child(string addSub, string otherSub) : base(addSub, otherSub) => Console.WriteLine("Call the child class with parameters");

        public Child(int No) => base.MethodParent();
    }
}
