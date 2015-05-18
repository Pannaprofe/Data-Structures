using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class CreateQueue:Creator
    {
        public override void BuildCollection(List<int> inputList)
        {
            Queue queue = new Queue();
            foreach (var elem in inputList)
            {
                queue.Enqueue(elem);
            } 
        }
    }
}
