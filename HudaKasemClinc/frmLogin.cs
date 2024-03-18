using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HudaKasemClinc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;


            if(clsGlobal.CheakAdminLogin(txtusername.Text,txtpassword.Text))
            {
                lblwrong.Visible = false;

                this.Hide();
                frmMain frm=new frmMain(txtusername.Text);
                frm.Show();
            }
            else
            {
                lblwrong.Visible=true;
                txtpassword.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if(txtusername.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtusername, "Plese Enter Valid Data");
                txtusername.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtusername, "");
            }
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtpassword.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtpassword, "Plese Enter Valid Data");
                txtpassword.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpassword, "");
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtpassword.PasswordChar== '\0')
            {
                txtpassword.PasswordChar = '\u25CF';
            }
            else
                txtpassword.PasswordChar = '\0';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '\u25CF';
        }
    }
}
