namespace Zadania
{
    partial class zadanie1
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
            this.components = new System.ComponentModel.Container();
            this.mLabel = new System.Windows.Forms.Label();
            this.zLablel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.mNUD = new System.Windows.Forms.NumericUpDown();
            this.resListBox = new System.Windows.Forms.ListBox();
            this.zBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doc3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.mNUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mLabel.Location = new System.Drawing.Point(32, 45);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(77, 20);
            this.mLabel.TabIndex = 0;
            this.mLabel.Text = "m value: ";
            // 
            // zLablel
            // 
            this.zLablel.AutoSize = true;
            this.zLablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.zLablel.Location = new System.Drawing.Point(290, 45);
            this.zLablel.Name = "zLablel";
            this.zLablel.Size = new System.Drawing.Size(72, 20);
            this.zLablel.TabIndex = 1;
            this.zLablel.Text = "z value: ";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.okButton.Location = new System.Drawing.Point(538, 40);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 36);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // mNUD
            // 
            this.mNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mNUD.Location = new System.Drawing.Point(115, 40);
            this.mNUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mNUD.Maximum = new decimal(new int[] {2147483647, 0, 0, 0});
            this.mNUD.Name = "mNUD";
            this.mNUD.Size = new System.Drawing.Size(155, 27);
            this.mNUD.TabIndex = 4;
            // 
            // resListBox
            // 
            this.resListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.resListBox.FormattingEnabled = true;
            this.resListBox.ItemHeight = 20;
            this.resListBox.Location = new System.Drawing.Point(36, 101);
            this.resListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resListBox.Name = "resListBox";
            this.resListBox.Size = new System.Drawing.Size(577, 424);
            this.resListBox.TabIndex = 5;
            // 
            // zBox
            // 
            this.zBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.zBox.Location = new System.Drawing.Point(382, 40);
            this.zBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(122, 27);
            this.zBox.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.zadaniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.doc3ToolStripMenuItem, this.zadanie2ToolStripMenuItem, this.zadanie3ToolStripMenuItem,
                this.zadanie4ToolStripMenuItem, this.zadanie5ToolStripMenuItem, this.zadanie6ToolStripMenuItem,
                this.zadanie7ToolStripMenuItem, this.zadanie8ToolStripMenuItem
            });
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // doc3ToolStripMenuItem
            // 
            this.doc3ToolStripMenuItem.Name = "doc3ToolStripMenuItem";
            this.doc3ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.doc3ToolStripMenuItem.Text = "doc3";
            this.doc3ToolStripMenuItem.Click += new System.EventHandler(this.doc3ToolStripMenuItem_Click);
            // 
            // zadanie2ToolStripMenuItem
            // 
            this.zadanie2ToolStripMenuItem.Name = "zadanie2ToolStripMenuItem";
            this.zadanie2ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie2ToolStripMenuItem.Text = "Zadanie2";
            this.zadanie2ToolStripMenuItem.Click += new System.EventHandler(this.zadanie2ToolStripMenuItem_Click);
            // 
            // zadanie3ToolStripMenuItem
            // 
            this.zadanie3ToolStripMenuItem.Name = "zadanie3ToolStripMenuItem";
            this.zadanie3ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie3ToolStripMenuItem.Text = "Zadanie3";
            this.zadanie3ToolStripMenuItem.Click += new System.EventHandler(this.zadanie3ToolStripMenuItem_Click);
            // 
            // zadanie4ToolStripMenuItem
            // 
            this.zadanie4ToolStripMenuItem.Name = "zadanie4ToolStripMenuItem";
            this.zadanie4ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie4ToolStripMenuItem.Text = "Zadanie4";
            this.zadanie4ToolStripMenuItem.Click += new System.EventHandler(this.zadanie4ToolStripMenuItem_Click);
            // 
            // zadanie5ToolStripMenuItem
            // 
            this.zadanie5ToolStripMenuItem.Name = "zadanie5ToolStripMenuItem";
            this.zadanie5ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie5ToolStripMenuItem.Text = "Zadanie5";
            this.zadanie5ToolStripMenuItem.Click += new System.EventHandler(this.zadanie5ToolStripMenuItem_Click);
            // 
            // zadanie6ToolStripMenuItem
            // 
            this.zadanie6ToolStripMenuItem.Name = "zadanie6ToolStripMenuItem";
            this.zadanie6ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie6ToolStripMenuItem.Text = "Zadanie6";
            this.zadanie6ToolStripMenuItem.Click += new System.EventHandler(this.zadanie6ToolStripMenuItem_Click);
            // 
            // zadanie7ToolStripMenuItem
            // 
            this.zadanie7ToolStripMenuItem.Name = "zadanie7ToolStripMenuItem";
            this.zadanie7ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie7ToolStripMenuItem.Text = "Zadanie7";
            this.zadanie7ToolStripMenuItem.Click += new System.EventHandler(this.zadanie7ToolStripMenuItem_Click);
            // 
            // zadanie8ToolStripMenuItem
            // 
            this.zadanie8ToolStripMenuItem.Name = "zadanie8ToolStripMenuItem";
            this.zadanie8ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.zadanie8ToolStripMenuItem.Text = "Zadanie8";
            this.zadanie8ToolStripMenuItem.Click += new System.EventHandler(this.zadanie8ToolStripMenuItem_Click);
            // 
            // zadanie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 592);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.resListBox);
            this.Controls.Add(this.mNUD);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.zLablel);
            this.Controls.Add(this.mLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "zadanie1";
            this.Text = "zadanie1";
            ((System.ComponentModel.ISupportInitialize) (this.mNUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label zLablel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown mNUD;
        private System.Windows.Forms.ListBox resListBox;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doc3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie8ToolStripMenuItem;
    }
}