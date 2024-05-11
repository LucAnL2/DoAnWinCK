using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DoAnWin.PropertyClass
{
    public class UserPostJob : User
    {
        private string iDWork;
        private string statusJob;
        private int salary;
        private string userUpjob;
        public UserPostJob() { }
        public UserPostJob(string idUser, string nameUser, string iDWork, string require, string describe, string statusJob, int salary,string userUpjob) :base(idUser, nameUser, require, describe)
        {
            this.IDWork = iDWork;
            this.StatusJob = statusJob;
            this.Salary1 = salary;
            this.userUpjob = userUpjob;

        }

        public string IDWork { get => iDWork; set => iDWork = value; }
        public string StatusJob { get => statusJob; set => statusJob = value; }
        public int Salary1 { get => salary; set => salary = value; }
        public string UserUpjob { get => userUpjob; set => userUpjob = value; }

        public static bool CheckNullUserPostJob(UserPostJob newUser)
        {
            string[] propertiesToCheck = { "Id", "Name", "IDWork", "Require", "StatusJob", "Describe", "Salary1", "UserUpjob" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newUser.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newUser) == null || string.IsNullOrEmpty(property.GetValue(newUser).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Salary1")
                {
                    int experienceValue;
                    if (!int.TryParse(property.GetValue(newUser).ToString(), out experienceValue))
                    {
                        MessageBox.Show($"Thuộc tính {property.Name} phải là một số nguyên !!!");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
