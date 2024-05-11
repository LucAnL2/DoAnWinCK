using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;

namespace DoAnWin.DAOClass
{
    public class CandidateDAO
    {
        DBConnection conn = new DBConnection();

        public void AddCandidate(Candidate candidate)
        {
            //MessageBox.Show(candidate.IdWork);
            string sqlStr = string.Format("INSERT INTO Candidate(IDNguoiLam, TenNguoiLam, MaCV, DanhGia) VALUES (N'{0}', N'{1}', N'{2}', N'{3}')", candidate.Id, candidate.Name, candidate.IdWork, candidate.Role);

            conn.ThucThi(sqlStr);
        }

        public List<Candidate> LoadListCandidate(UserPostJob job)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select IDNguoiLam, TenNguoiLam, MaCV,DanhGia\r\n " +
            "From Candidate " +
            "where MaCV = N'{0}'", job.IDWork);
            return connect.LoadListCandidate(query);
        }
    }
}
