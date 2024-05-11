using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.ChildFormUser
{
    public partial class FCommentInUser : Form
    {
        string idworker;
        List<Comment> comments = new List<Comment>();
        CommentDAO commentDAO = new CommentDAO();
        public FCommentInUser()
        {
            InitializeComponent();
        }

        public FCommentInUser(string idworker)
        {
            InitializeComponent();
            this.idworker = idworker;
            comments = commentDAO.LoadComment(idworker);
            foreach (Comment comment in comments)
            {
                UComment uc = new UComment(comment);
                if (comment.Rate >= 4)
                    uc.Tag = "positive";
                else
                    uc.Tag = "negative";
                flowPanelContain.Controls.Add(uc);

            }
        }

        private void FCommentInUser_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void Display(string tagg)
        {
            foreach (Control item in flowPanelContain.Controls)
            {
                if ((string)item.Tag == tagg)
                {
                    item.Show();
                }
                else
                {
                    item.Hide();
                }
            }
        }

        private void DisplayAll()
        {
            foreach (Control item in flowPanelContain.Controls)
            {
                item.Show();
            }
        }

        private void rbPosivive_CheckedChanged(object sender, EventArgs e)
        {
            Display("positive");
        }

        private void rbNegative_CheckedChanged(object sender, EventArgs e)
        {
            Display("negative");
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            DisplayAll();
        }
    }
}
