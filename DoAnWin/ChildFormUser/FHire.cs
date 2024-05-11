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
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using DoAnWin.ChildFormWorker;
using System.Data.SqlClient;
using DoAnWin.NormalClass;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Runtime.Remoting.Channels;
using DoAnWin.DAOClass;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnWin.ChildFormUser
{
    public partial class FHire : Form
    {
        private List<string> Thedays = new List<string>();
        private List<string> workingDay = new List<string>();
        public static List<string> busyDay = new List<string>();
        private int month, year;
        private string id;
        private string name;
        private string idWork;
        private string describe;
        private string salary;
        public FHire(string id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        public FHire(string id, string name, string idWork, string describe, string salary)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.idWork = idWork;
            this.describe = describe;
            this.salary = salary;
        }
        
        public FHire(string id, string name, List<string> workingDay, string idWork)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.workingDay = workingDay;
            this.idWork = idWork;
        }

        private void FHire_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            LoadMatrix();
            guna2Button1.Hide();
        }
        private void CreateButton(Guna2Button Btn)
        {
            Btn.FillColor = Color.Transparent;
            Btn.ForeColor = Color.FromArgb(74, 65, 197);
            Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn.Size = new Size(50, 37);
            int dis = (FLPmatrix.Width - (2 * Btn.Width)) / 28;
            Btn.Margin = new Padding(dis, dis, 0, 0);
        }

        private void Enforcement()
        {
            String monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lblMonthYear.Text = monthName + " " + year;

            DateTime starOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayOfWeek = Convert.ToInt32(starOfTheMonth.DayOfWeek.ToString("d")) + 1;

            JobDAO jd = new JobDAO();
            busyDay = jd.CreateListBusyDay(id);

            //if (workingDay.Count != 0)
            //{
            //    if (CheckWorkingDay(busyDay, workingDay))
            //    {
            //        JobDAO jobDAO = new JobDAO();
            //        //MessageBox.Show("Ngày hôm đó bạn đã có công việc khác phải làm rồi");
            //        jd.UpdateBusyDay(idWork);
            //    }
            //    else if (CheckWorkingDay(busyDay, workingDay) == false)
            //    {
            //        MessageBox.Show("Ngày hôm đó bạn đã có công việc khác phải làm rồi");
            //        //jd.UpdateBusyDay(idWork);
            //    }
            //}

            //string test = "";
            //test += id + "\n";
            //MessageBox.Show(test);
            //foreach (string day in busyDay)
            //{
            //    test += day + "\n";
            //}
            //MessageBox.Show(test);

            for (int i = 1; i < dayOfWeek; i++)
            {
                Guna2Button Btn = new Guna2Button();
                CreateButton(Btn);
                Btn.Tag = "Clone";
                FLPmatrix.Controls.Add(Btn);
            }

            for (int i = 1; i <= days; i++)
            {
                Guna2Button Btn = new Guna2Button();
                CreateButton(Btn);
                if (isToDay(i, month, year))
                {
                    Btn.FillColor = Color.FromArgb(107, 95, 255);
                    Btn.ForeColor = Color.White;
                }
                if(isFuture(i, month, year))
                {
                    Btn.Tag = "Off";
                    Btn.Click += btn_Click;
                }
                if(isFuture(i,month, year) == false)
                    Btn.Tag = "Clone";
                Btn.Text = i.ToString();
                foreach (string day in Thedays)
                {
                    string date = day.Replace('/', ' ');
                    string[] parts = date.Split(' ');
                    string vday = parts[0];
                    string vmonth = parts[1];
                    string vyear = parts[2];
                    if (vyear == year.ToString() && vmonth == month.ToString() && vday == Btn.Text)
                    {
                        Btn.FillColor = Color.FromArgb(112, 48, 160);
                        Btn.ForeColor = Color.White;
                        Btn.Tag = "On";
                    }
                }

                //busyDay = jd.CreateListBusyDay(id);

                //if (workingDay.Count != 0)
                //{
                //    if (CheckWorkingDay(busyDay, workingDay))
                //    {
                //        JobDAO jobDAO = new JobDAO();
                //        jobDAO.UpdateBusyDay(idWork);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Ngày hôm đó bạn đã có công việc khác phải làm rồi");
                //    }
                //}

                foreach (string day in busyDay)
                {
                    string date = day.Replace('/', ' ');
                    string[] parts = date.Split(' ');
                    string vday = parts[0];
                    string vmonth = parts[1];
                    string vyear = parts[2];
                    if (vyear == year.ToString() && vmonth == month.ToString() && vday == Btn.Text)
                    {
                        Btn.FillColor = Color.FromArgb(246, 18, 18);
                        Btn.ForeColor = Color.White;
                        Btn.Tag = "Working";
                    }
                }

                FLPmatrix.Controls.Add(Btn);
            }
        }

        private bool isToDay(int date, int month, int year)
        {
            return date == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year;
        }

        private bool isFuture(int date, int month, int year)
        {
            DateTime inputDate = new DateTime(year, month, date);
            return inputDate > DateTime.Now;
        }

        private void LoadMatrix()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            Enforcement();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FLPmatrix.Controls.Clear();
            month++;

            if (month > 12)
            {
                month = 1;
                year++;
            }

            Enforcement();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            FLPmatrix.Controls.Clear();
            LoadMatrix();
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            FLPmatrix.Controls.Clear();
            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }

            Enforcement();
        }

        private void btnHireAllMonth_Click(object sender, EventArgs e)
        {
            foreach(Guna2Button btn in FLPmatrix.Controls)
            {
                if (btn.Tag.ToString() == "Off")
                {
                    btn.FillColor = Color.FromArgb(112, 48, 160);
                    btn.ForeColor = Color.White;
                    btn.Tag = "On";
                    string value = btn.Text + "/" + month.ToString() + "/" + year.ToString();
                    Thedays.Add(value);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string test = "";
            foreach(string day in Thedays)
            {
                test += day+" \n";
            }
            MessageBox.Show(test);
        }

        private void btnConFirm_Click(object sender, EventArgs e)
        {
            if (idWork == null)
            {
                string idWork = JobDAO.CreateWorkID();
                WorkerDAO wk = new WorkerDAO();
                int salary = wk.TakeSalary(id);
                foreach (string day in Thedays)
                {
                    Job job = new Job(StaticPropertyAndField.IncomeID, StaticPropertyAndField.IncomeName, id, name, idWork, txtDescribe.Text, "Chờ xác nhận", day, salary);
                    JobDAO jd = new JobDAO();
                    if(jd.HireWorker(job) == true)
                        this.Close();
                    else
                        return;
                }
            }
            else
            {
                txtDescribe.Enabled = false;
                foreach (string day in Thedays)
                {
                    Job job = new Job(StaticPropertyAndField.IncomeID, StaticPropertyAndField.IncomeName, id, name, idWork, describe, "Chờ xác nhận", day, Convert.ToInt32(salary));
                    JobDAO jd = new JobDAO();
                    if (jd.HireWorker(job) == true)
                        this.Close();
                }
            }
          //  this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Guna2Button btn in FLPmatrix.Controls)
            {
                if (btn.Tag.ToString() == "On")
                {
                    btn.FillColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(74, 65, 197);
                    btn.Tag = "Off";
                    string value = btn.Text + "/" + month.ToString() + "/" + year.ToString();
                    Thedays.Remove(value);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn.Tag.ToString() == "Off")
            {
                btn.FillColor = Color.FromArgb(112, 48, 160);
                btn.ForeColor = Color.White;
                btn.Tag = "On";
                string value = btn.Text + "/" + month.ToString() + "/" + year.ToString();
                Thedays.Add(value);
            }
            else if(btn.Tag.ToString() == "On")
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(74, 65, 197);
                btn.Tag = "Off";
                string value = btn.Text + "/" + month.ToString() + "/" + year.ToString();
                Thedays.RemoveAll(day => day == value);
            }
        }
    }
}
