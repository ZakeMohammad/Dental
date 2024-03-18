using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsDoctors
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adrees { get; set; }
        public int PatientNumber { get; set; }


        public clsDoctors()
        {
            Mode = enMode.Add;
            this.DoctorID = 0;
            this.Name = null;
            this.Phone = null;
            this.Email = null;
            this.Adrees = null;
            this.PatientNumber = 0;

        }

        private clsDoctors(int DoctorID, string Name, string Phone, string Email, string Adrees, int PatientNumber)
        {
            Mode = enMode.Update;
            this.DoctorID = DoctorID;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Adrees = Adrees;
            this.PatientNumber = PatientNumber;

        }


        private bool _AddNew()
        {
            this.DoctorID = clsDoctorsData.AddNewDoctors(this.Name, this.Phone, this.Email, this.Adrees, this.PatientNumber);

            return (this.DoctorID != 0);
        }


        private bool _Update()
        {
            return clsDoctorsData.UpdateDoctors(this.DoctorID, this.Name, this.Phone, this.Email, this.Adrees, this.PatientNumber);
        }


        public static clsDoctors Find(int DoctorID)
        {
            string Name = null;
            string Phone = null;
            string Email = null;
            string Adrees = null;
            int PatientNumber = 0;


            if (clsDoctorsData.FindDoctors(DoctorID, ref Name, ref Phone, ref Email, ref Adrees, ref PatientNumber))
                return new clsDoctors(DoctorID, Name, Phone, Email, Adrees, PatientNumber);
            else
                return null;
        }
        public static clsDoctors Find(string Name)
        {
            int DoctorID = 0;
            string Phone = null;
            string Email = null;
            string Adrees = null;
            int PatientNumber = 0;


            if (clsDoctorsData.FindDoctors(ref DoctorID,  Name, ref Phone, ref Email, ref Adrees, ref PatientNumber))
                return new clsDoctors(DoctorID, Name, Phone, Email, Adrees, PatientNumber);
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


        public static bool Delete(int DoctorID)
        {
            return clsDoctorsData.DeleteDoctors(DoctorID);
        }


        public static bool IsDoctorsExist(int DoctorID)
        {
            return clsDoctorsData.IsDoctorsExist(DoctorID);
        }


        public static DataTable All()
        {
            return clsDoctorsData.AllDoctors();
        }

        public int GitCurrentPatinetForThisDoctor()
        {
            return clsDoctorsData.GitCurrentPatinetForThisDoctor(this.DoctorID);
        }

    }
}
