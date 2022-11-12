using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gueltigkeitsbereich2
{
    public partial class Form1 : Form
    {
        private float x = 0.0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            float z = 0.0f;

            x += 0.1f;
            z += 0.1f;

            LblAnzeige.Text = "x: " + x + "\n" +
                "z: " + z;
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            float y = 0.0f;

            x += 0.1f;
            y += 0.1f;

            LblAnzeige.Text = "x: " + x + "\n" +
                "y: " + y;

        }
    }
}
