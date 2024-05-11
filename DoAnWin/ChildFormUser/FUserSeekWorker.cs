using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using Guna.UI2.WinForms;

namespace DoAnWin.ChildFormUser
{
    public partial class FUserSeekWorker : Form
    {
        WorkerDAO workerDAO = new WorkerDAO();
        FormDAO fd = new FormDAO();
        private bool isbtnHaNoi = false;
        private bool isbtnHCM = false;
        private bool isbtnHue = false;
        private bool isbtnNoiKhac = false;
        private bool isbtn80 = false;
        private bool isbtn80120 = false;
        private bool isbtn120200 = false;
        private bool isbtn200 = false;
        private bool isbtn1sao = false;
        private bool isbtn2sao = false;
        private bool isbtn3sao = false;
        private bool isbtn4sao = false;
        private bool isbtn5sao = false;
        private bool isbtn1618 = false;
        private bool isbtn1825 = false;
        private bool isbtn25 = false;

        private bool isbtnTopRevenue = false;
        private bool isbtnTopRate = false;
        private bool isbtnTopBooking = false;
        private bool isbtnMinVen = false;

        private List<(bool, Guna2GradientButton)> boolButtonPairs = new List<(bool, Guna2GradientButton)>();

        public FUserSeekWorker(string title)
        {
            InitializeComponent();
            lblTitle.Text = title;
        }

        private void FUserSeekWorker_Load(object sender, EventArgs e)
        {
            LoadListWorker();
        }
        private void LoadTrueToFalse()
        {
            // Thêm các cặp bool và nút vào danh sách
            boolButtonPairs.Add((isbtnHaNoi, btnHaNoi));
            boolButtonPairs.Add((isbtnHCM, btnHCM));
            boolButtonPairs.Add((isbtnHue, btnHue));
            boolButtonPairs.Add((isbtnNoiKhac, btnNoiKhac));
            boolButtonPairs.Add((isbtn80, btn80));
            boolButtonPairs.Add((isbtn80120, btn80120));
            boolButtonPairs.Add((isbtn120200, btn120200));
            boolButtonPairs.Add((isbtn200, btn200));
            boolButtonPairs.Add((isbtn1sao, btn1Star));
            boolButtonPairs.Add((isbtn2sao, btn2Star));
            boolButtonPairs.Add((isbtn3sao, btn3Star));
            boolButtonPairs.Add((isbtn4sao, btn4Star));
            boolButtonPairs.Add((isbtn5sao, btn5Star));
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
        private void LoadListWorker()
        {
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorker(lblTitle);
            foreach(Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }

        }
        private void UCFilter()
        {
            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.CreateQueryFilter(lblTitle, isbtnHaNoi, btnHaNoi, isbtnHCM, btnHCM, isbtnHue, btnHue, isbtnNoiKhac,
            isbtn80, isbtn80120, isbtn120200, isbtn200, isbtn1sao, isbtn2sao, isbtn3sao, isbtn4sao, isbtn5sao);
            loaduc(workers);

        }
        private void loaduc(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        bool isBtnAddressExpand = false;
        private void RollBtnAddress_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnAddressExpand, panelComboAddress, btnAddress, RollBtnAddress);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            RollBtnAddress.Start();
        }

        private void btnHaNoi_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHaNoi, btnHaNoi);
            UCFilter();

        }

        private void btnHCM_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHCM, btnHCM);
            UCFilter();

        }

        private void btnHue_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHue, btnHue);
            UCFilter();

        }

        private void btnNoiKhac_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnNoiKhac, btnNoiKhac);
            UCFilter();

        }

        bool isBtnHireCostExpand = false;
        private void RollBtnHireCost_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnHireCostExpand, panelComboHireCost, btnHireCost, RollBtnHireCost);
        }

        private void btnHireCost_Click(object sender, EventArgs e)
        {
            RollBtnHireCost.Start();
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn80, btn80);
            UCFilter();

        }

        private void btn80120_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn80120, btn80120);
            UCFilter();

        }

        private void btn120200_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn120200, btn120200);
            UCFilter();

        }

        private void btn200_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn200, btn200);
            UCFilter();

        }

        bool isBtnRateExpand = false;
        private void RollBtnRate_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnRateExpand, panelComboRate, btnRate, RollBtnRate);

        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            RollBtnRate.Start();
        }

        private void btn1Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn1sao, btn1Star);
            UCFilter();

        }

        private void btn2Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn2sao, btn2Star);
            UCFilter();

        }

        private void btn3Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn3sao, btn3Star);
            UCFilter();

        }

        private void btn4Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn4sao, btn4Star);
            UCFilter();

        }

        private void btn5Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn5sao, btn5Star);
            UCFilter();

        }

        bool isBtnAgeExpand = false;
        private void RollBtnAge_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnAgeExpand, panelComboAge, btnAge, RollBtnAge);
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            RollBtnAge.Start();
        }

        private void btnTopBooking_Click(object sender, EventArgs e)
        {
            
            isbtnTopRevenue = false;
            isbtnTopRate = false;
            isbtnMinVen = false;

            btnTopRevenue.BackColor = SystemColors.Control;
            btnTopRate.BackColor = SystemColors.Control;
            LoadTrueToFalse();
            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerTOPBook(lblTitle);
            loaduc(workers);
        }

        private void btnTopRate_Click(object sender, EventArgs e)
        {
            isbtnTopRevenue = false;
            isbtnTopBooking = false;
            isbtnMinVen = false;

            btnTopRevenue.BackColor = SystemColors.Control;
            btnTopBooking.BackColor = SystemColors.Control;
            LoadTrueToFalse();

            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerTOP(lblTitle);
            loaduc(workers);
        }

        private void btnTopRevenue_Click(object sender, EventArgs e)
        {
            isbtnTopBooking = false;
            isbtnTopRate = false;
            isbtnTopRevenue = false;

            btnTopRate.BackColor = SystemColors.Control;
            btnTopBooking.BackColor = SystemColors.Control;
            LoadTrueToFalse();
            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerMinRevenue(lblTitle);
            loaduc(workers);
        }
    }
}
