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

namespace HudaKasemClinc.All_Main_Forms.Payment
{
    public partial class frmall : Form
    {
        public frmall()
        {
            InitializeComponent();
        }
        DataTable _ALL;
        private void frmall_Load(object sender, EventArgs e)
        {
            _ALL = clsPayments.All();
            DGVALlAppointment.DataSource = _ALL;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFillter.SelectedIndex == 0)
            {
                txtFillter.Visible = false;

                DataView dataView = _ALL.DefaultView;

                dataView.RowFilter = "";
            }
            else
                txtFillter.Visible = true;
        }

        private void txtFillter_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "PatientName";

            DataView dataView = _ALL.DefaultView;
                FillterFor = "PatientName";
                dataView.RowFilter = string.Format("[{0}] like '{1}%'", FillterFor, txtFillter.Text);
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    return;
                }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPayments.Delete((int)DGVALlAppointment.CurrentRow.Cells[0].Value))
                MessageBox.Show("Data Deleted Succssfilly","Huda Clinc",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
