using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HudaClinc_DataAccessLayer
{
    public class clsDoctorsData
    {
        public static int AddNewDoctors(string Name, string Phone, string Email, string Adrees, int PatientNumber)
        {

            int DefultDoctorID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Doctors values (@Name,@Phone,@Email,@Adrees,@PatientNumber) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Adrees", Adrees);
                        Command.Parameters.AddWithValue("@PatientNumber", PatientNumber);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultDoctorID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultDoctorID;
        }


        public static bool FindDoctors( int DoctorID, ref string Name, ref string Phone, ref string Email, ref string Adrees, ref int PatientNumber)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Doctors where DoctorID =@DoctorID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                DoctorID = (int)Reader["DoctorID"];
                                Name = (string)Reader["Name"];
                                Phone = (string)Reader["Phone"];
                                Email = (string)Reader["Email"];
                                Adrees = (string)Reader["Adrees"];
                                PatientNumber = (int)Reader["PatientNumber"];

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
        public static bool FindDoctors(ref int DoctorID,  string Name, ref string Phone, ref string Email, ref string Adrees, ref int PatientNumber)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Doctors where Name =@Name";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                DoctorID = (int)Reader["DoctorID"];
                                Name = (string)Reader["Name"];
                                Phone = (string)Reader["Phone"];
                                Email = (string)Reader["Email"];
                                Adrees = (string)Reader["Adrees"];
                                PatientNumber = (int)Reader["PatientNumber"];

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

        public static bool UpdateDoctors(int DoctorID, string Name, string Phone, string Email, string Adrees, int PatientNumber)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Doctors set Name =@Name , Phone =@Phone , Email =@Email , Adrees =@Adrees , PatientNumber =@PatientNumber where DoctorID =@DoctorID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Adrees", Adrees);
                        Command.Parameters.AddWithValue("@PatientNumber", PatientNumber);

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


        public static bool DeleteDoctors(int DoctorID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Doctors where DoctorID=@DoctorID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);

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


        public static bool IsDoctorsExist(int DoctorID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Doctors where DoctorID=@DoctorID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);

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


        public static DataTable AllDoctors()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from Doctors";

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


        public static int GitCurrentPatinetForThisDoctor(int DoctorID)
        {
            int Number = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select count(*) from Appointments where DoctorID=@DoctorID and Status=1";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        Connection.Open();

                        Number = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Number;
        }


    }

}
