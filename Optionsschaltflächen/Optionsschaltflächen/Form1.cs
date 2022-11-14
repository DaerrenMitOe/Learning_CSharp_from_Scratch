using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optionsschaltflächen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            if (rBRot.Checked)
                LblAnzeige1.Text = "Rot";
            else if (rBGruen.Checked)
                LblAnzeige1.Text = "Grün";
            else
                LblAnzeige1.Text = "Blue";
        }

        private void rBRot_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRot.Checked)
                LblAnzeige2.Text = "Rot";
        }

        private void rBGruen_CheckedChanged(object sender, EventArgs e)
        {
            if (rBGruen.Checked)
                LblAnzeige2.Text = "Grün";
        }

        private void rBBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rBBlue.Checked)
                LblAnzeige2.Text = "Blue";
        }

        private void CmdRotSchalten_Click(object sender, EventArgs e)
        {
            rBRot.Checked = true;
        }
    }
}
