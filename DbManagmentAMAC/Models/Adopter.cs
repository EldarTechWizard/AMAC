using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManagmentAMAC.Models
{
    public class Adopter
    {
        private int id;
        private string name;
        private int age;
        private int address;
        private string number;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Address { get => address; set => address = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
    }
}
