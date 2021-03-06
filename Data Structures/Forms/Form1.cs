﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Structures.Structures;

namespace Data_Structures
{
    public partial class Form1 : Form
    {
        //List of currently opened structures 
        private List<CollectionInfo> StructureInfo = new List<CollectionInfo>(); 

        public Form1()
        {
            InitializeComponent();
            DllLinker.updateDllFiles();
            foreach (var plugin in DllLinker.dct_DllLinker)
            {
                
            }
           // AddElementsToCurrentTab(Tab1);
            //myCollection collection = new myCollection(new List<int>(), new MyList());
           // StructureInfo.Add(collection);
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
                StructureInfo[tabControl.SelectedIndex].list.Add(elem);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var rtb = getRichTextBox(2);
            string pattern = @"([0-9]+) $";
            string replacement = "";
            Regex rgx = new Regex(pattern,RegexOptions.None);
            rtb.Text = rgx.Replace(rtb.Text, replacement);
            try
            {
                StructureInfo[tabControl.SelectedIndex].list.Remove(StructureInfo[tabControl.SelectedIndex].list.Last());
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
            var typ = StructureInfo[tabControl.SelectedIndex].type;
            // inst - object of our class
            var inst = Activator.CreateInstance(typ);
            // draw - method of our class
            var BuildCollection = typ.GetMethod("BuildCollection");
            // Calling our method (from our our new object)
            var str = (string) BuildCollection.Invoke(inst, new object[] {StructureInfo[tabControl.SelectedIndex].list.Cast<object>().ToArray()});
            Control ctrl = tabControl.SelectedTab.Controls[3];
            RichTextBox rtb = ctrl as RichTextBox;
            rtb.Clear();
            rtb.AppendText(str);
            //Creator creator = StructureInfo[tabControl.SelectedIndex].structType.FactoryMethod();
            //creator.BuildCollection(StructureInfo[tabControl.SelectedIndex].list, tabControl.SelectedTab);

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
                StructureInfo.RemoveAt(deletedTabInd);
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "Structure (*.strct)|*.strct";
            this.Enabled = false;
            if (d.ShowDialog() == DialogResult.OK)
                DllLinker.SaveStructureToFile(StructureInfo[tabControl.SelectedIndex], d.FileName);
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

        public void AddNewStructureToNewTab(CollectionInfo x, string title)
        {
            TabPage myTabPage = new TabPage(title);
            tabControl.TabPages.Add(myTabPage);
            AddElementsToCurrentTab(myTabPage);
            StructureInfo.Add(x);
            tabControl.SelectTab(myTabPage);
            var rtb = getRichTextBox(2);
            foreach (var elem in x.list)
            {
                rtb.AppendText(elem + " ");
            }
            CreateCollection();
        }

        private void StackBtn_Click(object sender, EventArgs e)
        {
            CreateCollection(new NewStack().GetType());
        }

        private void QueueBtn_Click(object sender, EventArgs e)
        {
            CreateCollection(new NewQueue().GetType());
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            CreateCollection(new NewList().GetType());
        }

        private void CreateCollection(Type type)
        {
            TabPage myTabPage = new TabPage("123");
            tabControl.TabPages.Add(myTabPage);
            AddElementsToCurrentTab(myTabPage);
            CollectionInfo collectionInfo = new CollectionInfo(type,new List<int>());
            StructureInfo.Add(collectionInfo);

           /* // inst - object of our class
            var inst = Activator.CreateInstance(typ);
            // draw - method of our class
            var BuildCollection = typ.GetMethod("BuildCollection");
            // Calling our method (from our our new object)
            var str = (string)BuildCollection.Invoke(inst, new object[] { beginPoint.X, beginPoint.Y, endPoint.X, endPoint.Y });
            */
        }
    }
}
