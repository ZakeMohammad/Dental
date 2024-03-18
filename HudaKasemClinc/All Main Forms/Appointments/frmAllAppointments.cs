using HudaClinc_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    public partial class frmAllAppointments : Form
    {
        public frmAllAppointments()
        {
            InitializeComponent();
        }

 
        void RefreshMenu()
        {
            DataTable AllAppointment = clsAppointments.All(clsGlobal.CurrentDateFortoday);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllAppointment.Rows)
            {
                ctrlAppointmentCard menuiteminfo = new ctrlAppointmentCard();

                menuiteminfo.FillData(Convert.ToInt32(Row["AppointmentID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }
        private void frmAllAppointments_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmAllAppointmentForALlll frm = new frmAllAppointmentForALlll();
            frm.Show();
        }
    }
}
