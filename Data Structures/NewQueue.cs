using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class NewQueue
    {
        public string BuildCollection(Object[] lst)
        {
            Queue queue = new Queue();
            foreach (var elem in lst)
            {
                queue.Enqueue(elem);
            }
            StringBuilder Sb = new StringBuilder();
            while (queue.Count > 0)
            {
                Sb.Append(queue.Dequeue() + " ");
            }
            return Sb.ToString();

        }
    }
}
