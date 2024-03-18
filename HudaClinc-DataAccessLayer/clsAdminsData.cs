using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HudaClinc_DataAccessLayer
{
    public class clsAdminsData
    {
        public static int AddNewAdmins(string Username, string Name, string Password, int Permissions, string Image)
        {

            int DefultAdminID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Admins values (@Username,@Name,@Password,@Permissions,@Image) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permissions", Permissions);
                        Command.Parameters.AddWithValue("@Image", (object)Image ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultAdminID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultAdminID;
        }


        public static bool FindAdmins(ref int AdminID, ref string Username, ref string Name, ref string Password, ref int Permissions, ref string Image)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Admins where AdminID =@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AdminID = (int)Reader["AdminID"];
                                Username = (string)Reader["Username"];
                                Name = Reader["Name"] != DBNull.Value ? (string)Reader["Name"] : null;
                                Password = (string)Reader["Password"];
                                Permissions = (int)Reader["Permissions"];
                                Image = Reader["Image"] != DBNull.Value ? (string)Reader["Image"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }


        public static bool FindAdmins(ref int AdminID,  string Username, ref string Name, ref string Password, ref int Permissions, ref string Image)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Admins where Username =@Username";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AdminID = (int)Reader["AdminID"];
                                Username = (string)Reader["Username"];
                                Name = Reader["Name"] != DBNull.Value ? (string)Reader["Name"] : null;
                                Password = (string)Reader["Password"];
                                Permissions = (int)Reader["Permissions"];
                                Image = Reader["Image"] != DBNull.Value ? (string)Reader["Image"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }

        public static bool UpdateAdmins(int AdminID, string Username, string Name, string Password, int Permissions, string Image)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Admins set Username =@Username , Name =@Name , Password =@Password , Permissions =@Permissions , Image =@Image where AdminID =@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);
                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permissions", Permissions);
                        Command.Parameters.AddWithValue("@Image", (object)Image ?? DBNull.Value);

                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }


        public static bool DeleteAdmins(int AdminID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Admins where AdminID=@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);

                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }


        public static bool IsAdminsExist(string Username)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Admins where Username=@Username";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);

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


        public static DataTable AllAdmins()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from Admins";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }



        public static bool UpdatePaswword(string Password , int AdminID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Admins set  Password =@Password  where AdminID =@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@AdminID", AdminID);                  
                        Command.Parameters.AddWithValue("@Password", Password);
                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }

    }
}
