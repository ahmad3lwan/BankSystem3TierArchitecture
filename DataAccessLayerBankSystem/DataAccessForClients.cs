using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class DataAccessForClients
    {
        public static bool FindClientByID(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string AccountNumber, ref int PinCode, ref float AccountBalance)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * from Clients Where ID=@ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = (Convert.ToSingle(reader["AccountBalance"]));
                    PinCode = (Convert.ToInt32(reader["PinCode"]));
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool FindClientByAccountNumber(ref int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, string AccountNumber, ref int PinCode, ref float AccountBalance)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * from Clients Where AccountNumber=@AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    ID = Convert.ToInt32(reader["ID"]);
                    AccountBalance = (Convert.ToSingle(reader["AccountBalance"]));
                    PinCode = (Convert.ToInt32(reader["PinCode"]));
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewClientAndReturnID(string FirstName, string LastName, string Email, string Phone, string AccountNumber, int PinCode, float AccountBalance)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);
            string Query = @"
                 insert into Clients
                   (FirstName,LastName,Email,Phone,AccountNumber,PinCode,AccountBalance)
                    values
                        (@FirstName,@LastName,@Email,@Phone,@AccountNumber,@PinCode,@AccountBalance);
                   select SCOPE_IDENTITY();

          ";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            command.Parameters.AddWithValue("@PinCode", PinCode);

            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Convert.ToString(Result), out int ReturnedID))
                {
                    ID = ReturnedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return ID;

        }

        public static bool UpdateClient(int ID, string FirstName, string LastName, string Email, string Phone, string AccountNumber, int PinCode, float AccountBalance)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"Update Clients 
            set FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone,AccountNumber=@AccountNumber,PinCode=@PinCode,AccountBalance=@AccountBalance  where ID=@ID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            command.Parameters.AddWithValue("@PinCode", PinCode);

            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdated = true;
                }
                else
                {
                    IsUpdated = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }

        public static bool DeleteClient(int ID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Delete From Clients Where ID=@ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDeleted = true;
                }
                else
                {
                    IsDeleted = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsDeleted = false;
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }

        public static bool IsClientExists(int ID)
        {
            bool IsExists = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "select FirstName from Clients where ID=@ID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    IsExists = true;
                }
                else
                {
                    IsExists = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsExists = false;
            }
            finally
            {
                connection.Close();
            }
            return IsExists;

        }

        public static bool IsClientExists(string AccountNumber)
        {
            bool IsExists = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "select FirstName from Clients where AccountNumber=@AccountNumber;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    IsExists = true;
                }
                else
                {
                    IsExists = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsExists = false;
            }
            finally
            {
                connection.Close();
            }
            return IsExists;

        }

        public static bool Deposit(float NewAccountBalance, string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"Update Clients set AccountBalance=@AccountBalance where AccountNumber=@AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            command.Parameters.AddWithValue("@AccountBalance", NewAccountBalance);

            int RowsAffected = 0;
            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
            return (RowsAffected > 0);

        }

        public static bool WithDraw(float NewAccountBalance, string AccountNumber)
        {

            return Deposit(NewAccountBalance, AccountNumber);
        }

        public static DataTable GetAllBalances()
        {
            DataTable datatable = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select AccountNumber,FirstName,LastName,AccountBalance from Clients";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return datatable;

        }

        public static DataTable GetAllClients()
        {
            DataTable datatable = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select *  from Clients";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return datatable;


        }

        public static bool RegisterTransActionRecord(int ID, string AccountNumber, float Amount, DateTime CurrentDate, string TransactionName)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"Insert into Transactions (ID,AccountNumber,Amount,DateTime,TransActionName) 
                      values(@ID,@AccountNumber,@Amount,@DateTime,@TransActionName); ";

            SqlCommand command = new SqlCommand(Query, connection);

            int RowsAffected = 0;
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@DateTime", CurrentDate);
            command.Parameters.AddWithValue("@TransActionName", TransactionName);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool DeleteTransActionRecord(int RecordID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Delete From Transactions Where RecordID=@RecordID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@RecordID", RecordID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDeleted = true;
                }
                else
                {
                    IsDeleted = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
                IsDeleted = false;
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }

        public static DataTable GetAllTransactionsRecord()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);
            string Query = "Select * from Transactions";

            SqlCommand command=new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in"+ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }

    public class DataAccessForUsers
    {

        public static bool UpdateRate(string Code,decimal NewRate)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);
            int RowsAffected = 0;
            string Query = "Update  Currencies set RatePerDollar=@RatePerDollar Where (Code=@Code)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@RatePerDollar", NewRate);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return (RowsAffected > 0);
        }
        public static bool RegisterTransferRecord(int UserID,string UserName,string Acc_S,string Acc_D,float Balance_S,float Balance_D,float Amount,DateTime dateTime)
        {
            SqlConnection connection=new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"insert into Transfers (UserID,UserName,SourceAccNo,DestinationAccNo,SourceBalance,DestinationBalance,Amount,DateTime)
            values  (@UserID,@UserName,@SourceAccNo,@DestinationAccNo,@SourceBalance,@DestinationBalance,@Amount,@DateTime) ;           ";

            SqlCommand command =new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@SourceAccNo", Acc_S);
            command.Parameters.AddWithValue("@DestinationAccNo", Acc_D);
            command.Parameters.AddWithValue("@SourceBalance", Balance_S);
            command.Parameters.AddWithValue("@DestinationBalance", Balance_D);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@DateTime", dateTime);
            int RowsAffected = 0;
            try
            {
                connection.Open();
                RowsAffected=command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in "+ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool DeleteTransferRecord(DateTime TransactionDateTime)
        {
            
            SqlConnection connection=new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Delete From Transfers Where (DateTime=@DateTime) ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DateTime", TransactionDateTime);

            int RowsAffected = 0;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool FindCurrency(ref int ID,ref string Country,string Code,ref string Name,ref decimal Rate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);
            string Query = @"Select * From Currencies Where (Code=@Code)";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ID"];
                    Country = (string)reader["Country"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["RatePerDollar"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in "+ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool Find(ref int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, string UserName, string Password, ref int Permission)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * from Users Where (UserName=@UserName and Password=@Password)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = Convert.ToInt32(reader["ID"]);
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Permission = Convert.ToInt32(reader["Permission"]);
                    IsFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewUserAndReturnID(string FirstName, string LastName, string Email, string Phone, string UserName, string Password, int Permission)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);
            string Query = @"
                 insert into Users
                   (FirstName,LastName,Email,Phone,UserName,Password,Permission)
                    values
                        (@FirstName,@LastName,@Email,@Phone,@UserName,@Password,@Permission);
                   select SCOPE_IDENTITY();

          ";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Convert.ToString(Result), out int ReturnedID))
                {
                    ID = ReturnedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return ID;

        }

        public static bool Update(int ID, string FirstName, string LastName, string Email, string Phone, string UserName, string Password, int Permission)
        {

            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"Update Users 
            set FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone,Permission=@Permission,UserName=@UserName,Password=@Password where(ID=@ID)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            command.Parameters.AddWithValue("@Permission", Permission);

            command.Parameters.AddWithValue("@ID", ID);


            try
            {

                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                IsUpdated = (RowsAffected > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }

        public static bool Delete(string UserName, string Password)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Delete From Users Where (UserName=@UserName and Password=@Password)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                IsDeleted = (RowsAffected > 0);

            }
            catch (Exception ex) { Console.WriteLine("Error in " + ex.Message); }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }

        public static bool IsUserExist(string UserName)
        {
            bool IsUserExist = false;

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"select ID From Users Where UserName=@UserName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                IsUserExist = (result != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUserExist;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * from Users";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader= command.ExecuteReader();
                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }

        public static DataTable GetAllTransfers()
        {
            DataTable dataTable=new DataTable();
            
            SqlConnection connection = new SqlConnection( DataAccessSetting.ConnectionString);
            string Query = "Select * From Transfers";

            SqlCommand command=new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error in "+ex.Message); }
            finally
            {

            }

            return dataTable;
        }

        public static bool LoginRegister(int ID,string UserName,string Password,int Permission,DateTime CurrentDate)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = @"insert into Login (ID,UserName,Password,Permission,DateTime)
           values (@ID,@UserName,@Password,@Permission,@DateTime)  ;"; 

          SqlCommand command= new SqlCommand(Query, connection);
      
            command.Parameters.AddWithValue("@ID", ID);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            command.Parameters.AddWithValue("@Permission", Permission);

            command.Parameters.AddWithValue("@DateTime", CurrentDate);
            int RowsAffected = 0;
            try
            {
                connection.Open();
                RowsAffected=command.ExecuteNonQuery();


            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error in " + ex.Message);
             }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }
        public static bool DeleteLoginRecord(int LoginID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Delete from Login Where (LoginID=@LoginID) ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LoginID", LoginID);
            int RowsAffected = 0;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllLoginRecord()
        {

            SqlConnection connection=new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * From Login order by LoginID Asc";

            SqlCommand command = new SqlCommand(Query, connection);

            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return dataTable;
        }

        public static DataTable GetAllCurrencies()
        {

            SqlConnection connection = new SqlConnection(DataAccessSetting.ConnectionString);

            string Query = "Select * From Currencies order by Country Asc";

            SqlCommand command = new SqlCommand(Query, connection);

            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return dataTable;
        }

        
    }
}