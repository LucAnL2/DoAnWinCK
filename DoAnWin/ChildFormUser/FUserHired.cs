using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace DoAnWin.ChildFormUser
{
    public partial class FUserHired : Form
    {
        private List<Job> listFinishWork = new List<Job>();
        private JobDAO jd = new JobDAO();
        public FUserHired()
        {
            InitializeComponent();
            listFinishWork = jd.LoadFinishWork();
            //foreach (Job job in listFinishWork)
            //{
            //    UCHiredInUser uc = new UCHiredInUser(job);
            //    uc.Margin = new Padding(10);
            //    flowPanelContain.Controls.Add(uc);
            //}
        }

        private void FUserHired_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listFinishWork.Count.ToString());
            foreach (Job job in listFinishWork)
            {
                UCHiredInUser uc = new UCHiredInUser(job);
                //uc.Margin = new Padding(10);
                flowPanelContain.Controls.Add(uc);
            }

            JobDAO jd = new JobDAO();
            Dictionary<string, int> dataChart = jd.CreateDataChart(1);
            foreach (var pair in dataChart)
            {
                chartHireCost.Series[0].Points.AddXY(pair.Key, pair.Value);
            }

            Dictionary<string, int> dataCircleChart = jd.CreateDataCircleChart();
            //ChartArea chartArea = new ChartArea();
            //CircleChart.ChartAreas.Add(chartArea);
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            foreach (var item in dataCircleChart)
            {
                //series.Points.AddXY(item.Key, item.Value);
                CircleChart.Series[0].Points.AddXY(item.Key, item.Value);

            }
            //CircleChart.Series.Add(series);
            btnAll.Checked = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }
    }
}
