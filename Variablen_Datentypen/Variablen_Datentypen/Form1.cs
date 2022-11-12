﻿using System;
using System.Windows.Forms;

namespace Variablen_Datentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            byte By;
            short Sh;
            int It, Hex, Bn;
            long Lg;

            float F1;
            double Db1, Db2, Exp1, Exp2;
            decimal De;

            bool Bo;
            char Ch;
            string St;

            By = 200;
            Sh = 30000;
            It = 2_000_000_000;
            Lg = 3_000_000_000;
            Hex = 0x2f5;
            Bn = 0b1001;

            F1 = 1.0f / 7;
            Db1 = 1 / 7;
            Db2 = 1.0 / 7;
            De = 1.0m / 7;
            Exp1 = 1.5e3;
            Exp2 = 1.5e-3;

            Bo = true;
            Ch = 'a';
            St = "Zeichenkette";

            LblAnzeige.Text =
                "byte: " + By + "\n" +
                "short: " + Sh + "\n" +
                "int: " + It + "\n" +
                "long: " + Lg + "\n" +
                "(binäre Zahl): " + Bn + "\n" +
                "(hexadezimale Zahl): " + Hex + "\n\n" +

                "float: " + F1 + "\n" +
                "double 1: " + Db1 + "\n" +
                "double 2: " + Db2 + "\n" +
                "decimal: " + De + "\n" +
                "(Exponent positiv): " + Exp1 + "\n" +
                "(Exponent negativ): " + Exp2 + "\n\n" +

                "bool: " + Bo + "\n" +
                "char: " + Ch + "\n" +
                "string: " + St;
        }
    }
}
