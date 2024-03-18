using HudaClinc_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Patients
{
    public partial class frmUpdatePatient : Form
    {
        public frmUpdatePatient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        clsPatients _Patient;

        void Refresch()
        {
            Txtname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtage.Text = string.Empty;
            CBAllTreatment.SelectedIndex = -1;
            illnesses1.Text= string.Empty;
            illnesses2.Text= string.Empty;
            illnesses3.Text= string.Empty;
            illnesses4.Text= string.Empty;
            illnesses5.Text= string.Empty; 
        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsPatients Patient;
           
            if(txtFillter.Text==string.Empty||txtFillter.Text=="0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (guna2ComboBox1.SelectedIndex == 0)
                Patient = clsPatients.Find(Convert.ToInt32(txtFillter.Text));
            else
                Patient = clsPatients.Find(txtFillter.Text);

            if(Patient == null )
            {
                MessageBox.Show("Patient Does Not Exist...","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Refresch();
                btnSave.Enabled = false;
                guna2WinProgressIndicator1.Visible = false;
                return;
            }
            _Patient=Patient;
            guna2WinProgressIndicator1.Visible = true;
            btnSave.Enabled = true;
            FillDataToForm(Patient);
        }


        void FillDataToForm(clsPatients patient)
        {
            Txtname.Text = patient.PatientName;
            txtphone.Text = patient.Phone;
            txtemail.Text = patient.Email;
            txtage.Text=patient.Age.ToString();
            CBAllTreatment.SelectedItem = clsTreatments.Find(patient.RequiredTreatment).Name;
            if (patient.NeedReview)
                RDYes.Checked = true;
            else
                RDNo.Checked = true;

            illnesses1.Text=patient.FirstIllness;
            illnesses2.Text=patient.SecondIllness;
            illnesses3.Text = patient.ThearedIllness;
            illnesses4.Text = patient.FourIllness;
            illnesses5.Text = patient.FiveIllness;
        }

        //clsPatients.Find(CBPatients.SelectedItem.ToString()).PatientID;

        void UpdateData()
        {
            _Patient.PatientName = Txtname.Text;
            _Patient.Phone=txtphone.Text;
            _Patient.Email=txtemail.Text;
            _Patient.Age=Convert.ToInt32(txtage.Text);
            _Patient.RequiredTreatment = clsTreatments.Find(CBAllTreatment.SelectedItem.ToString()).TreatmentID;
            if (RDNo.Checked)
                _Patient.NeedReview = false; 
            else
                _Patient.NeedReview = true;
            _Patient.FirstIllness = illnesses1.Text;
            _Patient.SecondIllness = illnesses2.Text;
            _Patient.ThearedIllness = illnesses3.Text;
            _Patient.FourIllness = illnesses4.Text;
            _Patient.FiveIllness = illnesses5.Text;
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex==0)
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
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == (char)Keys.Enter)
                    btnSerarch.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();
            if (_Patient.Save())
                MessageBox.Show("Data Updated Succssfilly","Huda Clinc",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            if(txtage.Text.Length == 0)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }
    }
}
