using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAnWin.PropertyClass
{
    public class Job
    {
        private string idUser;
        private string nameUser;
        private string idWorker;
        private string nameWorker;
        private string idWork;
        private string describeWork;
        private string statusWork;
        private string comment;
        private string dayWork;
        private int salary;
        private string finishDay;
        private float rate;
        private int isEvaluate;
        public Job() { }

        public Job(string idUser,string nameUser, string idWorker, string nameWorker, string idWork, string describeWork, string statusWork, string dayWork, int salary)
        {
            IdUser = idUser;
            NameUser = nameUser;
            IdWorker = idWorker;
            NameWorker = nameWorker;
            IdWork = idWork;
            DescribeWork = describeWork;
            StatusWork = statusWork;
            DayWork = dayWork;
            Salary = salary;
        }

        public Job(string idUser, string nameUser, string idWorker, string nameWorker, string idWork, string describeWork, string statusWork)
        {
            IdUser = idUser;
            NameUser = nameUser;
            IdWorker = idWorker;
            NameWorker = nameWorker;
            IdWork = idWork;
            DescribeWork = describeWork;
            StatusWork = statusWork;
        }

        public Job(string idWorker, string dayWork, string statusWork)
        {
            DayWork = dayWork;
            IdWorker = idWorker;
            StatusWork = statusWork;
        }

        public Job(string idUser, string nameUser, string idWorker, string nameWorker, string idWork)
        {
            IdUser= idUser;
            NameUser = nameUser;
            IdWorker = idWorker;
            NameWorker = nameWorker;
            IdWork = idWork;
        }

        public Job(string idWorker, string nameWorker, string finishDay, string idWork)
        {
            IdWorker = idWorker;
            NameWorker = nameWorker;
            FinishDay = finishDay;
            IdWork = idWork;
        }

        public Job(string idUser, string nameUser, string idWorker, string nameWorker, string idWork, string finishDay, float rate)
        {
            this.IdUser = idUser;
            this.NameUser = nameUser;
            this.IdWorker = idWorker;
            this.NameWorker = nameWorker;
            this.IdWork = idWork;
            this.FinishDay = finishDay;
            this.Rate = rate;
        }


        public string IdUser { get => idUser; set => idUser = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string IdWorker { get => idWorker; set => idWorker = value; }
        public string NameWorker { get => nameWorker; set => nameWorker = value; }
        public string IdWork { get => idWork; set => idWork = value; }
        public string DescribeWork { get => describeWork; set => describeWork = value; }
        public string StatusWork { get => statusWork; set => statusWork = value; }
        public string Comment { get => comment; set => comment = value; }
        public string DayWork { get => dayWork; set => dayWork = value; }
        public int Salary { get => salary; set => salary = value; }
        public string FinishDay { get => finishDay; set => finishDay = value; }
        public int IsEvaluate { get => isEvaluate; set => isEvaluate = value; }
        public float Rate { get => rate; set => rate = value; }
        public static bool checkNullDescribeJobInCalender(Job job)
        {
            if (job.DescribeWork == "")
            {
                MessageBox.Show("Thêm mô tả công việc để tiến hành đặt lịch");
                return false;
            }
            return true;
        }
    }
}
