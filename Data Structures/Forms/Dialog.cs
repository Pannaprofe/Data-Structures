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
    public partial class Dialog : Form
    {
        private string FileName;
        public Dialog()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.FileName = FileNameTextBox.Text;
        }

        public string GetFileName()
        {
            return FileName;
        }
    }
}
