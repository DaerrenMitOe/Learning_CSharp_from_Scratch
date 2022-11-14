namespace Optionsschaltflächen
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
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.rBRot = new System.Windows.Forms.RadioButton();
            this.rBGruen = new System.Windows.Forms.RadioButton();
            this.rBBlue = new System.Windows.Forms.RadioButton();
            this.CmdRotSchalten = new System.Windows.Forms.Button();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(12, 9);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 0;
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(187, 12);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(85, 23);
            this.CmdPruefen.TabIndex = 1;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // rBRot
            // 
            this.rBRot.AutoSize = true;
            this.rBRot.Location = new System.Drawing.Point(187, 41);
            this.rBRot.Name = "rBRot";
            this.rBRot.Size = new System.Drawing.Size(42, 17);
            this.rBRot.TabIndex = 2;
            this.rBRot.TabStop = true;
            this.rBRot.Text = "Rot";
            this.rBRot.UseVisualStyleBackColor = true;
            this.rBRot.CheckedChanged += new System.EventHandler(this.rBRot_CheckedChanged);
            // 
            // rBGruen
            // 
            this.rBGruen.AutoSize = true;
            this.rBGruen.Location = new System.Drawing.Point(187, 64);
            this.rBGruen.Name = "rBGruen";
            this.rBGruen.Size = new System.Drawing.Size(48, 17);
            this.rBGruen.TabIndex = 3;
            this.rBGruen.TabStop = true;
            this.rBGruen.Text = "Grün";
            this.rBGruen.UseVisualStyleBackColor = true;
            this.rBGruen.CheckedChanged += new System.EventHandler(this.rBGruen_CheckedChanged);
            // 
            // rBBlue
            // 
            this.rBBlue.AutoSize = true;
            this.rBBlue.Location = new System.Drawing.Point(187, 87);
            this.rBBlue.Name = "rBBlue";
            this.rBBlue.Size = new System.Drawing.Size(46, 17);
            this.rBBlue.TabIndex = 4;
            this.rBBlue.TabStop = true;
            this.rBBlue.Text = "Blau";
            this.rBBlue.UseVisualStyleBackColor = true;
            this.rBBlue.CheckedChanged += new System.EventHandler(this.rBBlue_CheckedChanged);
            // 
            // CmdRotSchalten
            // 
            this.CmdRotSchalten.Location = new System.Drawing.Point(187, 110);
            this.CmdRotSchalten.Name = "CmdRotSchalten";
            this.CmdRotSchalten.Size = new System.Drawing.Size(85, 23);
            this.CmdRotSchalten.TabIndex = 5;
            this.CmdRotSchalten.Text = "Rot schalten";
            this.CmdRotSchalten.UseVisualStyleBackColor = true;
            this.CmdRotSchalten.Click += new System.EventHandler(this.CmdRotSchalten_Click);
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(12, 120);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.CmdRotSchalten);
            this.Controls.Add(this.rBBlue);
            this.Controls.Add(this.rBGruen);
            this.Controls.Add(this.rBRot);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.LblAnzeige1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.RadioButton rBRot;
        private System.Windows.Forms.RadioButton rBGruen;
        private System.Windows.Forms.RadioButton rBBlue;
        private System.Windows.Forms.Button CmdRotSchalten;
        private System.Windows.Forms.Label LblAnzeige2;
    }
}

