using Programming_Training__To_be_a_better_programmer_.OOP.Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.OOP.Abstraction
{
    public class Cat : IAnimal
    {
        public void MakeSound() => Console.WriteLine("meowwww....");
        
    }
}
