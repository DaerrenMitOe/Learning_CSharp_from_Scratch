using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrollkästchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBSchalter.Checked)
                LblAnzeige2.Text = "An";
            else
                LblAnzeige2.Text = "Aus";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            if (cBSchalter.Checked)
                LblAnzeige1.Text = "An";
            else
                LblAnzeige1.Text = "Aus";
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {
            cBSchalter.Checked = !cBSchalter.Checked;
        }
    }
}
