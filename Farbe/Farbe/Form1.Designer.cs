namespace Farbe
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
            this.CmdPositionAbs = new System.Windows.Forms.Button();
            this.CmdGroesseAbs = new System.Windows.Forms.Button();
            this.CmdTest = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.CmdFarbe = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdPositionAbs
            // 
            this.CmdPositionAbs.Location = new System.Drawing.Point(12, 12);
            this.CmdPositionAbs.Name = "CmdPositionAbs";
            this.CmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionAbs.TabIndex = 0;
            this.CmdPositionAbs.Text = "Position Abs";
            this.CmdPositionAbs.UseVisualStyleBackColor = true;
            this.CmdPositionAbs.Click += new System.EventHandler(this.CmdPositionAbs_Click);
            // 
            // CmdGroesseAbs
            // 
            this.CmdGroesseAbs.Location = new System.Drawing.Point(12, 57);
            this.CmdGroesseAbs.Name = "CmdGroesseAbs";
            this.CmdGroesseAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdGroesseAbs.TabIndex = 1;
            this.CmdGroesseAbs.Text = "Größe Abs";
            this.CmdGroesseAbs.UseVisualStyleBackColor = true;
            this.CmdGroesseAbs.Click += new System.EventHandler(this.CmdGroesseAbs_Click);
            // 
            // CmdTest
            // 
            this.CmdTest.Location = new System.Drawing.Point(12, 101);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(75, 23);
            this.CmdTest.TabIndex = 2;
            this.CmdTest.Text = "Test";
            this.CmdTest.UseVisualStyleBackColor = true;
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(119, 12);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 3;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdFarbe
            // 
            this.CmdFarbe.Location = new System.Drawing.Point(119, 101);
            this.CmdFarbe.Name = "CmdFarbe";
            this.CmdFarbe.Size = new System.Drawing.Size(75, 23);
            this.CmdFarbe.TabIndex = 4;
            this.CmdFarbe.Text = "Farbe";
            this.CmdFarbe.UseVisualStyleBackColor = true;
            this.CmdFarbe.Click += new System.EventHandler(this.CmdFarbe_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(116, 67);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdFarbe);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdTest);
            this.Controls.Add(this.CmdGroesseAbs);
            this.Controls.Add(this.CmdPositionAbs);
            this.Name = "Form1";
            this.Text = "Farbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPositionAbs;
        private System.Windows.Forms.Button CmdGroesseAbs;
        private System.Windows.Forms.Button CmdTest;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdFarbe;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

