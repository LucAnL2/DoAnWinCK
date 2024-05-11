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

namespace DoAnWin.ChildFormUser
{
    public partial class FDetailWorkerInUser : Form
    {
        Worker worker;
        string title;
        public FDetailWorkerInUser(Worker worker, string title)
        {
            InitializeComponent();
            this.worker = worker;
            this.title = title;
            txtID.Text = worker.Id;
            txtName.Text = worker.Name;
            txtAddress.Text = worker.Address;
            txtDate.Text = worker.Date;
            txtgender.Text = worker.Sex;
            txtPhone.Text = worker.Phone;
            txtEmail.Text = worker.Email;
            txtHireTime.Text = worker.HireTimes;
            txtHireCost.Text = worker.HireCost;
            txtWorkTime.Text = worker.WorkingTime;
            txtDescribe.Text = worker.Describe;
            rsStar.Value = float.Parse(worker.AvgRate);
            if (worker.Avatar != "")
                picAvatar.Image = new Bitmap(@"" + worker.Avatar);
        }

        private void FDetailWorkerInUser_Load(object sender, EventArgs e)
        {
            lblHistory.Visible = false;
            dtgHistory.Visible = false;
            
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            FHire fHire = new FHire(worker.Id, worker.Name);
            fHire.ShowDialog();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            FCommentInUser fComment = new FCommentInUser(txtID.Text);
            fComment.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FHistoryWorkerInUsercs fHistoryWorkerInUsercs = new FHistoryWorkerInUsercs(txtID.Text);
            fHistoryWorkerInUsercs.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(title), ref FormDAO.activeForm, FUser.panelUserContain);
        }
    }
}
