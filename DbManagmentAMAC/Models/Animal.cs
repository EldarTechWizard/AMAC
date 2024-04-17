using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class Animal
    {
        protected int id;
        protected string picturePath;
        protected string name;
        protected string animalBreed;
        protected int age;
        protected string sex;
        protected string animalType;
        protected bool sterilized;
        protected string additionalInformation;
        protected string status;
        protected DateTime birthDate;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string AnimalBreed { get => animalBreed; set => animalBreed = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public bool Sterilized { get => sterilized; set => sterilized = value; }
        public string AdditionalInformation { get => additionalInformation; set => additionalInformation = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public string Status { get => status; set => status = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
