using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
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
    public partial class FComment : Form
    {
        Job job;
        public FComment()
        {
            InitializeComponent();
        }

        public FComment(Job job)
        {
            InitializeComponent();
            this.job = job;
        }

        private void FComment_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment(job.IdUser, job.NameUser, job.IdWorker, job.NameWorker,job.IdWork, DateTime.Now.ToString("dd MM yyyy"), txtComment.Text, (float)RSRate.Value);
            CommentDAO commentDAO = new CommentDAO();
            JobDAO jobDAO = new JobDAO();
            WorkerDAO workerDAO = new WorkerDAO();
            if(commentDAO.AddComment(comment))
            {
                this.Hide();
                jobDAO.UpdateComment(comment.IdWork);
                this.Close();
            }
            float avgRate = float.Parse(workerDAO.TakeAVGRate(job.IdWorker));
            workerDAO.UpdateAVGRate(avgRate, job.IdWorker);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.WorkerUploadImage(flowPanelContainImage, job.IdWork);
        }
    }
}
