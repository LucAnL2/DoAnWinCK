using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.ChildFormUser;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;

namespace DoAnWin.UserControls
{
    public partial class UCHiredInUser : UserControl
    {
        Job job;
        public UCHiredInUser()
        {
            InitializeComponent();
        }

        public UCHiredInUser(Job job)
        {
            InitializeComponent();
            this.job = job;
            lblName.Text = job.NameWorker;
            lblID.Text = job.IdWorker;
            lblFinishDay.Text = job.FinishDay;
        }

        private void UCHiredInUser_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (job.IsEvaluate == 0)
            {
                FComment fComment = new FComment(job);
                fComment.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn đã bình luận người này rồi", "Thông báo");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
