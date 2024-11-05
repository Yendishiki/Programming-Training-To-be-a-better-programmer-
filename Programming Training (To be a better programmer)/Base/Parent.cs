using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Base
{
    public class Parent
    {
        public Parent() => Console.WriteLine("Default Parent");

        public Parent(string addSub, string otherSub) => Console.WriteLine("Call the parent class with parameters");

        public void MethodParent()  => Console.WriteLine("Method Parent");
    }
}
