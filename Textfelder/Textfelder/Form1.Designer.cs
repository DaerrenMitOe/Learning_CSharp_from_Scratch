namespace Textfelder
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(13, 13);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 0;
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(197, 13);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(75, 23);
            this.CmdAusgabe.TabIndex = 1;
            this.CmdAusgabe.Text = "Ausgabe";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(197, 51);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 2;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(13, 86);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.CmdAusgabe);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

