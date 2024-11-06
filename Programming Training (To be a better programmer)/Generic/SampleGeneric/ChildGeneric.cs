using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Training__To_be_a_better_programmer_.Generic.SampleGeneric
{
    public class ChildGeneric<T> : ParentGeneric<T>
    {
        public void Child(T parentGeneric) => base.ParentGenericMethod(parentGeneric);
    }
}
