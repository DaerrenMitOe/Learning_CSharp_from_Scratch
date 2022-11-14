using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            double Gehalt;
            Gehalt = Convert.ToDouble(tGehalt.Text);
            LblAnzeige2.Text = "Steuerbetrag: ";
            if (Gehalt <= 12_000)
                LblAnzeige2.Text += Gehalt * 0.12;
            else if(Gehalt <= 20_000)
                LblAnzeige2.Text += Gehalt * 0.15;
            else
                LblAnzeige2.Text += Gehalt * 0.25;
        }
    }
}
