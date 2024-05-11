using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.ChildFormUser;
using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;

namespace DoAnWin.UserControls
{
    public partial class UCWorkerUploadInfo : UserControl
    {
        int count = 0;
        Worker worker;
        string title;
        FormDAO formDAO = new FormDAO();
        public UCWorkerUploadInfo()
        {
            InitializeComponent();
            picImage.BackgroundImage = DefaultBackground.Images[0];
        }
        public UCWorkerUploadInfo(Worker worker, string title)
        {
            InitializeComponent();
            this.title = title;
            this.worker = worker;
        }

        private void UCWorkerUploadInfo_Load(object sender, EventArgs e)
        {
            float valueRate = float.Parse(worker.AvgRate);
            lblID.Text = "ID: " + worker.Id;
            lblName.Text = "Tên: " + worker.Name;
            lblAddress.Text = "Địa chỉ: " + worker.Address;
            lblAge.Text = "Tuổi: " + worker.TuoiHople(worker.Date).ToString();
            lblPhone.Text = "SĐT: " + worker.Phone;
            RSRate.Value = valueRate;
            //
            lblHireCost.Text = "Giá thuê: " + worker.HireCost;
            //string[] listPath = formDAO.LoadImageWorkerInUser(worker.Id);
            //string test = "";
            //for (int i = 0; i < listPath.Length; i++)
            //{
            //    test += listPath[i] + "\n";
            //}
            //MessageBox.Show(test);

            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(worker.Id), worker.Id);
            if ( images.Count!=0 && images!= null)
            {
                WorkerBackground.Images.AddRange(images.ToArray());
                picImage.BackgroundImage = WorkerBackground.Images[0];
            }
            else
                picImage.BackgroundImage = DefaultBackground.Images[0];
        }
        private void panelContain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(worker.Id), worker.Id);
            if (images.Count != 0 && images != null)
            {
                WorkerBackground.Images.AddRange(images.ToArray());
                if (count < images.ToArray().Length - 1) { count++; }
                picImage.BackgroundImage = WorkerBackground.Images[count];
            }
            else
            {
                if (count < StaticPropertyAndField.listDefaultBackground.Length - 1) { count++; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
    }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            List<Image> images = formDAO.CreateListWorkerUploadImage(formDAO.LoadImageWorkerInUser(worker.Id), worker.Id);
            if (images.Count != 0 && images != null)
            {
                WorkerBackground.Images.AddRange(images.ToArray());
                if (count > 0) { count--; }
                picImage.BackgroundImage = WorkerBackground.Images[count];
            }
            else
            {
                if (count > 0) { count--; }
                picImage.BackgroundImage = DefaultBackground.Images[count];
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            fd.OpenChildForm(new ChildFormUser.FDetailWorkerInUser(worker, title), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        private void btnLike_CheckedChanged(object sender, EventArgs e)
        {
            if(btnLike.Checked)
            {
                FLike fLike = new FLike(StaticPropertyAndField.IncomeID, worker.Id);
                fLike.ShowDialog();
            }
        }
    }
}
