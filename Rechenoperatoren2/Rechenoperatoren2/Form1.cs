using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenoperatoren2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            double ausdruck;
            ausdruck = 3 * (-2.5) + 4 * 2;
            LblAnzeige.Text = "" + ausdruck;
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            double ausdruck;
            ausdruck = 3 * (-2.5 + 4) * 2;
            LblAnzeige.Text = "" + ausdruck;
        }
    }
}
