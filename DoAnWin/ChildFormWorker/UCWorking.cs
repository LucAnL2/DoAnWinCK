using DoAnWin.DAOClass;
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
    public partial class UCWorking : UserControl
    {
        private Job job = new Job();
        private bool isFinish = false;
        private JobDAO jd = new JobDAO();
        public UCWorking(Job job)
        {
            InitializeComponent();
            this.job = job;
            lblID.Text = job.IdUser;
            lblName.Text = job.NameUser;
            lblStatus.Text = job.StatusWork;
            if (lblStatus.Text == "Đang làm")
            {
                lblStatus.DisabledState.FillColor = Color.FromArgb(12, 152, 255);
            }
            else if (lblStatus.Text == "Bị hủy")
            {
                lblStatus.DisabledState.FillColor = Color.Red;

            }
            else if (lblStatus.Text == "Đã hoàn thành")
            {
                lblStatus.DisabledState.FillColor = Color.Lime;
            }
            else if (lblStatus.Text == "Chờ hoàn thành")
            {
                lblStatus.DisabledState.FillColor = Color.FromArgb(0, 156, 67);
                isFinish = true;
            }
        }

        private void UCWorking_Load(object sender, EventArgs e)
        {
        }


        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            if (isFinish == true)
            {
                jd.UpdateFinished(job.IdWork);
            }
        }
    }
}
