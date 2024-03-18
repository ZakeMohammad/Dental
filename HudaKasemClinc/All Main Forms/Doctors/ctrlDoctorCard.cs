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

namespace HudaKasemClinc.All_Main_Forms.Doctors
{
    public partial class ctrlDoctorCard : UserControl
    {
        public ctrlDoctorCard()
        {
            InitializeComponent();
        }


    


       public void FillData(int DoctorID)
        {
            clsDoctors Doctor = clsDoctors.Find(DoctorID);
         
            lblName.Text = Doctor.Name;
            lblID.Text = "#" + DoctorID.ToString();

            if (Doctor.Phone == "")
                lblPhone.Text = "null";
            else
                lblPhone.Text = Doctor.Phone.ToString();

            if(Doctor.Email== "")
                lblEmail.Text = "null";
            else
                lblEmail.Text = Doctor.Email.ToString();

            lblAddress.Text = Doctor.Adrees;
            lblNumber.Text=Doctor.GitCurrentPatinetForThisDoctor().ToString();
        }

    }
}
