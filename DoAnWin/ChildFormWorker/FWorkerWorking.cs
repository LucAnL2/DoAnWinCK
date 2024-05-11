using DoAnWin.DAOClass;
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

namespace DoAnWin.ChildFormWorker
{
    public partial class FWorkerWorking : Form
    {
        FormDAO fd = new FormDAO();
        JobDAO jd = new JobDAO();
        private List<Job> listWorkWorking = new List<Job>();
        public FWorkerWorking()
        {
            InitializeComponent();
            listWorkWorking = jd.LoadWorkWorkingInWorker();
        }

        private void FWorkerWorking_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listWorkWorking.Count.ToString());
            if(listWorkWorking != null)
                foreach (Job job in listWorkWorking)
                {
                    UCWorking uc = new UCWorking(job);
                    uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
            else
            {
                MessageBox.Show("Hiện tại bạn không đang làm bất kỳ công việc nào");
            }
        }

        private void flowPanelContain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
