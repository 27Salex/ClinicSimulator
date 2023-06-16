using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ClinicSimulator
{
    internal class Doctor : Person
    {
        private int doctorID;
        private string job;
        
        public Doctor(int id)
        {
            doctorID = id;
            job = GenerateJob();
        }
        public Doctor(int id,  string job, string dni, string name, int age, string sex, string phone) : base(dni, name, age, sex, phone)
        {
            doctorID = id;
            this.job = job; 
        }

        private string GenerateJob()
        {
            string[] jobList = { "Neurólogo", "Cardiólogo", "Oncólogo", "Dermatólogo", "Psiquiatra",
                "Ginecólogo", "Traumatólogo", "Endocrinólogo", "Pediatra", "Radiólogo", "Oftalmólogo",
                "Urólogo", "Otorrinolaringólogo", "Gastroenterólogo", "Nefrólogo" };
            Random rand = new Random();
            return jobList[rand.Next(0, jobList.Length - 1)];
        }
    }
}
