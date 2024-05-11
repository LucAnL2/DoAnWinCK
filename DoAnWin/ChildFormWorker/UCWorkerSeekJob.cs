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

namespace DoAnWin.ChildFormWorker
{
    public partial class UCWorkerSeekJob : UserControl
    {
        UserPostJob job;
        Worker worker;
        FormDAO formDAO = new FormDAO();
        int count = 0;
        public UCWorkerSeekJob()
        {
            InitializeComponent();
        }

        public UCWorkerSeekJob(UserPostJob job)
        {
            InitializeComponent();
            this.job = job;
            txtSalary.Text = job.Salary1.ToString();
            txtRequire.Text = job.Require;
            txtDescribe.Text = job.Describe;
            txtJob.Text = job.UserUpjob.ToString();
            //
            lblName.Text = job.Name;

            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(job.IDWork), job.IDWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                picImage.BackgroundImage = ImageBackground.Images[0];
            }
            else
                picImage.BackgroundImage = DefaultBackground.Images[0];
        }

        public UCWorkerSeekJob(UserPostJob job, Worker worker)
        {
            InitializeComponent();
            this.job = job;
            this.worker = worker;
            txtSalary.Text = job.Salary1.ToString();
            txtRequire.Text = job.Require;
            txtDescribe.Text = job.Describe;
            txtJob.Text = job.UserUpjob.ToString();

            lblName.Text = job.Name;

            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(job.IDWork), job.IDWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                picImage.BackgroundImage = ImageBackground.Images[0];
            }
            else
                picImage.BackgroundImage = DefaultBackground.Images[0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(job.IDWork), job.IDWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                if (count > 0) { count--; }
                picImage.BackgroundImage = ImageBackground.Images[count];
            }
            else
            {
                if (count > 0) { count--; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(job.IDWork), job.IDWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                if (count < images.ToArray().Length - 1) { count++; }
                picImage.BackgroundImage = ImageBackground.Images[count];
            }
            else
            {
                if (count < StaticPropertyAndField.listDefaultBackground.Length - 1) { count++; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
        }

        private void btnApplyfor_Click(object sender, EventArgs e)
        {
            CandidateDAO cd = new CandidateDAO();
            //MessageBox.Show(job.IDWork);
            Candidate candidate = new Candidate(worker.Id, worker.Name, job.IDWork, worker.AvgRate);
            cd.AddCandidate(candidate);
        }
    }
}
