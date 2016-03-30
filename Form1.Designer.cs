namespace osu_Relax
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Easy || AR-3");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Normal || AR-5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hard || AR-7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Madness || AR-9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nightcore - Pinball", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.label1 = new System.Windows.Forms.Label();
            this.ListOfSong_tree = new System.Windows.Forms.TreeView();
            this.console_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of songs:";
            // 
            // ListOfSong_tree
            // 
            this.ListOfSong_tree.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfSong_tree.Location = new System.Drawing.Point(11, 35);
            this.ListOfSong_tree.Name = "ListOfSong_tree";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Easy || AR-3";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Normal || AR-5";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Hard || AR-7";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Madness || AR-9";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Nightcore - Pinball";
            this.ListOfSong_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.ListOfSong_tree.Size = new System.Drawing.Size(386, 277);
            this.ListOfSong_tree.TabIndex = 2;
            // 
            // console_listbox
            // 
            this.console_listbox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_listbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.console_listbox.FormattingEnabled = true;
            this.console_listbox.ItemHeight = 15;
            this.console_listbox.Items.AddRange(new object[] {
            "Type \"Help\" to call for help!",
            "**** \\(^_^)/ ****"});
            this.console_listbox.Location = new System.Drawing.Point(403, 35);
            this.console_listbox.Name = "console_listbox";
            this.console_listbox.Size = new System.Drawing.Size(397, 244);
            this.console_listbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Console:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developed by Quickpow";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.console_listbox);
            this.Controls.Add(this.ListOfSong_tree);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "osu!Believe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView ListOfSong_tree;
        private System.Windows.Forms.ListBox console_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

