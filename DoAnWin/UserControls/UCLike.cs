using DoAnWin.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.UserControls
{
    public partial class UCLike : UserControl
    {
        Like like;
        public UCLike()
        {
            InitializeComponent();
        }

        public UCLike(Like like)
        {
            InitializeComponent();
            this.like = like;
            lblID.Text = like.IdUser.ToString();
            txtComment.Text = like.Comment;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCLike_Load(object sender, EventArgs e)
        {

        }
    }
}
