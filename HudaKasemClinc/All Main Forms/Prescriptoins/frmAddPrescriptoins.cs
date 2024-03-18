using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    public partial class frmAddPrescriptoins : Form
    {
        public frmAddPrescriptoins()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        clsPatients Patent;
        clsDoctors Doctor;
        void FillPatients()
        {
            CBPatients.Items.Clear();


            DataTable Patient = clsPatients.All();

            foreach (DataRow row in Patient.Rows)
            {
                CBPatients.Items.Add(row["PatientName"].ToString());
            }
            if (CBPatients.Items.Count == 0)
                CBPatients.Items.Add("No Patients in system");
        }
        void FillDoctors()
        {
            CBDoctors.Items.Clear();


            DataTable Doctors = clsDoctors.All();

            foreach (DataRow row in Doctors.Rows)
            {
                CBDoctors.Items.Add(row["Name"].ToString());
            }
           
            if (CBDoctors.Items.Count == 0)
                CBDoctors.Items.Add("No Doctors in system");
        }

        void FillMed()
        {
            CBMidicen.Items.Clear();


            DataTable Mides = clsMedicines.All();

            foreach (DataRow row in Mides.Rows)
            {
                CBMidicen.Items.Add(row["Name"].ToString());
            }

            if (Mides.Rows.Count == 0)
                CBMidicen.Items.Add("No Medicine in system");
        }
        void FillComboBoxes()
        {
            FillPatients();
            FillDoctors();
            FillMed();
        }
        private void frmAddPrescriptoins_Load(object sender, System.EventArgs e)
        {
            FillComboBoxes();
            CBDoctors.SelectedIndex = 0;
            CBPatients.SelectedIndex = 0;
            CBMidicen.SelectedIndex = 0;
            lblDate.Text=clsGlobal.CurrentDateFortoday.ToString();
        }

        private void CBPatients_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Patent=clsPatients.Find(CBPatients.SelectedItem.ToString());
            lblAge.Text=Patent.Age.ToString();
            if (Patent.Phone != "")
                lblPHone.Text = Patent.Phone.ToString();
            else
                lblPHone.Text = "null";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            clsPrescriptions Pre= new clsPrescriptions();   

            Pre.PatientID =clsPatients.Find(CBPatients.SelectedItem.ToString()).PatientID;
            Pre.DoctorID = clsDoctors.Find(CBDoctors.SelectedItem.ToString()).DoctorID;
            Pre.Description=txtnotes.Text;
            Pre.MedicineID= clsMedicines.Find(CBMidicen.SelectedItem.ToString()).ID;
            Pre.Date = DateTime.Now;

            if(Pre.Save())
                MessageBox.Show("Data Added Succssfilly","Huda Clinc",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
        }

    }
}
