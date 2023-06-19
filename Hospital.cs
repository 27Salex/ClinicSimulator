using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClinicSimulator
{
    internal class Hospital
    {
        public List<Doctor> doctors;
        private List<Patient> patients;
        public Hospital()
        {
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        public void AgregarMedicoManual()
        {
            Console.Clear();
            Console.WriteLine("Vamos a añadir un doctor manualmente");

            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Especialidad: ");
            string job = Console.ReadLine();

            Console.Write("Edad: ");
            int age = 0;
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Porfavor introduce un numero valido");

            Console.Write("Sexo: ");
            string sex = Console.ReadLine();

            Console.Write("Telefono: ");
            string phone = Console.ReadLine();
           
            Doctor manualDoc = new Doctor(doctors.Count + 1, name, dni, job, age, sex, phone);
            doctors.Add(manualDoc);


        }

        public void AgregarMedicoAuto()
        {
            Console.Clear();
            Console.WriteLine("Vamos a crear doctores, porfavor introduce la cantidad:");

            uint input = 0;
            
            while (!uint.TryParse(Console.ReadLine(), out input))
                Console.WriteLine("Porfavor introduce un numero valido");

            for (int i = 0; i < input; i++)
            {
                Doctor doc = new Doctor(doctors.Count + 1);
                doctors.Add(doc);
                Thread.Sleep(10);
            }

        }

        public void AgregarPacienteManual()
        {
            Console.Clear();
            Console.WriteLine("Vamos a añadir un paciente manualmente");

            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            Console.Write("Enfermedad: ");
            string sickness = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Edad: ");
            int age = 0;
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Porfavor introduce un numero valido");

            Console.Write("Sexo: ");
            string sex = Console.ReadLine();

            Console.Write("Telefono: ");
            string phone = Console.ReadLine();

            bool j = false;
            Console.Write("Numero de Medico: ");
            uint medicoAsignado = 0;

            while (!uint.TryParse(Console.ReadLine(), out medicoAsignado))
                Console.WriteLine("Porfavor introduce un numero valido");

            while (!j)
            {
                foreach (Doctor d in doctors)
                {
                    if (d.DoctorID == medicoAsignado)
                    {
                        j = true;
                    }
                }
                if (!j)
                {
                    Console.Write("Ese numero de medico no existe \n" +
                                    "Introduce el numero nuevamente:  ");
                    while (!uint.TryParse(Console.ReadLine(), out medicoAsignado))
                        Console.WriteLine("Porfavor introduce un numero valido");
                }
            }

            int doctorID = (int)medicoAsignado;
            Patient manualPatient = new Patient(patients.Count + 1, name, sickness, dni, age, sex, phone, doctorID);
            patients.Add(manualPatient);

        }

        public void AgregarPacienteAuto()
        {
            Console.Clear();
            Console.WriteLine("Vamos a crear pacientes, porfavor introduce la cantidad:");
            uint input = 0;
            while (!uint.TryParse(Console.ReadLine(), out input))

            for (int i = 0; i < input; i++)
            {
                Patient p = new Patient(patients.Count + 1, doctors.Count);
                patients.Add(p);
                Thread.Sleep(10);
            }
        }
        public void ListarMedicos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine(doctor.ToString());
            }

            Console.ReadKey();
            Console.ResetColor();
        }
        public void ListarPacientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            {
                Console.WriteLine(patient.ToString());
            }

            Console.ReadKey();
            Console.ResetColor();
        }

        public void PacientesXMedico()
        {
            Console.Clear();
            foreach (Doctor d2 in doctors)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(d2.ToString());
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                foreach (Patient p2 in patients)
                {
                    if (d2.DoctorID == p2.DoctorID)
                    {
                        Console.WriteLine(p2.ToString());
                    }
                }

                Console.ResetColor();
                Console.WriteLine("Pulsa cualquier tecla para la siguiente pagina...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();

        }
        public void EliminarPaciente()
        {
            Console.Clear();
            
        }
    }
}
