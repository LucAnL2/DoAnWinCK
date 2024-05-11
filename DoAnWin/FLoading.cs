using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin
{
    public partial class FLoading : Form
    {
        int isForm;
        public FLoading(int isForm)
        {
            InitializeComponent();
            this.isForm = isForm;
        }
        private int _value = 0;
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                this.Hide();
                timerLoading.Stop();
                if(isForm == 1)
                {
                    FWorker fWorker = new FWorker();
                    fWorker.ShowDialog();
                }
                else
                {
                    FUser fUser = new FUser();
                    fUser.ShowDialog();
                }
                this.Close();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                _value += 1;
                lblValue.Text = _value.ToString() + "%";
            }
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FLoading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timerLoading.Start();
        }
    }
}
