using DoAnWin.ChildFormWorker;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.DAOClass
{
    public class WorkerDAO
    {
        DBConnection connect = new DBConnection();
        FormDAO fd = new FormDAO();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT *FROM DangViec");
            return connect.Load(sqlStr);
        }
        public bool UpdateInfo(Worker newDangviec)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay, newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);

            if (Worker.CheckNullUploadInfo(newDangviec) == true)
            {
                string sqlStr = string.Format("UPDATE Worker SET DangThongTin = N'{0}' WHERE ID = N'{1}'",
                    "1", StaticPropertyAndField.IncomeID);
                connect.ThucThi(sqlStr);
                return true;
                //connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            }
            else
            {
                return false;
            }
        }
        public void DeleteWork(Worker newDangviec)
        {
            string sqlStr = string.Format("DELETE FROM DangViec WHERE ID = '{0}' AND NgheNghiep = '{1}'", newDangviec.Id, newDangviec.Job);
            connect.ThucThi(sqlStr);
        }
        public void updateInfo(Worker newInfo)
        {
            string sqlStr = string.Format("UPDATE Worker SET Ten = N'{0}', DiaChi = N'{1}', SDT = N'{2}', Email = N'{3}', " +
                "GioiTinh = N'{4}', NgaySinh = N'{5}', CCCD = N'{6}', TenTaiKhoan = N'{7}', MatKhau = N'{8}', TrangThai = N'{9}' WHERE ID = N'{10}'",
            newInfo.Name, newInfo.Address, newInfo.Phone, newInfo.Email, newInfo.Sex, newInfo.Date, newInfo.Cccd, newInfo.Account, newInfo.Pass, newInfo.Status, StaticPropertyAndField.IncomeID);
            connect.ThucThi(sqlStr);
        }
        public bool UpLoadInfoAndJob(Worker newInfo)
        {
            if(Worker.CheckNullUploadInfoToPostJob(newInfo))
            {
                string sqlStr = string.Format("UPDATE Worker SET NgheNghiep = N'{0}', NamKinhNghiem = N'{1}', GiaThue = N'{2}', MoTa = N'{3}' " +
                "WHERE ID = N'{4}'",
                newInfo.Job, newInfo.WorkingTime, newInfo.HireCost, newInfo.Describe, StaticPropertyAndField.IncomeID);
                connect.ThucThi(sqlStr);
                return true;
            }    
            else
            {
                return false;
            }
            
        }
        public void UpdateStatus(string ID)
        {
            string sqlStr = string.Format("UPDATE DangViec SET TrangThai = N'{0}' WHERE ID = N'{1}'", "Xác nhận", ID);
            connect.ThucThi(sqlStr);
        }
        public List<Worker> LoadListWorker(Label lblTitle)
        {
            string query = "";
            if (lblTitle.Text != "Thợ khác")
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.GioiTinh, Worker.NgaySinh, Worker.DiaChi, Worker.SDT,Worker.Email, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.TrangThai, Worker.NamKinhNghiem, Worker.GiaThue, Worker.NgheNghiep, Worker.MoTa, Worker.DangThongTin, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.TrangThai = N'{0}' and Worker.DangThongTin = N'{1}' and Worker.NgheNghiep = N'{2}'", "Hoạt động", "1", lblTitle.Text);
            }
            else
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.GioiTinh, Worker.NgaySinh, Worker.DiaChi, Worker.SDT,Worker.Email, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.TrangThai, Worker.NamKinhNghiem, Worker.GiaThue, Worker.NgheNghiep, Worker.MoTa, Worker.DangThongTin, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.TrangThai = N'{0}' and Worker.DangThongTin = N'{1}' and Worker.NgheNghiep != N'Thợ máy'and Worker.NgheNghiep != N'Thợ sơn'and Worker.NgheNghiep != N'Thợ rửa xe'and Worker.NgheNghiep != N'Thợ điện'and Worker.NgheNghiep != N'Thợ điêu khắc' and Worker.NgheNghiep != N'' ", "Hoạt động", "1");
            }
            return connect.LoadWorkerToUser(query);
        }
        public Worker IncomeWorker()
        {
            string query = string.Format("select Worker.ID, Worker.Ten, Worker.DiaChi, Worker.SDT, Worker.Email, Worker.GioiTinh,Worker.NgaySinh, Worker.CCCD, Worker.TenTaiKhoan, Worker.MatKhau, Worker.TrangThai, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.ID = N'{0}'", StaticPropertyAndField.IncomeID);
            return connect.LoadInComeWorker(query);
        }

        public int TakeSalary(string idWorker)
        {
            string query = string.Format("select GiaThue\r\n" +
                        "from Worker " +
                        "where id= N'{0}'", idWorker);
            return connect.TakeSalary(query);
        }

        public void UpdateLikeTimes(int LikeTime, string id)
        {
            string sqlStr = string.Format("UPDATE Worker SET LuotThich = N'{0}'" +
            "WHERE ID = N'{1}'",
            LikeTime, id);
            connect.ThucThi(sqlStr);
        }

        public int TakeLikeTime(string idWorker)
        {
            string query = string.Format("select LuotThich\r\n" +
                        "from Worker " +
                        "where id= N'{0}'", idWorker);
            return connect.TakeLikeTime(query);
        }

        public List<Worker> LoadAllWorker()
        {
            string query = string.Format("select Worker.ID, Worker.Ten, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.NgheNghiep,Worker.Avatar, Worker.LuotThich From Worker");
            return connect.LoadAllWorker(query);
        }

        public List<Worker> LoadByLike()
        {
            string query = string.Format("SELECT Worker.ID, Worker.Ten, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.NgheNghiep,Worker.Avatar, Worker.LuotThich\r\nFROM Worker\r\nORDER BY TRY_CAST(LuotThich AS INT) DESC;");
            return connect.LoadAllWorker(query);
        }
        public List<Worker> CreateQueryFilter(Label lblTitle, bool isbtnHaNoi, Guna2GradientButton btnHaNoi, bool isbtnHCM, Guna2GradientButton btnHCM, bool isbtnHue, Guna2GradientButton btnHue,
            bool isbtnNoiKhac, bool isbtn80, bool isbtn80120, bool isbtn120200, bool isbtn200, bool isbtn1sao, bool isbtn2sao, bool isbtn3sao, bool isbtn4sao, bool isbtn5sao)
        {
            //StringBuilder query = new StringBuilder($"SELECT DISTINCT DangViec.ID, Ten, SDT,DangViec.NgheNghiep,Worker.DanhGiaTrungBinh FROM DangViec INNER JOIN Worker ON Worker.ID = DangViec.ID WHERE NgheNghiep = N'{lblTitle.Text}' AND DangViec.TrangThai = N'Đang chờ'");
            //StringBuilder query = new StringBuilder($"select * from Worker WHERE NgheNghiep = N'{lblTitle.Text}' AND Worker.TrangThai = N'Hoạt động'");
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM Worker WHERE Worker.TrangThai = N'Hoạt động'");

            // Kiểm tra điều kiện về nghề nghiệp
            if (!string.IsNullOrEmpty(lblTitle.Text) &&
                lblTitle.Text != "Thợ máy" &&
                lblTitle.Text != "Thợ điêu khắc" &&
                lblTitle.Text != "Thợ sơn" &&
                lblTitle.Text != "Thợ rửa xe" &&
                lblTitle.Text != "Thợ điện")
            {
                query.Append(" AND Worker.NgheNghiep NOT IN (N'Thợ máy', N'Thợ điêu khắc', N'Thợ sơn', N'Thợ rửa xe', N'Thợ điện')");
            }
            else
            {
                query.Append($" AND Worker.NgheNghiep = N'{lblTitle.Text}'");
            }
            // Kiểm tra địa chỉ
            List<string> addressConditions = new List<string>();
            if (isbtnHaNoi)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnHaNoi.Text}'");
            }
            if (isbtnHCM)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnHCM.Text}'");
            }
            if (isbtnHue)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnHue.Text}'");
            }
            if (isbtnNoiKhac)
            {
                // Thêm điều kiện cho nơi khác
                addressConditions.Add($"Worker.DiaChi NOT IN (N'{btnHaNoi.Text}', N'{btnHCM.Text}', N'{btnHue.Text}')");
            }

            if (addressConditions.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", addressConditions));
                query.Append("  )");
            }
            List<string> salary = new List<string>();
            if (isbtn80)
            {
                salary.Add("CONVERT(FLOAT, Worker.GiaThue ) < 80000");
            }
            if (isbtn80120)
            {
                salary.Add("CONVERT(FLOAT, Worker.GiaThue) between 80000 and 120000");
            }
            if (isbtn120200)
            {
                salary.Add("CONVERT(FLOAT, Worker.GiaThue) between 120000 and 200000");
            }
            if (isbtn200)
            {
                salary.Add("CONVERT(FLOAT, Worker.GiaThue) > 200000");
            }

            if (salary.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", salary));
                query.Append(")");
            }
            List<string> Rate = new List<string>();
            if (isbtn1sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 1");
            }
            if (isbtn2sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 2");
            }
            if (isbtn3sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 3");
            }
            if (isbtn4sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 4");
            }
            if (isbtn5sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) = 5");
            }
            if (Rate.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", Rate));
                query.Append(" )");
            }
            //MessageBox.Show(query.ToString());
            return connect.LoadWorkerToUser(query.ToString());
        }
        public List<Worker> LoadListWorkerTOPBook(Label lblTitle)
        {
            //string query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(LuotThue AS INT) DESC");
            string query = "";

            if (!string.IsNullOrEmpty(lblTitle.Text) &&

                lblTitle.Text != "Thợ máy" &&

                lblTitle.Text != "Thợ điêu khắc" &&

                lblTitle.Text != "Thợ sơn" &&

                lblTitle.Text != "Thợ rửa xe" &&

                lblTitle.Text != "Thợ điện")

            {

                query = ("SELECT TOP 5 * FROM Worker WHERE NgheNghiep NOT IN (N'Thợ máy', N'Thợ điêu khắc', N'Thợ sơn', N'Thợ rửa xe', N'Thợ điện') ORDER BY TRY_CAST(LuotThue AS INT) DESC");

            }

            else

            {

                query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(LuotThue AS INT) DESC");

            }
            return connect.LoadWorkerToUser(query);

        }
        public List<Worker> LoadListWorkerTOP(Label lblTitle)
        {
            //string query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(DanhGiaTrungBinh AS FLOAT) DESC");
            string query = "";
            if (!string.IsNullOrEmpty(lblTitle.Text) &&
                lblTitle.Text != "Thợ máy" &&
                lblTitle.Text != "Thợ điêu khắc" &&
                lblTitle.Text != "Thợ sơn" &&
                lblTitle.Text != "Thợ rửa xe" &&
                lblTitle.Text != "Thợ điện")
            {
                query = ("SELECT TOP 5 * FROM Worker WHERE NgheNghiep NOT IN (N'Thợ máy', N'Thợ điêu khắc', N'Thợ sơn', N'Thợ rửa xe', N'Thợ điện') ORDER BY TRY_CAST(DanhGiaTrungBinh AS FLOAT) DESC");
            }
            else
            {
                query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(DanhGiaTrungBinh AS FLOAT) DESC");
            }
            return connect.LoadWorkerToUser(query);
        }
        public List<Worker> LoadListWorkerMinRevenue(Label lblTitle)
        {
            string query = "";
            if (!string.IsNullOrEmpty(lblTitle.Text) &&
                lblTitle.Text != "Thợ máy" &&
                lblTitle.Text != "Thợ điêu khắc" &&
                lblTitle.Text != "Thợ sơn" &&
                lblTitle.Text != "Thợ rửa xe" &&
                lblTitle.Text != "Thợ điện")
            {

                    query = $@"
                SELECT TOP 3 w.*, j.TongLuong
                FROM Worker w
                JOIN (
                    SELECT IDNguoiLam, SUM(Luong) AS TongLuong
                    FROM job
                    GROUP BY IDNguoiLam
                ) j ON w.ID = j.IDNguoiLam
                WHERE w.NgheNghiep NOT IN(N'Thợ máy', N'Thợ điêu khắc', N'Thợ sơn', N'Thợ rửa xe', N'Thợ điện')
                ORDER BY j.TongLuong DESC";
            }
            else
            {
                    query = $@"
                SELECT TOP 3 w.*, j.TongLuong
                FROM Worker w
                JOIN (
                    SELECT IDNguoiLam, SUM(Luong) AS TongLuong
                    FROM job
                    GROUP BY IDNguoiLam
                ) j ON w.ID = j.IDNguoiLam
                WHERE w.NgheNghiep = N'{lblTitle.Text}'
                ORDER BY j.TongLuong DESC";
            }

            return connect.LoadWorkerToUser(query);
        }
        public string TakeAVGRate(string id)
        {
            string query = string.Format("select ROUND(AVG(DanhGia), 1) as avgRate from Comment where IDNguoiLam = N'{0}'", id);
            return connect.TakeOneOjectFloat(query);
        }

        public void UpdateAVGRate(float avgRate, string id)
        {
            string sqlStr = string.Format("UPDATE Worker SET DanhGiaTrungBinh = N'{0}'" +
            "WHERE ID = N'{1}'",
            avgRate, id);
            connect.ThucThi(sqlStr);
        }
    }
}
