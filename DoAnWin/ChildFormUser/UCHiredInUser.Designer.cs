namespace DoAnWin.UserControls
{
    partial class UCHiredInUser
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
            this.panelContain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFinishDay = new System.Windows.Forms.Label();
            this.btnComment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BorderColor = System.Drawing.Color.Transparent;
            this.panelContain.BorderRadius = 10;
            this.panelContain.BorderThickness = 3;
            this.panelContain.Controls.Add(this.lblFinishDay);
            this.panelContain.Controls.Add(this.btnComment);
            this.panelContain.Controls.Add(this.lblID);
            this.panelContain.Controls.Add(this.lblName);
            this.panelContain.Controls.Add(this.guna2CirclePictureBox1);
            this.panelContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContain.Location = new System.Drawing.Point(0, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(790, 91);
            this.panelContain.TabIndex = 0;
            this.panelContain.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblFinishDay
            // 
            this.lblFinishDay.AutoSize = true;
            this.lblFinishDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishDay.ForeColor = System.Drawing.Color.Silver;
            this.lblFinishDay.Location = new System.Drawing.Point(431, 40);
            this.lblFinishDay.Name = "lblFinishDay";
            this.lblFinishDay.Size = new System.Drawing.Size(90, 18);
            this.lblFinishDay.TabIndex = 18;
            this.lblFinishDay.Text = "01/01/2024";
            // 
            // btnComment
            // 
            this.btnComment.BorderRadius = 5;
            this.btnComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.ForeColor = System.Drawing.Color.White;
            this.btnComment.Location = new System.Drawing.Point(591, 24);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(180, 45);
            this.btnComment.TabIndex = 17;
            this.btnComment.Text = "Bình luận";
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(279, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 22);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "200050";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(116, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Lý Lục Ân";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(17, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UCHiredInUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContain);
            this.Name = "UCHiredInUser";
            this.Size = new System.Drawing.Size(790, 91);
            this.Load += new System.EventHandler(this.UCHiredInUser_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelContain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private Guna.UI2.WinForms.Guna2GradientButton btnComment;
        private System.Windows.Forms.Label lblFinishDay;
    }
}
