using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsPatients
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string FirstIllness { get; set; }
        public string SecondIllness { get; set; }
        public string ThearedIllness { get; set; }
        public string FourIllness { get; set; }
        public string FiveIllness { get; set; }
        public int RequiredTreatment { get; set; }
        public bool NeedReview { get; set; }

        public clsPatients()
        {
            Mode = enMode.Add;
            this.PatientID = 0;
            this.PatientName = null;
            this.Phone = null;
            this.Email = null;
            this.Age = 0;
            this.FirstIllness = null;
            this.SecondIllness = null;
            this.ThearedIllness = null;
            this.FourIllness = null;
            this.FiveIllness = null;
            this.RequiredTreatment = 0;
            this.NeedReview = false;

        }

        private clsPatients(int PatientID, string PatientName, string Phone, string Email, int Age, string FirstIllness, string SecondIllness, string ThearedIllness, string FourIllness, string FiveIllness, int RequiredTreatment, bool NeedReview)
        {
            Mode = enMode.Update;
            this.PatientID = PatientID;
            this.PatientName = PatientName;
            this.Phone = Phone;
            this.Email = Email;
            this.Age = Age;
            this.FirstIllness = FirstIllness;
            this.SecondIllness = SecondIllness;
            this.ThearedIllness = ThearedIllness;
            this.FourIllness = FourIllness;
            this.FiveIllness = FiveIllness;
            this.RequiredTreatment = RequiredTreatment;
            this.NeedReview = NeedReview;
        }


        private bool _AddNew()
        {
            this.PatientID = clsPatientsData.AddNewPatients(this.PatientName, this.Phone, this.Email, this.Age, this.FirstIllness, this.SecondIllness, this.ThearedIllness, this.FourIllness, this.FiveIllness, this.RequiredTreatment, this.NeedReview);

            return (this.PatientID != 0);
        }


        private bool _Update()
        {
            return clsPatientsData.UpdatePatients(this.PatientID, this.PatientName, this.Phone, this.Email, this.Age, this.FirstIllness, this.SecondIllness, this.ThearedIllness, this.FourIllness, this.FiveIllness, this.RequiredTreatment, this.NeedReview);
        }


        public static clsPatients Find(int PatientID)
        {
            string PatientName = null;
            string Phone = null;
            string Email = null;
            int Age = 0;
            string FirstIllness = null;
            string SecondIllness = null;
            string ThearedIllness = null;
            string FourIllness = null;
            string FiveIllness = null;
            int RequiredTreatment = 0;
            bool NeedReview = false;


            if (clsPatientsData.FindPatients( PatientID, ref PatientName, ref Phone, ref Email, ref Age, ref FirstIllness, ref SecondIllness, ref ThearedIllness, ref FourIllness, ref FiveIllness, ref RequiredTreatment, ref NeedReview))
                return new clsPatients(PatientID, PatientName, Phone, Email, Age, FirstIllness, SecondIllness, ThearedIllness, FourIllness, FiveIllness, RequiredTreatment, NeedReview);
            else
                return null;
        }

        public static clsPatients Find( string Name)
        {
            int PatientID = 0;
            string Phone = null;
            string Email = null;
            int Age = 0;
            string FirstIllness = null;
            string SecondIllness = null;
            string ThearedIllness = null;
            string FourIllness = null;
            string FiveIllness = null;
            int RequiredTreatment = 0;
            bool NeedReview = false;


            if (clsPatientsData.FindPatients(ref PatientID, Name, ref Phone, ref Email, ref Age, ref FirstIllness, ref SecondIllness, ref ThearedIllness, ref FourIllness, ref FiveIllness, ref RequiredTreatment, ref NeedReview))
                return new clsPatients(PatientID, Name, Phone, Email, Age, FirstIllness, SecondIllness, ThearedIllness, FourIllness, FiveIllness, RequiredTreatment, NeedReview);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Add:
                    {
                        if (_AddNew())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                defult:
                    return false;
            }
            return false;
        }


        public static bool Delete(int PatientID)
        {
            return clsPatientsData.DeletePatients(PatientID);
        }


        public static bool IsPatientsExist(int PatientID)
        {
            return clsPatientsData.IsPatientsExist(PatientID);
        }


        public static DataTable All()
        {
            return clsPatientsData.AllPatients();
        }


        public static DataTable AllAppointmentForThisPateint(int PatientID)
        {
            return clsPatientsData.AllAppointmentForThisPateint(PatientID);
        }
        public decimal GitLastPaymentAmount()
        {
            return clsPatientsData.GitLastPaymentAmount(this.PatientID);
        }
        public int GitNumberOfPerspictoin()
        {
            return clsPatientsData.GitNumberOfPerspictoin(this.PatientID);
        }

        public static bool DisabelPayments(int PatientID,int PaymentID)
        {
            return clsPatientsData.DisabelPayments(PatientID, PaymentID);
        }
    }
}
