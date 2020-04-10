using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Zadania
{
    public partial class zadanie6 : Form
    {
        bool exbl { get; set; }
        public zadanie6()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {   

            if (this.exbl)
            {
                resListBox.Items.Remove("m must be interger and greater then 0!!!");
                resListBox.Items.Remove("k must be interger and from 1 to 6!!!");
                resListBox.Items.Remove("Please try again!!!");
                this.exbl = false;
            }
            double m = 0, k = 0;
            try
            {
                m = Convert.ToDouble(mBox.Text);
                k = Convert.ToDouble(kBox.Text);
                if (k < 1 || k - Math.Round(k) != 0 || k > 6)
                    throw new Exception("kEr");
                if (m <=0 || m - Math.Round(m) != 0)
                    throw new Exception("mEx");
            }
            catch (Exception ex)
            {
                this.exbl = true;
                if (ex.Message == "kEr")
                    resListBox.Items.Add("k must be interger and from 1 to 6!!!");
                else if (ex.Message == "mEx")
                    resListBox.Items.Add("m must be interger and greater then 0!!!");
                else
                    resListBox.Items.Add("Please try again!!!");
                return;
            }


            TooLongEx myex = null;
            ZadGlobal res;
            try
            {
                res = ZadObliczenia.Zadanie6(m, k);
            }
            catch (TooLongEx exception)
            {
                res = exception.ZGl;
                myex = exception;
            }
             
            
            for(int i = 0; i < 2; i++)
                resListBox.Items.Add(res.ListOfSingleCount[i].AreaType + "----X1: " +
                    res.ListOfSingleCount[i].X1.ToString() + "  X2: " + res.ListOfSingleCount[i].X2.ToString() + 
                    "  Roz: " + res.ListOfSingleCount[i].Area.ToString());
            
            
            if (myex != null)
            {
                resListBox.Items.Add(myex.Message);
            }
            resListBox.Items.Add("-------------------");
            
        }

        private void doc3_Click(object sender, EventArgs e)
        {
            var form = new doc3();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie1();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie2();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie3();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie4();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie5();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie7();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie8();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }
    }
}
