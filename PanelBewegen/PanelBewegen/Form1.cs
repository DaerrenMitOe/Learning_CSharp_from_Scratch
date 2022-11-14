using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelBewegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            p.Location = new Point(p.Location.X, p.Location.Y - 10);
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            p.Location = new Point(p.Location.X + 10, p.Location.Y);
        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {
            p.Location = new Point(p.Location.X, p.Location.Y + 10);
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            p.Location = new Point(p.Location.X - 10, p.Location.Y);
        }
    }
}
