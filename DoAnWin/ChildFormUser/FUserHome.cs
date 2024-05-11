using DoAnWin.DAOClass;
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
    public partial class FUserHome : Form
    {
        public FUserHome()
        {
            InitializeComponent();
        }

        private void FHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnMechanic.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnPainter.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnWasher_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnWasher.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnElecian_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnElecian.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnCarvers_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnCarvers.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnDifferent_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FUserSeekWorker(btnDifferent.Text), ref FormDAO.activeForm, FUser.panelUserContain);
        }
    }
}
