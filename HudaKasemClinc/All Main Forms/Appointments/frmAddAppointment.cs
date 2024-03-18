using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmAddAppointment : Form
    {
        public frmAddAppointment()
        {
            InitializeComponent();
        }

        string Date;
        string PM;
     
        private void StartHours_ValueChanged(object sender, EventArgs e)
        {
            lblSH.Text=StartHours.Value.ToString();
        }

        private void StartMunits_ValueChanged(object sender, EventArgs e)
        {
            lblSM.Text=StartMunits.Value.ToString();
        }

        private void EndHour_ValueChanged(object sender, EventArgs e)
        {
            lblEndH.Text=EndHour.Value.ToString();
        }

        private void EndMunits_ValueChanged(object sender, EventArgs e)
        {
            lblEndM.Text=EndMunits.Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           if(StartHours.Value > EndHour.Value || StartHours.Value == EndHour.Value)
           {
                if (StartHours.Value == 1 && EndHour.Value == 12)
                   
                MessageBox.Show("Please Choose valid time", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
           }

            if (!RDAM.Checked && !RDPM.Checked)
            {
                MessageBox.Show("Please Choose PM or AM to save appointment", "Huda Clinc",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            clsAppointments Appointment=new clsAppointments();


            Appointment.PatientID= clsPatients.Find(CBPatients.SelectedItem.ToString()).PatientID;
            Appointment.DoctorID = clsDoctors.Find(CBDoctors.SelectedItem.ToString()).DoctorID;
            Appointment.Date = TimerDate.Value;
            Appointment.Notes = txtNotes.Text;
            Appointment.Status = 1;
            if (RDAM.Checked)
                Appointment.AMOrPM = "AM";
            if (RDPM.Checked)
                Appointment.AMOrPM = "PM";

            Appointment.StartTimeHours = Convert.ToInt32(StartHours.Value);
            Appointment.StartTimeMuinets = Convert.ToInt32(StartMunits.Value);
            Appointment.EndTimeHours = Convert.ToInt32(EndHour.Value);
            Appointment.EndTImeMuinets = Convert.ToInt32(EndMunits.Value);

            Date = Appointment.Date.ToShortDateString();
            PM = Appointment.AMOrPM;


            if(Appointment.CheakValidety())
            {
                MessageBox.Show("Sorry.. You cant add this appointment because there are another appointment like this time..", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if(Appointment.IsThereOverlappingTime(Appointment.StartTimeHours,Appointment.EndTimeHours,Appointment.Date.ToShortDateString(),Appointment.AMOrPM))
            {
                MessageBox.Show("Sorry.. You cant add this appointment because there Time Overlapping.....", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                lblWrong.Visible = true;
                    return;
            }
          
            if (Appointment.Save())
                MessageBox.Show("Data Added Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }


        void GitValidStartAndEndHours(object ss,int[]validhours)
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

        void FillPatients()
        {
            CBPatients.Items.Clear();


            DataTable Patient = clsPatients.All();

            foreach (DataRow row in Patient.Rows)
            {
                CBPatients.Items.Add(row["PatientName"].ToString());
            }
        }
        void FillDoctors()
        {
            CBDoctors.Items.Clear();


            DataTable Doctors = clsDoctors.All();

            foreach (DataRow row in Doctors.Rows)
            {
                CBDoctors.Items.Add(row["Name"].ToString());
            }
        }

        void FillComboBoxes()
        {
            FillPatients();
            FillDoctors();
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            CBDoctors.SelectedIndex = 0;
            CBPatients.SelectedIndex= 0;
            TimerDate.Value = DateTime.Now;
        }

        private void lblWrong_Click(object sender, EventArgs e)
        {
            frmMakesuggestionforAppointmentsTime frm = new frmMakesuggestionforAppointmentsTime(clsAppointments.AllIntervalInTthisDay(Date, PM), PM);
            frm.BackData += GitValidStartAndEndHours;
            frm.Show();

        }
    }
}
