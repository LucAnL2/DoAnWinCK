namespace DoAnWin.ChildFormWorker
{
    partial class UCCandidate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.RSStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.btnHire = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(28, 26);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(91, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // RSStar
            // 
            this.RSStar.Location = new System.Drawing.Point(219, 33);
            this.RSStar.Name = "RSStar";
            this.RSStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.RSStar.ReadOnly = true;
            this.RSStar.Size = new System.Drawing.Size(120, 28);
            this.RSStar.TabIndex = 3;
            // 
            // btnHire
            // 
            this.btnHire.BorderRadius = 8;
            this.btnHire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHire.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHire.ForeColor = System.Drawing.Color.White;
            this.btnHire.Location = new System.Drawing.Point(385, 26);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(100, 45);
            this.btnHire.TabIndex = 4;
            this.btnHire.Text = "Thuê";
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // UCCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.RSStar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UCCandidate";
            this.Size = new System.Drawing.Size(500, 96);
            this.Load += new System.EventHandler(this.UCCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2RatingStar RSStar;
        private Guna.UI2.WinForms.Guna2GradientButton btnHire;
    }
}
