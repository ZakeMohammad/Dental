using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HudaClinc_DataAccessLayer
{
    public class clsAppointmentsData
    {
        public static int AddNewAppointments(int PatientID, int StartTimeMuinets, int StartTimeHours, int EndTImeMuinets, int EndTimeHours, DateTime Date, int DoctorID, string Notes, int? Status,string AMOrPM)
        {

            int DefultAppointmentID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Appointments values (@PatientID,@StartTimeMuinets,@StartTimeHours,@EndTImeMuinets,@EndTimeHours,@Date,@DoctorID,@Notes,@Status,@AMOrPM) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@StartTimeMuinets", StartTimeMuinets);
                        Command.Parameters.AddWithValue("@StartTimeHours", StartTimeHours);
                        Command.Parameters.AddWithValue("@EndTImeMuinets", EndTImeMuinets);
                        Command.Parameters.AddWithValue("@EndTimeHours", EndTimeHours);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@AMOrPM", AMOrPM);
                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultAppointmentID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultAppointmentID;
        }


        public static bool FindAppointments(ref int AppointmentID, ref int PatientID, ref int StartTimeMuinets, ref int StartTimeHours, ref int EndTImeMuinets, ref int EndTimeHours, ref DateTime Date, ref int DoctorID, ref string Notes, ref int? Status,ref string AMOrPM)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Appointments where AppointmentID =@AppointmentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AppointmentID = (int)Reader["AppointmentID"];
                                PatientID = (int)Reader["PatientID"];
                                StartTimeMuinets = (int)Reader["StartTimeMuinets"];
                                StartTimeHours = (int)Reader["StartTimeHours"];
                                EndTImeMuinets = (int)Reader["EndTImeMuinets"];
                                EndTimeHours = (int)Reader["EndTimeHours"];
                                Date = (DateTime)Reader["Date"];
                                DoctorID = (int)Reader["DoctorID"];
                                Notes = Reader["Notes"] != DBNull.Value ? (string)Reader["Notes"] : null;
                                Status = (int?)Reader["Status"];
                                Status = ((int?)((object)Status ?? DBNull.Value));
                                AMOrPM = (string)Reader["AMOrPM"];
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


        public static bool FindForPatiantDetelis(ref int AppointmentID,  int PatientID, ref int StartTimeMuinets, ref int StartTimeHours, ref int EndTImeMuinets, ref int EndTimeHours, ref DateTime Date, ref int DoctorID, ref string Notes, ref int? Status,ref string AMOrPM)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select top 1 * from  Appointments where PatientID =@PatientID and Status=1 order by Date";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AppointmentID = (int)Reader["AppointmentID"];
                                PatientID = (int)Reader["PatientID"];
                                StartTimeMuinets = (int)Reader["StartTimeMuinets"];
                                StartTimeHours = (int)Reader["StartTimeHours"];
                                EndTImeMuinets = (int)Reader["EndTImeMuinets"];
                                EndTimeHours = (int)Reader["EndTimeHours"];
                                Date = (DateTime)Reader["Date"];
                                DoctorID = (int)Reader["DoctorID"];
                                Notes = Reader["Notes"] != DBNull.Value ? (string)Reader["Notes"] : null;
                                Status = (int?)Reader["Status"];
                                Status = ((int?)((object)Status ?? DBNull.Value));
                                AMOrPM = (string)Reader["AMOrPM"];
                              
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

        public static bool UpdateAppointments(int AppointmentID, int PatientID, int StartTimeMuinets, int StartTimeHours, int EndTImeMuinets, int EndTimeHours, DateTime Date, int DoctorID, string Notes, int? Status, string AMOrPM)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Appointments set PatientID =@PatientID , StartTimeMuinets =@StartTimeMuinets , StartTimeHours =@StartTimeHours , EndTImeMuinets =@EndTImeMuinets , EndTimeHours =@EndTimeHours , Date =@Date , DoctorID =@DoctorID , Notes =@Notes , Status =@Status , AMOrPM=@AMOrPM where AppointmentID =@AppointmentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@StartTimeMuinets", StartTimeMuinets);
                        Command.Parameters.AddWithValue("@StartTimeHours", StartTimeHours);
                        Command.Parameters.AddWithValue("@EndTImeMuinets", EndTImeMuinets);
                        Command.Parameters.AddWithValue("@EndTimeHours", EndTimeHours);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@AMOrPM", AMOrPM);

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

        
        public static bool DeleteAppointments(int AppointmentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Appointments where AppointmentID=@AppointmentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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


        public static bool IsAppointmentsExist(int AppointmentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Appointments where AppointmentID=@AppointmentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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


        public static DataTable AllAppointments()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Appointments.AppointmentID,Patients.PatientName,(CONVERT(NVARCHAR(20), Appointments.StartTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.StartTimeMuinets))+' - '+(CONVERT(NVARCHAR(20), Appointments.EndTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.EndTImeMuinets))as Time , Appointments.AMOrPM , Appointments.Date, Doctors.Name as DoctorName, Appointments.Notes,AppointmentsStatus.StatusName from Appointments join Patients on Appointments.PatientID=Patients.PatientID inner join Doctors on Appointments.DoctorID=Doctors.DoctorID inner join AppointmentsStatus on Appointments.Status=AppointmentsStatus.StatusID";

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

        public static DataTable AllAppointments(string Date)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Appointments.AppointmentID,Patients.PatientName,(CONVERT(NVARCHAR(20), Appointments.StartTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.StartTimeMuinets))+' - '+(CONVERT(NVARCHAR(20), Appointments.EndTimeHours)+':'+CONVERT(NVARCHAR(20), Appointments.EndTImeMuinets))as Time , Appointments.Date, Doctors.Name as DoctorName, Appointments.Notes,AppointmentsStatus.StatusName  from Appointments join Patients on Appointments.PatientID=Patients.PatientID inner join Doctors on Appointments.DoctorID=Doctors.DoctorID inner join AppointmentsStatus on Appointments.Status=AppointmentsStatus.StatusID where Appointments.Date=@Date";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();
                        Command.Parameters.AddWithValue("@Date", Date);
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

        public static DataTable AllAppointmentsStartTimeAndEndTIme(string Date,string pm)
        {

           

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select StartTimeHours,StartTimeMuinets,EndTimeHours,EndTImeMuinets  from Appointments where Date=@Date and AMOrPM=@pm and Status=1";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@pm", pm);

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
    

        public static bool IsThereAnyAppointmentinThiTimeAndDate(int sh,int sm,int eh,int em,string amorpm,DateTime date)
        {
            bool Ruslt = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Appointments where StartTimeMuinets=@sm and StartTimeHours=@sh and EndTImeMuinets=@em and EndTimeHours=@eh and Date=@date and AMOrPM=@amorpm and  Status=1 ";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@sh", sh);
                        Command.Parameters.AddWithValue("@sm", sm);
                        Command.Parameters.AddWithValue("@eh", eh);
                        Command.Parameters.AddWithValue("@em", em);
                        Command.Parameters.AddWithValue("@date", date);
                        Command.Parameters.AddWithValue("@amorpm", amorpm);
                        Connection.Open();


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                                Ruslt = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Ruslt;
        }



        public static Dictionary<int,int>AllIntervalInTthisDay(string Date, string AMOrPM)
        {
          Dictionary<int,int>Rustl = new Dictionary<int,int>();
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select StartTimeHours,EndTimeHours from Appointments where Date=@Date and AMOrPM=@pm and Status=1";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@pm", AMOrPM);

                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                           if(Reader.HasRows)
                           {
                                dt.Load(Reader);
                           }

                            foreach (DataRow Row in dt.Rows)
                            {
                                Rustl.Add(Convert.ToInt32(Row["StartTimeHours"]), Convert.ToInt32(Row["EndTimeHours"]));
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }


            return Rustl;
        }


        public static bool ChangeStatus(int AppointmentID,int status)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Appointments set Status=@status where AppointmentID=@AppointmentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        Command.Parameters.AddWithValue("@status", status);
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
