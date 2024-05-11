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

namespace DoAnWin.UserControls
{
    public partial class UCTopWorker : UserControl
    {
        Worker worker;
        public UCTopWorker()
        {
            InitializeComponent();
        }

        public UCTopWorker(Worker worker)
        {
            float valueRate = float.Parse(worker.AvgRate);
            InitializeComponent();
            this.worker = worker;
            lblName.Text = worker.Name;
            lblLikeTime.Text = worker.LikeTime1.ToString();
            lblNgheNghiep.Text = worker.Job;
            RSRate.Value = valueRate;

        }

        private void UCTopWorker_Load(object sender, EventArgs e)
        {

        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            string id = worker.Id;
            FListLike like = new FListLike(id);
            like.ShowDialog();
        }
    }
}
