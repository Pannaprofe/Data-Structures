using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class DialogNew : Form
    {
        private string FileName;
        private Structure structure = new MyList();
        public DialogNew()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (FileNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("The file name is required");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.FileName = FileNameTextBox.Text;
            }
        }

        public string GetFileName()
        {
            return FileName;
        }

        public Structure GetChosenStructure()
        {
            return structure;
        }

        private void StackRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyStack();
        }

        private void QueueRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyQueue();
        }

        private void ListRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyList();
        }

        private void BTreeRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyBinaryTree();
        }
    }
}
