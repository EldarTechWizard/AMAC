using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public interface IRepository
    {

        string LastError { get; }

        bool Login(string username, string password);
        bool SelectUsers(DataTable data);
        bool InsertAdopter(Adopter adopter);
        bool SelectAdopter(DataTable data);
        bool DeleteAdopter(int id);
        bool UpdateAdopter(Adopter data);
        bool InsertRecord(PetReport record);
        bool SelectRecord(DataTable data);
        bool DeleteRecord(int id);
        bool UpdateRecord(PetReport petReport);
        bool InsertPdfFormat(PdfFormat format);
        bool SelectPdfFormat(DataTable data);
        bool DeletePdfFormat(int id);
        bool UpdatePdfFormat(PdfFormat format);
        bool GetIdentityNextValue(ref int value, string tableName);

    }
}
