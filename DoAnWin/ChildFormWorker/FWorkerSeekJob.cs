using DoAnWin.ChildFormUser;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;
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
    public partial class FWorkerSeekJob : Form
    {
        UserPostJobDAO ud = new UserPostJobDAO();
        List<UserPostJob> Jobs = new List<UserPostJob>();
        Worker worker;
        private bool salaryDecrease = false;
        private bool salaryIncrease = false;
        private bool isbtnElectric = false;
        private bool isbtnMachine = false;
        private bool isbtnPainter = false;
        private bool isbtnCarver = false;
        private bool isbtnWashman = false;
        private bool isbtnOther = false;
        private List<(bool, Guna2GradientButton)> boolButtonPairs = new List<(bool, Guna2GradientButton)>();

        public FWorkerSeekJob()
        {
            InitializeComponent();
            Jobs = ud.LoadListJobByUsersInWorker();

            if (Jobs != null)
            {
                foreach (UserPostJob job in Jobs)
                {
                    UCWorkerSeekJob uc = new UCWorkerSeekJob(job);
                    MessageBox.Show(uc.txtJob.Text);
                    uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
            }
        }
        private void loaduc(List<UserPostJob>  Jobs)
        {

            if (Jobs != null)
            {
                foreach (UserPostJob job in Jobs)
                {
                    UCWorkerSeekJob uc = new UCWorkerSeekJob(job, worker);
                    uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
            }
        }

        private void LoadTrueToFalse()
        {
            // Thêm các cặp bool và nút vào danh sách
            boolButtonPairs.Add((isbtnElectric, btnElectric));
            boolButtonPairs.Add((isbtnMachine, btnMachine));
            boolButtonPairs.Add((isbtnPainter, btnPainter));
            boolButtonPairs.Add((isbtnCarver, btnCarver));
            boolButtonPairs.Add((isbtnWashman, btnWashman));
            boolButtonPairs.Add((isbtnOther, btnOther));
            
            foreach (var pair in boolButtonPairs.ToList())
            {
                bool isBool = pair.Item1;
                Guna2GradientButton button = pair.Item2;

                if (isBool == true)
                {
                    FormDAO formDAO = new FormDAO();
                    formDAO.ButtonFalse(ref isBool, button);
                    // Cập nhật giá trị bool trong cặp
                    boolButtonPairs[boolButtonPairs.IndexOf(pair)] = (isBool, button);
                }
            }
        }
        public FWorkerSeekJob(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            Jobs = ud.LoadListJobByUsersInWorker();
            loaduc(Jobs);
        }

        private void FWorkerSeekJob_Load(object sender, EventArgs e)
        {

        }

        private void flowPanelContain_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isBtnSalaryExpand = false;
      
        private void btnSalary_Click(object sender, EventArgs e)
        {
            RollBtnSalary.Start();
        }

        private void RollBtnSalary_Tick_1(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnSalaryExpand, panelComboSalary, btnSalary, RollBtnSalary);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            LoadTrueToFalse();
            flowPanelContain.Controls.Clear();
            Jobs = UserPostJobDAO.LoadListJobByUserIncreaseSalary();
            loaduc(Jobs);
        }

        private void btnDecrese_Click(object sender, EventArgs e)
        {
            LoadTrueToFalse();
            flowPanelContain.Controls.Clear();
            Jobs = UserPostJobDAO.LoadListJobByUserDecreaseSalary();
            loaduc(Jobs);
        }
        private void UCFilter()
        {
            flowPanelContain.Controls.Clear();
            
            Jobs = UserPostJobDAO.CreateQueryFilter(isbtnElectric, btnElectric, isbtnMachine, btnMachine, isbtnPainter, btnPainter, isbtnCarver, btnCarver,
                isbtnWashman, btnWashman, isbtnOther, btnOther);
            loaduc(Jobs);
        }
        private void btnElectric_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnElectric, btnElectric);
            UCFilter();
        }
       
        private void btnMachine_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnMachine, btnMachine);
            UCFilter();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnPainter, btnPainter);
            UCFilter();
        }

        private void btnCarver_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnCarver, btnCarver);
            UCFilter();
        }

        private void btnWashman_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnWashman, btnWashman);
            UCFilter();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnOther, btnOther);
            UCFilter();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            RollbtnJob.Start();

        }
        bool isBtnJobExpand = false;
        private void RollbtnJob_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnJobExpand, panelComboJob, btnJob, RollbtnJob);
        }
    }
}
