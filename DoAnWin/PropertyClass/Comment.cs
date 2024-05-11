using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnWin.PropertyClass
{
    public class Comment : Job
    {
        private string mycomment;
        //private float rate;

        public Comment() { }

        public Comment(string idUser, string nameUser, string idWorker, string nameWorker,string idWork, string FinishDay, string comment, float Rate) :base(idUser, nameUser, idWorker, nameWorker, idWork,FinishDay, Rate)
        {
            this.mycomment = comment;
            //this.rate = Rate;
        }

        public string MyComment { get => mycomment; set => mycomment = value; }
        //public float Rate { get => rate; set => rate = value; }
        public static bool checkNullComment(Comment comment)
        {
            if(comment.mycomment == "")
            {
                MessageBox.Show("Vui lòng bình luận để thực hiện đánh giá");
                return false;
            }
            return true;
        }
    }
}
