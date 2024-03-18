using HudaClinc_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Doctors
{
    public partial class frmAddDoctor : Form
    {
        public frmAddDoctor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtName.Text.Length < 4)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Valid Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

          clsDoctors NewDoctor= new clsDoctors();

            NewDoctor.Name=TxtName.Text;
            NewDoctor.Phone=Txtphone.Text;
            NewDoctor.Email=TxtEmail.Text;
            NewDoctor.Adrees=TxtAdres.Text;

            if (NewDoctor.Save())
                MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();

        }

 
        private void TxtAdres_TextChanged(object sender, EventArgs e)
        {
            if (TxtAdres.Text.Length < 4)
            {
                btnAdd.Enabled = false;
            }
            else
                btnAdd.Enabled = true;
        }
    }
}
