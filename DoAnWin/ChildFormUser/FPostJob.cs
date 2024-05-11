using DoAnWin.DAOClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using DoAnWin.ChildFormWorker;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoAnWin.ChildFormUser
{
    public partial class FPostJob : Form
    {
        User user;
        UserPostJob job;
        UserPostJobDAO udao = new UserPostJobDAO();
        List<Candidate> Candidates;
        CandidateDAO cd = new CandidateDAO();
        string idWork;
        public FPostJob(UserPostJob job)
        {
            InitializeComponent();
            this.job = job;
            txtDescribe.Text = job.Describe;
            txtRequire.Text = job.Require;
            txtSalary.Text = job.Salary1.ToString();
            Candidates = cd.LoadListCandidate(job);
        }

        public FPostJob(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FPostJob_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            idWork = udao.CreateWorkID();
            if(Candidates != null)
            {
                lbl404.Hide();
                foreach (Candidate candidate in Candidates)
                {
                    UCCandidate uc = new UCCandidate(candidate, job);
                    uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem txtSalary.Text có phải là một số hay không
            if (!int.TryParse(txtSalary.Text, out int salary))
            {
                // Nếu không phải là số, gán giá trị mặc định là 0
                salary = 0;
                txtSalary.Text = "0";
            }

            UserPostJob us = new UserPostJob(StaticPropertyAndField.IncomeID, user.Name, idWork, txtRequire.Text, txtDescribe.Text, "Chờ xác nhận", salary,txtJob.Text);
            //MessageBox.Show(us.Salary.ToString());
            if (udao.UploadJob(us))
            {
                this.Hide();
                this.Close();
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.WorkerUploadImage(flowPanelContainImage, idWork);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtJob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
