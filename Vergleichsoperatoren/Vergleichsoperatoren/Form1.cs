using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vergleichsoperatoren{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            bool ausdruck;
            ausdruck = "Maier" != "Mayer";
            LblAnzeige.Text = "" + ausdruck;
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            bool ausdruck;
            ausdruck = 12 - 3 >= 4 * 2.5;
            LblAnzeige.Text = "" + ausdruck;
        }
    }
}
