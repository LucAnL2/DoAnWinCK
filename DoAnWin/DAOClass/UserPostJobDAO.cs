using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;

namespace DoAnWin.DAOClass
{
    public class UserPostJobDAO
    {
        DBConnection conn = new DBConnection();

        public string CreateWorkID()
        {
            Modify modify = new Modify();
            string id = (310000 + Person.random.Next(1, 101)).ToString();
            while (modify.Accounts("Select * from UserPostJob where MaCV = '" + id + "'").Count != 0)
            {
                long temp = Int32.Parse(id) + 100;
                id = temp.ToString();
            }
            return id;
        }

        public bool UploadJob(UserPostJob us)
        {
            //MessageBox.Show(us.Salary.ToString());
            if(UserPostJob.CheckNullUserPostJob(us))
            {
                string sqlStr = string.Format("INSERT INTO UserPostJob(IdNguoiThue,TenNguoiThue , MaCV, YeuCau, MoTaCV, TrangThaiCV, Luong, CongViec) " +
                    "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}',N'{7}')", us.Id, us.Name, us.IDWork, us.Require, us.Describe, us.StatusJob, us.Salary1.ToString(), us.UserUpjob);
                conn.ThucThi(sqlStr);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public List<UserPostJob> LoadListJobByUsers()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select IdNguoiThue,TenNguoiThue , MaCV, YeuCau, MoTaCV, TrangThaiCV, Luong, CongViec\r\n " +
            "From UserPostJob " +
            "where IdNguoiThue = {0}", StaticPropertyAndField.IncomeID);
            return connect.LoadListJobByUsers(query);
        }

        public List<UserPostJob> LoadListJobByUsersInWorker()
        {
   
            DBConnection connect = new DBConnection();   
            string query = string.Format("select IdNguoiThue,TenNguoiThue , MaCV, YeuCau, MoTaCV, TrangThaiCV, Luong, CongViec\r\n " +
            "From UserPostJob " );
            return connect.LoadListJobByUsers(query);
        }
        public static List<UserPostJob> LoadListJobByUserIncreaseSalary()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select IdNguoiThue,TenNguoiThue , MaCV, YeuCau, MoTaCV, TrangThaiCV, Luong, CongViec\r\n " +
            "From UserPostJob ORDER BY Luong ASC ");
            return connect.LoadListJobByUsers(query);
        }
        public static List<UserPostJob> LoadListJobByUserDecreaseSalary()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select IdNguoiThue,TenNguoiThue , MaCV, YeuCau, MoTaCV, TrangThaiCV, Luong, CongViec\r\n " +
            "From UserPostJob ORDER BY Luong DESC ");
            return connect.LoadListJobByUsers(query);
        }
        public static List<UserPostJob> CreateQueryFilter(bool isbtnElectric, Guna2GradientButton btnElectric, bool isbtnMachine, Guna2GradientButton btnMachine, bool isbtnPainter, Guna2GradientButton btnPainter, bool isbtnCarver,
             Guna2GradientButton btnCarver, bool isbtnWashman, Guna2GradientButton btnWashman, bool isbtnOther, Guna2GradientButton btnOther)
        {
            DBConnection connect = new DBConnection();
            StringBuilder query = new StringBuilder($"select * from UserPostJob WHERE TrangThaiCV = N'Chờ xác nhận'");
            // Kiểm tra công việc
            List<string> TypeWorks = new List<string>();
            if (isbtnElectric)
            {
                TypeWorks.Add($"UserPostJob.CongViec = N'{btnElectric.Text}'");
            }
            if (isbtnMachine)
            {
                TypeWorks.Add($"UserPostJob.CongViec = N'{btnMachine.Text}'");
            }
            if (isbtnPainter)
            {
                TypeWorks.Add($"UserPostJob.CongViec = N'{btnPainter.Text}'");
            }
            if (isbtnCarver)
            {
                TypeWorks.Add($"UserPostJob.CongViec = N'{btnCarver.Text}'");
            }
            if (isbtnWashman)
            {
                TypeWorks.Add($"UserPostJob.CongViec = N'{btnWashman.Text}'");
            }
            if (isbtnOther)
            {
                // Thêm điều kiện cho nơi khác
                TypeWorks.Add($"UserPostJob.CongViec NOT IN (N'{btnElectric.Text}', N'{btnMachine.Text}', N'{btnPainter.Text}', N'{btnCarver.Text}', N'{btnWashman.Text}')");
            }

            if (TypeWorks.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", TypeWorks));
                query.Append("  )");
            }
            return connect.LoadListJobByUsers(query.ToString());

        }
    }
}
