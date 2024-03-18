using HudaClinc_BusinessLayer;
using HudaKasemClinc.All_Main_Forms.Payment;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

            FillData();
        }

      

        Form CurrentForm;
        private void OpenCountainrForm(Form CountainrForm)
        {
            if (CurrentForm != null)
                CurrentForm.Close();

            CurrentForm = CountainrForm;
            CountainrForm.TopLevel = false;

            StaticPanel.Controls.Add(CountainrForm);
            CountainrForm.Dock = DockStyle.Fill;
            CountainrForm.BringToFront();
            CountainrForm.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ListPay))
            {
                frmall frm = new frmall();
                OpenCountainrForm(frm);
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.AddPay))
            {
                frnadd frm = new frnadd();
                OpenCountainrForm(frm);
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpdatePay))
            {
                frmUpdate frm = new frmUpdate();
                OpenCountainrForm(frm);
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.DeletPay))
            {
                frnDelete frm = new frnDelete();
                OpenCountainrForm(frm);
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
         
        }


        void FillData()
        {
            DataTable dt = clsPayments.All2();

            int counter = 0;

            foreach (DataRow dr in dt.Rows)
            {
                counter++;
                if (counter == 1)
                {
                    lblName1.Text = dr["PatientName"].ToString();
                    lblDate1.Text = dr["Date"].ToString();
                    lblAmount1.Text = dr["Amount"].ToString() + " $";
                }
                if (counter == 2)
                {
                    lblName2.Text = dr["PatientName"].ToString();
                    lblDate2.Text = dr["Date"].ToString();
                    lblAmount2.Text = dr["Amount"].ToString() + " $";
                }
                if (counter == 3)
                {
                    lblName3.Text = dr["PatientName"].ToString();
                    lblDate3.Text = dr["Date"].ToString();
                    lblAmount3.Text = dr["Amount"].ToString() + " $";
                }
                if (counter == 4)
                {
                    lblName4.Text = dr["PatientName"].ToString();
                    lblDate4.Text = dr["Date"].ToString();
                    lblAmount4.Text = dr["Amount"].ToString() + " $";
                }

            }
        }




    }
}
