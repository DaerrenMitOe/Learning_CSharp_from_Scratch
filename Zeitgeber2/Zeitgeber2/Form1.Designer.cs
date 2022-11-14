namespace Zeitgeber2
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
            this.components = new System.ComponentModel.Container();
            this.pYellow = new System.Windows.Forms.Panel();
            this.pGreen = new System.Windows.Forms.Panel();
            this.pBlue = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.CmdStart = new System.Windows.Forms.Button();
            this.TimAnzeige = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.Location = new System.Drawing.Point(94, 170);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(20, 20);
            this.pYellow.TabIndex = 0;
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.Green;
            this.pGreen.Location = new System.Drawing.Point(120, 170);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(20, 20);
            this.pGreen.TabIndex = 1;
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.Location = new System.Drawing.Point(120, 144);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(20, 20);
            this.pBlue.TabIndex = 2;
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.Location = new System.Drawing.Point(94, 144);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(20, 20);
            this.pRed.TabIndex = 3;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(84, 12);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 4;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TimAnzeige
            // 
            this.TimAnzeige.Interval = 500;
            this.TimAnzeige.Tick += new System.EventHandler(this.TimAnzeige_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.pRed);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.pGreen);
            this.Controls.Add(this.pYellow);
            this.Name = "Form1";
            this.Text = "Zeitgeber2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Timer TimAnzeige;
    }
}

