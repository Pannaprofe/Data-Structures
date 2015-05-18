using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    class CreateStack:Creator
    {
        public override void BuildCollection(List<int> inputList,TabPage tabPage)
        {
            Stack stack = new Stack();
            foreach (var elem in inputList)
            {
                stack.Push(elem);
            }

            RichTextBox rtb = getRichTextBox(tabPage);
            rtb.Clear();
            while (stack.Count>0)
            {
                rtb.AppendText(stack.Pop() + " ");
            }
        }
    }
}
