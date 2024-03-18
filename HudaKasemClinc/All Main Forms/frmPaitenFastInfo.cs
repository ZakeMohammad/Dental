using HudaClinc_BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmPaitenFastInfo : Form
    {
        public frmPaitenFastInfo(clsPatients patient)
        {
            InitializeComponent();
            Patient = patient;
        }

        clsPatients Patient;

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

   
        void FillData()
        {
            lblID.Text = Patient.PatientID.ToString();
            lblName.Text = Patient.PatientName;
            if (Patient.Phone == "")
                lblPhone.Text = "null";
            else
                lblPhone.Text = Patient.Phone;

            if(Patient.Email =="")
                lblEmail.Text = "null";
            else
                lblEmail.Text = Patient.Email;

            lblAge.Text=Patient.Age.ToString();

            clsAppointments CurrentAppointment = clsAppointments.FindForPatiantDetelis(Patient.PatientID);

            if (CurrentAppointment != null)
            {
                lblCurrentAppointment.Text = $"{CurrentAppointment.StartTimeHours}:{CurrentAppointment.StartTimeMuinets} - {CurrentAppointment.EndTimeHours}:{CurrentAppointment.EndTImeMuinets} "+$"  {CurrentAppointment.AMOrPM}";
                lblDate.Text = CurrentAppointment.Date.ToShortDateString();
            }
            else
            {
                lblCurrentAppointment.Text = "null";
                lblDate.Text = "v";
            }

            if (Patient.FirstIllness == "")
                illness1.Text = "null";
            else
                illness1.Text = Patient.FirstIllness;
            if (Patient.SecondIllness == "")
                illness2.Text = "null";
            else
                illness2.Text = Patient.SecondIllness;
            if (Patient.ThearedIllness == "")
                illness3.Text = "null";
            else
                illness3.Text = Patient.ThearedIllness;
            if (Patient.FourIllness == "")
                illness4.Text = "null";
            else
                illness4.Text = Patient.FourIllness;
            if (Patient.FiveIllness == "")
                illness5.Text = "null";
            else
                illness5.Text = Patient.FiveIllness;

            decimal Amount = Patient.GitLastPaymentAmount();
            int Number = Patient.GitNumberOfPerspictoin();

            if (Amount != 0)
            {
                lblAmount.Text = $"{Amount}" + " $";
                lblAmount.ForeColor = Color.Green;
            }
            else
                lblAmount.Text = "null";


            if (Number != 0)
            {
                lblNumberOfPrescription.Text = $"{Number}";
                lblNumberOfPrescription.ForeColor = Color.Blue;
            }
            else
                lblNumberOfPrescription.Text = "null";

        }

        private void frmPaitenFastInfo_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
