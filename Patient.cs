using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSimulator
{
    internal class Patient : Person
    {
        private int patientid;
        private string sickness;
        private int doctorID;

        public Patient(int id, int maxSize)
        {
            patientid = id;
            sickness = GenerateSickness();
            doctorID = GenerateDoctorID(maxSize);
        }

        

        public Patient(int id, string sickness, int idMedicoAssingado, string dni, string name, int age, string sex, string phone) : base(dni, name, age, sex, phone)
        {
            patientid = id;
            this.sickness = sickness;
            doctorID = idMedicoAssingado;
        }
        private string GenerateSickness()
        {
            string[] diseases = {
                "Resfriado común",
                "Gripe",
                "Hipertensión",
                "Diabetes",
                "Asma",
                "Artritis",
                "Cáncer",
                "Enfermedad de Alzheimer",
                "Enfermedad de Parkinson",
                "Sida",
                "Malaria",
                "Epilepsia",
                "Osteoporosis",
                "Anemia",
                "Enfermedad cardiovascular"
            };
            Random rand = new Random();
            return diseases[rand.Next(0, diseases.Length - 1)];
        }
        private int GenerateDoctorID(int maxSize)
        {
            Random random = new Random();
            return random.Next(0, maxSize);
        }
    }
}
