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
        private Structure currentStructure;

        public Form1()
        {
            InitializeComponent();
            AddElementsToCurrentTab(Tab1);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int elem = Convert.ToInt32(inputTextBox.Text);
                input.Add(elem);
                inputTextBox.Clear();

                int selectedTab = tabControl.SelectedIndex;
                Control ctrl = tabControl.Controls[selectedTab].Controls[2];
                RichTextBox rtb = ctrl as RichTextBox;
                rtb.AppendText(elem + " ");
            }
            catch (Exception)
            {
                MessageBox.Show("Element field should not be empty");
            }
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

        private void AddElementsToCurrentTab(TabPage tabpage)
        {
            Label labelElements = new Label();
            labelElements.Text = "Entered elements";
            labelElements.Name = "labelElements";
            labelElements.Location = new Point(10,10);

            RichTextBox rtbElements = new RichTextBox();
            rtbElements.Width = tabpage.Width;
            rtbElements.Name = "rtbElements";
            rtbElements.Location = new Point(0,labelElements.Top+labelElements.Height);

            Label labelCollection = new Label();
            labelCollection.Text = "Created collection";
            labelCollection.Name = "labelCollection";
            labelCollection.Location = new Point(10,rtbElements.Top+rtbElements.Height);

            RichTextBox rtbCollection = new RichTextBox();
            rtbCollection.Width = tabpage.Width;
            rtbCollection.Name = "rtbCollection";
            rtbCollection.Location = new Point(0,labelCollection.Top+labelCollection.Height);

            
            tabpage.Controls.Add(labelElements);
            tabpage.Controls.Add(labelCollection);
            tabpage.Controls.Add(rtbElements);
            tabpage.Controls.Add(rtbCollection);
        }

        private void AddNewTab(DialogNew dialog)
        {
            TabPage tp = new TabPage();
            tp.Name = dialog.GetFileName();
            tp.Text = dialog.GetFileName();
            tabControl.TabPages.Add(tp);
            AddElementsToCurrentTab(tp);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogNew dialog = new DialogNew();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                AddNewTab(dialog);
                this.currentStructure = dialog.GetChosenStructure();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
