using HudaClinc_BusinessLayer;
using System;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Payment
{
    public partial class frnDelete : Form
    {
        public frnDelete()
        {
            InitializeComponent();
        }




        int id;



        private void btnSerarch_Click(object sender, EventArgs e)
        {
            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPayments Pay = clsPayments.Find(Convert.ToInt32(txtFillter.Text));

            if (Pay == null)
            {
                PanelForNO.Visible = true;
                PanelForOk.Visible = false;
                LblNo.Text = $"Payment With ID {txtFillter.Text} Does Not Exist";
                return;
            }
            PanelForOk.Visible = true;
            PanelForNO.Visible = false;
            lblName1.Text = clsPatients.Find(Pay.PatientID).PatientName;
            lblDate1.Text=Pay.Date.ToShortDateString();
            lblAmount1.Text=Pay.Amount.ToString()+" $";
            id = Pay.PaymentID;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsPayments.Delete(id))
                MessageBox.Show("Data Deleted Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
          this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
