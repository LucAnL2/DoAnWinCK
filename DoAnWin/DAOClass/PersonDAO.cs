using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.DAOClass
{
    public class PersonDAO
    {
        DBConnection connect = new DBConnection();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT ID, Ten, Email, TenTaiKhoan, MatKhau, NhapLaiMatKhau, VaiTro FROM NguoiDung");
            return connect.Load(sqlStr);
        }
        public void DangKi(Person newPerson, string rePass)
        {
            if (Person.checkNullDangKi(newPerson, rePass))
            {
                if (newPerson.Role == "Người dùng")
                {
                    string sqlStr = string.Format("INSERT INTO NguoiDung (ID, Ten, Email, TenTaiKhoan, MatKhau,VaiTro,SDT) " +
                         "VALUES  (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", newPerson.Id, newPerson.Name, newPerson.Email
                         , newPerson.Account, newPerson.Pass, newPerson.Role, newPerson.Phone);
                    connect.ThucThi(sqlStr, "Đăng kí thành công", newPerson);
                }
                else
                {
                    string sqlStr = string.Format("INSERT INTO Worker (ID, Ten, Email, TenTaiKhoan, MatKhau,VaiTro,SDT) " +
                         "VALUES  (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", newPerson.Id, newPerson.Name, newPerson.Email
                         , newPerson.Account, newPerson.Pass, newPerson.Role, newPerson.Phone);
                    connect.ThucThi(sqlStr, "Đăng kí thành công", newPerson);
                }
            }
            else
            {
                return;

            }
        }
        public bool DangNhap(Account account, Guna2CustomRadioButton rbUser, Guna2CustomRadioButton rbWorker)
        {
            if(Person.checkNullDangNhap(account.UserName, account.Password))
            {
                string query;
                if (rbUser.Checked)
                {
                    query = "Select * from NguoiDung where TenTaiKhoan = '" + account.UserName + "' and MatKhau = '" + account.Password + "'";
                }
                else if (rbWorker.Checked)
                {
                    query = "Select * from Worker where TenTaiKhoan = '" + account.UserName + "' and MatKhau = '" + account.Password + "'";
                }
                else { MessageBox.Show("Vui lòng chỉ chọn một vai trò !!!"); return false; }
                return connect.ThucHienDangNhap(query);
            }
            return false;
        }
    }
}
