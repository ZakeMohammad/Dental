using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Patients
{
    public partial class frmAllPatients : Form
    {
        public frmAllPatients()
        {
            InitializeComponent();
        }

        DataTable _ALL;
        private void frmAllPatients_Load(object sender, EventArgs e)
        {
            _ALL = clsPatients.All();
            DGVALlPrescriptions.DataSource = _ALL;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFillter_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "PatientName";

            DataView dataView = _ALL.DefaultView;

            dataView.RowFilter = string.Format("[{0}] like '{1}%'", FillterFor, txtFillter.Text);
        }

        private void CBFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFillter.SelectedIndex == 0)
            {
                txtFillter.Visible = false;
                CBStatus.Visible = false;
                DataView dataView = _ALL.DefaultView;

                dataView.RowFilter = "";
            }
            if (CBFillter.SelectedIndex == 1)
            {
                CBStatus.Visible = false;
                txtFillter.Visible = true;
            }
            if (CBFillter.SelectedIndex == 2)
            {
                CBStatus.Visible = true;
                txtFillter.Visible = false;
            }
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = _ALL.DefaultView;

            string FillterFor = "";

            if (CBStatus.SelectedIndex == 0)
            {
                FillterFor = "0";
            }
            if (CBStatus.SelectedIndex == 1)
            {
                FillterFor = "1";
            }
            dataView.RowFilter = string.Format("[NeedReview] = {0}", FillterFor);
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBFillter.SelectedIndex == 1)
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
        }
    }
}
