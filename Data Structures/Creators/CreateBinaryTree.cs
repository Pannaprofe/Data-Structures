using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    class CreateBinaryTree:Creator
    {
        public override void BuildCollection(List<int> inputList,TabPage tabPage)
        {
            SortedSet<int> tree = new SortedSet<int>();
            foreach (var elem in inputList)
            {
                tree.Add(elem);
            }
            RichTextBox rtb = getRichTextBox(tabPage);
            rtb.Clear();
        }
    }
}
