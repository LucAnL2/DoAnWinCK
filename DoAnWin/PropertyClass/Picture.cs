using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.PropertyClass
{
    public class Picture
    {
        private string id;
        private string pic;
        public Picture()
        {

        }
        public Picture(string id, string pic)
        {
            this.id = id;
            this.pic = pic;
        }
        public string Id { get => id; set => id = value; }
        public string Pic { get => pic; set => pic = value; }
    }
}
