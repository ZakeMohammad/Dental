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
using System.Xml.Linq;

namespace HudaKasemClinc.All_Main_Forms.Doctors
{
    public partial class frmUpdateDoctor : Form
    {
        public frmUpdateDoctor()
        {
            InitializeComponent();
        }
        void Refresch()
        {
            TxtName.Text = string.Empty;
            Txtphone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtAdres.Text = string.Empty;
        }

        clsDoctors _Doctor;


        void FillDataToForm(clsDoctors Doctor)
        {
            TxtName.Text = Doctor.Name;
            Txtphone.Text = Doctor.Phone;
            TxtEmail.Text = Doctor.Email;
            TxtAdres.Text = Doctor.Adrees;

        }



        void UpdateData()
        {
            _Doctor.Name = TxtName.Text;
            _Doctor.Phone = Txtphone.Text;
            _Doctor.Email = TxtEmail.Text;
            _Doctor.Adrees = TxtAdres.Text;

        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {

            clsDoctors Doctor;
            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (guna2ComboBox1.SelectedIndex == 0)
                Doctor = clsDoctors.Find(Convert.ToInt32(txtFillter.Text));
            else
                Doctor = clsDoctors.Find(txtFillter.Text);

            if (Doctor == null)
            {
                MessageBox.Show("Doctor Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnSave.Enabled = false;
                guna2WinProgressIndicator1.Visible = false;
                return;
            }
            _Doctor = Doctor;
            guna2WinProgressIndicator1.Visible = true;
            btnSave.Enabled = true;
            FillDataToForm(Doctor);
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
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
            if (_Doctor.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
