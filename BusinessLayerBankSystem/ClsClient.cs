using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayerBankSystem;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Server;
namespace BusinessLayerBankSystem
{

    public class clsTransactionRecord
    {
        public static bool DeleteTransActionRecord(int RecordID)
        {
            return DataAccessForClients.DeleteTransActionRecord(RecordID);
        }
        public static DataTable GetAllTransactionRecord()
        {
            return DataAccessForClients.GetAllTransactionsRecord();
        }
    }
    public class clsTransfersRecord
    {
        public static bool DeleteTransferRecord(DateTime TransferTime)
        {
            return DataAccessForUsers.DeleteTransferRecord(TransferTime);
        }
    }

    public class clsCurrencies
    {
        public int ID
        {
            get;set;
        }

        public string Country
        {
            get;set;
        }
        public string Code
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public decimal Rate
        {
            get;set;
        }
        public clsCurrencies()
        {
            this.Code = "";
            this.Rate = 0;
            this.Country = "";
            this.Name = "";
        }
        public clsCurrencies(int ID,string Country,string Code,string Name,decimal Rate)
        {
            this.ID = ID;
            this.Country = Country;
            this.Code = Code;
            this.Name = Name;
            this.Rate = Rate;

        }
        public static DataTable GetAllCurrencies()
        {
            return DataAccessForUsers.GetAllCurrencies();
        }
        public static clsCurrencies Find(string Code)
        {
            int id = -1;
            string country = "";
            string name = "";
            decimal rate = 0;

            if(DataAccessForUsers.FindCurrency(ref id,ref country,Code,ref name,ref rate))
            {
                return new clsCurrencies(id, country, Code, name, rate);
            }
            else
            {
                return null;
            }
        }

        public static bool  UpdateRate(string Code,decimal NewRate)
        {
            return DataAccessForUsers.UpdateRate( Code, NewRate);
        }
    }
    public class clsLoginRecord
    {
        public static bool LoginRegister(int ID,string UserName,string Password,int Permission,DateTime CurrentTime)
        {
            return DataAccessForUsers.LoginRegister(ID,UserName,Password,Permission,CurrentTime);
        }
        public static bool DeleteLoginRecord(int LoginID)
        {
            return DataAccessForUsers.DeleteLoginRecord(LoginID);
        }
        public static DataTable GetAllLoginRecord()
        {
            return DataAccessForUsers.GetAllLoginRecord();

        }

    }

    public class ClsPerson
    {
         public enum enMode
        {
            enAddNew = 0, enUpdate = 1
        }
       public enMode _CurrentMode;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
    public class ClsClient:ClsPerson
    {
      
        float _Amount;
        enum enTransactions
        {
            enDeposit=0,enWithDraw=1
        }
        enTransactions _CurrentTransaction;
        public string AccountNumber { get; set; }   
        public int PinCode { get; set; }
        public float AccountBalance {  get; set; }

        public ClsClient()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            AccountNumber = "";
            PinCode = -1;
            AccountBalance = -1;
            _CurrentMode = enMode.enAddNew;
        }

        private ClsClient(int ID,string FirstName,string LastName,string Email,string  Phone,string AccountNumber,int PinCode,float AccountBalance)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.AccountBalance = AccountBalance;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;

            _CurrentMode = enMode.enUpdate;
        }

        public static  ClsClient FindByID(int ID)
        {
            string FirstName = ""; string LastName = "";string Email = "";string Phone = "";string AccountNumber = "";
            int PinCode = -1; float AccountBalance = -1;
            if(DataAccessForClients.FindClientByID(ID,ref FirstName,ref LastName,ref Email,ref Phone,ref AccountNumber,ref PinCode,ref AccountBalance ))
            {
                return new ClsClient(ID,FirstName,LastName,Email,Phone,AccountNumber,PinCode,AccountBalance);
            }
            else
            {
                return null;
            }

        }

