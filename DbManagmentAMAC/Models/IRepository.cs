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
        bool InsertAnimal(Animal animal);
        bool SelectAnimal(DataTable data);
        bool DeleteAnimal();
        bool UpdateAnimal(Animal animal);
        bool InsertAdopter(Adopter adopter);
        bool SelectAdopter(DataTable data);
        bool DeleteAdopter();
        bool UpdateAdopter(Adopter data);
        bool SelectRecord(DataTable data);
        bool DeleteRecord();
        bool UpdateRecord(PetReport petReport);

    }
}
