using System;
using System.Collections.Generic;


namespace ClinicSimulator
{
    internal class Person
    {
        private string dni;
        private string name;
        private int age;
        private string sex;
        private string phone;

        public Person()
        {
            Random rand = new Random();
            dni = rand.Next(1000000, 99999999).ToString() + "A";
            name = GenerateName();
            age = rand.Next(25, 65);
            sex = GenerateSex(); 
            phone = GeneratePhone();
        }
        public Person(string dni, string name, int age, string sex, string phone)
        {
            this.dni = dni;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.phone = phone;
        }

        public string GenerateName()
        {
            string[] nameslist = {"Juan Carlos", "Pedro", "Luis", "Carlos", "Alejandro", "Miguel", "Diego", "Javier", "Francisco", "Manuel",
            "Andrés", "Ricardo", "Hugo", "Pablo", "Sergio","María", "Ana", "Laura", "Sofía", "Isabella", "Lucía", "Valentina", "Camila",
            "Gabriela", "Mariana", "Paula", "Fernanda", "Daniela", "Valeria", "Carolina" };

            Random rand = new Random();
            return nameslist[rand.Next(0, nameslist.Length - 1)];
        }

        public string GenerateSex()
        {
            string[] sexList = { "Hombre", "Mujer", "No binario" };
            Random rand = new Random();
            return sexList[rand.Next(0, sexList.Length - 1)];
        }
        public string GeneratePhone()
        {
            Random rand = new Random();
            return "+34 " + rand.Next(111111111, 999999999);

        }
    }
}
