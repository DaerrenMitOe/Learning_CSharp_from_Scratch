namespace Rechenoperatoren2
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
            this.CmdAusdruck1 = new System.Windows.Forms.Button();
            this.CmdAusdruck2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAusdruck1
            // 
            this.CmdAusdruck1.Location = new System.Drawing.Point(197, 13);
            this.CmdAusdruck1.Name = "CmdAusdruck1";
            this.CmdAusdruck1.Size = new System.Drawing.Size(75, 23);
            this.CmdAusdruck1.TabIndex = 0;
            this.CmdAusdruck1.Text = "1. Ausdruck";
            this.CmdAusdruck1.UseVisualStyleBackColor = true;
            this.CmdAusdruck1.Click += new System.EventHandler(this.CmdAusdruck1_Click);
            // 
            // CmdAusdruck2
            // 
            this.CmdAusdruck2.Location = new System.Drawing.Point(197, 51);
            this.CmdAusdruck2.Name = "CmdAusdruck2";
            this.CmdAusdruck2.Size = new System.Drawing.Size(75, 23);
            this.CmdAusdruck2.TabIndex = 1;
            this.CmdAusdruck2.Text = "2. Ausdruck";
            this.CmdAusdruck2.UseVisualStyleBackColor = true;
            this.CmdAusdruck2.Click += new System.EventHandler(this.CmdAusdruck2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAusdruck2);
            this.Controls.Add(this.CmdAusdruck1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAusdruck1;
        private System.Windows.Forms.Button CmdAusdruck2;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

