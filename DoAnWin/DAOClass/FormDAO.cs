using DoAnWin.ChildFormWorker;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoAnWin.DAOClass
{
    public class FormDAO
    {
        public static Form activeForm;
        public List<Image> listImageBackground;
        public static string tempPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string defaultFolderPath = Path.Combine(tempPath, "Image");
        public void OpenChildForm(Form childForm, ref Form activeForm, Panel panel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        public void loadWorkerInfo(UserControl uc, FlowLayoutPanel flowLayoutPanel)
        {
            uc.Margin = new Padding(20);
            flowLayoutPanel.Controls.Add(uc);
        }
        public void ExpandButton(ref bool isExpand, FlowLayoutPanel flowLayoutPanel, Guna2GradientButton Button, Timer timer)
        {
            if (isExpand == false)
            {
                
                flowLayoutPanel.Height += 15;
                if (flowLayoutPanel.Height >= flowLayoutPanel.MaximumSize.Height)
                {
                    timer.Stop();
                    isExpand = true;
                }
                Button.HoverState.Image = Properties.Resources.newtrang;
                Button.Image = Properties.Resources.newdowntim;
            }
            else
            {
                flowLayoutPanel.Height -= 15;
                if (flowLayoutPanel.Height <= flowLayoutPanel.MinimumSize.Height)
                {
                    timer.Stop();
                    isExpand = false;
                }
                Button.HoverState.Image = Properties.Resources.newDown;
                Button.Image = Properties.Resources.newtim;
            }
        }
        public void CheckButtonActivate(ref bool check, Guna2GradientButton Button)
        {
            if (check == false)
            {
                Button.HoverState.Image = Properties.Resources.checkboxTrang;
                Button.Image = Properties.Resources.newchecktim;
                check = true;
            }
            else
            {
                Button.HoverState.Image = Properties.Resources.checkwhite;
                Button.Image = Properties.Resources.newsquaretim;
                check = false;
            }
        }
        public void ButtonFalse(ref bool check, Guna2GradientButton Button)
        {
            if (check == true)
            {
                Button.HoverState.Image = Properties.Resources.checkwhite;
                Button.Image = Properties.Resources.check;
                check = false;
            }
        }
        public void UploadAvatar(Guna2CirclePictureBox pic)
        {
            string pathImage;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                string fileName = Path.GetFileName(open.FileName);
                pic.Image = new Bitmap(open.FileName);
                //pic.Image = new Image.FromFile(fileName);
                try
                {
                    File.Copy(open.FileName, Path.Combine(defaultFolderPath, Path.GetFileName(open.FileName)), true);
                }
                catch{ }
                pathImage = Path.Combine(defaultFolderPath, fileName);
                string sqlStr = string.Format("UPDATE Worker SET ID = '{0}', Avatar = '{1}' WHERE ID = '{0}'", StaticPropertyAndField.IncomeID, pathImage);
                DBConnection db = new DBConnection();
                db.ThucThi(sqlStr);
            }
        }
        public void WorkerUploadImage(FlowLayoutPanel panel, string id)
        {
            flowLayoutPanel1 = panel;
            string pathImage;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = open.FileNames;
                try
                {

                    foreach (string fileName in fileNames)
                    {
                        File.Copy(fileName, Path.Combine(defaultFolderPath, Path.GetFileName(fileName)), true);
                        pathImage = Path.Combine(defaultFolderPath, Path.GetFileName(fileName));
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Size = new Size(100, 100);
                        //pic.Click += Pic_Click;
                        pic.Click += (sender, e) => Pic_Click(sender, e, id);
                        //pic.Tag = fileName;
                        pic.Tag = pathImage;
                        pic.Image = Image.FromFile(fileName);
                        string sqlStr = string.Format("INSERT INTO WorkerUploadImage (ID, Image) " +
                         "VALUES  (N'{0}', N'{1}')", id, pathImage);
                        DBConnection db = new DBConnection();
                        db.ThucThi(sqlStr);
                        flowLayoutPanel1.Controls.Add(pic);
                    }
                }
                catch{ }
            }
        }
        private FlowLayoutPanel flowLayoutPanel1;
        private void Pic_Click(object sender, EventArgs e, string id)
        {
            PictureBox clickedPic = sender as PictureBox;
            if (clickedPic != null && clickedPic.Tag != null)
            {
                string fileName = clickedPic.Tag.ToString();
                //File.Delete(Path.Combine(defaultFolderPath, Path.GetFileName(fileName)));
                string sqlStr = string.Format("DELETE FROM WorkerUploadImage WHERE ID = '{0}' AND Image = '{1}'", id, fileName);
                DBConnection db = new DBConnection();
                db.ThucThi(sqlStr);
                flowLayoutPanel1.Controls.Remove(clickedPic);
            }
        }
        public void DeleteAllImage()
        {
            string sqlStr = string.Format("DELETE FROM WorkerUploadImage WHERE ID = '{0}'", StaticPropertyAndField.IncomeID);
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public string[] LoadImageWorkerInUser(string id)
        {
            //string test = "";
            string query = string.Format("Select ID, Image from WorkerUploadImage where ID = '{0}'", id);
            Modify modify = new Modify();
            List<Account> accountList = modify.Accounts(query);
            string[] ImagePath = new string[accountList.Count];
            int count = 0;
            foreach (Account account in accountList)
            {
                ImagePath[count] = account.Password;
                //test += account.Password + "\n";
                count++;
            }
            //for (int i = 0; i < ImagePath.Length - 1; i++)
            //{
            //    test += ImagePath[i] + "";
            //}
            //MessageBox.Show(test);
            return ImagePath;
        }
        public List<Image> CreateListWorkerUploadImage(string[] paths, string id)
        {
            //string test = "";
            //Image[] images;
            List<Image> imagesList = new List<Image>();
            //for (int i = 0; i < paths.Length - 1; i++)
            //{
            //    //images[i] = Image.FromFile(paths[i]);
            //    //test += paths[i] + "\n";
            //    images[i] = new Bitmap(@"" + paths[i]);
            //}
            //MessageBox.Show(test);
            //return images;
            foreach (string path in paths)
            {
                if (!string.IsNullOrEmpty(path))
                {
                    // Kiểm tra xem đường dẫn có hợp lệ không trước khi tạo hình ảnh từ file
                    Image image = Image.FromFile(path);
                    //Image image = new Bitmap(@""+path);
                    //test += path + "\n";
                    imagesList.Add(image);
                }
            }
            //if (imagesList.Count == 0)
            //    MessageBox.Show("0");
            //else
            //{
            //    MessageBox.Show("1");
            //}
            //MessageBox.Show(test);
            return imagesList;
        }
    }
}
