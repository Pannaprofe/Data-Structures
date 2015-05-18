using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class CreateStack:Creator
    {
        public override void BuildCollection(List<int> inputList)
        {
            Stack stack = new Stack();
            foreach (var elem in inputList)
            {
                stack.Push(elem);
            }

        }
    }
}
