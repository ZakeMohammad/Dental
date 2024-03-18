using HudaClinc_DataAccessLayer;
using System;
using System.Data;

namespace HudaClinc_BusinessLayer
{
    public class clsPrescriptions
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int PrescriptionID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Description { get; set; }
        public int MedicineID { get; set; }
        public DateTime Date { get; set; }

      public  clsPatients Patients { get; }

      public  clsDoctors Doctors { get; }

        public clsMedicines Medicines { get; }
        public clsPrescriptions()
        {
            Mode = enMode.Add;
            this.PrescriptionID = 0;
            this.PatientID = 0;
            this.DoctorID = 0;
            this.Description = null;
            this.MedicineID = 0;
            this.Date = DateTime.Now;

        }

        private clsPrescriptions(int PrescriptionID, int PatientID, int DoctorID, string Description, int MedicineID, DateTime Date)
        {
            Mode = enMode.Update;
            this.PrescriptionID = PrescriptionID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.Description = Description;
            this.MedicineID = MedicineID;
            this.Date = Date;
            Doctors = clsDoctors.Find(DoctorID);
            Patients = clsPatients.Find(PatientID);
            Medicines=clsMedicines.Find(MedicineID);
        }


        private bool _AddNew()
        {
            this.PrescriptionID = clsPrescriptionsData.AddNewPrescriptions(this.PatientID, this.DoctorID, this.Description, this.MedicineID, this.Date);

            return (this.PrescriptionID != 0);
        }


        private bool _Update()
        {
            return clsPrescriptionsData.UpdatePrescriptions(this.PrescriptionID, this.PatientID, this.DoctorID, this.Description, this.MedicineID, this.Date);
        }


        public static clsPrescriptions Find(int PrescriptionID)
        {
            int PatientID = 0;
            int DoctorID = 0;
            string Description = null;
            int MedicineID = 0;
            DateTime Date = DateTime.Now;


            if (clsPrescriptionsData.FindPrescriptions(ref PrescriptionID, ref PatientID, ref DoctorID, ref Description, ref MedicineID, ref Date))
                return new clsPrescriptions(PrescriptionID, PatientID, DoctorID, Description, MedicineID, Date);
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


        public static bool Delete(int PrescriptionID)
        {
            return clsPrescriptionsData.DeletePrescriptions(PrescriptionID);
        }


        public static bool IsPrescriptionsExist(int PrescriptionID)
        {
            return clsPrescriptionsData.IsPrescriptionsExist(PrescriptionID);
        }


        public static DataTable All()
        {
            return clsPrescriptionsData.AllPrescriptions();
        }

        public static DataTable All2()
        {
            return clsPrescriptionsData.AllPrescriptions2();
        }



    }
}
