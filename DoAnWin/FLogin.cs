using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtAccount.Text, txtPassword.Text);
            PersonDAO PSD = new PersonDAO();
            if (PSD.DangNhap(account, rbUser, rbWorker))
            {
                this.Hide();
                if (rbUser.Checked)
                {
                    FLoading fLoading = new FLoading(0);
                    fLoading.ShowDialog();
                }
                else if (rbWorker.Checked)
                {
                    FLoading fLoading = new FLoading(1);
                    fLoading.ShowDialog();
                }
                this.Close();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FForgotPasswordAndRegister fFGPAR = new FForgotPasswordAndRegister(1);
            fFGPAR.ShowDialog();
            this.Close();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FForgotPasswordAndRegister fFGPAR = new FForgotPasswordAndRegister(2);
            fFGPAR.ShowDialog();
            this.Close();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            rbUser.Checked = true;
        }

        private void lblWorker_Click(object sender, EventArgs e)
        {
            rbWorker.Checked = true;
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
