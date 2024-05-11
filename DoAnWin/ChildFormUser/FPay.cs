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
    public partial class FPay : Form
    {
        Job job;
        JobDAO jd = new JobDAO();
        UserDAO userDAO = new UserDAO();

        public FPay()
        {
            InitializeComponent();
        }

        public FPay(Job job)
        {
            InitializeComponent();
            this.job = job;
            txtMoney.Text = jd.TotalSalary(job.IdWork).ToString();        
        }

        private void FPay_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            long moneyBalance = long.Parse(userDAO.MoneyBalance());
            if (int.Parse(txtMoney.Text) <= moneyBalance)
            {
                jd.UpdateWaitingWorkFinish(job.IdWork);
                //MessageBox.Show("Đúng");
            }
            else
            {
                MessageBox.Show("Tài khoản không đủ để thanh toán !!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
