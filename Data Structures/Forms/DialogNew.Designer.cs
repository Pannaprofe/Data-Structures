namespace Data_Structures
{
    partial class DialogNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.StackRdBtn = new System.Windows.Forms.RadioButton();
            this.QueueRdBtn = new System.Windows.Forms.RadioButton();
            this.ListRdBtn = new System.Windows.Forms.RadioButton();
            this.BTreeRdBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the filename";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(165, 20);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.FileNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose structure type";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(223, 143);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // StackRdBtn
            // 
            this.StackRdBtn.AutoSize = true;
            this.StackRdBtn.Location = new System.Drawing.Point(40, 84);
            this.StackRdBtn.Name = "StackRdBtn";
            this.StackRdBtn.Size = new System.Drawing.Size(51, 17);
            this.StackRdBtn.TabIndex = 5;
            this.StackRdBtn.TabStop = true;
            this.StackRdBtn.Text = "Stack";
            this.StackRdBtn.UseVisualStyleBackColor = true;
            this.StackRdBtn.CheckedChanged += new System.EventHandler(this.StackRdBtn_CheckedChanged);
            // 
            // QueueRdBtn
            // 
            this.QueueRdBtn.AutoSize = true;
            this.QueueRdBtn.Location = new System.Drawing.Point(40, 107);
            this.QueueRdBtn.Name = "QueueRdBtn";
            this.QueueRdBtn.Size = new System.Drawing.Size(57, 17);
            this.QueueRdBtn.TabIndex = 6;
            this.QueueRdBtn.TabStop = true;
            this.QueueRdBtn.Text = "Queue";
            this.QueueRdBtn.UseVisualStyleBackColor = true;
            this.QueueRdBtn.CheckedChanged += new System.EventHandler(this.QueueRdBtn_CheckedChanged);
            // 
            // ListRdBtn
            // 
            this.ListRdBtn.AutoSize = true;
            this.ListRdBtn.Location = new System.Drawing.Point(40, 130);
            this.ListRdBtn.Name = "ListRdBtn";
            this.ListRdBtn.Size = new System.Drawing.Size(41, 17);
            this.ListRdBtn.TabIndex = 7;
            this.ListRdBtn.TabStop = true;
            this.ListRdBtn.Text = "List";
            this.ListRdBtn.UseVisualStyleBackColor = true;
            this.ListRdBtn.CheckedChanged += new System.EventHandler(this.ListRdBtn_CheckedChanged);
            // 
            // BTreeRdBtn
            // 
            this.BTreeRdBtn.AutoSize = true;
            this.BTreeRdBtn.Location = new System.Drawing.Point(40, 153);
            this.BTreeRdBtn.Name = "BTreeRdBtn";
            this.BTreeRdBtn.Size = new System.Drawing.Size(78, 17);
            this.BTreeRdBtn.TabIndex = 8;
            this.BTreeRdBtn.TabStop = true;
            this.BTreeRdBtn.Text = "Binary tree";
            this.BTreeRdBtn.UseVisualStyleBackColor = true;
            this.BTreeRdBtn.CheckedChanged += new System.EventHandler(this.BTreeRdBtn_CheckedChanged);
            // 
            // DialogNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 200);
            this.Controls.Add(this.BTreeRdBtn);
            this.Controls.Add(this.ListRdBtn);
            this.Controls.Add(this.QueueRdBtn);
            this.Controls.Add(this.StackRdBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DialogNew";
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.RadioButton StackRdBtn;
        private System.Windows.Forms.RadioButton QueueRdBtn;
        private System.Windows.Forms.RadioButton ListRdBtn;
        private System.Windows.Forms.RadioButton BTreeRdBtn;

    }
}