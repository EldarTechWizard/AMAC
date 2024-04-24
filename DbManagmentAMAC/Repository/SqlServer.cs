using DbManagmentAMAC.Models;
using Microsoft.SqlServer.Server;
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
        public string LastError => lastError;

        public SqlServer()
        {

        }
        public SqlServer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool DeleteAdopter(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteAdopter";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@adopterId", id);
       

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }


        public bool DeleteRecord(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteRecord";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@animalId", id);


                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool InsertRecord(PetReport record)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertRecord";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@Photo", record.PicturePath);
                    cmd.Parameters.AddWithValue("@Name", record.Name);
                    cmd.Parameters.AddWithValue("@Breed", record.AnimalBreed);
                    cmd.Parameters.AddWithValue("@Age", record.Age);
                    cmd.Parameters.AddWithValue("@Sex", record.Sex);
                    cmd.Parameters.AddWithValue("@Sterilized", record.Sterilized);
                    cmd.Parameters.AddWithValue("@AnimalType", record.AnimalType);
                    cmd.Parameters.AddWithValue("@Status", record.Status);
                    cmd.Parameters.AddWithValue("@AdditionalInformation", record.AdditionalInformation);
                    cmd.Parameters.AddWithValue("@RescueDate", record.RescueDate);
                    cmd.Parameters.AddWithValue("@TemporaryHome", record.TempHome);
                    cmd.Parameters.AddWithValue("@Rescuer", record.Rescuer);
                    cmd.Parameters.AddWithValue("@Veterinarian", record.Vet);
                    cmd.Parameters.AddWithValue("@Diagnostic", record.Diagnostic);
                    cmd.Parameters.AddWithValue("@BirthDate", record.BirthDate);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }
        public bool InsertAdopter(Adopter adopter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertAdopter";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@name", adopter.Name);
                    cmd.Parameters.AddWithValue("@age", adopter.Age);
                    cmd.Parameters.AddWithValue("@address", adopter.Address);
                    cmd.Parameters.AddWithValue("@phone", adopter.Number);
                    cmd.Parameters.AddWithValue("@email", adopter.Email);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }


        public bool Login(string username, string password)
        {
            try
            {
                connectionString = new SqlConnectionStringBuilder()
                {
                    DataSource = "LAPTOP-5C9UCS9L",
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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from adopterView";
                    data.Load(cmd.ExecuteReader());
                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool SelectRecord(DataTable data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from animalAndPetReportView";
                    data.Load(cmd.ExecuteReader());
                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool UpdateAdopter(Adopter adopter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateAdopter";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@adopterId", adopter.Id);
                    cmd.Parameters.AddWithValue("@name", adopter.Name);
                    cmd.Parameters.AddWithValue("@age", adopter.Age);
                    cmd.Parameters.AddWithValue("@address", adopter.Address);
                    cmd.Parameters.AddWithValue("@phone", adopter.Number);
                    cmd.Parameters.AddWithValue("@email", adopter.Email);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool UpdateRecord(PetReport record)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateRecord";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@animalId", record.Id);
                    cmd.Parameters.AddWithValue("@photo", record.PicturePath);
                    cmd.Parameters.AddWithValue("@name", record.Name);
                    cmd.Parameters.AddWithValue("@breed", record.AnimalBreed);
                    cmd.Parameters.AddWithValue("@age", record.Age);
                    cmd.Parameters.AddWithValue("@sex", record.Sex);
                    cmd.Parameters.AddWithValue("@sterilized", record.Sterilized);
                    cmd.Parameters.AddWithValue("@animalType", record.AnimalType);
                    cmd.Parameters.AddWithValue("@status", record.Status);
                    cmd.Parameters.AddWithValue("@additionalInfo", record.AdditionalInformation);
                    cmd.Parameters.AddWithValue("@rescueDate", record.RescueDate);
                    cmd.Parameters.AddWithValue("@temporaryHome", record.TempHome);
                    cmd.Parameters.AddWithValue("@rescuer", record.Rescuer);
                    cmd.Parameters.AddWithValue("@veterinarian", record.Vet);
                    cmd.Parameters.AddWithValue("@diagnostic", record.Diagnostic);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool InsertPdfFormat(PdfFormat format)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertAdoptionFormPDF";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@idAnimal", format.AnimalId);
                    cmd.Parameters.AddWithValue("@idAdopter", format.AdopterId);
                    cmd.Parameters.AddWithValue("@volunteerInCharge", format.Volunter);
                    cmd.Parameters.AddWithValue("@adoptionDate", format.AdoptionDate);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool DeletePdfFormat(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteAdoptionFormPDF";
                    cmd.CommandTimeout = 120;

                    cmd.Parameters.AddWithValue("@formId", id);


                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool UpdatePdfFormat(PdfFormat format)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateAdoptionFormPDF";
                    cmd.CommandTimeout =120 ;

                    cmd.Parameters.AddWithValue("@formId",format.Id);
                    cmd.Parameters.AddWithValue("@idAnimal", format.AnimalId);
                    cmd.Parameters.AddWithValue("@idAdopter", format.AdopterId);
                    cmd.Parameters.AddWithValue("@volunteerInCharge", format.Volunter);
                    cmd.Parameters.AddWithValue("@adoptionDate", format.AdoptionDate);


                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool SelectPdfFormat(DataTable data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from adoptionFormatView";
                    data.Load(cmd.ExecuteReader());
                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool GetIdentityNextValue(ref int value, string tableName)
        {
            try
            {
                DataTable temp = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT IDENT_CURRENT( '{tableName}' );";
                    temp.Load(cmd.ExecuteReader());
                }

                value = int.Parse(temp.Rows[0][0].ToString()) + 1;

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool SelectUsers(DataTable data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from usersView";
                    data.Load(cmd.ExecuteReader());
                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }
    }
}
