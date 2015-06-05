namespace Data_Structures
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBtn = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.tbl_Btns = new System.Windows.Forms.TableLayoutPanel();
            this.StackBtn = new System.Windows.Forms.Button();
            this.QueueBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tbl_Btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(168, 21);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(27, 23);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(121, 21);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.deleteCurrentToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteCurrentToolStripMenuItem
            // 
            this.deleteCurrentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCurrentToolStripMenuItem1});
            this.deleteCurrentToolStripMenuItem.Name = "deleteCurrentToolStripMenuItem";
            this.deleteCurrentToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.deleteCurrentToolStripMenuItem.Text = "Delete";
            // 
            // deleteCurrentToolStripMenuItem1
            // 
            this.deleteCurrentToolStripMenuItem1.Name = "deleteCurrentToolStripMenuItem1";
            this.deleteCurrentToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.deleteCurrentToolStripMenuItem1.Text = "Delete Current";
            this.deleteCurrentToolStripMenuItem1.Click += new System.EventHandler(this.deleteCurrentToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(27, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(589, 255);
            this.tabControl.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(265, 21);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(358, 21);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // tbl_Btns
            // 
            this.tbl_Btns.ColumnCount = 5;
            this.tbl_Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Btns.Controls.Add(this.ListBtn, 2, 0);
            this.tbl_Btns.Controls.Add(this.QueueBtn, 1, 0);
            this.tbl_Btns.Controls.Add(this.StackBtn, 0, 0);
            this.tbl_Btns.Location = new System.Drawing.Point(27, 311);
            this.tbl_Btns.Name = "tbl_Btns";
            this.tbl_Btns.RowCount = 1;
            this.tbl_Btns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Btns.Size = new System.Drawing.Size(606, 31);
            this.tbl_Btns.TabIndex = 11;
            // 
            // StackBtn
            // 
            this.StackBtn.Location = new System.Drawing.Point(3, 3);
            this.StackBtn.Name = "StackBtn";
            this.StackBtn.Size = new System.Drawing.Size(75, 23);
            this.StackBtn.TabIndex = 0;
            this.StackBtn.Text = "Stack";
            this.StackBtn.UseVisualStyleBackColor = true;
            this.StackBtn.Click += new System.EventHandler(this.StackBtn_Click);
            // 
            // QueueBtn
            // 
            this.QueueBtn.Location = new System.Drawing.Point(84, 3);
            this.QueueBtn.Name = "QueueBtn";
            this.QueueBtn.Size = new System.Drawing.Size(75, 23);
            this.QueueBtn.TabIndex = 1;
            this.QueueBtn.Text = "Queue";
            this.QueueBtn.UseVisualStyleBackColor = true;
            this.QueueBtn.Click += new System.EventHandler(this.QueueBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(165, 3);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(75, 23);
            this.ListBtn.TabIndex = 2;
            this.ListBtn.Text = "List";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 369);
            this.Controls.Add(this.tbl_Btns);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbl_Btns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TableLayoutPanel tbl_Btns;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Button QueueBtn;
        private System.Windows.Forms.Button StackBtn;
    }
}

