namespace Position_Groesse_Farbe
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
            this.CmdPositionRel = new System.Windows.Forms.Button();
            this.CmdPositionAbs = new System.Windows.Forms.Button();
            this.CmdGroesseRel = new System.Windows.Forms.Button();
            this.CmdGroesseAbs = new System.Windows.Forms.Button();
            this.CmdTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPositionRel
            // 
            this.CmdPositionRel.Location = new System.Drawing.Point(12, 12);
            this.CmdPositionRel.Name = "CmdPositionRel";
            this.CmdPositionRel.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionRel.TabIndex = 0;
            this.CmdPositionRel.Text = "Position Rel";
            this.CmdPositionRel.UseVisualStyleBackColor = true;
            this.CmdPositionRel.Click += new System.EventHandler(this.CmdPositionRel_Click);
            // 
            // CmdPositionAbs
            // 
            this.CmdPositionAbs.Location = new System.Drawing.Point(197, 12);
            this.CmdPositionAbs.Name = "CmdPositionAbs";
            this.CmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionAbs.TabIndex = 1;
            this.CmdPositionAbs.Text = "Position Abs";
            this.CmdPositionAbs.UseVisualStyleBackColor = true;
            this.CmdPositionAbs.Click += new System.EventHandler(this.CmdPositionAbs_Click);
            // 
            // CmdGroesseRel
            // 
            this.CmdGroesseRel.Location = new System.Drawing.Point(12, 125);
            this.CmdGroesseRel.Name = "CmdGroesseRel";
            this.CmdGroesseRel.Size = new System.Drawing.Size(75, 23);
            this.CmdGroesseRel.TabIndex = 2;
            this.CmdGroesseRel.Text = "Größe Rel";
            this.CmdGroesseRel.UseVisualStyleBackColor = true;
            this.CmdGroesseRel.Click += new System.EventHandler(this.CmdGroesseRel_Click);
            // 
            // CmdGroesseAbs
            // 
            this.CmdGroesseAbs.Location = new System.Drawing.Point(197, 125);
            this.CmdGroesseAbs.Name = "CmdGroesseAbs";
            this.CmdGroesseAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdGroesseAbs.TabIndex = 3;
            this.CmdGroesseAbs.Text = "Größe Abs";
            this.CmdGroesseAbs.UseVisualStyleBackColor = true;
            this.CmdGroesseAbs.Click += new System.EventHandler(this.CmdGroesseAbs_Click);
            // 
            // CmdTest
            // 
            this.CmdTest.Location = new System.Drawing.Point(12, 226);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(75, 23);
            this.CmdTest.TabIndex = 0;
            this.CmdTest.Text = "Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdTest);
            this.Controls.Add(this.CmdGroesseAbs);
            this.Controls.Add(this.CmdGroesseRel);
            this.Controls.Add(this.CmdPositionAbs);
            this.Controls.Add(this.CmdPositionRel);
            this.Name = "Form1";
            this.Text = "Position, Größe, Farbe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdPositionRel;
        private System.Windows.Forms.Button CmdPositionAbs;
        private System.Windows.Forms.Button CmdGroesseRel;
        private System.Windows.Forms.Button CmdGroesseAbs;
        private System.Windows.Forms.Button CmdTest;
    }
}

