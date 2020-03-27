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
    public partial class zadanie1 : Form
    {

        bool exbl { get; set; }
        public zadanie1()
        {
            InitializeComponent();
            this.exbl = false;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(AreaType.Trapezoid);

            if (zBox.Text == "")
            {
                zBox.Text = "100";
            }

            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("Please try again. For example type 0,1");
                this.exbl = false;
            }

            double trueRes = 1000000 / 3;
            try
            {
                double z = Convert.ToDouble(zBox.Text);
            }
            catch
            {
                resListBox.Items.Add("Please try again. For example type 0,1");
                this.exbl = true;
                return;
            }
            double minRes = trueRes - trueRes / 100 * Convert.ToDouble(zBox.Text);
            double maxRes = trueRes + trueRes / 100 * Convert.ToDouble(zBox.Text);
            int M = Convert.ToInt32(mNUD.Value);
            ZadGlobal gl = new ZadGlobal(ZadObliczenia.Oblicznie(M, x => x*x));

            for (int i = 0; i < gl.ListOfSingleCount.Count; i++)
            {
                SingleCount g = gl.ListOfSingleCount[i];
                if (g.Area >= minRes && g.Area <= maxRes)
                    resListBox.Items.Add(g.AreaType.ToString() + ": " + g.Area.ToString());
                if(i%2 == 1)
                {
                    resListBox.Items.Add("------------------------------");
                }
            }
        }

        private void doc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new doc3();
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
