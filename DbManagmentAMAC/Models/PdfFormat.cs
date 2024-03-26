using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class PdfFormat 
    {
        private PetReport report;
        private Adopter adopter;
        private string volunter;
        private string adoptionName;
        public PdfFormat() { }
        public PdfFormat(PetReport petReport, Adopter adopter) 
        {
            this.report = petReport;
            this.adopter = adopter;
        }

        public PetReport Report { get => report; set => report = value; }
        public Adopter Adopter { get => adopter; set => adopter = value; }
        public string Volunter { get => volunter; set => volunter = value; }
        public string AdoptionName { get => adoptionName; set => adoptionName = value; }
    }
}
