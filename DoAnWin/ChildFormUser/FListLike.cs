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
    public partial class FListLike : Form
    {
        string idWorker;
        LikeDAO likeDAO = new LikeDAO();
        FormDAO fd = new FormDAO();
        public FListLike()
        {
            InitializeComponent();
        }

        public FListLike(string idWorker)
        {
            InitializeComponent();
            this.idWorker = idWorker;
        }

        private void FListLike_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            List<Like> likes = new List<Like>();
            likes = likeDAO.LoadListLike(idWorker);
            foreach (Like like in likes)
            {
                UCLike uc = new UCLike(like);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }

        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
