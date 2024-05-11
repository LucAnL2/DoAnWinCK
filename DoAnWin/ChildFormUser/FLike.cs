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
using DoAnWin.Properties;
using DoAnWin.PropertyClass;

namespace DoAnWin.ChildFormUser
{
    public partial class FLike : Form
    {
        string idTho;
        LikeDAO ld= new LikeDAO();
        WorkerDAO workerDAO = new WorkerDAO();
        public FLike()
        {
            InitializeComponent();
        }

        public FLike(string idUser, string idTho)
        {
            InitializeComponent();
            this.idTho = idTho;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FLike_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            ld.InsertLike(StaticPropertyAndField.IncomeID, idTho, txtComment.Text);
            int LikeTime = workerDAO.TakeLikeTime(idTho) + 1;
            //MessageBox.Show(LikeTime.ToString());
            workerDAO.UpdateLikeTimes(LikeTime, idTho);
        }
    }
}
