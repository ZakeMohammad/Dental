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

namespace HudaKasemClinc.All_Main_Forms
{
    public partial class ctrlTreatment : UserControl
    {
        public ctrlTreatment()
        {
            InitializeComponent();
        }

        int id;
        public void FillData(int ID)
        {
            id = ID;
            clsTreatments MEd = clsTreatments.Find(ID);
            lblID.Text = "#"+ID.ToString();
            lblmed.Text = MEd.Name;
            lblpr.Text = MEd.Price.ToString() + " $";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsTreatments.Delete(id))
                MessageBox.Show("Data Deleted Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