        public static ClsClient FindByAccountNumber(string AccountNumber)
        {
            int ID = -1;
            string FirstName = ""; string LastName = ""; string Email = ""; string Phone = "";
            int PinCode = -1; float AccountBalance = -1;
            if (DataAccessForClients.FindClientByAccountNumber(ref ID, ref FirstName, ref LastName, ref Email, ref Phone,  AccountNumber, ref PinCode, ref AccountBalance))
            {
                return new ClsClient(ID, FirstName, LastName, Email, Phone, AccountNumber, PinCode, AccountBalance);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewClient()
        {
            this.ID = DataAccessForClients.AddNewClientAndReturnID(this.FirstName, this.LastName, this.Email, this.Phone, this.AccountNumber, this.PinCode, this.AccountBalance);

            return (this.ID != -1);
        }

        public static bool DeleteClient(int ID)
        {
            return DataAccessForClients.DeleteClient(ID);
        }

        public static bool IsClientExists(int ID)
        {
            return DataAccessForClients.IsClientExists(ID);
        }
        public static bool IsClientExists(string AccountNumber)
        {
            return DataAccessForClients.IsClientExists(AccountNumber);
        }
        private bool _UpdateClient()
        {
            return DataAccessForClients.UpdateClient(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.AccountNumber, this.PinCode, this.AccountBalance);
        }

        private void _RegisterTransActionRecordInDataBase()
        {
            DateTime CurrentDate= DateTime.Now;
            switch(_CurrentTransaction)
            {
                case enTransactions.enDeposit:
                   DataAccessForClients.RegisterTransActionRecord(this.ID, this.AccountNumber, this._Amount, CurrentDate, "Deposit");
                    break;
                case enTransactions.enWithDraw:
                   DataAccessForClients.RegisterTransActionRecord(this.ID, this.AccountNumber, this._Amount, CurrentDate, "WithDraw");
                    break;

            }
        }
        public bool Deposit(float Amount)
        {
            if(Amount>0)
            {
                _Amount = Amount;
                this.AccountBalance += Amount;
              if(DataAccessForClients.Deposit(this.AccountBalance, this.AccountNumber))
                {
                    
                    _CurrentTransaction = enTransactions.enDeposit;
                    _RegisterTransActionRecordInDataBase();
                    return true;
                }
              else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public bool WithDraw(float Amount)
        {
            if(Amount>=this.AccountBalance||Amount==0)
            {
                return false;
            }

            else
            {
                this.AccountBalance -= Amount;
                _Amount = Amount;
                if(DataAccessForClients.WithDraw(this.AccountBalance, this.AccountNumber))
                {
                    _CurrentTransaction = enTransactions.enWithDraw;
                    _RegisterTransActionRecordInDataBase();
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static DataTable GetTotalBalances()
        {
            return DataAccessForClients.GetAllBalances();
        }

        public static DataTable GetAllClients()
        {
            return DataAccessForClients.GetAllClients();
        }
        private void _RegisterTransferRecordInDataBase(int UserID,string UserName,string Acc_s,string Acc_D,float Balance_s,float Balance_D,float Amount )
        {
            DateTime dateTime = DateTime.Now;
            DataAccessForUsers.RegisterTransferRecord(UserID,UserName,Acc_s,Acc_D,Balance_s,Balance_D,Amount, dateTime);
        }

        public  bool Transfer(int UserID,string UserName,float Amount,ClsClient ClientDestination)
        {
            if(Amount>this.AccountBalance)
            {
                return false;
            }
            this.WithDraw(Amount);
            ClientDestination.Deposit(Amount);
            _RegisterTransferRecordInDataBase(UserID,UserName,this.AccountNumber,ClientDestination.AccountNumber,this.AccountBalance,ClientDestination.AccountBalance,Amount);
            return true;


        }
        public bool Save()
        {
            switch(_CurrentMode)
            {
                case enMode.enAddNew:
                    if(_AddNewClient())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateClient();
            }
            return false;


        }


    }
    public class ClsUser:ClsPerson
    {
        public  enum enPermissions
        {
            pAll = -1, pManageClient = 1, pTransaction = 2, pManageUsers = 4, pCurrencyExchange = 8, pLoginRegister = 16
        }


        public string UserName
        {
            get;set;
        }

        public string Password
        {
            get;set;
        }
        public int Permission
        {
            get;set;
        }
        public ClsUser()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            UserName = "";
            Password = "";
            ID = -1;
            Permission = 0;
            _CurrentMode = enMode.enAddNew;
        }
        public bool CheckUserPermission(enPermissions permissions)
        {
            if((enPermissions)(this.Permission)==enPermissions.pAll)
            {
                return true;
            }

            if ((((enPermissions)(this.Permission))&(permissions)) == permissions)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private ClsUser(int ID,string FirstName,string LastName,string Email,string Phone,string UserName,string Password,int Permission)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;

            _CurrentMode=enMode.enUpdate;

        }

        public static ClsUser Find(string UserName, string Password)
        {
            string FirstName = ""; string LastName = ""; string Email = ""; string Phone = "";
            int ID = -1;int Permission = 0;
            if(DataAccessForUsers.Find( ref ID,ref FirstName,ref LastName,ref Email,ref Phone,UserName,Password,ref Permission))
            {
                return new ClsUser(ID,FirstName,LastName,Email,Phone,UserName,Password,Permission);
            }
            else
            {
                return null;
            }
        }
       
        public static bool Delete(string UserName,string Password)
        {
            return DataAccessForUsers.Delete(UserName, Password);
        }
        public static bool IsUserExist(string UserName)
        {
            return DataAccessForUsers.IsUserExist(UserName);
        }
        private bool _AddNewUser()
        {
            this.ID = DataAccessForUsers.AddNewUserAndReturnID(FirstName, LastName, Email, Phone, UserName, Password, Permission);

            return (this.ID != -1);
        }
        private bool _UpdateUser()
        {
            return DataAccessForUsers.Update(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.UserName, this.Password, this.Permission);

        }

        public static DataTable GetAllUsers()
        {
            return DataAccessForUsers.GetAllUsers();
        }
        public bool Save()
        {
            switch(_CurrentMode)
            {
                case enMode.enAddNew:
                    if(_AddNewUser())
                    {
                        return true;
                     }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateUser();

            }
            return false;
        }
        public static DataTable GetAllTransfers()
        {
            return DataAccessForUsers.GetAllTransfers();
        }
    }

}
