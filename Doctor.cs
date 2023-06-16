using System;

namespace ClinicSimulator
{
    internal class Doctor : Person
    {
        private int doctorID;
        private string job;

        public Doctor(int id)
        {
            this.doctorID = id;
            job = GenerateJob();
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
