using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    class CreateQueue:Creator
    {
        public override void BuildCollection(List<int> inputList,TabPage tabPage)
        {
            Queue queue = new Queue();
            foreach (var elem in inputList)
            {
                queue.Enqueue(elem);
            }
            RichTextBox rtb = getRichTextBox(tabPage);
            rtb.Clear();
            while (queue.Count > 0)
            {
                rtb.AppendText(queue.Dequeue() + " ");
            }

        }
    }
}
