using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Models
{
    public class Person
    {
        public string Name { get; set; }
        public List<string> PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
