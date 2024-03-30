using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class PetReport : Animal
    {
        private string rescueDate;
        private string diagnostic;
        private string tempHome;
        private string vet;

        public PetReport() { }
        public PetReport(Animal animal) 
        {
            this.id = animal.Id;
            this.picturePath = animal.PicturePath;
            this.name = animal.Name;
            this.animalBreed = animal.AnimalBreed;
            this.age = animal.Age;
            this.sex = animal.Sex;
            this.animalType = animal.AnimalType;
            this.sterilized = animal.Sterilized;
            this.additionalInformation = animal.AdditionalInformation;
            this.rescuer = animal.Rescuer;
        }

        public string RescueDate { get => rescueDate; set => rescueDate = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        public string TempHome { get => tempHome; set => tempHome = value; }
        public string Vet { get => vet; set => vet = value; }
        
    }
}
