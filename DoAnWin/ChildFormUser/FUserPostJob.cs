using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
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
    public partial class FUserPostJob : Form
    {
        FormDAO fd = new FormDAO();
        private Form activeForm;
        User us;
        UserPostJobDAO ud = new UserPostJobDAO();
        List<UserPostJob> Jobs = new List<UserPostJob>();
        public FUserPostJob()
        {
            InitializeComponent();
        }

        public FUserPostJob(User us)
        {
            InitializeComponent();
            this.us = us;
            Jobs = ud.LoadListJobByUsers();
        }

        private void btnUploadWork_Click(object sender, EventArgs e)
        {
            //fd.OpenChildForm(new FPostJob(us), ref activeForm, flowPannelContain);
            FPostJob fPostJob = new FPostJob(us);
            fPostJob.ShowDialog();
        }

        private void FUserPostJob_Load(object sender, EventArgs e)
        {
            if(Jobs != null)
            {
                lbl404.Hide();
                foreach (UserPostJob job in Jobs)
                {
                    UCUserPostJob uc = new UCUserPostJob(job);
                    uc.Margin = new Padding(5);
                    flowPannelContainJob.Controls.Add(uc);
                }
            }
        }


        private void ClearControls(FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Dispose();
            }
            panel.Controls.Clear();
        }
    }
}
