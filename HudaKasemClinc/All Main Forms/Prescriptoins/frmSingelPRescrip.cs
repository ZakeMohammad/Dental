using System;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    public partial class frmSingelPRescrip : Form
    {
        public frmSingelPRescrip(int pReID)
        {
            InitializeComponent();
            PReID = pReID;
        }


        int PReID;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSingelPRescrip_Load(object sender, EventArgs e)
        {
            ctrlPrescriptoinsCard1.FillData(PReID);
        }
    }
}
