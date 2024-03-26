using DbManagmentAMAC.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DbManagmentAMAC.Repository
{
    public class SqlServer : IRepository
    {
        private string lastError;
        private string connectionString;
        public string LastError => throw new NotImplementedException();

        public SqlServer()
        {

        }
        public SqlServer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool DeleteAdopter()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnimal()
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public bool InsertAdopter(Adopter adopter)
        {
            throw new NotImplementedException();
        }

        public bool InsertAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            try
            {
                connectionString = new SqlConnectionStringBuilder()
                {
                    DataSource = "ASUSTUF",
                    InitialCatalog = "Amac",
                    UserID = username,
                    Password = password
                }.ConnectionString;
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                    conn.Open();

                return true;
            }catch (Exception e)
            {
                lastError = e.Message;
                return false;
            }
        }
        public bool SelectAdopter(DataTable data)
        {
            throw new NotImplementedException();
        }
        public bool SelectAnimal(DataTable data)
        {
            throw new NotImplementedException();
        }
        public bool SelectRecord(DataTable data)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAdopter(Adopter data)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRecord(PetReport petReport)
        {
            throw new NotImplementedException();
        }
    }
}
