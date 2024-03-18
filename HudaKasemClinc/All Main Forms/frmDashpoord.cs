using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmDashpoord : Form
    {
        public frmDashpoord()
        {
            InitializeComponent();
        }

        private void frmDashpoord_Load(object sender, EventArgs e)
        {
            List<int> Numbes = clsGlobal.AllNumbers();

            lblAd.Text = Numbes[0].ToString();
            lblApp.Text = Numbes[1].ToString();
            lblPre.Text = Numbes[2].ToString();
            lblPay.Text = Numbes[3].ToString();
            lblNumberPatinets.Text = Numbes[4].ToString();
            lblMed.Text = Numbes[5].ToString();
            lblTre.Text = Numbes[6].ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
