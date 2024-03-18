using Guna.UI2.WinForms;
using HudaClinc_BusinessLayer;
using HudaKasemClinc.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HudaKasemClinc.All_Main_Forms.Admin
{
    public partial class frmUpdateAdmin : Form
    {
        public frmUpdateAdmin(int id)
        {
            InitializeComponent();
            ID = id;
        }

        string CurrentUsername = "";
        enum enPermissions
        {
            All = -1, ListPate = 1, AddPatie = 2, UpdatePate = 4,
            ListDoct = 16, AddDoct = 32, UpdateDoct = 64,
            ListAppoi = 128, AddAppoi = 256, UpdateAppoi = 512, ListPres = 1024, AddPres = 2048,
            UpdatePres = 4096, ListPay = 8192, AddPay = 16284, UpdatePay = 32768, DeletPay = 65536,
            ChangePass = 131072, UpatePermeis = 262144, Dashppor = 524288, tresamint = 1048576,
            midencins = 2097152
        }

        void CheakWhatAdminHavePermissions()
        {
            if (_Adm.Permissions == -1)
            {
                CHAll.Checked = true;
                return;
            }

            if ((_Adm.Permissions & (int)enPermissions.AddPatie) == (int)enPermissions.AddPatie)
            {
                CHAddPaitentt.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpdatePate) == (int)enPermissions.UpdatePate)
            {
                CHUpdatePatinet.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ListPate) == (int)enPermissions.ListPate)
            {
                CHListPatient.Checked = true;
            }

            if ((_Adm.Permissions & (int)enPermissions.AddDoct) == (int)enPermissions.AddDoct)
            {
                CHAddDoctoer.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpdateDoct) == (int)enPermissions.UpdateDoct)
            {
                CHUpdateDoctoer.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ListDoct) == (int)enPermissions.ListDoct)
            {
                CHListDoctoer.Checked = true;
            }

            if ((_Adm.Permissions & (int)enPermissions.AddAppoi) == (int)enPermissions.AddAppoi)
            {
                CHAddAppoi.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpdateAppoi) == (int)enPermissions.UpdateAppoi)
            {
                CHUpdateAppo.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ListAppoi) == (int)enPermissions.ListAppoi)
            {
                CHListAppoi.Checked = true;
            }

            if ((_Adm.Permissions & (int)enPermissions.AddPres) == (int)enPermissions.AddPres)
            {
                CHAddPEr.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpdatePres) == (int)enPermissions.UpdatePres)
            {
                CHUpdaetPer.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ListPres) == (int)enPermissions.ListPres)
            {
                CHListPeres.Checked = true;
            }

            if ((_Adm.Permissions & (int)enPermissions.Dashppor) == (int)enPermissions.Dashppor)
            {
                CHDashpp.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.tresamint) == (int)enPermissions.tresamint)
            {
                CHTreate.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.midencins) == (int)enPermissions.midencins)
            {
                CHMedicein.Checked = true;
            }

            if ((_Adm.Permissions & (int)enPermissions.AddPay) == (int)enPermissions.AddPay)
            {
                CHAddPayme.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpdatePay) == (int)enPermissions.UpdatePay)
            {
                CHUpdatePayamen.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ListPay) == (int)enPermissions.ListPay)
            {
                CHListPaym.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.DeletPay) == (int)enPermissions.DeletPay)
            {
                CHDeletePay.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.ChangePass) == (int)enPermissions.ChangePass)
            {
                CHChangePasw.Checked = true;
            }
            if ((_Adm.Permissions & (int)enPermissions.UpatePermeis) == (int)enPermissions.UpatePermeis)
            {
                CHChangePermissoin.Checked = true;
            }

        }

        int CalculatePermissions()
        {
            int Result = 0;

            if (CHAll.Checked == true)
            {
                Result = -1;
                return Result;
            }
            else
                Result = 0;

            if (CHListPatient.Checked == true)
                Result += 1;
            if (CHAddPaitentt.Checked == true)
                Result += 2;
            if (CHUpdatePatinet.Checked == true)
                Result += 4;
            if (CHListDoctoer.Checked == true)
                Result += 16;
            if (CHAddDoctoer.Checked == true)
                Result += 32;
            if (CHUpdateDoctoer.Checked == true)
                Result += 64;
            if (CHListAppoi.Checked == true)
                Result += 128;
            if (CHAddAppoi.Checked == true)
                Result += 256;
            if (CHUpdateAppo.Checked == true)
                Result += 512;
            if (CHListPeres.Checked == true)
                Result += 1024;
            if (CHAddPEr.Checked == true)
                Result += 2048;
            if (CHUpdaetPer.Checked == true)
                Result += 4096;
            if (CHListPaym.Checked == true)
                Result += 8192;
            if (CHAddPayme.Checked == true)
                Result += 16284;
            if (CHUpdatePayamen.Checked == true)
                Result += 32768;
            if (CHDeletePay.Checked == true)
                Result += 65536;
            if (CHChangePasw.Checked == true)
                Result += 131072;
            if (CHChangePermissoin.Checked == true)
                Result += 262144;         
            if (CHDashpp.Checked == true)
                Result += 524288;
            if (CHTreate.Checked == true)
                Result += 1048576;
            if (CHMedicein.Checked == true)
                Result += 2097152;

            return Result;
        }
        int ID;
        clsAdmins _Adm;
        private void frmUpdateAdmin_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpatePermeis))
            {
                GropPermissions.Enabled= true;
            }
            else
            {
                GropPermissions.Enabled = false;
            }

        }

        string ImagePath;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Refresch()
        {
            txtname.Text = string.Empty;
            txtUsername.Text = string.Empty;
          
            Pictre.Image = Resources.admin;
            CheakAll(false);
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

      
        void ChaekAllPateint(bool CheakAll)
        {
            if(CheakAll)
            {
               
                CHAddPaitentt.Checked = true;
                CHUpdatePatinet.Checked = true;
                CHListPatient.Checked = true;
            }
            else
            {
              
                CHAddPaitentt.Checked = false;
                CHUpdatePatinet.Checked = false;
                CHListPatient.Checked = false;
            }
        }
        void ChaekAllPDocoter(bool CheakAll)
        {
            if (CheakAll)
            {
              
                CHAddDoctoer.Checked = true;
                CHUpdateDoctoer.Checked = true;
                CHListDoctoer.Checked = true;
            }
            else
            {
              
                CHAddDoctoer.Checked = false;
                CHUpdateDoctoer.Checked = false;
                CHListDoctoer.Checked = false;
            }
        }
        void ChaekAllAppoi(bool CheakAll)
        {
            if (CheakAll)
            {
              
                CHAddAppoi.Checked = true;
                CHUpdateAppo.Checked = true;
                CHListAppoi.Checked = true;
            }
            else
            {
               
                CHAddAppoi.Checked = false;
                CHUpdateAppo.Checked = false;
                CHListAppoi.Checked = false;
            }
        }
        void ChaekAllPrese(bool CheakAll)
        {
            if (CheakAll)
            {
             
                CHAddPEr.Checked = true;
                CHUpdaetPer.Checked = true;
                CHListPeres.Checked = true;
            }
            else
            {
               
                CHAddPEr.Checked = false;
                CHUpdaetPer.Checked = false;
                CHListPeres.Checked = false;
            }
        }

        void ChaekAllPayme(bool CheakAll)
        {
            if (CheakAll)
            {
             
                CHAddPayme.Checked = true;
                CHUpdatePayamen.Checked = true;
                CHListPaym.Checked = true;
                CHDeletePay.Checked = true;
            }
            else
            {
              
                CHAddPayme.Checked = false;
                CHUpdatePayamen.Checked = false;
                CHListPaym.Checked = false;
                CHDeletePay.Checked = false;
            }
        }

        void ChaekAllAdmin(bool CheakAll)
        {
            if (CheakAll)
            {
              
                CHChangePasw.Checked = true;
                CHChangePermissoin.Checked = true;
            }
            else
            {
              
                CHChangePasw.Checked = false;
                CHChangePermissoin.Checked = false;
            }
        }
        void CheakAll(bool IsCheakAll)
        {
            if (IsCheakAll)
            {
                ChaekAllPateint(true);
                ChaekAllPDocoter(true);
                ChaekAllAppoi(true);
                ChaekAllPrese(true);
                ChaekAllPayme(true);
                ChaekAllAdmin(true);
                CHTreate.Checked = true;
                CHDashpp.Checked = true;
                CHMedicein.Checked = true;
            }
            else
            {
                ChaekAllPateint(false);
                ChaekAllPDocoter(false);
                ChaekAllAppoi(false);
                ChaekAllPrese(false);
                ChaekAllPayme(false);
                ChaekAllAdmin(false);
                CHTreate.Checked = false;
                CHDashpp.Checked = false;
                CHMedicein.Checked = false;
            }
        }

     

        void FillDataToForm(clsAdmins Adm)
        {
            txtname.Text = Adm.Name;
            txtUsername.Text = Adm.Username;

            if (Adm.Image != "" && Adm.Image!=null)
            {
                Pictre.Image =Image.FromFile(Adm.Image);
            }
            else
                Pictre.Image = Resources.admin;

            _Adm = Adm;
            ImagePath = Adm.Image;
            CurrentUsername = Adm.Username;
            CheakWhatAdminHavePermissions();
        }
        void UpdateData()
        {
            _Adm.Username = txtUsername.Text;
            _Adm.Name=txtname.Text;

            if (Pictre.Image == Resources.admin)
                _Adm.Image = "";
            else
                _Adm.Image = ImagePath;
            _Adm.Password=_Adm.Password;
            _Adm.Permissions = CalculatePermissions();
        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            Refresch();
            clsAdmins Adm;

            if (txtFillter.Text == string.Empty || txtFillter.Text == "0")
            {
                MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Adm = clsAdmins.Find(Convert.ToInt32(txtFillter.Text));


            if (Adm == null)
            {
                MessageBox.Show("Admin Does Not Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresch();
                btnUpdate.Enabled = false;

                return;
            }
            _Adm = Adm;

            btnUpdate.Enabled = true;
            FillDataToForm(Adm);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            UpdateData();
            if (_Adm.Save())
                MessageBox.Show("Data Updated Succssfilly", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            this.Close();
        }

        private void lblPhot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Pictre.Image = new Bitmap(openFileDialog1.FileName);
                ImagePath = openFileDialog1.FileName;
            }
            else
                ImagePath = _Adm.Image;
        }


        private void CHAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CHAll.Checked)
                CheakAll(true);
            else
                CheakAll(false);
        }

        private void txtname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtname.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtname, "Please Enter Valid Data");
                txtname.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtname, "");
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CurrentUsername == txtUsername.Text)
                return;
            if (txtUsername.Text==string.Empty|| clsAdmins.IsAdminsExist(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "There are another Username like this.");
                txtUsername.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length==0)
                btnUpdate.Enabled=false;
            else
                btnUpdate.Enabled=true;
        }


    }
}
