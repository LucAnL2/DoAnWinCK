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

namespace DoAnWin.ChildFormUser
{
    public partial class FUserInfo : Form
    {
        FormDAO fd = new FormDAO();
        private Form activeForm;
        User us;
        public FUserInfo()
        {
            InitializeComponent();
        }

        public FUserInfo(User us)
        {
            InitializeComponent();
            this.us = us;
            btnInfo.Text = us.Name;
            btnSurplus.Text = "Số dư: " + us.Surplus + " VNĐ";
        }

        private void FUserInfo_Load(object sender, EventArgs e)
        {
        }

        private void btnListWorker_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new ChildFormUser.FListWorkerHiring(), ref activeForm, panelContain);
        }

        private void btnSurplus_Click(object sender, EventArgs e)
        {
            FRechargeMoney fRechargeMoney = new FRechargeMoney();
            fRechargeMoney.ShowDialog();
        }
    }
}
