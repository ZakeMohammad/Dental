using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmSingelApp : Form
    {
        public frmSingelApp(int appid)
        {
            InitializeComponent();
            AppID = appid;
        }
        int AppID;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmSingelApp_Load(object sender, EventArgs e)
        {
            ctrlAppointmentCard1.FillData(AppID);
           lblDate.Text= ctrlAppointmentCard1.Date;

        }
    }
}
