using Programming_Training__To_be_a_better_programmer_.OOP.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Generic
{
    public class SampleGeneric<T> where T : Body, new()
    {
        public void Execute()
        {
            T t = new T();
            t.Charge();
        }
    }
}
