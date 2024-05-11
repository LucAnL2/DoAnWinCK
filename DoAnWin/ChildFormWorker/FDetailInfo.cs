using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
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
    public partial class FDetailInfo : Form
    {
        private Worker worker;
        private string[] listGender = { "Nam", "Nữ", "Bí mật" };
        private string[] listActive = { "Hoạt động", "Tạm nghỉ" };
        public FDetailInfo(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
        }

        private void FDetailInfo_Load(object sender, EventArgs e)
        {
            cbbActive.DataSource = listActive;
            cbbGender.DataSource = listGender;
            txtID.Text = StaticPropertyAndField.IncomeID;
            txtName.Text = worker.Name;
            txtAddress.Text = worker.Address;
            txtPhone.Text = worker.Phone;
            txtEmail.Text = worker.Email;
            txtCCCD.Text = worker.Cccd;
            txtAccount.Text = worker.Account;
            txtPassword.Text = worker.Pass;
            try
            {
                dtpDate.Value = DateTime.Parse(worker.Date);
            }
            catch { }

            if (worker.Active == "Hoạt động") cbbActive.SelectedIndex = 0;
            else cbbActive.SelectedIndex = 1;

            if (worker.Sex == "Nam") cbbGender.SelectedIndex = 0;
            else if (worker.Sex == "Nữ") cbbGender.SelectedIndex = 1;
            else cbbGender.SelectedIndex = 2;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Worker wk = new Worker(txtName.Text, txtAddress.Text,txtPhone.Text, txtEmail.Text, cbbGender.Text, dtpDate.Value.ToString(),txtCCCD.Text,txtAccount.Text,txtPassword.Text, cbbActive.Text);
            WorkerDAO wkd = new WorkerDAO();
            wkd.updateInfo(wk);
        }
    }
}
