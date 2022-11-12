using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            String Name, Strasse, Ort;
            int Hausnummer, Alter;
            float Gehalt;

            Name = "Claus Clever";
            Strasse = "Bergstraße";
            Hausnummer = 34;
            Ort = "09445 Brunnenstadt";
            Alter = 32;
            Gehalt = 2852.55f;

            LblAnzeige.Text = "Adresse:\n" +
                Name + "\n" +
                Strasse +" " + Hausnummer + "\n" +
                Ort + "\n\n" +
                "Alter: " + Alter + "\n" +
                "Gehalt " + Gehalt;
        }
    }
}
