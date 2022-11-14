using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schieberegler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void tBRot_Scroll(object sender, EventArgs e)
        {
            p.BackColor= Color.FromArgb(tBRot.Value, tBGruen.Value, tBBlau.Value);
            LblRot.Text = "Rot: \n" + tBRot.Value;
        }

        private void tBGruen_Scroll(object sender, EventArgs e)
        {
            p.BackColor = Color.FromArgb(tBRot.Value, tBGruen.Value, tBBlau.Value);
            LblGruen.Text = "Grün: \n" + tBGruen.Value;
        }

        private void tBBlau_Scroll(object sender, EventArgs e)
        {
            p.BackColor = Color.FromArgb(tBRot.Value, tBGruen.Value, tBBlau.Value);
            LblBlau.Text = "Blue: \n" + tBGruen.Value;
        }

        private void init()
        {
            tBRot.Value = 128;
            tBGruen.Value = 128;
            tBBlau.Value = 128;

            LblRot.Text = "Rot: \n" + tBRot.Value;
            LblGruen.Text = "Grün: \n" + tBGruen.Value;
            LblBlau.Text = "Blue: \n" + tBGruen.Value;

            p.BackColor = Color.FromArgb(tBRot.Value, tBGruen.Value, tBBlau.Value);
        }
    }
}
