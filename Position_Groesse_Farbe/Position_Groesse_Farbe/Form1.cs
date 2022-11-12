﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Position_Groesse_Farbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPositionAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 200);
        }

        private void CmdGroesseRel_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(CmdTest.Size.Width + 20, CmdTest.Size.Height);
        }

        private void CmdGroesseAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Size= new Size(50, 100);
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(CmdTest.Location.X + 20, CmdTest.Location.Y);
        }
    }
}
