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
    public class clsPaymentsData
    {
        public static int AddNewPayments(int PatientID,  DateTime Date, decimal Amount, string Notes, bool ItsLastOne, int AdminID)
        {

            int DefultPaymentID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "insert into Payments values (@PatientID,@Date,@Amount,@Notes,@ItsLastOne,@AdminID) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                     
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ItsLastOne", ItsLastOne);
                        Command.Parameters.AddWithValue("@AdminID", AdminID);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultPaymentID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultPaymentID;
        }


        public static bool FindPayments(ref int PaymentID, ref int PatientID, ref DateTime Date, ref decimal Amount, ref string Notes, ref bool ItsLastOne, ref int AdminID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select * from  Payments where PaymentID =@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PaymentID = (int)Reader["PaymentID"];
                                PatientID = (int)Reader["PatientID"];
                           
                                Date = (DateTime)Reader["Date"];
                                Amount = (decimal)Reader["Amount"];
                                Notes = Reader["Notes"] != DBNull.Value ? (string)Reader["Notes"] : null;
                                ItsLastOne = (bool)Reader["ItsLastOne"];
                                AdminID = (int)Reader["AdminID"];

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


        public static bool UpdatePayments(int PaymentID, int PatientID, DateTime Date, decimal Amount, string Notes, bool ItsLastOne, int AdminID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "update Payments set PatientID =@PatientID  , Date =@Date , Amount =@Amount , Notes =@Notes , ItsLastOne =@ItsLastOne , AdminID =@AdminID where PaymentID =@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
          
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ItsLastOne", ItsLastOne);
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


        public static bool DeletePayments(int PaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "Delete from Payments where PaymentID=@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

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


        public static bool IsPaymentsExist(int PaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select Found=1 from Payments where PaymentID=@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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


        public static DataTable AllPayments()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "SELECT Payments.PaymentID, Patients.PatientName, Payments.Date, Payments.Amount, Payments.Notes, Admins.Username FROM     Payments INNER JOIN                Admins ON Payments.AdminID = Admins.AdminID INNER JOIN                 Patients ON Payments.PatientID = Patients.PatientID";

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

        public static DataTable AllPayments2()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    string Querey = "select  top 4 * from TopPayment order by Date desc";

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
