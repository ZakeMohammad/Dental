using HudaClinc_BusinessLayer;
using HudaKasemClinc.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HudaKasemClinc.All_Main_Forms.Admin
{
    public partial class frmChangePaswoord : Form
    {
        public frmChangePaswoord()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        clsAdmins _Adm;

        string CurrentPassword;
        void Refresch()
        {
            txtconfrim.Text = string.Empty;
            txtFillter.Text = string.Empty;
            txtnew.Text = string.Empty;
            Pictre.Image = Resources.admin;
            txtOldPasw.Text = string.Empty;
        }
        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsAdmins Adm;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Adm = clsAdmins.Find(Convert.ToInt32(txtFillter.Text));


            if (Adm == null)
            {
                MessageBox.Show("Admin Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnChange.Enabled = false;

                return;
            }
            _Adm = Adm;
            FillDataToForm(Adm);
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


        void FillDataToForm(clsAdmins Adm)
        {
            lblUserna.Text = Adm.Username;

            if (Adm.Image != "" && Adm.Image != null)
            {
                Pictre.Image = Image.FromFile(Adm.Image);
            }
            else
                Pictre.Image = Resources.admin;

            _Adm = Adm;
            CurrentPassword=Adm.Password;
        }

        private void txtnew_TextChanged(object sender, EventArgs e)
        {
            if(txtnew.Text.Length==0)
            {
                btnChange.Enabled=false;
            }
            else
                btnChange.Enabled = true;
        }

        private void txtconfrim_Validating(object sender, CancelEventArgs e)
        {
            if(txtconfrim.Text!=txtnew.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtconfrim, "Please Enter Same Password.");
                txtconfrim.Focus();
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtconfrim, "");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if(txtOldPasw.Text!=CurrentPassword)
            {
                MessageBox.Show("Your password is incorrect. Please enter your password correctly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtconfrim.Text = string.Empty;
                txtnew.Text = string.Empty;

                return;
            }


            if(clsAdmins.UpdatePaswword(txtnew.Text,_Adm.AdminID))
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Update failed", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            Refresch();

        }
    }
}
