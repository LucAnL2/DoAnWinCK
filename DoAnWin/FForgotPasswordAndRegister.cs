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

namespace DoAnWin
{
    public partial class FForgotPasswordAndRegister : Form
    {
        string[] listRole = { "Người dùng", "Thợ"};
        private int tabIndex {  get; set; }
        public FForgotPasswordAndRegister(int tabIndex)
        {
            InitializeComponent();
            cbbRole.DataSource = listRole;
            this.tabIndex = tabIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void FForgotPasswordAndRegister_Load(object sender, EventArgs e)
        {
            if(tabIndex == 1)
            {
                TabControl.SelectTab(tabPage1);
            }
            else
            {
                TabControl.SelectTab(tabPage2);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id = Person.CreateID(cbbRole);
            Person person = new Person(id, txtName.Text, txtEmail.Text, txtAccount.Text, txtPassword.Text, cbbRole.Text, txtPhone.Text);
            PersonDAO PSD = new PersonDAO();
            PSD.DangKi(person, txtConfirmPassword.Text);
        }
    }
}
