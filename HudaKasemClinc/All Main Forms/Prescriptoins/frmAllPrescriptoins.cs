using HudaClinc_BusinessLayer;
using HudaKasemClinc.All_Main_Forms.Prescriptoins;
using System;
using System.Data;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class frmAllPrescriptoins : Form
    {
        public frmAllPrescriptoins()
        {
            InitializeComponent();
        }


        void RefreshMenu()
        {
            DataTable Pre = clsPrescriptions.All2();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in Pre.Rows)
            {
                ctrlPrescriptoinsCard menuiteminfo = new ctrlPrescriptoinsCard();


                menuiteminfo.FillData(Convert.ToInt32(Row["PrescriptionID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }

        private void frmAllPrescriptoins_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmalllllPres frm=new frmalllllPres();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmalllllPres frm = new frmalllllPres();
            frm.Show();
        }
    }
}
