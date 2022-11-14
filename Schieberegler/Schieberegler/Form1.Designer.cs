namespace Schieberegler
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
            this.tBRot = new System.Windows.Forms.TrackBar();
            this.tBGruen = new System.Windows.Forms.TrackBar();
            this.tBBlau = new System.Windows.Forms.TrackBar();
            this.p = new System.Windows.Forms.Panel();
            this.LblRot = new System.Windows.Forms.Label();
            this.LblGruen = new System.Windows.Forms.Label();
            this.LblBlau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBlau)).BeginInit();
            this.SuspendLayout();
            // 
            // tBRot
            // 
            this.tBRot.LargeChange = 32;
            this.tBRot.Location = new System.Drawing.Point(12, 12);
            this.tBRot.Maximum = 255;
            this.tBRot.Name = "tBRot";
            this.tBRot.Size = new System.Drawing.Size(104, 45);
            this.tBRot.SmallChange = 8;
            this.tBRot.TabIndex = 0;
            this.tBRot.TickFrequency = 16;
            this.tBRot.Scroll += new System.EventHandler(this.tBRot_Scroll);
            // 
            // tBGruen
            // 
            this.tBGruen.LargeChange = 32;
            this.tBGruen.Location = new System.Drawing.Point(12, 63);
            this.tBGruen.Maximum = 255;
            this.tBGruen.Name = "tBGruen";
            this.tBGruen.Size = new System.Drawing.Size(104, 45);
            this.tBGruen.SmallChange = 8;
            this.tBGruen.TabIndex = 1;
            this.tBGruen.TickFrequency = 16;
            this.tBGruen.Scroll += new System.EventHandler(this.tBGruen_Scroll);
            // 
            // tBBlau
            // 
            this.tBBlau.LargeChange = 32;
            this.tBBlau.Location = new System.Drawing.Point(12, 114);
            this.tBBlau.Maximum = 255;
            this.tBBlau.Name = "tBBlau";
            this.tBBlau.Size = new System.Drawing.Size(104, 45);
            this.tBBlau.SmallChange = 8;
            this.tBBlau.TabIndex = 2;
            this.tBBlau.TickFrequency = 16;
            this.tBBlau.Scroll += new System.EventHandler(this.tBBlau_Scroll);
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(163, 12);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(134, 147);
            this.p.TabIndex = 3;
            // 
            // LblRot
            // 
            this.LblRot.AutoSize = true;
            this.LblRot.Location = new System.Drawing.Point(122, 12);
            this.LblRot.Name = "LblRot";
            this.LblRot.Size = new System.Drawing.Size(0, 13);
            this.LblRot.TabIndex = 4;
            // 
            // LblGruen
            // 
            this.LblGruen.AutoSize = true;
            this.LblGruen.Location = new System.Drawing.Point(122, 63);
            this.LblGruen.Name = "LblGruen";
            this.LblGruen.Size = new System.Drawing.Size(0, 13);
            this.LblGruen.TabIndex = 5;
            // 
            // LblBlau
            // 
            this.LblBlau.AutoSize = true;
            this.LblBlau.Location = new System.Drawing.Point(122, 114);
            this.LblBlau.Name = "LblBlau";
            this.LblBlau.Size = new System.Drawing.Size(0, 13);
            this.LblBlau.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.Controls.Add(this.LblBlau);
            this.Controls.Add(this.LblGruen);
            this.Controls.Add(this.LblRot);
            this.Controls.Add(this.p);
            this.Controls.Add(this.tBBlau);
            this.Controls.Add(this.tBGruen);
            this.Controls.Add(this.tBRot);
            this.Name = "Form1";
            this.Text = "Schieberegler";
            ((System.ComponentModel.ISupportInitialize)(this.tBRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBGruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBBlau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBRot;
        private System.Windows.Forms.TrackBar tBGruen;
        private System.Windows.Forms.TrackBar tBBlau;
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Label LblRot;
        private System.Windows.Forms.Label LblGruen;
        private System.Windows.Forms.Label LblBlau;
    }
}

