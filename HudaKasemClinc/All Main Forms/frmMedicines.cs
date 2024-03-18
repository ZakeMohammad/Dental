using HudaClinc_BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmMedicines : Form
    {
        public frmMedicines()
        {
            InitializeComponent();
        }

        private void RDCheakAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (RDCheakAdd.Checked == true)
            {
                GropAdd.Visible = true;
                GropUpdate.Visible = false;
                RDChekUpdate.Checked = false;
            }
            else
            {
                GropAdd.Visible = false;
            }
              
        }
        private void RDChekUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(RDChekUpdate.Checked == true)
            {
                GropUpdate.Visible = true;
                GropAdd.Visible=false;
                RDCheakAdd.Checked = false;
            }
            else
            {
                GropUpdate.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void RefreshMenu()
        {
            DataTable Pre = clsMedicines.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in Pre.Rows)
            {
                ctrlMedicine menuiteminfo = new ctrlMedicine();


                menuiteminfo.FillData(Convert.ToInt32(Row["ID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }
        private void frmMedicines_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        clsMedicines _Med;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            clsMedicines Med=new clsMedicines();

            Med.Name = txtNameAdd.Text;
            Med.Price = Convert.ToDecimal(txtPriceAdd.Text);

            if (Med.Save())
                MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             else
                MessageBox.Show("Plese Enter Valid Data", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            Refresch();
            RDCheakAdd.Checked = false;
            frmMedicines_Load(null,null);
        }

 
        private void txtNameAdd_Validating(object sender, CancelEventArgs e)
        {
            if(RDCheakAdd.Checked)
            {
                if(txtNameAdd.Text.Length==0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNameAdd, "Plese Enter Valid Data");
                    txtNameAdd.Focus();
                }
                else
                {
                    e.Cancel= false;
                    errorProvider1.SetError(txtNameAdd, "");
                }
            }

        }

        private void txtNameUpd_Validating(object sender, CancelEventArgs e)
        {
            if (RDChekUpdate.Checked)
            {
                if (txtNameUpd.Text.Length == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNameUpd, "Plese Enter Valid Data");
                    txtNameUpd.Focus();
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtNameUpd, "");
                }
            }
        }

        private void txtPriceAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void txtPriceUPd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void txtNameUpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNameAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
            }
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


        void FillDataToForm(clsMedicines Med)
        {
            txtPriceUPd.Text = Med.Price.ToString();
            txtNameUpd.Text = Med.Name;
        }
        void UpdateData()
        {
            _Med.Price =Convert.ToDecimal(txtPriceUPd.Text);
             _Med.Name = txtNameUpd.Text;
        }
        void Refresch()
        {
            txtFillter.Text = string.Empty;
            txtNameUpd.Text = string.Empty;
            txtPriceUPd.Text = string.Empty;
            txtNameAdd.Text= string.Empty;
            txtPriceAdd.Text= string.Empty;
        }
        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsMedicines MEd;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MEd = clsMedicines.Find((Convert.ToInt32(txtFillter.Text)));


            if (MEd == null)
            {
                MessageBox.Show("Prescription Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnUdpate.Enabled = false;
                return;
            }

            _Med = MEd;

            btnUdpate.Enabled = true;
            FillDataToForm(MEd);
        }

        private void btnUdpate_Click(object sender, EventArgs e)
        {
            UpdateData();

            if (_Med.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Refresch() ;
            RDChekUpdate.Checked = false;
            btnUdpate.Enabled = false;
            frmMedicines_Load(null, null);
        }

        private void txtPriceUPd_Validating(object sender, CancelEventArgs e)
        {
            if (RDChekUpdate.Checked)
            {
                if (txtPriceUPd.Text.Length == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPriceUPd, "Plese Enter Valid Data");
                    txtPriceUPd.Focus();
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPriceUPd, "");
                }
            }
        }

        private void txtPriceAdd_Validating(object sender, CancelEventArgs e)
        {
            if (RDCheakAdd.Checked)
            {
                if (txtPriceAdd.Text.Length == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPriceAdd, "Plese Enter Valid Data");
                    txtPriceAdd.Focus();
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPriceAdd, "");
                }
            }
        }



    }
}
