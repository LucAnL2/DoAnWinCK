using DoAnWin.PropertyClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;

namespace DoAnWin.NormalClass
{
    public class DBConnection
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DoAnWin;Integrated Security=True";
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        public DataTable Load(string sqlStr)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                    DataTable dtperson = new DataTable();
                    adapter.Fill(dtperson);
                    return dtperson;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return null;
        }
        public void ThucThi(string sqlStr, string successMessage, Person newperson)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, connection);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(successMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDConnection: " + ex.Message);
            }
            finally
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Close();
                }

            }
        }

        public void ThucThi(string sqlStr)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, connection);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thao tác thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại: " + ex.Message);
            }
            finally
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Close();
                }

            }
        }
        public void CreateFileData(string id)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            try
            {
                string defaultFolderPath = root + "\\DataUser\\";
                string defaultFilePath = Path.Combine(defaultFolderPath, id.ToString() + ".txt");
                string defaultFilePathNeo = Path.Combine(defaultFolderPath, id.ToString() + "History" + ".txt");
                if (File.Exists(defaultFilePath))
                {
                    MessageBox.Show("Default file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (StreamWriter writer = new StreamWriter(defaultFilePath))
                {
                    //writer.WriteLine("");
                }
                using (StreamWriter writer = new StreamWriter(defaultFilePathNeo))
                {
                    //writer.WriteLine("");
                }
                MessageBox.Show("Default text file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Worker> LoadWorkerToUser(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Worker> workers = new List<Worker>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Worker worker = new Worker();
                            worker.Id = reader["ID"].ToString();
                            worker.Name = reader["Ten"].ToString();
                            worker.Sex = reader["GioiTinh"].ToString();
                            worker.Date = reader["NgaySinh"].ToString();
                            worker.Email = reader["Email"].ToString();
                            worker.WorkingTime = reader["NamKinhNghiem"].ToString();
                            worker.Address = reader["DiaChi"].ToString();
                            worker.Phone = reader["SDT"].ToString();
                            worker.HireTimes = reader["LuotThue"].ToString();
                            worker.HireCost = reader["GiaThue"].ToString();
                            worker.AvgRate = reader["DanhGiaTrungBinh"].ToString();
                            worker.Job = reader["NgheNghiep"].ToString();
                            worker.Describe = reader["MoTa"].ToString();
                            worker.Avatar = reader["Avatar"].ToString();

                            workers.Add(worker);
                        }
                    }
                }
                return workers;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Job> LoadListJob(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Job> jobs = new List<Job>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.IdUser = reader["IDNguoiThue"].ToString();
                            job.NameUser = reader["Ten"].ToString();
                            job.DescribeWork = reader["MoTaCV"].ToString();
                            job.IdWork = reader["MaCV"].ToString();
                            job.IdWorker = reader["IDNguoiLam"].ToString();


                            jobs.Add(job);
                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return jobs;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public bool ThucHienDangNhap(string query)
        {
            Modify modify = new Modify();
            if (modify.Accounts(query).Count != 0)
            {
                StaticPropertyAndField.IncomeID = modify.Accounts(query)[0].UserName;
                StaticPropertyAndField.IncomeName = modify.Accounts(query)[0].Password;
                return true;
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public Worker LoadInComeWorker(string query)
        {
            SqlConnection conn = GetSqlConnection();
            Worker worker = new Worker();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(query, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            worker.Id = reader["ID"].ToString();
                            worker.Name = reader["Ten"].ToString();
                            worker.Address = reader["DiaChi"].ToString();
                            worker.Phone = reader["SDT"].ToString();
                            worker.Email = reader["Email"].ToString();
                            worker.Sex = reader["GioiTinh"].ToString();
                            worker.Date = reader["NgaySinh"].ToString();
                            worker.Cccd = reader["CCCD"].ToString();
                            worker.Account = reader["TenTaiKhoan"].ToString();
                            worker.Pass = reader["MatKhau"].ToString();
                            worker.Active = reader["TrangThai"].ToString();
                            worker.Avatar = reader["Avatar"].ToString();
                        }
                    }
                }
                return worker;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public List<Job> LoadListWorkingDay(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Job> jobs = new List<Job>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.IdWork = reader["MaCV"].ToString();
                            job.DayWork = reader["NgayLam"].ToString();


                            jobs.Add(job);
                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return jobs;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Job> LoadWorkWorking(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Job> jobs = new List<Job>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.IdUser = reader["IDNguoiThue"].ToString();
                            job.IdWorker = reader["IDNguoiLam"].ToString();
                            job.NameWorker = reader["TenNguoiLam"].ToString();
                            job.StatusWork = reader["TrangThaiCV"].ToString();
                            job.DescribeWork = reader["MoTaCV"].ToString();
                            job.IdWork = reader["MaCV"].ToString();


                            jobs.Add(job);
                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return jobs;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Job> LoadWorkWorkingInWorker(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Job> jobs = new List<Job>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.IdUser = reader["IDNguoiThue"].ToString();
                            job.IdWorker = reader["IDNguoiLam"].ToString();
                            job.NameWorker = reader["TenNguoiLam"].ToString();
                            job.StatusWork = reader["TrangThaiCV"].ToString();
                            job.DescribeWork = reader["MoTaCV"].ToString();
                            job.IdWork = reader["MaCV"].ToString();
                            job.NameUser = reader["TenNguoiThue"].ToString();
                            job.FinishDay = reader["NgayHoanThanh"].ToString();
                            job.IsEvaluate = Convert.ToInt32(reader["DaDanhGia"]);
                            job.Rate = Convert.ToSingle(reader["DanhGia"].ToString());

                            jobs.Add(job);
                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return jobs;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public int TakeSalary(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            int Salary = 0;
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Salary = Convert.ToInt32(reader["GiaThue"]);

                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return Salary;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public int TotalSalary(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            int Salary = 0;
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Salary = Convert.ToInt32(reader["TongLuong"]);

                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return Salary;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public string MoneyBalance(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            string Money = "";
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Money = reader["SoDU"].ToString();

                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return Money;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public User UserInfo(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            User user = new User();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = reader["ID"].ToString();
                            user.Name = reader["Ten"].ToString();
                            user.Sex = reader["GioiTinh"].ToString();
                            user.Phone = reader["SDT"].ToString();
                            user.Address = reader["DiaChi"].ToString();
                            user.Cccd = reader["CCCD"].ToString();
                            user.Date = reader["NgaySinh"].ToString();
                            user.Email = reader["Email"].ToString();
                            user.Surplus = reader["SoDU"].ToString();
                            user.Account = reader["TenTaiKhoan"].ToString();
                            user.Pass = reader["MatKhau"].ToString();
                            user.Avatar = reader["Avatar"].ToString();



                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return user;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public int TakeLikeTime(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            int LikeTime = 0;
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LikeTime = Convert.ToInt32(reader["LuotThich"]);

                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                //MessageBox.Show(LikeTime.ToString());
                return LikeTime;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public List<Worker> LoadAllWorker(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Worker> workers = new List<Worker>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Worker worker = new Worker();
                            worker.Id = reader["ID"].ToString();
                            worker.Name = reader["Ten"].ToString();
                            worker.HireTimes = reader["LuotThue"].ToString();
                            worker.AvgRate = reader["DanhGiaTrungBinh"].ToString();
                            worker.Job = reader["NgheNghiep"].ToString();
                            worker.Avatar = reader["Avatar"].ToString();
                            worker.LikeTime1 = Convert.ToInt32(reader["LuotThich"]);

                            workers.Add(worker);
                        }
                    }
                }
                return workers;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Like> LoadListLike(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Like> likes = new List<Like>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Like like = new Like();
                            like.IdUser = reader["IDNguoiThich"].ToString();
                            like.IdWorker = reader["IDTho"].ToString();
                            like.Comment = reader["BinhLuan"].ToString();


                            likes.Add(like);
                        }
                    }
                }
                return likes;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<Comment> LoadComment(string sqlStr)
        {
            SqlConnection conn = GetSqlConnection();
            List<Comment> comments = new List<Comment>();
            try
            {
                conn.Open();
                using (conn)
                {

                    SqlCommand command = new SqlCommand(sqlStr, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comment comment = new Comment();
                            comment.IdUser = reader["IDNguoiThue"].ToString();
                            comment.NameUser = reader["TenNguoiThue"].ToString();
                            comment.IdWorker = reader["IDNguoiLam"].ToString();
                            comment.NameUser = reader["TenNguoiLam"].ToString();
                            comment.IdWork = reader["MaCV"].ToString();
                            comment.MyComment = reader["BinhLuan"].ToString();
                            comment.Rate = Convert.ToSingle(reader["DanhGia"].ToString());
                            comment.FinishDay = reader["NgayHoanThanh"].ToString();


                            comments.Add(comment);
                        }
                    }
                }
                //MessageBox.Show(jobs[0].IdUser);
                return comments;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "DBConnection");
            }
            finally
            {
                conn.Close();
            }
            return null;
        }


        public List<UserPostJob> LoadListJobByUsers(string query)
        {
            List<UserPostJob> Jobs = new List<UserPostJob>();
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Jobs.Add(new UserPostJob(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), 
                        dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(6),dataReader.GetString(7)));
                }
                sqlConnection.Close();
            }
            return Jobs;
        }

        public List<Candidate> LoadListCandidate(string query)
        {
            List<Candidate> Candidates = new List<Candidate>();
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Candidates.Add(new Candidate(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDouble(3).ToString()));
                }
                sqlConnection.Close();
            }
            return Candidates;
        }

        public Dictionary<string, int> CreateDateChart(string query)
        {
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            using (SqlConnection connection = GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ngayLam = reader.GetString(0);
                    int tongLuong = reader.GetInt32(1);
                    resultDictionary.Add(ngayLam, tongLuong);
                }
            }
            return resultDictionary;
        }

        public string TakeOneOjectFloat(string query)
        {
            string obj = "";
            using (SqlConnection connection = GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        obj = reader.GetDouble(0).ToString();

                    }
                    catch 
                    {
                        obj = "0";
                    }
                }
            }
            return obj;
        }
    }
}
