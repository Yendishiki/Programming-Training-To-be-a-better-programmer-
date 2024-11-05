using Programming_Training__To_be_a_better_programmer_.OOP.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.OOP.Abstraction
{
    public abstract class Ninja: Body
    {
        public string Fullname { get; set; }
        public void DoSomething() => Console.WriteLine("Run");

        public abstract void Jutsu();

        //This is the sample of recursive
        public void Fight(int round = 1)
        {
            if (round == 3) { Console.WriteLine("Draw"); return; }

            Console.WriteLine($"The battle is round {round}");
            Fight(round += 1);
        }
    }
}
