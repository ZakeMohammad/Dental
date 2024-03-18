using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmAllAppointmentForALlll : Form
    {
        public frmAllAppointmentForALlll()
        {
            InitializeComponent();
        }


        DataTable _ALL;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmAllAppointmentForALlll_Load(object sender, EventArgs e)
        {
            _ALL= clsAppointments.All();
            DGVALlAppointment.DataSource = _ALL; 
        }

        private void showTimeRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSingelApp frm = new frmSingelApp((int)DGVALlAppointment.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsAppointments.Delete((int)DGVALlAppointment.CurrentRow.Cells[0].Value))
                MessageBox.Show("Appointment Succssfilly Deleted", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsAppointments.ChangeStatus((int)DGVALlAppointment.CurrentRow.Cells[0].Value, 3))
                MessageBox.Show("Appointment Succssfilly Canceld", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return;
        }

        private void CBFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBFillter.SelectedIndex == 0)
            {
                txtFillter.Visible = false;
                CBStatus.Visible = false;
                DataView dataView = _ALL.DefaultView;

                dataView.RowFilter = "";
            }
            if(CBFillter.SelectedIndex == 1)
            {
                CBStatus.Visible = false;
                txtFillter.Visible = true;
            }
            if( CBFillter.SelectedIndex == 2)
            {
                CBStatus.Visible = true;
                txtFillter.Visible = false;
            }
        }

        private void txtFillter_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "PatientName";

            DataView dataView = _ALL.DefaultView;

             dataView.RowFilter = string.Format("[{0}] like '{1}%'", FillterFor, txtFillter.Text);
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = _ALL.DefaultView;

            string FillterFor = "";

            if (CBStatus.SelectedIndex==0)
            {
                FillterFor = "Active";
            }
            if (CBStatus.SelectedIndex == 1)
            {
                FillterFor = "Done Successfully";
            }
            if (CBStatus.SelectedIndex == 2)
            {
                FillterFor = "Canceled";
            }
          

            dataView.RowFilter = string.Format("[StatusName] like '{0}%'", FillterFor);
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CBFillter.SelectedIndex==1)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


    }
}
