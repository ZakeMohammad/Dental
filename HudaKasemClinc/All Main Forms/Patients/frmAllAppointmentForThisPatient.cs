using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Patients
{
    public partial class frmAllAppointmentForThisPatient : Form
    {
        public frmAllAppointmentForThisPatient(int patientID)
        {
            InitializeComponent();
            PatientID = patientID;
        }
        int PatientID;

        DataTable All;
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

        private void frmAllAppointmentForThisPatient_Load(object sender, EventArgs e)
        {
            All= clsPatients.AllAppointmentForThisPateint(PatientID); ;
            DGVALlAppointment.DataSource = All;
        }

        private void CBFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBFillter.SelectedIndex==0)
            {
                DataView dataView = All.DefaultView;

                dataView.RowFilter = "";
                CBStatus.Visible = false;
            }
            else
                CBStatus.Visible= true;
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = All.DefaultView;

            string FillterFor = "";

            if (CBStatus.SelectedIndex == 0)
            {
                FillterFor = "Active";
            }
            if (CBStatus.SelectedIndex == 1)
            {
                FillterFor = "Done Successfully";
            }
            if (CBStatus.SelectedIndex == 2)
            {
                FillterFor = "Canceled";
            }


            dataView.RowFilter = string.Format("[StatusName] like '{0}%'", FillterFor);
        }
    }
}
