namespace Kontrollkästchen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdUmschalten = new System.Windows.Forms.Button();
            this.cBSchalter = new System.Windows.Forms.CheckBox();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(160, 12);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(112, 23);
            this.CmdPruefen.TabIndex = 0;
            this.CmdPruefen.Text = "Schalter prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdUmschalten
            // 
            this.CmdUmschalten.Location = new System.Drawing.Point(160, 76);
            this.CmdUmschalten.Name = "CmdUmschalten";
            this.CmdUmschalten.Size = new System.Drawing.Size(112, 23);
            this.CmdUmschalten.TabIndex = 1;
            this.CmdUmschalten.Text = "Schalter umschalten";
            this.CmdUmschalten.UseVisualStyleBackColor = true;
            this.CmdUmschalten.Click += new System.EventHandler(this.CmdUmschalten_Click);
            // 
            // cBSchalter
            // 
            this.cBSchalter.AutoSize = true;
            this.cBSchalter.Location = new System.Drawing.Point(160, 53);
            this.cBSchalter.Name = "cBSchalter";
            this.cBSchalter.Size = new System.Drawing.Size(65, 17);
            this.cBSchalter.TabIndex = 2;
            this.cBSchalter.Text = "Schalter";
            this.cBSchalter.UseVisualStyleBackColor = true;
            this.cBSchalter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(101, 22);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 3;
            this.LblAnzeige1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(101, 81);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.cBSchalter);
            this.Controls.Add(this.CmdUmschalten);
            this.Controls.Add(this.CmdPruefen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdUmschalten;
        private System.Windows.Forms.CheckBox cBSchalter;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
    }
}

