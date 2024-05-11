namespace DoAnWin.UserControls
{
    partial class UCWorkingWorker
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
            this.lblStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinish = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtDescribe = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.White;
            this.panelContain.BorderColor = System.Drawing.Color.Silver;
            this.panelContain.BorderRadius = 10;
            this.panelContain.BorderThickness = 2;
            this.panelContain.Controls.Add(this.lblStatus);
            this.panelContain.Controls.Add(this.btnFinish);
            this.panelContain.Controls.Add(this.txtDescribe);
            this.panelContain.Controls.Add(this.lblID);
            this.panelContain.Controls.Add(this.lblName);
            this.panelContain.Controls.Add(this.guna2CirclePictureBox1);
            this.panelContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContain.Location = new System.Drawing.Point(0, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1150, 96);
            this.panelContain.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.BorderRadius = 8;
            this.lblStatus.DisabledState.BorderColor = System.Drawing.Color.Lime;
            this.lblStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblStatus.DisabledState.FillColor = System.Drawing.Color.Lime;
            this.lblStatus.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Enabled = false;
            this.lblStatus.FillColor = System.Drawing.Color.Lime;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(391, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 30);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Đã hoàn thành";
            // 
            // btnFinish
            // 
            this.btnFinish.BorderRadius = 5;
            this.btnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(588, 26);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(180, 45);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Hoàn thành";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtDescribe
            // 
            this.txtDescribe.BorderRadius = 10;
            this.txtDescribe.BorderThickness = 2;
            this.txtDescribe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescribe.DefaultText = "";
            this.txtDescribe.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.txtDescribe.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDescribe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtDescribe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescribe.Enabled = false;
            this.txtDescribe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescribe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescribe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescribe.Location = new System.Drawing.Point(814, 14);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.PasswordChar = '\0';
            this.txtDescribe.PlaceholderText = "";
            this.txtDescribe.SelectedText = "";
            this.txtDescribe.Size = new System.Drawing.Size(298, 68);
            this.txtDescribe.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(259, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 22);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "200050";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(92, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UCWorkingWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContain);
            this.Name = "UCWorkingWorker";
            this.Size = new System.Drawing.Size(1150, 96);
            this.Load += new System.EventHandler(this.UCWorkingWorker_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelContain;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescribe;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinish;
        private Guna.UI2.WinForms.Guna2Button lblStatus;
        private System.Windows.Forms.Label lblID;
    }
}
