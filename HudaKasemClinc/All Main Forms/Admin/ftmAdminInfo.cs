using HudaClinc_BusinessLayer;
using HudaKasemClinc.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace HudaKasemClinc.All_Main_Forms.Admin
{
    public partial class ftmAdminInfo : Form
    {
        public ftmAdminInfo(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        int id;
        private void ftmAdminInfo_Load(object sender, EventArgs e)
        {
            clsAdmins Admin = clsAdmins.Find(id);
            lbln.Text= Admin.Name;
           lblu.Text = Admin.Username;

            if (Admin.Image != "" && Admin.Image != null)
            {
                Pictre.Image = Image.FromFile(Admin.Image);
            }
            else
                Pictre.Image = Resources.admin;

            if (Admin.Permissions == -1)
                lblp.Text = "All";
            else
                lblp.Text = "Specific";
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdateAdmin frm = new frmUpdateAdmin(id);
            frm.Show();
        }
    }
}
