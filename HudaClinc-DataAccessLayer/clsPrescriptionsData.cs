using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_DataAccessLayer
{
    public class clsPrescriptionsData
    {
        public static int AddNewPrescriptions(int PatientID, int DoctorID, string Description, int MedicineID, DateTime Date)
        {

            int DefultPrescriptionID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Prescriptions values (@PatientID,@DoctorID,@Description,@MedicineID,@Date) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@MedicineID", MedicineID);
                        Command.Parameters.AddWithValue("@Date", Date);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultPrescriptionID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultPrescriptionID;
        }


        public static bool FindPrescriptions(ref int PrescriptionID, ref int PatientID, ref int DoctorID, ref string Description, ref int MedicineID, ref DateTime Date)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Prescriptions where PrescriptionID =@PrescriptionID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PrescriptionID = (int)Reader["PrescriptionID"];
                                PatientID = (int)Reader["PatientID"];
                                DoctorID = (int)Reader["DoctorID"];
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;
                                MedicineID = (int)Reader["MedicineID"];
                                Date = (DateTime)Reader["Date"];

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


        public static bool UpdatePrescriptions(int PrescriptionID, int PatientID, int DoctorID, string Description, int MedicineID, DateTime Date)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Prescriptions set PatientID =@PatientID , DoctorID =@DoctorID , Description =@Description , MedicineID =@MedicineID , Date =@Date where PrescriptionID =@PrescriptionID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@MedicineID", MedicineID);
                        Command.Parameters.AddWithValue("@Date", Date);

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


        public static bool DeletePrescriptions(int PrescriptionID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Prescriptions where PrescriptionID=@PrescriptionID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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


        public static bool IsPrescriptionsExist(int PrescriptionID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Prescriptions where PrescriptionID=@PrescriptionID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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


        public static DataTable AllPrescriptions()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    string Querey = "SELECT Prescriptions.PrescriptionID, Patients.PatientName, Doctors.Name AS DoctorName, Prescriptions.Description, Medicines.Name AS  Medicine, Prescriptions.Date FROM     Doctors INNER JOIN Prescriptions ON Doctors.DoctorID = Prescriptions.DoctorID INNER JOIN Medicines ON Prescriptions.MedicineID = Medicines.ID INNER JOIN Patients ON Prescriptions.PatientID = Patients.PatientID";
                    

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

        public static DataTable AllPrescriptions2()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select top 5 * from Prescriptions order by Date desc";

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

    }
}
