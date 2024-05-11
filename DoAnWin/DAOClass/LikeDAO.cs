using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;

namespace DoAnWin.DAOClass
{
    public class LikeDAO
    {
        public void InsertLike(string idUser, string idWorker, string comment)
        {
            string sqlStr = string.Format("INSERT INTO LikeTable(IDNguoiThich , IDTho, BinhLuan) VALUES (N'{0}', N'{1}', N'{2}')", idUser, idWorker, comment);
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);

        }

        public List<Like> LoadListLike(string idW)
        {
            string query = string.Format("select IDNguoiThich, IDTho, BinhLuan from LikeTable where IDTho = N'{0}'", idW);
            DBConnection db = new DBConnection();
            return db.LoadListLike(query);
        }
    }
}
