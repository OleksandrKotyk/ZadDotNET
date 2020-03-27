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
    public partial class zadanie3 : Form
    {

        bool exbl { get; set; }
        public zadanie3()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("Please try again.");
                resListBox.Items.Remove("x1 is greater or equal then x2");
                this.exbl = false;
            }
            double x1 = 0, x2 = 0;
            try
            {
                x1 = Convert.ToDouble(x1Box.Text);
                x2 = Convert.ToDouble(x2Box.Text);
                if (x1 >= x2)
                {
                    throw new Exception("xEr");
                }
            }
            catch(Exception ex)
            {
                if(ex.Message == "xEr")
                    resListBox.Items.Add("x1 is greater or equal then x2");
                else
                resListBox.Items.Add("Please try again.");
                this.exbl = true;
                return;
            }


            double trueRes = (Math.Pow(x2, 3) / 3) - (Math.Pow(x1, 3) / 3);
            resListBox.Items.Add("Poprawny: " + trueRes);
            double resTr = 0, resRg = 0;
            for (int i = 1; i <= 6; i++) { 
                resTr += Math.Pow(trueRes - ZadObliczenia.TrapezLicz(x1, x2, (int)Math.Pow(10, i), x => x * x), 2);
                resRg += Math.Pow(trueRes - ZadObliczenia.ProstLicz(x1, x2, (int)Math.Pow(10, i), x => x * x), 2);
            }

            ZadGlobal res = ZadObliczenia.zadanie3(new SingleCount(x1, x2, 0));
            resListBox.Items.Add("Wynik dla " + res.ListOfSingleCount[1].AreaType + ": " + res.ListOfSingleCount[0].Area);
            resListBox.Items.Add("Błąd dla " + res.ListOfSingleCount[0].AreaType + ": " + Math.Round(Math.Abs(res.ListOfSingleCount[0].Area - trueRes) / (trueRes / 100), 2) + " %");
            resListBox.Items.Add("Wynik dla " + res.ListOfSingleCount[1].AreaType + ": " + res.ListOfSingleCount[1].Area);
            resListBox.Items.Add("Błąd dla " + res.ListOfSingleCount[0].AreaType + ": " + Math.Round(Math.Abs(res.ListOfSingleCount[1].Area - trueRes) / (trueRes / 100), 2) + " %");
            resListBox.Items.Add("------------------------");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
