using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsMedicines
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        public clsMedicines()
        {
            Mode = enMode.Add;
            this.ID = 0;
            this.Name = null;
            this.Price = 0;

        }

        private clsMedicines(int ID, string Name, decimal Price)
        {
            Mode = enMode.Update;
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;

        }


        private bool _AddNew()
        {
            this.ID = clsMedicinesData.AddNewMedicines(this.Name, this.Price);

            return (this.ID != 0);
        }


        private bool _Update()
        {
            return clsMedicinesData.UpdateMedicines(this.ID, this.Name, this.Price);
        }


        public static clsMedicines Find(int ID)
        {
            string Name = null;
            decimal Price = 0;


            if (clsMedicinesData.FindMedicines(ref ID, ref Name, ref Price))
                return new clsMedicines(ID, Name, Price);
            else
                return null;
        }
        public static clsMedicines Find( string Name)
        {
            int ID = 0;
            decimal Price = 0;


            if (clsMedicinesData.FindMedicines(ref ID,  Name, ref Price))
                return new clsMedicines(ID, Name, Price);
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


        public static bool Delete(int ID)
        {
            return clsMedicinesData.DeleteMedicines(ID);
        }


        public static bool IsMedicinesExist(int ID)
        {
            return clsMedicinesData.IsMedicinesExist(ID);
        }


        public static DataTable All()
        {
            return clsMedicinesData.AllMedicines();
        }







    }
}
