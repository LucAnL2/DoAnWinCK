namespace DoAnWin.ChildFormWorker
{
    partial class FWorkerSeekJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWorkerSeekJob));
            this.flowPanelContain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelComboSalary = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalary = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnIncrease = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDecrese = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RollBtnSalary = new System.Windows.Forms.Timer(this.components);
            this.panelComboJob = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJob = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnElectric = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMachine = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPainter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCarver = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnWashman = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnOther = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RollbtnJob = new System.Windows.Forms.Timer(this.components);
            this.panelComboSalary.SuspendLayout();
            this.panelComboJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelContain
            // 
            this.flowPanelContain.AutoScroll = true;
            this.flowPanelContain.BackColor = System.Drawing.Color.White;
            this.flowPanelContain.Location = new System.Drawing.Point(12, 87);
            this.flowPanelContain.Name = "flowPanelContain";
            this.flowPanelContain.Size = new System.Drawing.Size(1250, 668);
            this.flowPanelContain.TabIndex = 0;
            this.flowPanelContain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelContain_Paint);
            // 
            // panelComboSalary
            // 
            this.panelComboSalary.Controls.Add(this.btnSalary);
            this.panelComboSalary.Controls.Add(this.btnIncrease);
            this.panelComboSalary.Controls.Add(this.btnDecrese);
            this.panelComboSalary.Location = new System.Drawing.Point(12, 12);
            this.panelComboSalary.MaximumSize = new System.Drawing.Size(185, 161);
            this.panelComboSalary.MinimumSize = new System.Drawing.Size(185, 53);
            this.panelComboSalary.Name = "panelComboSalary";
            this.panelComboSalary.Size = new System.Drawing.Size(185, 53);
            this.panelComboSalary.TabIndex = 6;
            // 
            // btnSalary
            // 
            this.btnSalary.Animated = true;
            this.btnSalary.BackColor = System.Drawing.Color.White;
            this.btnSalary.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalary.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalary.FillColor = System.Drawing.Color.Transparent;
            this.btnSalary.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalary.ForeColor = System.Drawing.Color.Indigo;
            this.btnSalary.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSalary.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnSalary.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSalary.HoverState.Image = global::DoAnWin.Properties.Resources.downTrang;
            this.btnSalary.Image = global::DoAnWin.Properties.Resources.rightTim;
            this.btnSalary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSalary.ImageOffset = new System.Drawing.Point(6, 0);
            this.btnSalary.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSalary.Location = new System.Drawing.Point(3, 3);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(180, 46);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Lương";
            this.btnSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalary.TextOffset = new System.Drawing.Point(5, 0);
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Animated = true;
            this.btnIncrease.BackColor = System.Drawing.Color.White;
            this.btnIncrease.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnIncrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrease.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncrease.FillColor = System.Drawing.Color.Transparent;
            this.btnIncrease.FillColor2 = System.Drawing.Color.Transparent;
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIncrease.ForeColor = System.Drawing.Color.Indigo;
            this.btnIncrease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnIncrease.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnIncrease.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnIncrease.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnIncrease.ImageSize = new System.Drawing.Size(15, 15);
            this.btnIncrease.Location = new System.Drawing.Point(3, 55);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(180, 46);
            this.btnIncrease.TabIndex = 4;
            this.btnIncrease.Text = "Tăng dần";
            this.btnIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIncrease.TextOffset = new System.Drawing.Point(5, 0);
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrese
            // 
            this.btnDecrese.Animated = true;
            this.btnDecrese.BackColor = System.Drawing.Color.White;
            this.btnDecrese.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnDecrese.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrese.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrese.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrese.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrese.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrese.FillColor = System.Drawing.Color.Transparent;
            this.btnDecrese.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDecrese.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrese.ForeColor = System.Drawing.Color.Indigo;
            this.btnDecrese.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDecrese.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnDecrese.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrese.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDecrese.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDecrese.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDecrese.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDecrese.Location = new System.Drawing.Point(3, 107);
            this.btnDecrese.Name = "btnDecrese";
            this.btnDecrese.Size = new System.Drawing.Size(180, 46);
            this.btnDecrese.TabIndex = 5;
            this.btnDecrese.Text = "Giảm dần";
            this.btnDecrese.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDecrese.TextOffset = new System.Drawing.Point(5, 0);
            this.btnDecrese.Click += new System.EventHandler(this.btnDecrese_Click);
            // 
            // RollBtnSalary
            // 
            this.RollBtnSalary.Interval = 1;
            this.RollBtnSalary.Tick += new System.EventHandler(this.RollBtnSalary_Tick_1);
            // 
            // panelComboJob
            // 
            this.panelComboJob.Controls.Add(this.btnJob);
            this.panelComboJob.Controls.Add(this.btnElectric);
            this.panelComboJob.Controls.Add(this.btnMachine);
            this.panelComboJob.Controls.Add(this.btnPainter);
            this.panelComboJob.Controls.Add(this.btnCarver);
            this.panelComboJob.Controls.Add(this.btnWashman);
            this.panelComboJob.Controls.Add(this.btnOther);
            this.panelComboJob.Location = new System.Drawing.Point(232, 12);
            this.panelComboJob.MaximumSize = new System.Drawing.Size(185, 367);
            this.panelComboJob.MinimumSize = new System.Drawing.Size(185, 53);
            this.panelComboJob.Name = "panelComboJob";
            this.panelComboJob.Size = new System.Drawing.Size(185, 53);
            this.panelComboJob.TabIndex = 7;
            // 
            // btnJob
            // 
            this.btnJob.Animated = true;
            this.btnJob.BackColor = System.Drawing.Color.White;
            this.btnJob.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJob.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJob.FillColor = System.Drawing.Color.Transparent;
            this.btnJob.FillColor2 = System.Drawing.Color.Transparent;
            this.btnJob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJob.ForeColor = System.Drawing.Color.Indigo;
            this.btnJob.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnJob.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnJob.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnJob.HoverState.Image = global::DoAnWin.Properties.Resources.downTrang;
            this.btnJob.Image = global::DoAnWin.Properties.Resources.rightTim;
            this.btnJob.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnJob.ImageOffset = new System.Drawing.Point(6, 0);
            this.btnJob.ImageSize = new System.Drawing.Size(15, 15);
            this.btnJob.Location = new System.Drawing.Point(3, 3);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(180, 46);
            this.btnJob.TabIndex = 4;
            this.btnJob.Text = "Loại công việc";
            this.btnJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnJob.TextOffset = new System.Drawing.Point(5, 0);
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnElectric
            // 
            this.btnElectric.Animated = true;
            this.btnElectric.BackColor = System.Drawing.Color.White;
            this.btnElectric.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnElectric.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnElectric.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnElectric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElectric.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnElectric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnElectric.FillColor = System.Drawing.Color.Transparent;
            this.btnElectric.FillColor2 = System.Drawing.Color.Transparent;
            this.btnElectric.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElectric.ForeColor = System.Drawing.Color.Indigo;
            this.btnElectric.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnElectric.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnElectric.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectric.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnElectric.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnElectric.Image = global::DoAnWin.Properties.Resources.check;
            this.btnElectric.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnElectric.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnElectric.ImageSize = new System.Drawing.Size(15, 15);
            this.btnElectric.Location = new System.Drawing.Point(3, 55);
            this.btnElectric.Name = "btnElectric";
            this.btnElectric.Size = new System.Drawing.Size(180, 46);
            this.btnElectric.TabIndex = 7;
            this.btnElectric.Text = "Thợ điện";
            this.btnElectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnElectric.TextOffset = new System.Drawing.Point(5, 0);
            this.btnElectric.Click += new System.EventHandler(this.btnElectric_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.Animated = true;
            this.btnMachine.BackColor = System.Drawing.Color.White;
            this.btnMachine.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnMachine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachine.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachine.FillColor = System.Drawing.Color.Transparent;
            this.btnMachine.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMachine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMachine.ForeColor = System.Drawing.Color.Indigo;
            this.btnMachine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMachine.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnMachine.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachine.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMachine.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMachine.Image = global::DoAnWin.Properties.Resources.check;
            this.btnMachine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMachine.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnMachine.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMachine.Location = new System.Drawing.Point(3, 107);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(180, 46);
            this.btnMachine.TabIndex = 4;
            this.btnMachine.Text = "Thợ máy";
            this.btnMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMachine.TextOffset = new System.Drawing.Point(5, 0);
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            // 
            // btnPainter
            // 
            this.btnPainter.Animated = true;
            this.btnPainter.BackColor = System.Drawing.Color.White;
            this.btnPainter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnPainter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPainter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPainter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPainter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPainter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPainter.FillColor = System.Drawing.Color.Transparent;
            this.btnPainter.FillColor2 = System.Drawing.Color.Transparent;
            this.btnPainter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPainter.ForeColor = System.Drawing.Color.Indigo;
            this.btnPainter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPainter.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnPainter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainter.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPainter.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnPainter.Image = global::DoAnWin.Properties.Resources.check;
            this.btnPainter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPainter.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPainter.ImageSize = new System.Drawing.Size(15, 15);
            this.btnPainter.Location = new System.Drawing.Point(3, 159);
            this.btnPainter.Name = "btnPainter";
            this.btnPainter.Size = new System.Drawing.Size(180, 46);
            this.btnPainter.TabIndex = 5;
            this.btnPainter.Text = "Thợ sơn";
            this.btnPainter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPainter.TextOffset = new System.Drawing.Point(5, 0);
            this.btnPainter.Click += new System.EventHandler(this.btnPainter_Click);
            // 
            // btnCarver
            // 
            this.btnCarver.Animated = true;
            this.btnCarver.BackColor = System.Drawing.Color.White;
            this.btnCarver.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnCarver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCarver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCarver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCarver.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCarver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCarver.FillColor = System.Drawing.Color.Transparent;
            this.btnCarver.FillColor2 = System.Drawing.Color.Transparent;
            this.btnCarver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCarver.ForeColor = System.Drawing.Color.Indigo;
            this.btnCarver.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCarver.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnCarver.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarver.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCarver.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnCarver.Image = global::DoAnWin.Properties.Resources.check;
            this.btnCarver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCarver.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCarver.ImageSize = new System.Drawing.Size(15, 15);
            this.btnCarver.Location = new System.Drawing.Point(3, 211);
            this.btnCarver.Name = "btnCarver";
            this.btnCarver.Size = new System.Drawing.Size(180, 46);
            this.btnCarver.TabIndex = 6;
            this.btnCarver.Text = "Thợ điêu khăc";
            this.btnCarver.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCarver.TextOffset = new System.Drawing.Point(5, 0);
            this.btnCarver.Click += new System.EventHandler(this.btnCarver_Click);
            // 
            // btnWashman
            // 
            this.btnWashman.Animated = true;
            this.btnWashman.BackColor = System.Drawing.Color.White;
            this.btnWashman.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnWashman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWashman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWashman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWashman.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWashman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWashman.FillColor = System.Drawing.Color.Transparent;
            this.btnWashman.FillColor2 = System.Drawing.Color.Transparent;
            this.btnWashman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWashman.ForeColor = System.Drawing.Color.Indigo;
            this.btnWashman.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnWashman.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnWashman.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWashman.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnWashman.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnWashman.Image = global::DoAnWin.Properties.Resources.check;
            this.btnWashman.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnWashman.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnWashman.ImageSize = new System.Drawing.Size(15, 15);
            this.btnWashman.Location = new System.Drawing.Point(3, 263);
            this.btnWashman.Name = "btnWashman";
            this.btnWashman.Size = new System.Drawing.Size(180, 46);
            this.btnWashman.TabIndex = 6;
            this.btnWashman.Text = "Thợ rửa xe";
            this.btnWashman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWashman.TextOffset = new System.Drawing.Point(5, 0);
            this.btnWashman.Click += new System.EventHandler(this.btnWashman_Click);
            // 
            // btnOther
            // 
            this.btnOther.Animated = true;
            this.btnOther.BackColor = System.Drawing.Color.White;
            this.btnOther.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnOther.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOther.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOther.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOther.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOther.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOther.FillColor = System.Drawing.Color.Transparent;
            this.btnOther.FillColor2 = System.Drawing.Color.Transparent;
            this.btnOther.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOther.ForeColor = System.Drawing.Color.Indigo;
            this.btnOther.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOther.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnOther.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOther.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnOther.Image = global::DoAnWin.Properties.Resources.check;
            this.btnOther.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOther.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnOther.ImageSize = new System.Drawing.Size(15, 15);
            this.btnOther.Location = new System.Drawing.Point(3, 315);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(180, 46);
            this.btnOther.TabIndex = 6;
            this.btnOther.Text = "Thợ khác";
            this.btnOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOther.TextOffset = new System.Drawing.Point(5, 0);
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // RollbtnJob
            // 
            this.RollbtnJob.Interval = 1;
            this.RollbtnJob.Tick += new System.EventHandler(this.RollbtnJob_Tick);
            // 
            // FWorkerSeekJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1274, 767);
            this.Controls.Add(this.panelComboJob);
            this.Controls.Add(this.panelComboSalary);
            this.Controls.Add(this.flowPanelContain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWorkerSeekJob";
            this.Text = "FWorkerSeekJob";
            this.Load += new System.EventHandler(this.FWorkerSeekJob_Load);
            this.panelComboSalary.ResumeLayout(false);
            this.panelComboJob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelContain;
        private System.Windows.Forms.FlowLayoutPanel panelComboSalary;
        private Guna.UI2.WinForms.Guna2GradientButton btnSalary;
        private Guna.UI2.WinForms.Guna2GradientButton btnIncrease;
        private Guna.UI2.WinForms.Guna2GradientButton btnDecrese;
        private System.Windows.Forms.Timer RollBtnSalary;
        private System.Windows.Forms.FlowLayoutPanel panelComboJob;
        private Guna.UI2.WinForms.Guna2GradientButton btnJob;
        private Guna.UI2.WinForms.Guna2GradientButton btnMachine;
        private Guna.UI2.WinForms.Guna2GradientButton btnPainter;
        private Guna.UI2.WinForms.Guna2GradientButton btnCarver;
        private Guna.UI2.WinForms.Guna2GradientButton btnWashman;
        private Guna.UI2.WinForms.Guna2GradientButton btnOther;
        private Guna.UI2.WinForms.Guna2GradientButton btnElectric;
        private System.Windows.Forms.Timer RollbtnJob;
    }
}