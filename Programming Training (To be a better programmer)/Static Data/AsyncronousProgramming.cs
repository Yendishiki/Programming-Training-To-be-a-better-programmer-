using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Static_Data
{
    public static class AsyncronousProgramming
    {
        public static  void PerformAsyncTask()
        {
            Console.WriteLine("Task started...");

            // Simulate a delay
             Task.Delay(10000);

            Console.WriteLine("Task finished after delay.");
        }
    }
}
