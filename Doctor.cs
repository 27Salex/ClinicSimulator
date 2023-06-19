using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ClinicSimulator
{
    internal class Doctor : Person
    {
        private int doctorID;
        private string job;
        public int DoctorID { get { return doctorID; } }

        public Doctor(int id)
        {
            doctorID = id;
            job = GenerateJob();
        }
        public Doctor(int id,  string name, string dni, string job, int age, string sex, string phone) : base(dni, name, age, sex, phone)
        {
            doctorID = id;
            this.job = job; 
        }

        private string GenerateJob()
        {
            string[] jobList = { "Neurologo", "Cardiologo", "Oncologo", "Dermatologo", "Psiquiatra",
                "Ginecologo", "Traumatologo", "Endocrinologo", "Pediatra", "Radiologo", "Oftalmologo",
                "Urologo", "Otorrinolaringologo", "Gastroenterologo", "Nefrologo" };
            return jobList[base.Rand.Next(0, jobList.Length)];
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return base.ToString() + "Colegiado: " + doctorID + " ║ " + "Especialidad: " + job; 
        }
    }
}
