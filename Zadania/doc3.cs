using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadania.doc3Class;

namespace Zadania
{
    public partial class doc3 : Form
    {
        public doc3()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Global global;
            Obiczenia obliczenia = new Obiczenia();
            global = obliczenia.Wykonaj(Convert.ToInt32(inputNUD.Value));
            for (int i = 0; i < inputNUD.Value; i++)
            {
                resLBox.Items.Add("==result# " + i.ToString() + "== value1=" + global.ListOfResults[i].LosujLiczby.Liczba1.ToString() +
                    "   value2=" + global.ListOfResults[i].LosujLiczby.Liczba2.ToString());
                if ((double)global.ListOfResults[i].Potegowanie == double.PositiveInfinity)
                    resLBox.Items.Add("suma=" + global.ListOfResults[i].Dodawanie.ToString() + "   roznica=" + global.ListOfResults[i].Odejmowanie.ToString() +
                        "   iloczyn=" + global.ListOfResults[i].Mnozenie.ToString() + "   iloraz=" + global.ListOfResults[i].Dzielenie.ToString() +
                        "   potegowanie=+Infinity");
                else
                    resLBox.Items.Add("suma=" + global.ListOfResults[i].Dodawanie.ToString() + "   roznica=" + global.ListOfResults[i].Odejmowanie.ToString() +
                        "   iloczyn=" + global.ListOfResults[i].Mnozenie.ToString() + "   iloraz=" + global.ListOfResults[i].Dzielenie.ToString() +
                        "   potegowanie=" + global.ListOfResults[i].Potegowanie.ToString());
            }
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
