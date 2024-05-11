using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
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
    public partial class FHistoryWorkerInUsercs : Form
    {
        private List<Job> listFinishWork = new List<Job>();
        private JobDAO jd = new JobDAO();
        string idWorker;
        public FHistoryWorkerInUsercs()
        {
            InitializeComponent();
        }

        public FHistoryWorkerInUsercs(string idWorker)
        {
            InitializeComponent();
            this.idWorker = idWorker;
            listFinishWork = jd.LoadFinishWorkInWorker(idWorker);
        }

        private void FHistoryWorkerInUsercs_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            if (listFinishWork != null)
                foreach (Job job in listFinishWork)
                {
                    UCWorkedInWorker uc = new UCWorkedInWorker(job);
                    //uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
        }
    }
}
