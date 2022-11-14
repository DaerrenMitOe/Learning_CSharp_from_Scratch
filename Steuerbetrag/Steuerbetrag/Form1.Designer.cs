namespace Steuerbetrag
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
            this.tGehalt = new System.Windows.Forms.TextBox();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tGehalt
            // 
            this.tGehalt.Location = new System.Drawing.Point(12, 25);
            this.tGehalt.Name = "tGehalt";
            this.tGehalt.Size = new System.Drawing.Size(100, 20);
            this.tGehalt.TabIndex = 0;
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(12, 9);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(41, 13);
            this.LblAnzeige1.TabIndex = 1;
            this.LblAnzeige1.Text = "Gehalt:";
            this.LblAnzeige1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(12, 51);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige.TabIndex = 2;
            this.CmdAnzeige.Text = "Berechnen";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(142, 28);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.tGehalt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tGehalt;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Label LblAnzeige2;
    }
}

