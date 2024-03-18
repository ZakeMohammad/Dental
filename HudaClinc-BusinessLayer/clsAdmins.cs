using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsAdmins
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public string Image { get; set; }


        public clsAdmins()
        {
            Mode = enMode.Add;
            this.AdminID = 0;
            this.Username = null;
            this.Name = null;
            this.Password = null;
            this.Permissions = 0;
            this.Image = null;

        }

        private clsAdmins(int AdminID, string Username, string Name, string Password, int Permissions, string Image)
        {
            Mode = enMode.Update;
            this.AdminID = AdminID;
            this.Username = Username;
            this.Name = Name;
            this.Password = Password;
            this.Permissions = Permissions;
            this.Image = Image;

        }


        private bool _AddNew()
        {
            this.AdminID = clsAdminsData.AddNewAdmins(this.Username, this.Name, this.Password, this.Permissions, this.Image);

            return (this.AdminID != 0);
        }


        private bool _Update()
        {
            return clsAdminsData.UpdateAdmins(this.AdminID, this.Username, this.Name, this.Password, this.Permissions, this.Image);
        }


        public static clsAdmins Find(int AdminID)
        {
            string Username = null;
            string Name = null;
            string Password = null;
            int Permissions = 0;
            string Image = null;


            if (clsAdminsData.FindAdmins(ref AdminID, ref Username, ref Name, ref Password, ref Permissions, ref Image))
                return new clsAdmins(AdminID, Username, Name, Password, Permissions, Image);
            else
                return null;
        }

        public static clsAdmins Find(string Username)
        {
          int AdminID = 0;
            string Name = null;
            string Password = null;
            int Permissions = 0;
            string Image = null;


            if (clsAdminsData.FindAdmins(ref AdminID,  Username, ref Name, ref Password, ref Permissions, ref Image))
                return new clsAdmins(AdminID, Username, Name, Password, Permissions, Image);
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


        public static bool Delete(int AdminID)
        {
            return clsAdminsData.DeleteAdmins(AdminID);
        }


        public static bool IsAdminsExist(string Username)
        {
            return clsAdminsData.IsAdminsExist(Username);
        }


        public static DataTable All()
        {
            return clsAdminsData.AllAdmins();
        }

        public static bool UpdatePaswword(string Password, int AdminID)
        {
            return clsAdminsData.UpdatePaswword(Password, AdminID);
        }

    }
}
