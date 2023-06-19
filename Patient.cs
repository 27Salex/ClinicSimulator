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
        public int DoctorID { get { return doctorID; } }
        public Patient(int id, int maxSize)
        {
            patientid = id;
            sickness = GenerateSickness();
            doctorID = GenerateDoctorID(maxSize);
        }

        

        public Patient(int id, string name, string sickness, string dni, int age, string sex, string phone, int idMedicoAssingado) : base(dni, name, age, sex, phone)
        {
            patientid = id;
            this.sickness = sickness;
            doctorID = idMedicoAssingado;
        }
        private string GenerateSickness()
        {
            string[] diseases = {
                "Resfriado",
                "Gripe",
                "Hipertensión",
                "Diabetes",
                "Asma",
                "Artritis",
                "Cáncer",
                "Alzheimer",
                "Parkinson",
                "Sida",
                "Malaria",
                "Epilepsia",
                "Osteoporosis",
                "Anemia",
                "Enfermedad cardiovascular"
            };
            return diseases[base.Rand.Next(0, diseases.Length - 1)];
        }
        private int GenerateDoctorID(int maxSize)
        {
            return base.Rand.Next(1, maxSize + 1);
        }
        public override string ToString()
        {
            return base.ToString() + "Doctor a cargo: " + doctorID + " ║ " + "Enfermedad: " + sickness;
        }
    }
}
