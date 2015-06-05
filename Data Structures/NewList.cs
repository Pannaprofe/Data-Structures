using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class NewList
    {
        public string BuildCollection(Object[] lst )
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (var elem in lst)
            {
                sb.Append(elem + " ");
            }
            return sb.ToString();
        }
    }
}
