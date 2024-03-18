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

namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    public partial class frmalllllPres : Form
    {
        public frmalllllPres()
        {
            InitializeComponent();
        }
        DataTable _ALL;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmalllllPres_Load(object sender, EventArgs e)
        {
            _ALL = clsPrescriptions.All();
            DGVALlPrescriptions.DataSource = _ALL;
        }

        private void showTimeRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSingelPRescrip frm = new frmSingelPRescrip((int)DGVALlPrescriptions.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsAppointments.Delete((int)DGVALlPrescriptions.CurrentRow.Cells[0].Value))
                MessageBox.Show("Appointment Succssfilly Deleted", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return;
        }

        private void CBFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFillter.SelectedIndex == 0)
            {
                txtFillter.Visible = false;
            
                DataView dataView = _ALL.DefaultView;

                dataView.RowFilter = "";
            }
            if (CBFillter.SelectedIndex == 1)
            {          
                txtFillter.Visible = true;
            }
           
        }

        private void txtFillter_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "PatientName";

            DataView dataView = _ALL.DefaultView;

            dataView.RowFilter = string.Format("[{0}] like '{1}%'", FillterFor, txtFillter.Text);
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
