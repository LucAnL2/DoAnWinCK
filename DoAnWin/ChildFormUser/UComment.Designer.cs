namespace DoAnWin.UserControls
{
    partial class UComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UComment));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.RSRate = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.picImage = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImageBackground = new System.Windows.Forms.ImageList(this.components);
            this.DefaultBackground = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.picImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(18, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // RSRate
            // 
            this.RSRate.BackColor = System.Drawing.Color.Transparent;
            this.RSRate.BorderColor = System.Drawing.Color.Gainsboro;
            this.RSRate.Location = new System.Drawing.Point(199, 9);
            this.RSRate.Name = "RSRate";
            this.RSRate.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.RSRate.ReadOnly = true;
            this.RSRate.Size = new System.Drawing.Size(120, 28);
            this.RSRate.TabIndex = 3;
            this.RSRate.Value = 2.5F;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(75, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bình luận:";
            // 
            // txtComment
            // 
            this.txtComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.BorderThickness = 3;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.Enabled = false;
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Location = new System.Drawing.Point(18, 65);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "Nhập bình luận";
            this.txtComment.SelectedText = "";
            this.txtComment.Size = new System.Drawing.Size(523, 123);
            this.txtComment.TabIndex = 18;
            // 
            // picImage
            // 
            this.picImage.BackgroundImage = global::DoAnWin.Properties.Resources.ImageLogin;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Controls.Add(this.btnNext);
            this.picImage.Controls.Add(this.btnPrevious);
            this.picImage.Location = new System.Drawing.Point(570, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(327, 202);
            this.picImage.TabIndex = 19;
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
            this.btnNext.Location = new System.Drawing.Point(291, 74);
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
            this.btnPrevious.Location = new System.Drawing.Point(3, 74);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PressedState.Image = global::DoAnWin.Properties.Resources.left;
            this.btnPrevious.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPrevious.Size = new System.Drawing.Size(36, 54);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
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
            // UComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.RSRate);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UComment";
            this.Size = new System.Drawing.Size(900, 208);
            this.Load += new System.EventHandler(this.UComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.picImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2RatingStar RSRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2Panel picImage;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrevious;
        private System.Windows.Forms.ImageList ImageBackground;
        private System.Windows.Forms.ImageList DefaultBackground;
    }
}
