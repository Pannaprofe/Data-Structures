using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public abstract class Creator
    {
        protected List<int> inputList;

        protected  RichTextBox getRichTextBox(TabPage tabPage)
        {
            Control ctrl = tabPage.Controls[3];
            RichTextBox rtb = ctrl as RichTextBox;
            return rtb;
        }
        abstract public void BuildCollection(List<int> inputList, TabPage tabPage);
    }
}
