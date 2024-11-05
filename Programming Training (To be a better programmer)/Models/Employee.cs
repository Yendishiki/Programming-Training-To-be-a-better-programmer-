using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Models
{
    public class Employee
    {
        private int _salary;

        public string Name { get; set; }
        public int Salary 
        { 
            get {
                return _salary;
            }
            set 
            {
                if (_salary <= 10000) Console.WriteLine("The salary is not fair for this position");
                
                _salary = value;
            } 
        }
    }
}
