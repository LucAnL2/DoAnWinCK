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

namespace DoAnWin.ChildFormUser
{
    public partial class FTopWorker : Form
    {
        WorkerDAO workerDAO = new WorkerDAO();
        FormDAO fd = new FormDAO();
        public FTopWorker()
        {
            InitializeComponent();
        }

        private void FTopWorker_Load(object sender, EventArgs e)
        {
            LoadListWorker();
        }

        private void LoadListWorker()
        {
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadAllWorker();
            foreach (Worker worker in workers)
            {
                UCTopWorker uc = new UCTopWorker(worker);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }

        }
        private void LoadListWorkerLike()
        {
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadByLike();
            foreach (Worker worker in workers)
            {
                UCTopWorker uc = new UCTopWorker(worker);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }

        }

        private void flowPanelContain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbLike_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLike.Checked)
            {
                ClearControls(flowPanelContain);
                LoadListWorkerLike();
            }
            else
            {
                ClearControls(flowPanelContain);
                LoadListWorker();
            }
        }

        private void ClearControls(FlowLayoutPanel panel)
        {
            while (panel.Controls.Count > 0)
            {
                Control control = panel.Controls[0];
                panel.Controls.Remove(control);
                control.Dispose();
            }
        }

    }
}
