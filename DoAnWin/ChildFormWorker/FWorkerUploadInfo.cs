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
using DoAnWin.NormalClass;

namespace DoAnWin.ChildFormWorker
{
    public partial class FWorkerUploadInfo : Form
    {
        public FWorkerUploadInfo()
        {
            InitializeComponent();
        }

        private void FWorkerUploadInfo_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            FormDAO fd = new FormDAO();
            fd.DeleteAllImage();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.WorkerUploadImage(flowPanelContainImage, StaticPropertyAndField.IncomeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(txtJob.Text, txtWorkingYear.Text, txtHireCost.Text, txtDescribe.Text);
            WorkerDAO wkd = new WorkerDAO();
            if(wkd.UpLoadInfoAndJob(worker))
                this.Close();
            else
                return;
        }
    }
}
