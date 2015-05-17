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
    public partial class Form1 : Form
    {
        private List<Structure> structures = new List<Structure>();
        private List<int> input = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            input.Add(Convert.ToInt32(inputTextBox.Text));
            inputTextBox.Clear();
        }

        private static void DigitalInput(KeyPressEventArgs e)   // defence against the non-digital input
        {
            var ch = e.KeyChar;
            if (!Char.IsDigit(ch) && (ch != 8) && (ch != 46))  // turning on backspace and del keys
                e.Handled = true;
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitalInput(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddNewTab(Dialog dialog)
        {
            TabPage tp = new TabPage();
            tp.Name = dialog.GetFileName();
            tp.Text = dialog.GetFileName();
            tabControl.TabPages.Add(tp);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog d = new Dialog();
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
            {
                AddNewTab(d);
            }
        }
    }
}
