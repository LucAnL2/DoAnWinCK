namespace DoAnWin.ChildFormUser
{
    partial class FComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FComment));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RSRate = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanelContainImage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Indigo;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(748, 45);
            this.panelTop.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(703, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bình luận";
            // 
            // RSRate
            // 
            this.RSRate.BackColor = System.Drawing.Color.Transparent;
            this.RSRate.BorderColor = System.Drawing.Color.Gainsboro;
            this.RSRate.Location = new System.Drawing.Point(191, 68);
            this.RSRate.Name = "RSRate";
            this.RSRate.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.RSRate.Size = new System.Drawing.Size(138, 28);
            this.RSRate.TabIndex = 14;
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.lblMonthYear.Location = new System.Drawing.Point(56, 68);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(116, 26);
            this.lblMonthYear.TabIndex = 15;
            this.lblMonthYear.Text = "Đánh giá:";
            // 
            // txtComment
            // 
            this.txtComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.BorderThickness = 3;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Location = new System.Drawing.Point(61, 133);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "Nhập bình luận";
            this.txtComment.SelectedText = "";
            this.txtComment.Size = new System.Drawing.Size(406, 155);
            this.txtComment.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(68, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bình luận:";
            // 
            // flowPanelContainImage
            // 
            this.flowPanelContainImage.AutoScroll = true;
            this.flowPanelContainImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanelContainImage.Location = new System.Drawing.Point(60, 346);
            this.flowPanelContainImage.Name = "flowPanelContainImage";
            this.flowPanelContainImage.Size = new System.Drawing.Size(616, 151);
            this.flowPanelContainImage.TabIndex = 18;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.btnAddImage.BorderThickness = 1;
            this.btnAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImage.FillColor = System.Drawing.Color.White;
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Image = global::DoAnWin.Properties.Resources.plusTim;
            this.btnAddImage.Location = new System.Drawing.Point(682, 346);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(31, 151);
            this.btnAddImage.TabIndex = 17;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(67, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đính kèm ảnh:";
            // 
            // btnFinish
            // 
            this.btnFinish.Animated = true;
            this.btnFinish.AutoRoundedCorners = true;
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderRadius = 21;
            this.btnFinish.BorderThickness = 2;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.HoverState.BorderColor = System.Drawing.Color.Indigo;
            this.btnFinish.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFinish.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFinish.HoverState.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(512, 181);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(201, 45);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "Hoàn thành";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // FComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 523);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.flowPanelContainImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblMonthYear);
            this.Controls.Add(this.RSRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FComment";
            this.Load += new System.EventHandler(this.FComment_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2RatingStar RSRate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.FlowLayoutPanel flowPanelContainImage;
        private Guna.UI2.WinForms.Guna2Button btnAddImage;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinish;
    }
}