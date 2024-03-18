using HudaClinc_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HudaKasemClinc
{
    public class clsGlobal
    {
   

        public static DataTable AllTreatments()
        {
            DataTable Names = new DataTable();

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT Name FROM Treatments ";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                Names.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Names;
        }


        public static string CurrentDateFortoday {  get; set; }


        public static clsAdmins CurrentAdmin { get; set; }

        public enum enPermissions
        {
            All = -1, ListPate = 1, AddPatie = 2, UpdatePate = 4,
            ListDoct = 16, AddDoct = 32, UpdateDoct = 64,
            ListAppoi = 128, AddAppoi = 256, UpdateAppoi = 512, ListPres = 1024, AddPres = 2048,
            UpdatePres = 4096, ListPay = 8192, AddPay = 16284, UpdatePay = 32768, DeletPay = 65536,
            ChangePass = 131072, UpatePermeis = 262144, Dashppor = 524288, tresamint = 1048576,
            midencins = 2097152
        }

        public static bool CheakAdminLogin(string Username, string Password)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=DentalClinc;User Id=sa;Password=123456"))
                {

                    string Querey = "select Found=1 from Admins where Username=@Username and Password=@Password ;";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Connection.Open();

                        RowEffected = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }

        public static bool CheakPermiisoins(enPermissions Permissoin)
        {
            if ((clsGlobal.CurrentAdmin.Permissions & (int)Permissoin) == (int)Permissoin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> AllNumbers()
        {
            List<int>Numbers= new List<int>();  
            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=DentalClinc;User Id=sa;Password=123456"))
                {
                    string Query = "select (select count(*) from Admins) as First,(select count(*) from Appointments) as secound,(select count(*) from Prescriptions) as thered,(select count(*) from Payments)as four,(select count(*) from Patients)as five,(select count(*) from Medicines)as seven,(select count(*) from Treatments)as ethi";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                Numbers.Add(Convert.ToInt32(Reader["First"]));
                                Numbers.Add(Convert.ToInt32(Reader["secound"]));
                                Numbers.Add(Convert.ToInt32(Reader["thered"]));
                                Numbers.Add(Convert.ToInt32(Reader["four"]));
                                Numbers.Add(Convert.ToInt32(Reader["five"]));
                                Numbers.Add(Convert.ToInt32(Reader["seven"]));
                                Numbers.Add(Convert.ToInt32(Reader["ethi"]));
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Numbers;
        }


    }
}
