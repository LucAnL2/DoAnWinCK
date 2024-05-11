using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.ChildFormWorker
{
    public partial class FHistory : Form
    {
        private List<Job> listFinishWork = new List<Job>();
        private JobDAO jd = new JobDAO();
        public FHistory()
        {
            InitializeComponent();
            listFinishWork = jd.LoadFinishWorkInWorker(StaticPropertyAndField.IncomeID);
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listFinishWork.Count.ToString());
            if(listFinishWork != null)
                foreach (Job job in listFinishWork)
                {
                    UCWorkedInWorker uc = new UCWorkedInWorker(job);
                    //uc.Margin = new Padding(10);
                    flowPanelContain.Controls.Add(uc);
                }
            JobDAO jd = new JobDAO();
            Dictionary<string, int> dataChart = jd.CreateDataChart(0);
            //chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // xóa lưới
            //chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chartRevenue.ChartAreas[0].AxisX.Minimum = 1;// đặt lại giá trị tối thiểu
            foreach (var pair in dataChart)
            {
                chartRevenue.Series[0].Points.AddXY(pair.Key, pair.Value);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //JobDAO jd = new JobDAO();
            //Dictionary<string, int> dataChart = jd.CreateDataChart();
            //chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // xóa lưới
            //chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chartRevenue.ChartAreas[0].AxisX.Minimum = 1;// đặt lại giá trị tối thiểu
            //foreach (var pair in dataChart)
            //{
            //    chartRevenue.Series[0].Points.AddXY(pair.Key, pair.Value);
            //}
            //string test = "";
            //foreach (var data in dataChart)
            //{
            //    test += data.Key + " " + data.Value + "\n";

            //}
            //MessageBox.Show(test);
        }
    }
}
