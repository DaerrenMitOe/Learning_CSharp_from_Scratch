namespace Zahlenauswahlfeld
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
            this.NumEingabe = new System.Windows.Forms.NumericUpDown();
            this.LblAusgabe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // NumEingabe
            // 
            this.NumEingabe.Location = new System.Drawing.Point(12, 12);
            this.NumEingabe.Name = "NumEingabe";
            this.NumEingabe.Size = new System.Drawing.Size(120, 20);
            this.NumEingabe.TabIndex = 0;
            this.NumEingabe.ValueChanged += new System.EventHandler(this.NumEingabe_ValueChanged);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(166, 12);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.NumEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumEingabe;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

