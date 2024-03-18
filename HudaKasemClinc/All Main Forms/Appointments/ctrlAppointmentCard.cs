using HudaClinc_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class ctrlAppointmentCard : UserControl
    {
        public ctrlAppointmentCard()
        {
            InitializeComponent();
        }

        int AppointmentID;

        public string Date;

      
        public void FillData(int appointmentID)
        {
            AppointmentID = appointmentID;

            clsAppointments Appointment = clsAppointments.Find(appointmentID);
            lblid.Text ="#"+ AppointmentID.ToString();
            lbldoctor.Text = Appointment.Doctors.Name;
            lblpatinte.Text = Appointment.Patients.PatientName;
            lbltime.Text=Appointment.StartTimeHours.ToString()+":"+Appointment.StartTimeMuinets.ToString()+" - "+Appointment.EndTimeHours.ToString()+":"+Appointment.EndTImeMuinets.ToString();
            if (Appointment.Status == 1)
                lblstatus.Text = "Active";
            if (Appointment.Status == 2)
                lblstatus.Text = "Done";
            if (Appointment.Status == 3)
                lblstatus.Text = "Canceled";
            Date=Appointment.Date.ToShortDateString();

            lblmmm.Text = Appointment.AMOrPM;
           
        }
    

        private void btnCanceleee_Click(object sender, EventArgs e)
        {
            if (clsAppointments.ChangeStatus(AppointmentID, 3))
            {
                MessageBox.Show("Appointment Succssfilly Canceld", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                btnDeleteeeee.Enabled = false;
                guna2Button1.Enabled = false;
            }
              
            return;
        }

        private void btnDeleteeeee_Click(object sender, EventArgs e)
        {
            if (clsAppointments.Delete(AppointmentID))
            {
                guna2Button1.Enabled = false;
                btnCanceleee.Enabled = false;
                MessageBox.Show("Data Deleted Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
               
            return;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (clsAppointments.ChangeStatus(AppointmentID, 2))
            {
                btnDeleteeeee.Enabled = false;
                btnCanceleee.Enabled = false;
                MessageBox.Show("Another Appointment is Done You are", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
              
            return;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (SidePanel.Visible == false)
                SidePanel.Visible = true;
            else
                SidePanel.Visible = false;
        }

      
    }
}
