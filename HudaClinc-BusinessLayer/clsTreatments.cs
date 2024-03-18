using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsTreatments
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int TreatmentID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        public clsTreatments()
        {
            Mode = enMode.Add;
            this.TreatmentID = 0;
            this.Name = null;
            this.Price = 0;

        }

        private clsTreatments(int TreatmentID, string Name, decimal Price)
        {
            Mode = enMode.Update;
            this.TreatmentID = TreatmentID;
            this.Name = Name;
            this.Price = Price;

        }


        private bool _AddNew()
        {
            this.TreatmentID = clsTreatmentsData.AddNewTreatments(this.Name, this.Price);

            return (this.TreatmentID != 0);
        }


        private bool _Update()
        {
            return clsTreatmentsData.UpdateTreatments(this.TreatmentID, this.Name, this.Price);
        }


        public static clsTreatments Find(int TreatmentID)
        {
            string Name = null;
            decimal Price = 0;


            if (clsTreatmentsData.FindTreatments(ref TreatmentID, ref Name, ref Price))
                return new clsTreatments(TreatmentID, Name, Price);
            else
                return null;
        }
        public static clsTreatments Find(string Name)
        {
            int TreatmentID = 0;
            decimal Price = 0;


            if (clsTreatmentsData.FindTreatments(ref TreatmentID, Name, ref Price))
                return new clsTreatments(TreatmentID, Name, Price);
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


        public static bool Delete(int TreatmentID)
        {
            return clsTreatmentsData.DeleteTreatments(TreatmentID);
        }


        public static bool IsTreatmentsExist(int TreatmentID)
        {
            return clsTreatmentsData.IsTreatmentsExist(TreatmentID);
        }


        public static DataTable All()
        {
            return clsTreatmentsData.AllTreatments();
        }






    }
}
