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

namespace DoAnWin
{
    public partial class FWorker : Form
    {
        public FWorker()
        {
            InitializeComponent();
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.IncomeWorker();
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormWorker.FWorkerInfo(worker), ref FormDAO.activeForm, panelWorkerContain);
        }

        private void FWorker_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnWorkerInfo_Click(object sender, EventArgs e)
        {
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.IncomeWorker();
            FormDAO fd = new FormDAO();
            lblVal.Text = btnWorkerInfo.Text;
            picVal.Image = Properties.Resources.user;
            fd.OpenChildForm(new ChildFormWorker.FWorkerInfo(worker), ref FormDAO.activeForm, panelWorkerContain);
        }

        private void btnSeekJob_Click(object sender, EventArgs e)
        {
            WorkerDAO workerDAO = new WorkerDAO();
            Worker worker = workerDAO.IncomeWorker();
            FormDAO fd = new FormDAO();
            lblVal.Text = btnSeekJob.Text;
            picVal.Image = Properties.Resources.timviec;
            fd.OpenChildForm(new ChildFormWorker.FWorkerSeekJob(worker), ref FormDAO.activeForm, panelWorkerContain);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHistory.Text;
            picVal.Image = Properties.Resources.history;
            fd.OpenChildForm(new ChildFormWorker.FHistory(), ref FormDAO.activeForm, panelWorkerContain);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FLogin login = new FLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
