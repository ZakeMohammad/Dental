using HudaClinc_BusinessLayer;
using System;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Payment
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        clsPayments _Pay;
        int id;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Refresch()
        {
            txtname.Text = string.Empty;
            txtnotes.Text = string.Empty;
            Txtamount.Text = string.Empty;
            txtFillter.Text = string.Empty;
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

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }

        void FillDataToForm(clsPayments Pay)
        {
            txtname.Text = Pay.Patient.PatientName;
            Txtamount.Text=Pay.Amount.ToString();
            txtnotes.Text = Pay.Notes.ToString();
            id = Pay.PatientID;
        }
        void UpdateData()
        {
            _Pay.PatientID = id;
            _Pay.Date=_Pay.Date;
            _Pay.AdminID = _Pay.AdminID;
            _Pay.Amount=Convert.ToDecimal(Txtamount.Text);
            _Pay.Notes=txtnotes.Text;
            _Pay.ItsLastOne=_Pay.ItsLastOne;
        }


        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsPayments Pay;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pay = clsPayments.Find(Convert.ToInt32(txtFillter.Text));


            if (Pay == null)
            {
                MessageBox.Show("Patient Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnAdd.Enabled = false;
               
                return;
            }
            _Pay = Pay;

            btnAdd.Enabled = true;
            FillDataToForm(Pay);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateData();
            if (_Pay.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void Txtamount_TextChanged(object sender, EventArgs e)
        {
            if (Txtamount.Text.Length <= 0)
            {
                btnAdd.Enabled = false;
            }
            else
                btnAdd.Enabled = true;
        }

        private void Txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Mark the event as handled, preventing the character from being entered
            }
        }
    }
}
