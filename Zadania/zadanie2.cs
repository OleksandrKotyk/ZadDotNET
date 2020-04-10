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
    public partial class zadanie2 : Form
    {
        bool exbl { get; set; }
        public zadanie2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (zBox.Text == "")
                zBox.Text = "100";
            resListBox.Items.Remove("If you want to have a real result try z = 0,01, or something else!!!");
            if (this.exbl)
            {
                Console.WriteLine(resListBox.TopIndex);
                resListBox.Items.Remove("Please try again. z is from 0 to 100");
                resListBox.Items.Remove("z is too small. Begin from 0,0001");
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
                if (25000000 / 100.0 * z - Math.Floor(25000000 / 100.0 * z) != 0)
                {
                    throw new Exception("zEr");
                }
            }
            catch (Exception ex)
            {
                if(ex.Message == "zEr") resListBox.Items.Add("z is too small. Begin from 0,0001");
                else resListBox.Items.Add("Please try again. z is from 0 to 100");
                this.exbl = true;
                return;
            }
            
            TooLongEx myex = null;
            ZadGlobal res;
            bool test1 = false, test2 = false;
            try
            {
                res = ZadObliczenia.Zadanie2(x => x * x * x, z, 25000000, out test1, out test2);
            }
            catch (TooLongEx exception)
            {
                myex = exception;
                res = exception.ZGl;
            }
            
            if (!test1 && res.ListOfSingleCount[0].N != -1)
            {
                resListBox.Items.Add("Unreal for Trapezoid!!! Near: " + res.ListOfSingleCount[0].N.ToString());
            }
            else if(res.ListOfSingleCount[0].N != -1)
                resListBox.Items.Add(AreaType.Trapezoid + ": " + res.ListOfSingleCount[0].N.ToString());
            
            
            if (!test2 && res.ListOfSingleCount[1].N != -1)
            {
                resListBox.Items.Add("Unreal for Rectangle!!! Near: " + res.ListOfSingleCount[1].N.ToString());
                //resListBox.Items.Add("If you want to have a real result try z = 0,01, or something else!!!");
            }
            else if (res.ListOfSingleCount[1].N != -1)
                resListBox.Items.Add(AreaType.Rectangle + ": " + res.ListOfSingleCount[1].N.ToString());

            
            if (myex != null)
            {
                resListBox.Items.Add(myex.Message);
            }
            resListBox.Items.Add("------------------------------------------------");
            
        }

        private void zadanie8_Load(object sender, EventArgs e)
        {

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
            form.Location = new Point(this.Left, this.Top);
            form.Show();
        }

        private void zadanie8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new zadanie8();
            Zadania.Program.apcon.MainForm = form;
            this.Close();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Left, this.Top);
            form.Show();
        }
    }
}
