using HudaClinc_BusinessLayer;
using HudaKasemClinc.All_Main_Forms.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Doctors
{
    public partial class frmAllDoctors : Form
    {
        public frmAllDoctors()
        {
            InitializeComponent();
        }
        void RefreshMenu()
        {
            DataTable AllDoctors = clsDoctors.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllDoctors.Rows)
            {
                ctrlDoctorCard menuiteminfo = new ctrlDoctorCard();


                menuiteminfo.FillData(Convert.ToInt32(Row["DoctorID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllDoctors_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }
    }
}
