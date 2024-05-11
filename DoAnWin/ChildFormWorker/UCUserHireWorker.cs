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
using DoAnWin.ChildFormWorker;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;

namespace DoAnWin.UserControls
{
    public partial class UCUserHireWorker : UserControl
    {
        Job job;
        List<Job> jobs = new List<Job>();
        List<string> workingday = new List<string>();
        public UCUserHireWorker(Job job)
        {
            InitializeComponent();
            this.job = job;
            lblID.Text = lblID.Text+" " +job.IdUser;
            lblName.Text = lblName.Text+" " +job.NameUser;
            JobDAO jd = new JobDAO();
            jobs = jd.LoadListWorkingDay(job.IdWork);
            txtDescribe.Text = job.DescribeWork;
            foreach (Job j in jobs)
            {
                workingday.Add(j.DayWork);
            }
            FHire.busyDay = jd.CreateListBusyDay(job.IdWorker);
            string test = "";
            foreach (string item in workingday)
            {
                Guna2TextBox txt = new Guna2TextBox();
                txt.Margin = new Padding(8);
                txt.Size = new Size(180, 38);
                txt.ReadOnly = true;
                test += item;
                txt.Text = item.Replace(" ", "/");
                flowContainPanel.Controls.Add(txt);
            }
            //MessageBox.Show(test);
        }

        private void UCUserHireWorker_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //string test = "";
            //foreach (string work in workingday)
            //{
            //    test += work;
            //}
            //foreach (string work in FHire.busyDay)
            //{
            //    test += work+"\n";
            //}
            //MessageBox.Show(test);
            if (workingday.Count != 0)
            {
                if (CheckWorkingDay(FHire.busyDay, workingday))
                {
                    JobDAO jd = new JobDAO();
                    //MessageBox.Show("Ngày hôm đó bạn đã có công việc khác phải làm rồi");
                    //foreach (string work in FHire.busyDay)
                    //{
                    //    test += work;
                    //}
                    //MessageBox.Show(test);
                    jd.UpdateBusyDay(job.IdWork);
                    FHire.busyDay = jd.CreateListBusyDay(job.IdWorker);
                    this.Hide();
                }
                else if (CheckWorkingDay(FHire.busyDay, workingday) == false)
                {
                    MessageBox.Show("Ngày hôm đó bạn đã có công việc khác phải làm rồi");
                    //jd.UpdateBusyDay(idWork);
                }
            }
            FormDAO formDAO = new FormDAO();
            FHire fHire = new FHire(job.IdWorker, job.NameWorker, workingday, job.IdWork);
            fHire.Size = fHire.MinimumSize;
            fHire.btnClose.Hide();
            formDAO.OpenChildForm(fHire,ref FWorkerNotification.CldActiveForm, FWorkerNotification.panelContainCalendar);
        }
        private bool CheckWorkingDay(List<string> A, List<string> B)
        {
            return !A.Intersect(B).Any();
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            JobDAO jd = new JobDAO();
            jd.UpdateRefuse(job.IdWork);
            this.Hide();

        }
    }
}
