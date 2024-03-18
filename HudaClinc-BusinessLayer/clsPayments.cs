using HudaClinc_DataAccessLayer;
using System;
using System.Data;

namespace HudaClinc_BusinessLayer
{
    public class clsPayments
    {

        public enum enMode { Add, Update }
        enMode Mode;
        public int PaymentID { get; set; }
        public int PatientID { get; set; }
    
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public bool ItsLastOne { get; set; }
        public int AdminID { get; set; }


       public clsPatients Patient { get; }
        public clsPayments()
        {
            Mode = enMode.Add;
            this.PaymentID = 0;
            this.PatientID = 0;
        
            this.Date = DateTime.Now;
            this.Amount = 0;
            this.Notes = null;
            this.ItsLastOne = false;
            this.AdminID = 0;

        }

        private clsPayments(int PaymentID, int PatientID, DateTime Date, decimal Amount, string Notes, bool ItsLastOne, int AdminID)
        {
            Mode = enMode.Update;
            this.PaymentID = PaymentID;
            this.PatientID = PatientID;
        
            this.Date = Date;
            this.Amount = Amount;
            this.Notes = Notes;
            this.ItsLastOne = ItsLastOne;
            this.AdminID = AdminID;
            Patient = clsPatients.Find(PatientID);
        }


        private bool _AddNew()
        {
            this.PaymentID = clsPaymentsData.AddNewPayments(this.PatientID, this.Date, this.Amount, this.Notes, this.ItsLastOne, this.AdminID);

            return (this.PaymentID != 0);
        }


        private bool _Update()
        {
            return clsPaymentsData.UpdatePayments(this.PaymentID, this.PatientID, this.Date, this.Amount, this.Notes, this.ItsLastOne, this.AdminID);
        }


        public static clsPayments Find(int PaymentID)
        {
            int PatientID = 0;
        
            DateTime Date = DateTime.Now;
            decimal Amount = 0;
            string Notes = null;
            bool ItsLastOne = false;
            int AdminID = 0;


            if (clsPaymentsData.FindPayments(ref PaymentID, ref PatientID, ref Date, ref Amount, ref Notes, ref ItsLastOne, ref AdminID))
                return new clsPayments(PaymentID, PatientID, Date, Amount, Notes, ItsLastOne, AdminID);
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


        public static bool Delete(int PaymentID)
        {
            return clsPaymentsData.DeletePayments(PaymentID);
        }


        public static bool IsPaymentsExist(int PaymentID)
        {
            return clsPaymentsData.IsPaymentsExist(PaymentID);
        }


        public static DataTable All()
        {
            return clsPaymentsData.AllPayments();
        }



        public static DataTable All2()
        {
            return clsPaymentsData.AllPayments2();
        }


    }
}
