using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class PetReport : Animal
    {
        private DateTime rescueDate;
        private string diagnostic;
        private string tempHome;
        private string vet;
        private string rescuer;

        public PetReport() { }
        

        public DateTime RescueDate { get => rescueDate; set => rescueDate = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        public string TempHome { get => tempHome; set => tempHome = value; }
        public string Vet { get => vet; set => vet = value; }
        public string Rescuer { get => rescuer; set => rescuer = value; }
    }
}
