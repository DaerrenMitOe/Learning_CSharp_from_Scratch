using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeitgeber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimAnzeige.Enabled = true;
        }

        private void TimAnzeige_Tick(object sender, EventArgs e)
        {   
            pRed.Location = new Point(pRed.Location.X - pRed.Location.X / 10, pRed.Location.Y - pRed.Location.Y / 10);
            pBlue.Location = new Point(pRed.Location.X - pRed.Location.X / 10, pRed.Location.Y - pRed.Location.Y / 10);
            pGreen.Location = new Point(pGreen.Location.X - pGreen.Location.X / 10, pGreen.Location.Y - pGreen.Location.Y / 10);
            pYellow.Location = new Point(pYellow.Location.X - pYellow.Location.X / 10, pYellow.Location.Y + pYellow.Location.Y / 10);
        }
    }
}
