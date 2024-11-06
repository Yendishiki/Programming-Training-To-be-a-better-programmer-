using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Generic.SampleGeneric
{
    public class ParentGeneric <T>
    {
        private string ReturnType(T param) => String.IsNullOrEmpty(param.ToString()) ? "Parent" : "Child";
        public void ParentGenericMethod(T parentGeneric) 
            => Console.WriteLine($"This is {ReturnType(parentGeneric)}, assign value: {parentGeneric}");
    }
}
