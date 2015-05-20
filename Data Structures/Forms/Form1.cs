using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Structures.Forms;
using Data_Structures.Structures;

namespace Data_Structures
{
    public partial class Form1 : Form
    {
        //List of currently opened structures 
        private List<myCollection> inputStructure = new List<myCollection>();

        public Form1()
        {
            InitializeComponent();
            AddElementsToCurrentTab(Tab1);
            myCollection collection = new myCollection(new List<int>(), new MyList());
            inputStructure.Add(collection);
        }

        void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            //validate the current page, to cancel the select use:
            //MessageBox.Show("123");
            //e.Cancel = true;
        }

        //Get richtextbox object from currently selected tab page
        private RichTextBox getRichTextBox(int ind)
        {
            int selectedTab = tabControl.SelectedIndex;
            Control ctrl = tabControl.Controls[selectedTab].Controls[ind];
            RichTextBox rtb = ctrl as RichTextBox;
            return rtb;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int elem = Convert.ToInt32(inputTextBox.Text);
                inputStructure[tabControl.SelectedIndex].list.Add(elem);
                inputTextBox.Clear();

                var rtb = getRichTextBox(2);
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
            tabControl.Selecting += new TabControlCancelEventHandler(tabControl_Selecting);
        }

        //Fill in the tab page with richtextboxes and labels
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
            rtbElements.ReadOnly = true;

            Label labelCollection = new Label();
            labelCollection.Text = "Created collection";
            labelCollection.Name = "labelCollection";
            labelCollection.Location = new Point(10,rtbElements.Top+rtbElements.Height);

            RichTextBox rtbCollection = new RichTextBox();
            rtbCollection.Width = tabpage.Width;
            rtbCollection.Name = "rtbCollection";
            rtbCollection.Location = new Point(0,labelCollection.Top+labelCollection.Height);
            rtbCollection.ReadOnly = true;

            
            tabpage.Controls.Add(labelElements);
            tabpage.Controls.Add(labelCollection);
            tabpage.Controls.Add(rtbElements);
            tabpage.Controls.Add(rtbCollection);
        }

        //Add new tab to tabControl
        private void AddNewTab(DialogNew dialog)
        {
            TabPage tp = new TabPage();
            tp.Name = dialog.GetFileName();
            tp.Text = dialog.GetFileName();
            tabControl.TabPages.Add(tp);
            AddElementsToCurrentTab(tp);
            var structureType = dialog.GetChosenStructure();
            myCollection collection = new myCollection(new List<int>(), structureType);
            inputStructure.Add(collection);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogNew dialog = new DialogNew();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                AddNewTab(dialog);
                myCollection collection = new myCollection(new List<int>(), dialog.GetChosenStructure());
                inputStructure.Add(collection);
                tabControl.SelectedIndex = tabControl.TabCount-1;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var rtb = getRichTextBox(2);
            string pattern = @"([0-9]+) $";
            string replacement = "";
            Regex rgx = new Regex(pattern,RegexOptions.None);
            rtb.Text = rgx.Replace(rtb.Text, replacement);
            try
            {
                inputStructure[tabControl.SelectedIndex].list.Remove(inputStructure[tabControl.SelectedIndex].list.Last());
            }
            catch (Exception)
            {
                MessageBox.Show("No elements to delete");
            }
            
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateCollection();
        }

        private void CreateCollection()
        {
            Creator creator = inputStructure[tabControl.SelectedIndex].structType.FactoryMethod();
            creator.BuildCollection(inputStructure[tabControl.SelectedIndex].list, tabControl.SelectedTab);
        }

        private void deleteCurrentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteTab();
        }

        private void DeleteTab()
        {
            try
            {
                int deletedTabInd = tabControl.SelectedIndex;
                inputStructure.RemoveAt(deletedTabInd);
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
            catch (Exception)
            {
                MessageBox.Show("No structures to delete");
            }           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "Structure (*.strct)|*.strct";
            this.Enabled = false;
            if (d.ShowDialog() == DialogResult.OK)
                DllLinker.SaveStructureToFile(inputStructure[tabControl.SelectedIndex], d.FileName);
            this.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Structure (*.strct)|*.strct";
            this.Enabled = false;

            if (d.ShowDialog() == DialogResult.OK)
                AddNewStructureToNewTab(DllLinker.getStructureFromFile(d.FileName), d.SafeFileName);

            this.Enabled = true;
        }

        public void AddNewStructureToNewTab(myCollection x, string title)
        {
            TabPage myTabPage = new TabPage(title);
            tabControl.TabPages.Add(myTabPage);
            AddElementsToCurrentTab(myTabPage);
            inputStructure.Add(x);
            tabControl.SelectTab(myTabPage);
            var rtb = getRichTextBox(2);
            foreach (var elem in x.list)
            {
                rtb.AppendText(elem + " ");
            }
            CreateCollection();
        }
    }
}
