using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DoAnWin.ChildFormWorker
{
    public partial class FWorkerInfo : Form
    {
        private Form activeChildForm;
        Worker worker;
        public FWorkerInfo(Worker worker)
        {
            InitializeComponent();
            FormDAO fd = new FormDAO();
            this.worker = worker;
            fd.OpenChildForm(new ChildFormWorker.FDetailInfo(worker), ref activeChildForm, panelContain);
            if (worker.Avatar != "")
                picAvatar.Image = new Bitmap(@""+worker.Avatar);
        }
        private void FWorkerInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnDetailInfo_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            btnValue.Text = btnDetailInfo.Text;
            fd.OpenChildForm(new ChildFormWorker.FDetailInfo(worker), ref activeChildForm, panelContain);
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            FWorkerNotification fWorker = new FWorkerNotification(worker.Id, worker.Name);
            fWorker.ShowDialog();

        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            btnValue.Text = btnRate.Text;
            fd.OpenChildForm(new ChildFormWorker.FWorkerContainComment(worker), ref activeChildForm, panelContain);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            WorkerDAO wkd = new WorkerDAO();
            if (wkd.UpdateInfo(worker))
            {
                FWorkerUploadInfo f = new FWorkerUploadInfo();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi đăng tải");
                return;
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.UploadAvatar(picAvatar);
        }

        private void btnWorking_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            btnValue.Text = btnWorking.Text;
            fd.OpenChildForm(new ChildFormWorker.FWorkerWorking(), ref activeChildForm, panelContain);
        }
    }
}
