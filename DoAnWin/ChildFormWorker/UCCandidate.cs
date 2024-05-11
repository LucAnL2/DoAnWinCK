using DoAnWin.ChildFormUser;
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
    public partial class UCCandidate : UserControl
    {
        Candidate candidate;
        UserPostJob job;
        public UCCandidate()
        {
            InitializeComponent();
        }

        public UCCandidate(Candidate candidate, UserPostJob job)
        {
            InitializeComponent();
            this.candidate = candidate;
            lblName.Text = candidate.Name;
            RSStar.Value = Convert.ToSingle(candidate.AvgRate);
            this.job = job;
        }

        private void UCCandidate_Load(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            //string id, string name, string idWork, string describe, string salary
            //MessageBox.Show(job.IDWork);
            FHire fHire = new FHire(candidate.Id, candidate.Name, job.IDWork, job.Describe, job.Salary1.ToString());
            fHire.ShowDialog();
        }
    }
}
