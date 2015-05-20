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
        private Structure structure;
        private bool TheStructureIsChosen = false;

        public DialogNew()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (InputIsCorrect())
            {
                this.DialogResult = DialogResult.OK;
                this.FileName = FileNameTextBox.Text;
            }              
        }

        private bool InputIsCorrect()
        {
            if (FileNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("The file name is required");
                return false;
            }
            if (TheStructureIsChosen == false)
            {
                MessageBox.Show("The chosen structure is required");
                return false;
            }
            return true;
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
            TheStructureIsChosen = true;
        }

        private void QueueRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyQueue();
            TheStructureIsChosen = true;
        }

        private void ListRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            structure = new MyList();
            TheStructureIsChosen = true;
        }
    }
}
