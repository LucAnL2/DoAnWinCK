namespace DoAnWin.UserControls
{
    partial class UCWorkedInWorker
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.RSStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblFinishDay = new System.Windows.Forms.Label();
            this.lblIdWork = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.RSStar);
            this.guna2Panel1.Controls.Add(this.lblFinishDay);
            this.guna2Panel1.Controls.Add(this.lblIdWork);
            this.guna2Panel1.Controls.Add(this.lblID);
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1200, 91);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // RSStar
            // 
            this.RSStar.Location = new System.Drawing.Point(1024, 29);
            this.RSStar.Name = "RSStar";
            this.RSStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.RSStar.ReadOnly = true;
            this.RSStar.Size = new System.Drawing.Size(120, 28);
            this.RSStar.TabIndex = 23;
            this.RSStar.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // lblFinishDay
            // 
            this.lblFinishDay.AutoSize = true;
            this.lblFinishDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishDay.ForeColor = System.Drawing.Color.Silver;
            this.lblFinishDay.Location = new System.Drawing.Point(560, 39);
            this.lblFinishDay.Name = "lblFinishDay";
            this.lblFinishDay.Size = new System.Drawing.Size(90, 18);
            this.lblFinishDay.TabIndex = 22;
            this.lblFinishDay.Text = "01/01/2024";
            // 
            // lblIdWork
            // 
            this.lblIdWork.AutoSize = true;
            this.lblIdWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblIdWork.Location = new System.Drawing.Point(812, 35);
            this.lblIdWork.Name = "lblIdWork";
            this.lblIdWork.Size = new System.Drawing.Size(76, 22);
            this.lblIdWork.TabIndex = 20;
            this.lblIdWork.Text = "300050";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(346, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 22);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "200050";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(141, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 22);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Lý Lục Ân";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DoAnWin.Properties.Resources.avartar1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(15, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UCWorkedInWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCWorkedInWorker";
            this.Size = new System.Drawing.Size(1200, 91);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2RatingStar RSStar;
        private System.Windows.Forms.Label lblFinishDay;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdWork;
    }
}
