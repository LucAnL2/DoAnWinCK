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

namespace DoAnWin.ChildFormUser
{
    public partial class UCUserPostJob : UserControl
    {
        UserPostJob job;
        public UCUserPostJob()
        {
            InitializeComponent();
        }

        public UCUserPostJob(UserPostJob job)
        {
            InitializeComponent();
            this.job = job;
            txtSalary.Text = job.Salary1.ToString();
            txtRequire.Text = job.Require;
        }

        private void UCUserPostJob_Load(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FPostJob fPostJob = new FPostJob(job);
            fPostJob.ShowDialog();
        }
    }
}
