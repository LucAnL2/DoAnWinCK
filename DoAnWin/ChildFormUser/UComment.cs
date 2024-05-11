using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoAnWin.UserControls
{
    public partial class UComment : UserControl
    {
        FormDAO formDAO = new FormDAO();
        Comment comment;
        int count = 0;

        public UComment()
        {
            InitializeComponent();
        }

        public UComment(Comment comment)
        {
            InitializeComponent();
            this.comment = comment;
            lblName.Text = comment.NameUser;
            txtComment.Text = comment.MyComment;
            RSRate.Value = comment.Rate;


            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(comment.IdWork), comment.IdWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                picImage.BackgroundImage = ImageBackground.Images[0];
            }
            else
                picImage.BackgroundImage = DefaultBackground.Images[0];
        }

        private void UComment_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(comment.IdWork), comment.IdWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                if (count < images.ToArray().Length - 1) { count++; }
                picImage.BackgroundImage = ImageBackground.Images[count];
            }
            else
            {
                if (count < StaticPropertyAndField.listDefaultBackground.Length - 1) { count++; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(comment.IdWork), comment.IdWork);
            if (images.Count != 0 && images != null)
            {
                ImageBackground.Images.AddRange(images.ToArray());
                if (count > 0) { count--; }
                picImage.BackgroundImage = ImageBackground.Images[count];
            }
            else
            {
                if (count > 0) { count--; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
        }
    }
}
