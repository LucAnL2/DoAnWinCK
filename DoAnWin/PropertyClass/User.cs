using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.PropertyClass
{
    public class User : Person
    {
        private string hireID;
        private string hireName;
        private string vote;
        private string comment;
        private string position;
        private string salary;
        private string address;
        private string require;
        private string workingDay;
        private string workingHour;
        private string describe;
        private string status;
        // thuoc tinh cho phan Booking (address o tren)
        private string hiredID;
        private string hiredName;
        private string hireDays;
        private string hireMonths;
        private string hireYears;
        private string statusRequest;
        private string jobWantHire;
        
        public User() { }

        public User(string id, string name, string sex, string phone, string address, string cccd,
            string date, string email, string surplus, string account, string pass, string avatar) :base(id,  name,  sex,  phone,  address,  cccd,
            date, email, surplus, account,  pass,  avatar)
        { 

        }
        public User(string id, string position, string salary, string address, string require, string workingDay, string workingHour, string describe, string status) : base(id)
        {
            Position = position;
            Salary = salary;
            Address = address;
            Require = require;
            WorkingDay = workingDay;
            WorkingHour = workingHour;
            Describe = describe;
            Status = status;
        }

        public User(string id, string name, string email, string account, string pass
            , string role, string phone) : base(id, name, email, account, pass, role, phone)
        {
        }

        // cons Booking
        public User(string id, string name, string require, string describe)
        {
            this.Id = id;
            this.Name = name;
            this.require = require;
            this.describe = describe;
        }

        public string HireID { get => hireID; set => hireID = value; }
        public string HireName { get => hireName; set => hireName = value; }
        public string Vote { get => vote; set => vote = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Position { get => position; set => position = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Address1 { get => address; set => address = value; }
        public string Require { get => require; set => require = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingHour { get => workingHour; set => workingHour = value; }
        public string Describe { get => describe; set => describe = value; }
        public string Status { get => status; set => status = value; }
        public string HiredID { get => HiredID1; set => HiredID1 = value; }
        public string HiredID1 { get => hiredID; set => hiredID = value; }
        public string HiredName { get => hiredName; set => hiredName = value; }
        public string HireDays { get => hireDays; set => hireDays = value; }
        public string HireMonths { get => hireMonths; set => hireMonths = value; }
        public string HireYears { get => hireYears; set => hireYears = value; }
        public string StatusRequest { get => statusRequest; set => statusRequest = value; }
        public string JobWantHire { get => jobWantHire; set => jobWantHire = value; }

        public static bool checkNullUserDangViec(User newUser)
        {
            string[] propertiesToCheck = { "Id", "Position", "Salary", "Address", "Require", "WorkingDay", "WorkingHour", "Describe", "Status" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newUser.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newUser) == null || string.IsNullOrEmpty(property.GetValue(newUser).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Experience")
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
