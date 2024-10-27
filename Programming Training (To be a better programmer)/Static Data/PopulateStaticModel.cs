using Programming_Training__To_be_a_better_programmer_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Static_Data
{
    public class PopulateStaticModel
    {
        public List<User> Users()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Gemini"
                }
            };
        }
    }
}
