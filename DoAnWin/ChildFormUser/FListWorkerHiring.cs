using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;

namespace DoAnWin.ChildFormUser
{
    public partial class FListWorkerHiring : Form
    {
        FormDAO fd = new FormDAO();
        JobDAO jd = new JobDAO();
        UserDAO ud = new UserDAO();
        private List<Job> listWorkWorking = new List<Job>();
        public FListWorkerHiring()
        {
            InitializeComponent();
            listWorkWorking = jd.LoadWorkWorking();
        }

        private void FListWorkerHiring_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listWorkWorking.Count.ToString());
            foreach(Job job in listWorkWorking)
            {
                UCWorkingWorker uc = new UCWorkingWorker(job);
                flowPanelContain.Controls.Add(uc);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User us = new User();
            us = ud.UserInfo();
            fd.OpenChildForm(new ChildFormUser.FUserInfo(us), ref FormDAO.activeForm, FUser.panelUserContain);
        }
    }
}
