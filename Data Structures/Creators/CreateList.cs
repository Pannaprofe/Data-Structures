using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    class CreateList:Creator
    {
        public override void BuildCollection(List<int> inputList,TabPage tabPage)
        {
            var list = inputList;

            RichTextBox rtb = getRichTextBox(tabPage);
            rtb.Clear();
            foreach (var elem in list)
            {
                rtb.AppendText(elem + " ");
            }
        }
    }
}
