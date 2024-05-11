namespace DoAnWin.ChildFormWorker
{
    partial class UCWorkerSeekJob
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorkerSeekJob));
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2ImageButton();
            this.picImage = new Guna.UI2.WinForms.Guna2Panel();
            this.btnApplyfor = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescribe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRequire = new Guna.UI2.WinForms.Guna2TextBox();
            this.ImageBackground = new System.Windows.Forms.ImageList(this.components);
            this.DefaultBackground = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJob = new Guna.UI2.WinForms.Guna2TextBox();
            this.picImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AnimatedGIF = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.Image = global::DoAnWin.Properties.Resources.right;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnNext.Image = global::DoAnWin.Properties.Resources.angle_rightxam;
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(22, 22);
            this.btnNext.Location = new System.Drawing.Point(252, 87);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.Image = global::DoAnWin.Properties.Resources.right;
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNext.Size = new System.Drawing.Size(36, 54);
            this.btnNext.TabIndex = 0;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AnimatedGIF = true;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPrevious.HoverState.Image = global::DoAnWin.Properties.Resources.left;
            this.btnPrevious.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnPrevious.Image = global::DoAnWin.Properties.Resources.angle_leftxam;
            this.btnPrevious.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrevious.ImageRotate = 0F;
            this.btnPrevious.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPrevious.Location = new System.Drawing.Point(0, 87);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PressedState.Image = global::DoAnWin.Properties.Resources.left;
            this.btnPrevious.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPrevious.Size = new System.Drawing.Size(36, 54);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImage = global::DoAnWin.Properties.Resources.ImageLogin;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Controls.Add(this.btnNext);
            this.picImage.Controls.Add(this.btnPrevious);
            this.picImage.Location = new System.Drawing.Point(13, 16);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(288, 245);
            this.picImage.TabIndex = 20;
            // 
            // btnApplyfor
            // 
            this.btnApplyfor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplyfor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplyfor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplyfor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplyfor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplyfor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApplyfor.ForeColor = System.Drawing.Color.White;
            this.btnApplyfor.Location = new System.Drawing.Point(383, 379);
            this.btnApplyfor.Name = "btnApplyfor";
            this.btnApplyfor.Size = new System.Drawing.Size(128, 45);
            this.btnApplyfor.TabIndex = 21;
            this.btnApplyfor.Text = "Ứng tuyển";
            this.btnApplyfor.Click += new System.EventHandler(this.btnApplyfor_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(379, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(322, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 22;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(336, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mô tả công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(26, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mức lương:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(26, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Yêu cầu:";
            // 
            // txtDescribe
            // 
            this.txtDescribe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.txtDescribe.BorderThickness = 3;
            this.txtDescribe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescribe.DefaultText = "";
            this.txtDescribe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescribe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescribe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescribe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescribe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescribe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescribe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescribe.Location = new System.Drawing.Point(316, 163);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.PasswordChar = '\0';
            this.txtDescribe.PlaceholderText = "";
            this.txtDescribe.SelectedText = "";
            this.txtDescribe.Size = new System.Drawing.Size(251, 185);
            this.txtDescribe.TabIndex = 24;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.txtSalary.BorderThickness = 3;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(13, 286);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(232, 48);
            this.txtSalary.TabIndex = 25;
            // 
            // txtRequire
            // 
            this.txtRequire.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.txtRequire.BorderThickness = 3;
            this.txtRequire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequire.DefaultText = "";
            this.txtRequire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRequire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRequire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRequire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRequire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRequire.Location = new System.Drawing.Point(13, 361);
            this.txtRequire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRequire.Name = "txtRequire";
            this.txtRequire.PasswordChar = '\0';
            this.txtRequire.PlaceholderText = "";
            this.txtRequire.SelectedText = "";
            this.txtRequire.Size = new System.Drawing.Size(273, 63);
            this.txtRequire.TabIndex = 26;
            // 
            // ImageBackground
            // 
            this.ImageBackground.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ImageBackground.ImageSize = new System.Drawing.Size(200, 200);
            this.ImageBackground.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DefaultBackground
            // 
            this.DefaultBackground.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DefaultBackground.ImageStream")));
            this.DefaultBackground.TransparentColor = System.Drawing.Color.Transparent;
            this.DefaultBackground.Images.SetKeyName(0, "Background1.jpg");
            this.DefaultBackground.Images.SetKeyName(1, "Background2.jpg");
            this.DefaultBackground.Images.SetKeyName(2, "Background3.jpg");
            this.DefaultBackground.Images.SetKeyName(3, "Background4.jpg");
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txtJob);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtDescribe);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(587, 450);
            this.guna2Panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(329, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhóm công việc:";
            // 
            // txtJob
            // 
            this.txtJob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.txtJob.BorderThickness = 3;
            this.txtJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJob.DefaultText = "";
            this.txtJob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJob.Location = new System.Drawing.Point(316, 88);
            this.txtJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJob.Name = "txtJob";
            this.txtJob.PasswordChar = '\0';
            this.txtJob.PlaceholderText = "";
            this.txtJob.SelectedText = "";
            this.txtJob.Size = new System.Drawing.Size(251, 48);
            this.txtJob.TabIndex = 29;
            // 
            // UCWorkerSeekJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtRequire);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnApplyfor);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCWorkerSeekJob";
            this.Size = new System.Drawing.Size(587, 450);
            this.picImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrevious;
        private Guna.UI2.WinForms.Guna2Panel picImage;
        private Guna.UI2.WinForms.Guna2GradientButton btnApplyfor;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescribe;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2TextBox txtRequire;
        private System.Windows.Forms.ImageList ImageBackground;
        private System.Windows.Forms.ImageList DefaultBackground;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtJob;
    }
}
