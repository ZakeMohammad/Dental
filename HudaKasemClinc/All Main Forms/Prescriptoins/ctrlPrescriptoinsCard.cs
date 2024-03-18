using HudaClinc_BusinessLayer;
using System;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    public partial class ctrlPrescriptoinsCard : UserControl
    {
        public ctrlPrescriptoinsCard()
        {
            InitializeComponent();
        }

        int MedID;


        public void FillData(int medID)
        {
            MedID = medID;
            clsPrescriptions Pre = clsPrescriptions.Find(medID);

            lblID.Text="#"+medID.ToString();
            lblPatient.Text = Pre.Patients.PatientName;
            lblDoctor.Text = Pre.Doctors.Name;
            lblDate.Text = Pre.Date.ToShortDateString();
            lblMed.Text = Pre.Medicines.Name;
            guna2TextBox1.Text = Pre.Description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(clsPrescriptions.Delete(MedID))
                MessageBox.Show("Data Deleted Succssfilly","Huda Clinc",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
         
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
