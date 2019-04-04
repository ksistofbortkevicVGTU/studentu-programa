using System;
using System.Collections.Generic;

namespace studentuprograma
{
    class MainClass
    {

        private static void AddStudent(List<Studentas> Studentai)
        {
            Console.Write("Iveskite studento varda: "); string vard = Console.ReadLine();
            Console.Write("Iveskite studento pavarde: "); string pav = Console.ReadLine();
            Console.Write("Iveskite studento egzamino pazymi: "); int egz = int.Parse(Console.ReadLine());
            Studentas stud = new Studentas(vard, pav, egz);
            stud.AddPazymiai();
            Studentai.Add(stud);
        }

        private static void PrintStudents(List<Studentas> Studentai)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis(vid.)");
            foreach (Studentas stud in Studentai)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,16}", stud.GetVardas(), stud.GetPavarde(), stud.BendrasPazymys());
            }
        }

        private static void Menu(List<Studentas> Studentai)
        {
            do
            {
                Console.WriteLine("Studentu programa:\n\n1 - Įvesti naują studentą\n2 - Isvesti studentus ant ekrano\nx - Baigti darba");
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") break;
                if (ConsoleInput == "1") AddStudent(Studentai);
                if (ConsoleInput == "2") PrintStudents(Studentai);
            } while (true);
        }

        public static void Main(string[] args)
        {
            List<Studentas> Studentai = new List<Studentas>();
            Menu(Studentai);
        }
    }
}
