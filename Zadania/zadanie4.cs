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
    public partial class zadanie4 : Form
    {
        bool exbl { get; set; }
        public zadanie4()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("Please try again.");
                resListBox.Items.Remove("x1 is greater or equal then x2");
                resListBox.Items.Remove("k must be interger and greater then 0!!!");
                resListBox.Items.Remove("z is equal to 0");
                this.exbl = false;
            }
            double x1 = 0, x2 = 0, z = 0, k = 0;
            try
            {
                x1 = Convert.ToDouble(x1Box.Text);
                x2 = Convert.ToDouble(x2Box.Text);
                z = Convert.ToDouble(zBox.Text);
                k = Convert.ToDouble(kBox.Text);
                if (x1 >= x2)
                    throw new Exception("xEr");
                if (k < 1 || k - Math.Round(k) != 0)
                    throw new Exception("kEr");
                if (z == 0)
                    throw new Exception("zEr");
            }
            catch (Exception ex)
            {
                if (ex.Message == "xEr")
                    resListBox.Items.Add("x1 is greater or equal then x2");
                else if (ex.Message == "kEr")
                    resListBox.Items.Add("k must be interger and greater then 0!!!");
                else if (ex.Message == "zEr")
                    resListBox.Items.Add("z is equal to 0");
                else
                    resListBox.Items.Add("Please try again.");
                this.exbl = true;
                return;
            }


            ZadGlobal res = ZadObliczenia.zadanie4(x1, x2, z, k);

            resListBox.Items.Add("Podzelne przez z " + AreaType.Trapezoid + ": " + res.ListOfSingleCount[0].Area +"  x1: " + res.ListOfSingleCount[0].X1 +
                "  x2: " + res.ListOfSingleCount[0].X2);
            resListBox.Items.Add("Podzelne przez z " + AreaType.Rectangle + ": " + res.ListOfSingleCount[1].Area + "  x1: " + res.ListOfSingleCount[1].X1 +
                "  x2: " + res.ListOfSingleCount[1].X2);
            resListBox.Items.Add("------------------------");
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
