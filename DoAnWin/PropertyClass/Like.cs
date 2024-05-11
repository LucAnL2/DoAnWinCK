using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.PropertyClass
{
    public class Like
    {
        private string idUser;
        private string nameUser;
        private string idWorker;
        private string nameWorker;
        private string comment;
        public Like() { }

        public Like(string idUser, string nameUser, string idWorker, string comment)
        {
            IdUser = idUser;
            NameUser = nameUser;
            IdWorker = idWorker;
            Comment = comment;
        }

        public string IdUser { get => idUser; set => idUser = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string IdWorker { get => idWorker; set => idWorker = value; }
        public string NameWorker { get => nameWorker; set => nameWorker = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
