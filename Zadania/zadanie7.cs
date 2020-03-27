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
    public partial class zadanie7 : Form
    {
        bool exbl { get; set; }
        public zadanie7()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.exbl)
            {
                resListBox.Items.Remove("Please try again!!!");
                resListBox.Items.Remove("Please try again!!! k is invalid. k is from 1");
                resListBox.Items.Remove("x1 is greater or equal then x2");
                resListBox.Items.Remove("z is equal to 0");
                this.exbl = false;
            }
            double x1 = 0, x2 = 0, z =0;
            try
            {
                z = Convert.ToDouble(zBox.Text);
                x1 = Convert.ToDouble(x1Box.Text);
                x2 = Convert.ToDouble(x2Box.Text);
                if (x1 >= x2)
                    throw new Exception("xEr");
                if (z == 0)
                    throw new Exception("zEx");
            }
            catch (Exception ex)
            {
                if (ex.Message == "xEr")
                    resListBox.Items.Add("x1 is greater or equal then x2");
                else if (ex.Message == "zEx")
                    resListBox.Items.Add("z is equal to 0");
                else
                    resListBox.Items.Add("Please try again!!!");
                this.exbl = true;
                return;
            }

            

            ZadGlobal res = ZadObliczenia.Zadanie7(z, x1, x2);
            if (res.ListOfSingleCount[0].N != -1 && res.ListOfSingleCount[1].N != -1)
            {
                resListBox.Items.Add(AreaType.Trapezoid + ": " + res.ListOfSingleCount[0].N);
                resListBox.Items.Add(AreaType.Rectangle + ": " + res.ListOfSingleCount[1].N);
                resListBox.Items.Add("----------------");
            }
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

        private void zadanie6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie6();
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
