using HudaClinc_BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmUpdateAppointment : Form
    {
        public frmUpdateAppointment()
        {
            InitializeComponent();
        }

        clsAppointments _Appointment;

        void Refresch()
        {
            Txtname.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            lblStatus.Text = string.Empty;
            Datemiker.Value = DateTime.Now;
            lblSH.Text = string.Empty;
            lblSM.Text = string.Empty;
            lblEndH.Text = string.Empty;
            lblEndM.Text = string.Empty;
          
            txtNotes.Text = string.Empty;
            txtFillter.Text = string.Empty;
        }
        private void frmUpdateAppointment_Load(object sender, EventArgs e)
        {

        }
        int statusid;

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsAppointments Appointment;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Plese Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Appointment = clsAppointments.Find(Convert.ToInt32(txtFillter.Text));

            if (Appointment == null)
            {
                MessageBox.Show("Appointment Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnSave.Enabled = false;
                guna2WinProgressIndicator1.Visible = false;
                return;
            }

            _Appointment = Appointment;
            guna2WinProgressIndicator1.Visible = true;
            btnSave.Enabled = true;
            FillDataToForm(Appointment);
        }

        string Date;
        string PM;

        int startbefore = 0;
        int endbefore = 0;
        DateTime Datebeferoe= DateTime.Now;
        void FillDataToForm(clsAppointments App)
        {
            Txtname.Text = App.Patients.PatientName;
            txtDoctorName.Text = App.Doctors.Name;
           Datemiker.Value = App.Date;
            if(App.Status==1)
            {
                lblStatus.Text = "Active";
                lblStatus.ForeColor = Color.Blue;
                statusid = 1;
            }
            if (App.Status == 2)
            {
                lblStatus.Text = "Done";
                lblStatus.ForeColor = Color.Green;
                statusid = 2;
            }
            if (App.Status == 3)
            {
                lblStatus.Text = "Canceled";
                lblStatus.ForeColor = Color.Red;
                statusid = 3;
            }
            if (App.AMOrPM=="PM")
                RDPM.Checked = true;
            else
                RDAM.Checked = true;

            lblSH.Text = App.StartTimeHours.ToString();
            lblSM.Text = App.StartTimeMuinets.ToString();
            lblEndH.Text = App.EndTimeHours.ToString();
            lblEndM.Text = App.EndTImeMuinets.ToString();

            StartHours.Value = App.StartTimeHours;
            StartMunits.Value = App.StartTimeMuinets;
            EndHour.Value = App.EndTimeHours;
            EndMunits.Value = App.EndTImeMuinets;

            txtNotes.Text = App.Notes;

            startbefore = App.StartTimeHours; 
            endbefore =App.EndTimeHours;
            Datebeferoe = App.Date;
        }



        void UpdateData()
        {
            _Appointment.Patients.PatientName = Txtname.Text;
            _Appointment.Doctors.Name = txtDoctorName.Text;
            _Appointment.Status = statusid;
            if (RDPM.Checked)
                _Appointment.AMOrPM = "PM";
            else
                _Appointment.AMOrPM = "AM";
            _Appointment.Date = Datemiker.Value;


            _Appointment.StartTimeHours = Convert.ToInt32( StartHours.Value);
            _Appointment.StartTimeMuinets = Convert.ToInt32(StartMunits.Value);
            _Appointment.EndTimeHours = Convert.ToInt32(EndHour.Value);
            _Appointment.EndTImeMuinets = Convert.ToInt32(EndMunits.Value);
            _Appointment.Status = statusid;
            _Appointment.Notes= txtNotes.Text; 
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();

            if (StartHours.Value > EndHour.Value || StartHours.Value == EndHour.Value)
            {
                MessageBox.Show("Plese Choose valid time", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (!RDAM.Checked && !RDPM.Checked)
            {
                MessageBox.Show("Plese Choose PM or AM to save appointment", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            Date = _Appointment.Date.ToShortDateString();
            PM = _Appointment.AMOrPM;

            if(!(startbefore==_Appointment.StartTimeHours && endbefore==_Appointment.EndTimeHours && Datebeferoe==_Appointment.Date))
            {
                if (_Appointment.CheakValidety())
                {
                    MessageBox.Show("Sorry.. You cant add this appointment because there are another appointment like this time..", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    lblWrong.Visible = true;
                    return;
                }
                if (_Appointment.IsThereOverlappingTime(_Appointment.StartTimeHours, _Appointment.EndTimeHours, _Appointment.Date.ToShortDateString(), _Appointment.AMOrPM))
                {
                    MessageBox.Show("Sorry.. You cant add this appointment because there Time Overlapping.....", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    lblWrong.Visible = true;
                    return;
                }
            }

            if (_Appointment.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void StartHours_ValueChanged(object sender, EventArgs e)
        {
            lblSH.Text=StartHours.Value.ToString();
        }

        private void StartMunits_ValueChanged(object sender, EventArgs e)
        {
            lblSM.Text = StartMunits.Value.ToString();
        }

        private void EndHour_ValueChanged(object sender, EventArgs e)
        {
            lblEndH.Text = EndHour.Value.ToString();
        }

        private void EndMunits_ValueChanged(object sender, EventArgs e)
        {
            lblEndM.Text = EndMunits.Value.ToString();
        }

        private void lblWrong_Click(object sender, EventArgs e)
        {
            frmMakesuggestionforAppointmentsTime frm = new frmMakesuggestionforAppointmentsTime(clsAppointments.AllIntervalInTthisDay(Date, PM), PM);
            frm.BackData += GitValidStartAndEndHours;
            frm.Show();

        }
        void GitValidStartAndEndHours(object ss, int[] validhours)
        {
            StartHours.Value = validhours[0];
            EndHour.Value = validhours[1];
            StartMunits.Value = 0;
            EndMunits.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
