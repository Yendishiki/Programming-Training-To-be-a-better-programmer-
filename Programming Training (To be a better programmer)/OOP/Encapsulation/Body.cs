﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.OOP.Encapsulation
{
    public abstract class Body
    {
        public void Charge() => ChakraRecovery();

        //accessible in the parent but not in instantiation
        protected void ChakraRecovery() => Console.WriteLine("Charge chakra to recover");

        //inheritance of this implementation
        //body
          //ninja
            //naruto & sasuke
    }
}