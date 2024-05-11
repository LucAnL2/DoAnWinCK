namespace DoAnWin.ChildFormWorker
{
    partial class FWorkerContainComment
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbAll = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNegative = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPosivive = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbPositive = new System.Windows.Forms.Label();
            this.flowPanelContain = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(988, 51);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách bình luận";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.rbAll);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.rbNegative);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.rbPosivive);
            this.guna2Panel1.Controls.Add(this.lbPositive);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(988, 38);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // rbAll
            // 
            this.rbAll.Animated = true;
            this.rbAll.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbAll.CheckedState.BorderThickness = 2;
            this.rbAll.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbAll.CheckedState.InnerColor = System.Drawing.Color.Indigo;
            this.rbAll.CheckedState.InnerOffset = 10;
            this.rbAll.Location = new System.Drawing.Point(853, 8);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(20, 20);
            this.rbAll.TabIndex = 15;
            this.rbAll.Text = "guna2CustomRadioButton1";
            this.rbAll.UncheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbAll.UncheckedState.BorderThickness = 2;
            this.rbAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(877, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tất cả";
            // 
            // rbNegative
            // 
            this.rbNegative.Animated = true;
            this.rbNegative.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbNegative.CheckedState.BorderThickness = 2;
            this.rbNegative.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbNegative.CheckedState.InnerColor = System.Drawing.Color.Indigo;
            this.rbNegative.CheckedState.InnerOffset = 10;
            this.rbNegative.Location = new System.Drawing.Point(687, 9);
            this.rbNegative.Name = "rbNegative";
            this.rbNegative.Size = new System.Drawing.Size(20, 20);
            this.rbNegative.TabIndex = 13;
            this.rbNegative.Text = "guna2CustomRadioButton1";
            this.rbNegative.UncheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbNegative.UncheckedState.BorderThickness = 2;
            this.rbNegative.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNegative.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbNegative.CheckedChanged += new System.EventHandler(this.rbNegative_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(711, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tiêu cực";
            // 
            // rbPosivive
            // 
            this.rbPosivive.Animated = true;
            this.rbPosivive.CheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbPosivive.CheckedState.BorderThickness = 2;
            this.rbPosivive.CheckedState.FillColor = System.Drawing.Color.White;
            this.rbPosivive.CheckedState.InnerColor = System.Drawing.Color.Indigo;
            this.rbPosivive.CheckedState.InnerOffset = 10;
            this.rbPosivive.Location = new System.Drawing.Point(513, 10);
            this.rbPosivive.Name = "rbPosivive";
            this.rbPosivive.Size = new System.Drawing.Size(20, 20);
            this.rbPosivive.TabIndex = 11;
            this.rbPosivive.Text = "guna2CustomRadioButton1";
            this.rbPosivive.UncheckedState.BorderColor = System.Drawing.Color.Indigo;
            this.rbPosivive.UncheckedState.BorderThickness = 2;
            this.rbPosivive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPosivive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPosivive.CheckedChanged += new System.EventHandler(this.rbPosivive_CheckedChanged);
            // 
            // lbPositive
            // 
            this.lbPositive.AutoSize = true;
            this.lbPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPositive.ForeColor = System.Drawing.Color.Indigo;
            this.lbPositive.Location = new System.Drawing.Point(537, 11);
            this.lbPositive.Name = "lbPositive";
            this.lbPositive.Size = new System.Drawing.Size(72, 18);
            this.lbPositive.TabIndex = 12;
            this.lbPositive.Text = "Tích cực";
            // 
            // flowPanelContain
            // 
            this.flowPanelContain.AutoScroll = true;
            this.flowPanelContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelContain.Location = new System.Drawing.Point(0, 89);
            this.flowPanelContain.Name = "flowPanelContain";
            this.flowPanelContain.Size = new System.Drawing.Size(988, 544);
            this.flowPanelContain.TabIndex = 2;
            this.flowPanelContain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelContain_Paint);
            // 
            // FWorkerContainComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 633);
            this.Controls.Add(this.flowPanelContain);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWorkerContainComment";
            this.Text = "FWorkerContainComment";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelContain;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbAll;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbNegative;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbPosivive;
        private System.Windows.Forms.Label lbPositive;
    }
}