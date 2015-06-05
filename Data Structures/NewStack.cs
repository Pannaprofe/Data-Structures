using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class NewStack
    {
        public string BuildCollection(Object[] lst)
        {
            Stack stack = new Stack();
            foreach (var elem in lst)
            {
                stack.Push(elem);
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Append(stack.Pop() + " ");
            return sb.ToString();
        }
    }
}
