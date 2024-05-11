using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWin.PropertyClass;
using DoAnWin.NormalClass;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace DoAnWin.DAOClass
{
    public class CommentDAO
    {
        public bool AddComment(Comment comment)
        {
            DBConnection conn = new DBConnection();
            if(Comment.checkNullComment(comment))
            {
                string sqlStr = string.Format("INSERT INTO Comment(IdNguoiThue,TenNguoiThue , IdNguoiLam, TenNguoiLam, MaCV, BinhLuan, DanhGia, NgayHoanThanh) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')", comment.IdUser, comment.NameUser, comment.IdWorker, comment.NameWorker, comment.IdWork, comment.MyComment, comment.Rate, comment.FinishDay);
                conn.ThucThi(sqlStr);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public List<Comment> LoadComment(string id)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("Select distinct * " +
                "from Comment " +
                "where Comment.IDNguoiLam = N'{0}' ", id);

            return connect.LoadComment(query);
        }
    }
}
