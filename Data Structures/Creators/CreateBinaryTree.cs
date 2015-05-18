using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class CreateBinaryTree:Creator
    {
        public override void BuildCollection(List<int> inputList)
        {
            SortedSet<int> tree = new SortedSet<int>();
            foreach (var elem in inputList)
            {
                tree.Add(elem);
            }

        }
    }
}
