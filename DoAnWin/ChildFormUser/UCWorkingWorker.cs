using DoAnWin.ChildFormUser;
using DoAnWin.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.UserControls
{
    public partial class UCWorkingWorker : UserControl
    {
        private Job job = new Job();
        private bool isWorking = false;
        public UCWorkingWorker(Job job)
        {
            InitializeComponent();
            this.job = job;
            lblName.Text = job.NameWorker;
            lblID.Text = job.IdWorker;
            lblStatus.Text = job.StatusWork;
            txtDescribe.Text = job.DescribeWork;
            if (lblStatus.Text == "Đang làm")
            {
                lblStatus.DisabledState.FillColor = Color.FromArgb(12, 152, 255);
                isWorking = true;
            }
            else if (lblStatus.Text == "Chờ xác nhận")
            {
                lblStatus.DisabledState.FillColor = Color.Silver;
            }
            else if (lblStatus.Text == "Bị hủy")
            {
                lblStatus.DisabledState.FillColor = Color.Red;

            }
            else if(lblStatus.Text =="Đã hoàn thành")
            {
                lblStatus.DisabledState.FillColor = Color.Lime;
            }
            else if(lblStatus.Text == "Chờ hoàn thành")
            {
                lblStatus.DisabledState.FillColor = Color.FromArgb(0, 156, 67);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(isWorking == true)
            {
                FPay fPay = new FPay(job);
                fPay.ShowDialog();
            }    
        }

        private void UCWorkingWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
