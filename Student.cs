using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG252_Project_Joshua_Simanga_Mieke
{
    class Student
    {
        private int studNumber;
        private string name, surname;
        private string gender;
        private string dob;
        private string moduleCodes;
        private string address;
        private string phoneNo;
        string userName; 
        string password;
        System.Drawing.Image studImage;

        public int StudNumber { get => studNumber; set => studNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }
        public string ModuleCodes { get => moduleCodes; set => moduleCodes = value; }
        public string Address { get => address; set => address = value; }
        public System.Drawing.Image StudImage { get => studImage; set => studImage = value; }


        public Student()
        {

        }
        public Student(int studNumber, string name, string surname, string gender, string dob, string moduleCodes, string address, string phoneNo, System.Drawing.Image studImage)
        {
            this.studNumber = studNumber;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.dob = dob;
            this.moduleCodes = moduleCodes;
            this.address = address;
            this.phoneNo = phoneNo;
            this.studImage = studImage;
        }

        public Student(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }

    }
}
