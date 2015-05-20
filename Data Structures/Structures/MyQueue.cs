using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    [Serializable]
    class MyQueue:Structure
    {
        public override Creator FactoryMethod()
        {
            return new CreateQueue();
        }
    }
}
