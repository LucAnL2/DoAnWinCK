using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.ChildFormUser;
using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;

namespace DoAnWin
{
    public partial class FUser : Form
    {
        UserDAO userDAO = new UserDAO();
        User us = new User();
        private Panel leftBorderBtn;
        public FUser()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(6, 42);
            panelLeft.Controls.Add(leftBorderBtn);
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            guna2ShadowForm1.SetShadowForm(this);
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, panelUserContain);
            us = userDAO.UserInfo();
            ControlLeftBorder(btnHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHome.Text;
            picVal.Image = Properties.Resources.icons8_google_home_64;
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, panelUserContain);
            ControlLeftBorder(btnHome);
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnPostJob.Text;
            picVal.Image = Properties.Resources.tuyenthogra;
            fd.OpenChildForm(new ChildFormUser.FUserPostJob(us), ref FormDAO.activeForm, panelUserContain);
            ControlLeftBorder(btnPostJob);
        }

        private void btnHired_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHired.Text;
            picVal.Image = Properties.Resources.history;
            fd.OpenChildForm(new ChildFormUser.FUserHired(), ref FormDAO.activeForm, panelUserContain);
            ControlLeftBorder(btnHired);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //User us = new User();
            //us = userDAO.UserInfo();
            FormDAO fd = new FormDAO();
            lblVal.Text = btnUser.Text;
            picVal.Image = Properties.Resources.user;
            fd.OpenChildForm(new ChildFormUser.FUserInfo(us), ref FormDAO.activeForm, panelUserContain);
            ControlLeftBorder(btnUser);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FLogin login = new FLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHired.Text;
            picVal.Image = Properties.Resources.history;
            fd.OpenChildForm(new ChildFormUser.FTopWorker(), ref FormDAO.activeForm, panelUserContain);
            ControlLeftBorder(btnTop);
        }

        private void ControlLeftBorder(Guna2GradientButton currentBtn)
        {
            leftBorderBtn.BackColor = System.Drawing.Color.FromArgb(107, 95, 255);
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }
    }
}
