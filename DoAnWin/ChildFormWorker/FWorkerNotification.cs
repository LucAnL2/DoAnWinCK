using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.ChildFormUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.UserControls;

namespace DoAnWin.ChildFormWorker
{
    public partial class FWorkerNotification : Form
    {
        public static Form CldActiveForm;
        string id;
        string name;
        public FWorkerNotification(string id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }
        public FWorkerNotification()
        {
            InitializeComponent();
        }

        private void FWorkerNotification_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            FormDAO fd = new FormDAO();
            FHire fHire = new FHire(id, name);
            fHire.Size = fHire.MinimumSize;
            fHire.btnClose.Hide();
            fd.OpenChildForm(fHire, ref CldActiveForm, panelContainCalendar);
            LoadListJob();
        }

        private void LoadListJob()
        {
            List<Job> jobs = new List<Job>();
            FormDAO fd = new FormDAO();
            JobDAO jd = new JobDAO();
            jobs = jd.LoadListJob(id);
            if(jobs.Count != 0) { lblNull.Hide(); }
            foreach (Job job in jobs)
            {
                UCUserHireWorker uc = new UCUserHireWorker(job);
                fd.loadWorkerInfo(uc, flowPanelContainJob);
            }
        }
    }
}
