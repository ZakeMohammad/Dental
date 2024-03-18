using Guna.UI2.WinForms;
using HudaClinc_BusinessLayer;
using HudaKasemClinc.All_Main_Forms;
using HudaKasemClinc.All_Main_Forms.Admin;
using HudaKasemClinc.All_Main_Forms.Appointments;
using HudaKasemClinc.All_Main_Forms.Doctors;
using HudaKasemClinc.All_Main_Forms.Patients;
using HudaKasemClinc.All_Main_Forms.Prescriptoins;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HudaKasemClinc
{
    public partial class frmMain : Form
    {
        public frmMain(string username)
        {
            InitializeComponent();
            clsGlobal.CurrentAdmin = clsAdmins.Find(username);
        }


        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                }
            }
            base.WndProc(ref m);
        }


        private void frmTest_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1450, 700);
          
         
            clsGlobal.CurrentDateFortoday=DateTime.Now.ToShortDateString();
        }
        enum enShoices { Patients, Doctors, Appointments, Dashpoord, Payments, Prescriptions }





        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Guna2GroupBox CurrentPanel;
        void HidePanel(enShoices Choice)
        {
            if (Choice == enShoices.Patients)
            {
                PanelForDoctor.Visible = false;
                PanelForAppointment.Visible = false;
                PanelForPrescripotion.Visible = false;
            }
            if (Choice == enShoices.Doctors)
            {
                PanelForPatient.Visible = false;
                PanelForAppointment.Visible = false;
                PanelForPrescripotion.Visible = false;
            }
            if (Choice == enShoices.Appointments)
            {
                PanelForDoctor.Visible = false;
                PanelForPatient.Visible = false;
                PanelForPrescripotion.Visible = false;

            }
            if (Choice == enShoices.Prescriptions)
            {
                PanelForDoctor.Visible = false;
                PanelForAppointment.Visible = false;
                PanelForPatient.Visible = false;

            }
        }

        void ShowSidePanel(enShoices Choice)
        {
            switch (Choice)
            {
                case enShoices.Patients:
                    {
                        PanelForPatient.Visible = true;
                        CurrentPanel = PanelForPatient;
                        HidePanel(enShoices.Patients);
                        break;
                    }
                case enShoices.Doctors:
                    {
                        PanelForDoctor.Visible = true;
                        CurrentPanel = PanelForDoctor;
                        HidePanel(enShoices.Doctors);
                        break;
                    }
                case enShoices.Appointments:
                    {
                        PanelForAppointment.Visible = true;
                        CurrentPanel = PanelForAppointment;
                        HidePanel(enShoices.Appointments);
                        break;
                    }
                case enShoices.Prescriptions:
                    {
                        PanelForPrescripotion.Visible = true;
                        CurrentPanel = PanelForPrescripotion;
                        HidePanel(enShoices.Prescriptions);
                        break;
                    }

            }
        }

        Form CurrentForm;
        private void OpenCountainrForm(Form CountainrForm)
        {
            if (CurrentForm != null)
                CurrentForm.Close();

            CurrentForm = CountainrForm;
            CountainrForm.TopLevel = false;

            PanelForAllForms.Controls.Add(CountainrForm);
            CountainrForm.Dock = DockStyle.Fill;
            CountainrForm.BringToFront();
            CountainrForm.Show();
        }

    
        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            if (SideRaithPanel.Visible == false)
                SideRaithPanel.Visible = true;
            else
                SideRaithPanel.Visible = false;
        }

        private void lblDoctors_Click(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelForDoctor)
            {
                PanelForDoctor.Visible = false;
                CurrentPanel = null;
                return;
            }
            ShowSidePanel(enShoices.Doctors);
        }

        private void lblAppointments_Click(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelForAppointment)
            {
                PanelForAppointment.Visible = false;
                CurrentPanel = null;
                return;
            }
            ShowSidePanel(enShoices.Appointments);
        }

        private void lblPrescripotion_Click(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelForPrescripotion)
            {
                PanelForPrescripotion.Visible = false;
                CurrentPanel = null;
                return;
            }
            ShowSidePanel(enShoices.Prescriptions);
        }

        private void lblPatients_Click(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelForPatient)
            {
                PanelForPatient.Visible = false;
                CurrentPanel = null;
                return;
            }
            ShowSidePanel(enShoices.Patients);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClincSummary_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.Dashppor))
            {
                frmDashpoord frm = new frmDashpoord();
                OpenCountainrForm(frm);
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void lblDoctors_MouseHover(object sender, EventArgs e)
        {
           Label CurrentLabel=sender as Label;

            CurrentLabel.ForeColor = Color.Black;

        }

        private void lblDoctors_MouseLeave(object sender, EventArgs e)
        {
            Label CurrentLabel = sender as Label;

            CurrentLabel.ForeColor = Color.RoyalBlue;
        }

        private void TxtSearchForPatients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
                btnSerarch.PerformClick();
        }

        private void btnSerarch_Click(object sender, EventArgs e)
        {
            clsPatients Patient=clsPatients.Find(TxtSearchForPatients.Text);

            if(Patient == null )
            {
                MessageBox.Show("Patient does not exist in system","Huda Clinc",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                TxtSearchForPatients.Text = "";
                return;
            }
            frmPaitenFastInfo frm = new frmPaitenFastInfo(Patient);
            frm.Show();
        }


        private void btnGoToPage_MouseHover(object sender, EventArgs e)
        {
            btnGoToPage.FillColor = Color.Brown;

        }

        private void btnGoToPage_MouseLeave(object sender, EventArgs e)
        {
            btnGoToPage.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void btnGoToPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.facebook.com/profile.php?id=100088413528682");
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            //Insede
            frmPayment frmPayment = new frmPayment();
            OpenCountainrForm(frmPayment);
            SideRaithPanel.Visible = false;
        }


        ///
        private void btnAddNewPatient_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.AddPatie))
            {
                frmAddPatient frm = new frmAddPatient();
                OpenCountainrForm(frm);
                PanelForPatient.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdatePatient_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpdatePate))
            {
                frmUpdatePatient frm = new frmUpdatePatient();
                OpenCountainrForm(frm);
                PanelForPatient.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnAllPatient_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ListPate))
            {
                frmAllPatients frm = new frmAllPatients();
                OpenCountainrForm(frm);
                PanelForPatient.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
        }
        private void btnAddnewDoctor_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.AddDoct))
            {
                frmAddDoctor frm = new frmAddDoctor();
                OpenCountainrForm(frm);
                PanelForDoctor.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
    
        }

        private void btnUpdateDoctor_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpdateDoct))
            {
                frmUpdateDoctor frm = new frmUpdateDoctor();
                OpenCountainrForm(frm);
                PanelForDoctor.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
    
        }

        private void btnAllDoctors_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ListDoct))
            {
                frmAllDoctors frm = new frmAllDoctors();
                OpenCountainrForm(frm);
                PanelForDoctor.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnAddNewAppointment_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.AddAppoi))
            {
                frmAddAppointment frm = new frmAddAppointment();
                OpenCountainrForm(frm);
                PanelForAppointment.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
  
        }

        private void btnUpdateAppointment_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpdateAppoi))
            {
                frmUpdateAppointment frm = new frmUpdateAppointment();
                OpenCountainrForm(frm);
                PanelForAppointment.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
     
        }

        private void btnAllAppointments_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ListAppoi))
            {
                frmAllAppointments frm = new frmAllAppointments();
                OpenCountainrForm(frm);
                PanelForAppointment.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void btnAddPrescripotion_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.AddPres))
            {
                frmAddPrescriptoins frm = new frmAddPrescriptoins();
                OpenCountainrForm(frm);
                PanelForPrescripotion.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
       
        }

        private void btnUpdatePrescripotion_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.UpdatePres))
            {
                frmUpdatePrescriptoins frm = new frmUpdatePrescriptoins();
                OpenCountainrForm(frm);
                PanelForPrescripotion.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnAllPrescripotion_Click_1(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ListPres))
            {
                frmAllPrescriptoins frm = new frmAllPrescriptoins();
                OpenCountainrForm(frm);
                PanelForPrescripotion.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            clsGlobal.CurrentAdmin = null;
            frmLogin frm= new frmLogin();
            frm.Show();
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.tresamint))
            {
                frmTreatments frm = new frmTreatments();
                OpenCountainrForm(frm);
                SideRaithPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.midencins))
            {
                frmMedicines frm = new frmMedicines();
                OpenCountainrForm(frm);
                SideRaithPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
         
        }

        private void btnChangePaswoord_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheakPermiisoins(clsGlobal.enPermissions.ChangePass))
            {
                frmChangePaswoord frm = new frmChangePaswoord();
                frm.Show();
            }
            else
            {
                MessageBox.Show("You Not Allowd To Use This Future Contact With Your Admin", "Huda Clinc", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnAdminInfo_Click(object sender, EventArgs e)
        {
            ftmAdminInfo frm = new ftmAdminInfo(clsGlobal.CurrentAdmin.AdminID);
            frm.Show();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
