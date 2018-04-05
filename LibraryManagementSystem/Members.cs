using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Members
    {
        private string id;
        private string name;
        private string address;
        private string job;
        private string email;
        private int age;
        private bool gender;
        private bool ispenalty;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Job { get => job; set => job = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
        public bool Gender { get => gender; set => gender = value; }
        public bool Ispenalty { get => ispenalty; set => ispenalty = value; }
    }
}
