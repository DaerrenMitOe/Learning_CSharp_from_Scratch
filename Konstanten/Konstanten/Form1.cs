using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstanten
{
    public partial class Form1 : Form
    {
        private const int MaxWert = 75;
        private const string Eintrag = "Picture";

        private enum Farbe : int
        {
            Rot = 1,
            Gelb = 2,
            Blau = 3
        }

        private enum DayOfWeek : int
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEnumeration2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Sonntag: " + DayOfWeek.Sunday + " " + (int)DayOfWeek.Sunday + "\n" +
                "Samstag: " + DayOfWeek.Saturday + " " + (int)DayOfWeek.Saturday;
        }

        private void CmdKonstanten_Click(object sender, EventArgs e)
        {
            const int MaxWert = 55;
            const int MinWert = 5;
            LblAnzeige.Text = (MaxWert - MinWert) / 2 + "\n" + Eintrag;
        }

        private void CmdEnumeration1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Farbe: " + Farbe.Gelb + " " + (int)Farbe.Gelb;

        }
    }
}
