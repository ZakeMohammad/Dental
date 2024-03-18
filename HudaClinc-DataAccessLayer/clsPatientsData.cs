using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HudaClinc_DataAccessLayer
{
    public class clsPatientsData
    {
        public static int AddNewPatients(string PatientName, string Phone, string Email, int Age, string FirstIllness, string SecondIllness, string ThearedIllness, string FourIllness, string FiveIllness, int RequiredTreatment, bool NeedReview)
        {

            int DefultPatientID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Patients values (@PatientName,@Phone,@Email,@Age,@FirstIllness,@SecondIllness,@ThearedIllness,@FourIllness,@FiveIllness,@RequiredTreatment,@NeedReview) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientName", PatientName);
                        Command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Age", Age);
                        Command.Parameters.AddWithValue("@FirstIllness", (object)FirstIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@SecondIllness", (object)SecondIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ThearedIllness", (object)ThearedIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@FourIllness", (object)FourIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@FiveIllness", (object)FiveIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@RequiredTreatment", RequiredTreatment);
                        Command.Parameters.AddWithValue("@NeedReview", NeedReview);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultPatientID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultPatientID;
        }


        public static bool FindPatients( int PatientID, ref string PatientName, ref string Phone, ref string Email, ref int Age, ref string FirstIllness, ref string SecondIllness, ref string ThearedIllness, ref string FourIllness, ref string FiveIllness, ref int RequiredTreatment, ref bool NeedReview)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Patients where PatientID =@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PatientID = (int)Reader["PatientID"];
                                PatientName = (string)Reader["PatientName"];
                                Phone = Reader["Phone"] != DBNull.Value ? (string)Reader["Phone"] : null;
                                Email = Reader["Email"] != DBNull.Value ? (string)Reader["Email"] : null;
                                Age = (int)Reader["Age"];
                                FirstIllness = Reader["FirstIllness"] != DBNull.Value ? (string)Reader["FirstIllness"] : null;
                                SecondIllness = Reader["SecondIllness"] != DBNull.Value ? (string)Reader["SecondIllness"] : null;
                                ThearedIllness = Reader["ThearedIllness"] != DBNull.Value ? (string)Reader["ThearedIllness"] : null;
                                FourIllness = Reader["FourIllness"] != DBNull.Value ? (string)Reader["FourIllness"] : null;
                                FiveIllness = Reader["FiveIllness"] != DBNull.Value ? (string)Reader["FiveIllness"] : null;
                                RequiredTreatment = (int)Reader["RequiredTreatment"];
                                NeedReview = (bool)Reader["NeedReview"];

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


        public static bool FindPatients(ref int PatientID, string PatientName, ref string Phone, ref string Email, ref int Age, ref string FirstIllness, ref string SecondIllness, ref string ThearedIllness, ref string FourIllness, ref string FiveIllness, ref int RequiredTreatment, ref bool NeedReview)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Patients where PatientName =@PatientName";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientName", PatientName);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PatientID = (int)Reader["PatientID"];
                                PatientName = (string)Reader["PatientName"];
                                Phone = Reader["Phone"] != DBNull.Value ? (string)Reader["Phone"] : null;
                                Email = Reader["Email"] != DBNull.Value ? (string)Reader["Email"] : null;
                                Age = (int)Reader["Age"];
                                FirstIllness = Reader["FirstIllness"] != DBNull.Value ? (string)Reader["FirstIllness"] : null;
                                SecondIllness = Reader["SecondIllness"] != DBNull.Value ? (string)Reader["SecondIllness"] : null;
                                ThearedIllness = Reader["ThearedIllness"] != DBNull.Value ? (string)Reader["ThearedIllness"] : null;
                                FourIllness = Reader["FourIllness"] != DBNull.Value ? (string)Reader["FourIllness"] : null;
                                FiveIllness = Reader["FiveIllness"] != DBNull.Value ? (string)Reader["FiveIllness"] : null;
                                RequiredTreatment = (int)Reader["RequiredTreatment"];
                                NeedReview = (bool)Reader["NeedReview"];

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


        public static bool UpdatePatients(int PatientID, string PatientName, string Phone, string Email, int Age, string FirstIllness, string SecondIllness, string ThearedIllness, string FourIllness, string FiveIllness, int RequiredTreatment, bool NeedReview)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Patients set PatientName =@PatientName , Phone =@Phone , Email =@Email , Age =@Age , FirstIllness =@FirstIllness , SecondIllness =@SecondIllness , ThearedIllness =@ThearedIllness , FourIllness =@FourIllness , FiveIllness =@FiveIllness , RequiredTreatment =@RequiredTreatment , NeedReview =@NeedReview where PatientID =@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@PatientName", PatientName);
                        Command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Age", Age);
                        Command.Parameters.AddWithValue("@FirstIllness", (object)FirstIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@SecondIllness", (object)SecondIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ThearedIllness", (object)ThearedIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@FourIllness", (object)FourIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@FiveIllness", (object)FiveIllness ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@RequiredTreatment", RequiredTreatment);
                        Command.Parameters.AddWithValue("@NeedReview", NeedReview);

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


        public static bool DeletePatients(int PatientID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Patients where PatientID=@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

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


        public static bool IsPatientsExist(int PatientID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Patients where PatientID=@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

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


        public static DataTable AllPatients()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "SELECT Patients.PatientID, Patients.PatientName, Patients.Phone, Patients.Email, Patients.Age, Patients.FirstIllness, Patients.SecondIllness, Patients.ThearedIllness, Patients.FourIllness, Patients.FiveIllness, Treatments.Name, Treatments.Price,                  Patients.NeedReview FROM     Patients INNER JOIN                  Treatments ON Patients.RequiredTreatment = Treatments.TreatmentID";

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


        public static DataTable AllAppointmentForThisPateint(int PatientID)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Appointments.AppointmentID,Patients.PatientName,(CONVERT(NVARCHAR(20), Appointments.StartTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.StartTimeMuinets))+' - '+(CONVERT(NVARCHAR(20), Appointments.EndTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.EndTImeMuinets))as Time , Appointments.Date, Doctors.Name as DoctorName, Appointments.Notes,AppointmentsStatus.StatusName from Appointments join Patients on Appointments.PatientID=Patients.PatientID inner join Doctors on Appointments.DoctorID=Doctors.DoctorID inner join AppointmentsStatus on Appointments.Status=AppointmentsStatus.StatusID where Patients.PatientID=@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
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

        public static decimal GitLastPaymentAmount(int PatientID)
        {

            decimal Number = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Amount from Payments where PatientID=@PatientID and ItsLastOne=1";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

                        Connection.Open();

                        Number = Convert.ToDecimal(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Number ;
        }
        public static int GitNumberOfPerspictoin(int PatientID)
        {

            int Number = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select COUNT(*) from Prescriptions where PatientID=@PatientID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

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
        public static bool DisabelPayments(int PatientID, int PaymentID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Payments set ItsLastOne=0 where PatientID =@PatientID and PaymentID!=@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
