using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Payment
{
    public partial class frnadd : Form
    {
        public frnadd()
        {
            InitializeComponent();
        }
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void FillPatients()
        {
            CBPatients.Items.Clear();


            DataTable Patient = clsPatients.All();

            foreach (DataRow row in Patient.Rows)
            {
                CBPatients.Items.Add(row["PatientName"].ToString());
            }
        }
        private void frnadd_Load(object sender, EventArgs e)
        {
            FillPatients();
            CBPatients.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsPayments Pay=new clsPayments();


            Pay.PatientID= clsPatients.Find(CBPatients.SelectedItem.ToString()).PatientID;

            Pay.Date=DateTime.Now;
            Pay.Notes=txtnotes.Text;
            Pay.AdminID = clsGlobal.CurrentAdmin.AdminID;
            Pay.Amount= Convert.ToDecimal(Txtamount.Text);
            Pay.ItsLastOne = true;

                if (Pay.Save())
                {
                    if (clsPatients.DisabelPayments(Pay.PatientID,Pay.PaymentID))
                        MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Please Enter Valid Amount", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            this.Close();
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(Txtamount.Text.Length <= 0)
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
                e.Handled = true; 
            }
        }
    }
}
