namespace DoAnWin.UserControls
{
    partial class UCTopWorker
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
            this.btnLook = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblLikeTime = new System.Windows.Forms.Label();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.RSRate = new Guna.UI2.WinForms.Guna2RatingStar();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLook
            // 
            this.btnLook.BorderRadius = 5;
            this.btnLook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLook.ForeColor = System.Drawing.Color.White;
            this.btnLook.Location = new System.Drawing.Point(986, 16);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(180, 45);
            this.btnLook.TabIndex = 18;
            this.btnLook.Text = "Xem";
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(161, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(36, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 16;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblLikeTime
            // 
            this.lblLikeTime.AutoSize = true;
            this.lblLikeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikeTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblLikeTime.Location = new System.Drawing.Point(402, 39);
            this.lblLikeTime.Name = "lblLikeTime";
            this.lblLikeTime.Size = new System.Drawing.Size(98, 22);
            this.lblLikeTime.TabIndex = 17;
            this.lblLikeTime.Text = "Lượt thích";
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgheNghiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblNgheNghiep.Location = new System.Drawing.Point(570, 39);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(123, 22);
            this.lblNgheNghiep.TabIndex = 17;
            this.lblNgheNghiep.Text = "Nghề nghiệp";
            // 
            // RSRate
            // 
            this.RSRate.BackColor = System.Drawing.Color.Transparent;
            this.RSRate.BorderColor = System.Drawing.Color.Gainsboro;
            this.RSRate.Location = new System.Drawing.Point(777, 33);
            this.RSRate.Name = "RSRate";
            this.RSRate.RatingColor = System.Drawing.Color.Cyan;
            this.RSRate.ReadOnly = true;
            this.RSRate.Size = new System.Drawing.Size(120, 28);
            this.RSRate.TabIndex = 19;
            this.RSRate.Value = 2.5F;
            // 
            // UCTopWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RSRate);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lblNgheNghiep);
            this.Controls.Add(this.lblLikeTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UCTopWorker";
            this.Size = new System.Drawing.Size(1200, 89);
            this.Load += new System.EventHandler(this.UCTopWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnLook;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblLikeTime;
        private System.Windows.Forms.Label lblNgheNghiep;
        private Guna.UI2.WinForms.Guna2RatingStar RSRate;
    }
}
