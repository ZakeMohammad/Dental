using Guna.UI2.WinForms;
using HudaClinc_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    public partial class frmUpdatePrescriptoins : Form
    {
        public frmUpdatePrescriptoins()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Refresch()
        {
          Datemiker.Value = DateTime.Now;
            txtDoctorName.Text = string.Empty;
            Txtname.Text = string.Empty;
            CBMidicen.Items.Add("Empty");
            CBMidicen.SelectedIndex = 0;
            txtNotes.Text = string.Empty;
            txtFillter.Text = string.Empty;
        }
        clsPrescriptions _Prescription;
      
        int docID;
        int PatID;
     
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
          
            FillMed();
        }

        void FillDataToForm(clsPrescriptions Preee)
        {
            txtDoctorName.Text = Preee.Doctors.Name;
            Txtname.Text = Preee.Patients.PatientName;
            Datemiker.Value = Preee.Date;
            txtNotes.Text = Preee.Description;
            CBMidicen.SelectedItem= clsMedicines.Find(Preee.MedicineID).Name;
            docID = Preee.DoctorID;
            PatID = Preee.PatientID;   
        }

        void UpdateData()
        {
            _Prescription.Date = Datemiker.Value;
            _Prescription.DoctorID = docID;
            _Prescription.PatientID = PatID;
            _Prescription.MedicineID = clsMedicines.Find(CBMidicen.SelectedItem.ToString()).ID;
            _Prescription.Description = txtNotes.Text;
        }



        private void frmUpdatePrescriptoins_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
                btnSerarch.PerformClick();
            return;
        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsPrescriptions Preeee;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Preeee = clsPrescriptions.Find(Convert.ToInt32(txtFillter.Text));

            if (Preeee == null)
            {
                MessageBox.Show("Prescription Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnSave.Enabled = false;
              
                return;
            }

            _Prescription = Preeee;
        
            btnSave.Enabled = true;
            FillDataToForm(Preeee);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();

            if (_Prescription.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
