using System;
using System.Collections.Generic;


namespace ClinicSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor(1, "Otorrino", "13245678D", "Pablo", 50, "Macho", "+666 666 666 666");
            Patient p = new Patient(1, "Pendejismo", 1, "8765432A", "Pedro", 30, "Macho", "+666 888 666 666");

            Console.WriteLine(d.ToString()); 
            Console.WriteLine(p.ToString());

        }
    }
}
