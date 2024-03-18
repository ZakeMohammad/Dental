using HudaClinc_BusinessLayer;
using HudaKasemClinc.All_Main_Forms.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmTreatments : Form
    {
        public frmTreatments()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (RDChekUpdate.Checked == true)
            {
                GropUpdate.Visible = true;
                GropAdd.Visible = false;
                RDCheakAdd.Checked = false;
            }
            else
            {
                GropUpdate.Visible = false;
            }
        }


        void RefreshMenu()
        {
            DataTable Pre = clsTreatments.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in Pre.Rows)
            {
                ctrlTreatment menuiteminfo = new ctrlTreatment();


                menuiteminfo.FillData(Convert.ToInt32(Row["TreatmentID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }

        private void frmTreatments_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        clsTreatments _Ter;
        void Refresch()
        {
            txtFillter.Text = string.Empty;
            txtNameUpd.Text = string.Empty;
            txtPriceUPd.Text = string.Empty;
            txtNameAdd.Text = string.Empty;
            txtPriceAdd.Text = string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            clsTreatments Ter = new clsTreatments();

            Ter.Name = txtNameAdd.Text;
            Ter.Price = Convert.ToDecimal(txtPriceAdd.Text);

            if (Ter.Save())
                MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Plese Enter Valid Data", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            Refresch();
            RDCheakAdd.Checked = false;
            frmTreatments_Load(null, null);
        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsTreatments Ter;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ter = clsTreatments.Find((Convert.ToInt32(txtFillter.Text)));


            if (Ter == null)
            {
                MessageBox.Show("Treatment Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnUdpate.Enabled = false;
                return;
            }

            _Ter = Ter;

            btnUdpate.Enabled = true;
            FillDataToForm(Ter);
        }
        void FillDataToForm(clsTreatments Ter)
        {
            txtPriceUPd.Text = Ter.Price.ToString();
            txtNameUpd.Text = Ter.Name;
        }
        void UpdateData()
        {
            _Ter.Price = Convert.ToDecimal(txtPriceUPd.Text);
            _Ter.Name = txtNameUpd.Text;
        }

        private void btnUdpate_Click(object sender, EventArgs e)
        {
            UpdateData();

            if (_Ter.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Refresch();
            RDChekUpdate.Checked = false;
            btnUdpate.Enabled = false;
            frmTreatments_Load(null, null);
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

        private void txtNameAdd_Validating(object sender, CancelEventArgs e)
        {
            if (RDCheakAdd.Checked)
            {
                if (txtNameAdd.Text.Length == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNameAdd, "Plese Enter Valid Data");
                    txtNameAdd.Focus();
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtNameAdd, "");
                }
            }
        }

        private void txtPriceUPd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPriceAdd_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
