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
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }



        private void NumberAge_ValueChanged_1(object sender, EventArgs e)
        {
            lblAge.Text = NumberAge.Value.ToString();
        }

        private void RDYes_CheckedChanged(object sender, EventArgs e)
        {
            GropBoxForillnesses.Enabled = true;
        }

        private void RDNo_CheckedChanged(object sender, EventArgs e)
        {
            GropBoxForillnesses.Enabled = false;
            illnesses1.Text = string.Empty;
            illnesses2.Text = string.Empty;
            illnesses3.Text = string.Empty;
            illnesses4.Text = string.Empty;
            illnesses5.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren()) 
                return;

            clsPatients NewPatient=new clsPatients();

            NewPatient.PatientName=TxtName.Text;
            NewPatient.Phone=TxtPhone.Text;
            NewPatient.Email=TxtEnail.Text;
            NewPatient.Age=Convert.ToInt32(NumberAge.Value); 
            NewPatient.FirstIllness=illnesses1.Text;
            NewPatient.SecondIllness = illnesses2.Text;
            NewPatient.ThearedIllness = illnesses3.Text;
            NewPatient.FourIllness = illnesses4.Text;
            NewPatient.FiveIllness = illnesses5.Text;
            NewPatient.RequiredTreatment = CBAllTreatment.SelectedIndex + 1;

            if(NewPatient.Save())
                MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if(TxtName.Text.Length <4)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Valid Name");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(TxtName, "");
            }
        }



    }
}
