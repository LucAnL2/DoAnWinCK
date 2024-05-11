using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.DAOClass
{
    public class UserDAO
    {
        DBConnection connect = new DBConnection();
        public void PostWork(User newDangviec)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay, newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);

            if (User.checkNullUserDangViec(newDangviec) == true)
            {
                string sqlStr = string.Format("INSERT INTO NguoiDungDangViec (ID, ViTri, Luong, DiaChi, YeuCau, NgayLam, GioLam, MoTa, TrangThai) " +
                        "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", newDangviec.Id, newDangviec.Position, newDangviec.Salary
                        , newDangviec.Address, newDangviec.Require, newDangviec.WorkingDay, newDangviec.WorkingHour, newDangviec.Describe, newDangviec.Status);
                connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            }
            else
            {
                return;
            }
        }
        public void DeleteWork(User newDangviec)
        {
            string sqlStr = string.Format("DELETE FROM NguoiDungDangViec WHERE ID = '{0}' AND NgheNghiep = '{1}'", newDangviec.Id);
            connect.ThucThi(sqlStr);
        }
        public void updateBooking(User newBooking) // chuyen doi trang thái thanh "Đang làm"
        {
            //newDangviec = new Worker(newDangviec.Id, newDangvi   
            string sqlStr = string.Format("Update ThueViec Set TrangThaiThue = N'{0}' WHERE IDNguoiThue = N'{1}' And IDNguoiDuocThue = N'{2}'", "Đang làm", newBooking.Id, newBooking.HiredID);
            ///connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            connect.ThucThi(sqlStr);

        }
        public void DeleteBooking(User newBooking) // chuyen doi trang thái thanh "Đang làm"
        {
            //newDangviec = new Worker(newDangviec.Id, newDangvi   
            string sqlStr = string.Format("DELETE FROM ThueViec WHERE IDNguoiThue = N'{0}' AND IDNguoiDuocThue = N'{1}' AND TrangThaiThue = N'{2}'", newBooking.Id, newBooking.HiredID, "Chờ xác nhận");
            ///connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            connect.ThucThi(sqlStr);

        }
        public void Booking(User newBooking)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangvi   
            string sqlStr = string.Format("INSERT INTO ThueViec (IDNguoiThue, TenNguoiThue, IDNguoiDuocThue, TenNguoiDuocThue, NgayThue, ThangThue, NamThue, TrangThaiThue,DiaChi,SDT,CongViecMuonThue) " +
                    "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}')", newBooking.Id, newBooking.Name, newBooking.HiredID
                    , newBooking.HiredName, newBooking.HireDays, newBooking.HireMonths, newBooking.HireYears, newBooking.StatusRequest, newBooking.Address, newBooking.Phone, newBooking.JobWantHire);
            ///connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            connect.ThucThi(sqlStr);
        }

        public void RechargeMoney(string Money)
        {
            string sqlStr = string.Format("UPDATE NguoiDung SET SoDU = N'{0}' " +
                "WHERE Id = N'{1}'", Money, StaticPropertyAndField.IncomeID);
            connect.ThucThi(sqlStr);
        }

        public string MoneyBalance()
        {
            string sqlStr = string.Format("select SoDU " +
                "FROM NguoiDung " +
                "WHERE Id = N'{0}'", StaticPropertyAndField.IncomeID);
            return connect.MoneyBalance(sqlStr);
        }

        public User UserInfo()
        {
            string sqlStr = string.Format("select ID, Ten, GioiTinh, SDT, DiaChi, CCCD, NgaySinh, Email, SoDU, TenTaiKhoan, MatKhau, Avatar " +
                "FROM NguoiDung " +
                "WHERE Id = N'{0}'", StaticPropertyAndField.IncomeID);
            return connect.UserInfo(sqlStr);
        }
    }
}
