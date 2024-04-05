using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class PdfFormat 
    {
        private int animalId;
        private int adopterId;
        private DateTime adoptionDate;
        private string volunter;
        public PdfFormat() { }


        public int AnimalId { get => animalId; set => animalId = value; }
        public int AdopterId { get => adopterId; set => adopterId = value; }
        public DateTime AdoptionDate { get => adoptionDate; set => adoptionDate = value; }
        public string Volunter { get => volunter; set => volunter = value; }
    }
}
