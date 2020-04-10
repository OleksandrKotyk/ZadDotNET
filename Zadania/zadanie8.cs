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
    public partial class zadanie8 : Form
    {
        bool exbl { get; set; }
        public zadanie8()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (zBox.Text == "")
                zBox.Text = "100";

            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("Please try again. z is from 0 to 100");
                this.exbl = false;
            }
            double z;
            try
            {
                z = Convert.ToDouble(zBox.Text);
                if (z < 0 || z > 100)
                {
                    throw new Exception();
                }
            }
            catch
            {
                resListBox.Items.Add("Please try again. z is from 0 to 100");
                this.exbl = true;
                return;
            }

            TooLongEx myex = null;
            ZadGlobal res;
            try
            {
                res = ZadObliczenia.Zadanie8(x => Math.Cos(x), z, 1);
            }
            catch (TooLongEx exception)
            {
                myex = exception;
                res = exception.ZGl;
            }


            if (res.ListOfSingleCount[0].N != -1)
                resListBox.Items.Add(AreaType.Trapezoid + ": " + res.ListOfSingleCount[0].N.ToString()); 
            if (res.ListOfSingleCount[1].N != -1)
                resListBox.Items.Add(AreaType.Rectangle + ": " + res.ListOfSingleCount[1].N.ToString());
            
            if (myex != null)
            {
                resListBox.Items.Add(myex.Message);
            }
            resListBox.Items.Add("------------------------------------------------");
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

        private void zadanie7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie7();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(this.Left, this.Top);
            form.Show();
        }
    }
}
