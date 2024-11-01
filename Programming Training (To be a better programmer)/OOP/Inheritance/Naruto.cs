using Programming_Training__To_be_a_better_programmer_.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.OOP.Inheritance
{
    public class Naruto: Ninja
    {
        public void HiddenChakraRecoveryInKyuubiMode()
        {
            ChakraRecovery();
        }

        public override void Jutsu() => Console.WriteLine("Rasengan");
    }
}
