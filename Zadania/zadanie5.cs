using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania
{
    public partial class zadanie5 : Form
    {
        bool exbl { get; set; }
        public zadanie5()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("k must be interger and from 1 to 6!!!");
                resListBox.Items.Remove("Please try again.");
                this.exbl = false;
            }
            double k = 0;
            try
            {
                k = Convert.ToDouble(kBox.Text);
                if (k < 1 || k - Math.Round(k) != 0 || k > 6)
                    throw new Exception("kEr");
            }
            catch (Exception ex)
            {
                if (ex.Message == "kEr")
                    resListBox.Items.Add("k must be interger and from 1 to 6!!!");
                else
                    resListBox.Items.Add("Please try again.");
                this.exbl = true;
                return;
            }
            
            TooLongEx myex = null;


            ZadGlobal res;
            try
            {
                res = ZadObliczenia.zadanie5(Convert.ToDouble(kBox.Text));
            }
            catch (TooLongEx exception)
            {
                myex = exception;
                res = exception.ZGl;
            }

            
            for (int i = 0; i < res.ListOfSingleCount.Count(); i++)
            {
                resListBox.Items.Add((i > 1? AreaType.Trapezoid:AreaType.Rectangle) + "   area" + (i % 2 == 0? " y=x^3":" y=x^2") + ": " + res.ListOfSingleCount[i].Area + 
                    "    x1: " + res.ListOfSingleCount[i].X1 + "     x2: " + res.ListOfSingleCount[i].X2);
            }

            if (myex != null)
            {
                resListBox.Items.Add(myex.Message);
            }
            
            resListBox.Items.Add("-------------------------------------");
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

        private void zadanie6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie6();
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
