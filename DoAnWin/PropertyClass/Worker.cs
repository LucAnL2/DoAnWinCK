using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.PropertyClass
{
    public class Worker : Person
    {
        private string job;
        private string workingDay;
        private string workingTime;
        private string hireCost;
        private string experience;
        private string describe;
        private string hireTimes;
        private string avgRate;
        private string status;
        private string active;
        //private string avatar;
        private int LikeTime;

        public Worker()
        {

        }
        //public Worker(string id, string name, string sex, string phone, string address,
        //    string cccd, string date, string email, string account, string pass)
        //    : base(id, name, sex, phone, address, cccd, date, email, account, pass)
        //{
        //}
        public Worker(string name, string address, string phone, string email, string sex, string date, string cccd, string account , string pass, string status):base(name,address,phone, email,sex, date,cccd, account,pass)
        {
            this.status = status;
        }
        public Worker(string job, string experience, string hireCost, string describe)
        {
            this.job = job;
            this.experience = experience;
            this.hireCost = hireCost;
            this.describe = describe;
        }
        public Worker(string id, string job, string workingDay, string workingTime,
            string hireCost, string experience, string describe) : base(id)
        {
            Job = job;
            WorkingDay = workingDay;
            WorkingTime = workingTime;
            HireCost = hireCost;
            Experience = experience;
            Describe = describe;
        }
        public Worker(string id, string name, string avgRate)
        {
            this.Id = id;
            this.Name = name;
            this.AvgRate = avgRate;
        }

        public string Job { get => job; set => job = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingTime { get => workingTime; set => workingTime = value; }
        public string HireCost { get => hireCost; set => hireCost = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Describe { get => describe; set => describe = value; }
        public string HireTimes { get => hireTimes; set => hireTimes = value; }
        public string AvgRate { get => avgRate; set => avgRate = value; }
        public string Status { get => status; set => status = value; }
        public string Active { get => active; set => active = value; }
        //public string Avatar { get => avatar; set => avatar = value; }
        public int LikeTime1 { get => LikeTime; set => LikeTime = value; }

        //public static class GlobalVariables
        //{
        //    public static int Id = 3;
        //}
        //public static bool checkNullDangViec(Worker newDangviec)
        //{

        //    foreach (var property in newDangviec.GetType().GetProperties())
        //    {
        //        if (property.GetValue(newDangviec) == null)
        //        {
        //            MessageBox.Show($"Thuộc tính {property.Name} không được để trống !!!");
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        public static bool checkNullDangViec(Worker newWorker, string[] propertiesToCheck)
        {
            //string[] propertiesToCheck = { "Id", "Job", "WorkingDay", "WorkingTime", "HireCost", "Experience", "Describe" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newWorker.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newWorker) == null || string.IsNullOrEmpty(property.GetValue(newWorker).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Experience")
                {
                    int experienceValue;
                    if (!int.TryParse(property.GetValue(newWorker).ToString(), out experienceValue))
                    {
                        MessageBox.Show($"Thuộc tính {property.Name} phải là một số nguyên !!!");
                        return false;
                    }
                }
            }
            return true;
        }


        public static bool checkNullInfo(Worker newWorker)
        {
            string[] propertiesToCheck = { "Id", "Name", "Sex", "Phone", "Address", "CCCD", "Date", "Email", "Account", "Pass", "Active" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newWorker.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newWorker) == null || string.IsNullOrEmpty(property.GetValue(newWorker).ToString()))
                {
                    MessageBox.Show("Vui lòng cập nhật đầy đủ thông tin để truy cập chức năng này !!!");
                    return false;
                }
            }
            return true;
        }

        public int TuoiHople(string ngaySinhTam)
        {
            // Chuyển đổi ngày tháng năm sinh từ kiểu varchar sang kiểu DateTime
            DateTime ngaySinh;
            if (!DateTime.TryParse(ngaySinhTam, out ngaySinh))
            {
                // Nếu không thể chuyển đổi, trả về false (ngày tháng năm sinh không hợp lệ)
                return 0;
            }
            DateTime ngayHienTai = DateTime.Today;
            int age = ngayHienTai.Year - ngaySinh.Year;

            // Kiểm tra nếu ngày sinh trong năm nay chưa tới thì trừ đi 1 tuổi
            if (ngaySinh > ngayHienTai.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        public static bool CheckNullUploadInfo(Worker newWorker)
        {
            if(newWorker.Name == "" || newWorker.Address == "" || newWorker.Phone == "" || newWorker.Email == "" || newWorker.Account == "" || newWorker.Pass == "")
                return false;
            return true;
        }
        public static bool CheckNullUploadInfoToPostJob(Worker newWorker)
        {
            string[] propertiesToCheck = { "Job", "Experience", "HireCost", "Describe"};

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newWorker.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newWorker) == null || string.IsNullOrEmpty(property.GetValue(newWorker).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Experience" || property.Name == "HireCost" )
                {
                    int experienceValue;
                    if (!int.TryParse(property.GetValue(newWorker).ToString(), out experienceValue))
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
