using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studentuprograma
{
    class MainClass
    {
        public static Studentas ToObjectFromLine(string Line)
        {
            string[] SeparatedWords = Line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int ExamGrade = int.Parse(SeparatedWords[7]);
            List<int> grades = new List<int>(){
                int.Parse(SeparatedWords[2]),
                int.Parse(SeparatedWords[3]),
                int.Parse(SeparatedWords[4]),
                int.Parse(SeparatedWords[5]),
                int.Parse(SeparatedWords[6])
            };
            Studentas StudentObject = new Studentas(SeparatedWords[0], SeparatedWords[1], ExamGrade, grades);
            return StudentObject;
        }

        public static List<Studentas> ToObjectFromLines(string[] LinesFromFile)
        {
            List<Studentas> studentai = new List<Studentas>();

            foreach (string stud in LinesFromFile){
                studentai.Add(ToObjectFromLine(stud));}
            return studentai;
        }

        public static List<Studentas> ReadFile()
        {
            List<Studentas> studentai = new List<Studentas>();
            string[] lines = File.ReadAllLines("../../kursiokai.txt");
            lines = lines.Skip(1).ToArray();

            studentai.AddRange(ToObjectFromLines(lines));

            return studentai;
        }

        private static void AddStudent(List<Studentas> Studentai)
        {
            Console.Write("Iveskite studento varda: "); string vard = Console.ReadLine();
            Console.Write("Iveskite studento pavarde: "); string pav = Console.ReadLine();
            Console.Write("Iveskite studento egzamino pazymi: "); int egz = int.Parse(Console.ReadLine());
            Studentas stud = new Studentas(vard, pav, egz);
            Console.WriteLine("iveskite 1, kad sugeneruoti atsitiktinius pazymius, spauskite \"Enter\" kad ivesti pazymius ranka"); 
            int sel = int.Parse(Console.ReadLine());
            if (sel == 1)
            {
                Console.WriteLine("Kiek pazymiu sugeneruoti?"); int kiek = int.Parse(Console.ReadLine());
                stud.GeneratePazymiai(kiek);
            }
            else stud.AddPazymiai();
            Studentai.Add(stud);
        }

        private static void PrintStudents(List<Studentas> Studentai)
        {
            Console.WriteLine("Vesti bendra pazymi is 1 - vidurkio ar 2 - medianos?"); int sel = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in Studentai)
            {
                stud.GautiVidurki(sel);
                Console.WriteLine("{0,-15}{1,-15}{2,16}", stud.GetVardas(), stud.GetPavarde(), Math.Round(stud.BendrasPazymys(), 2));
            }
        }

        private static void Menu(List<Studentas> Studentai)
        {
            do
            {
                Console.WriteLine("Studentu programa:\n\n1 - Įvesti naują studentą\n2 - Isvesti studentus ant ekrano\n3 - Nuskaityti studentus is failo\nx - Baigti darba");
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") break;
                if (ConsoleInput == "1") AddStudent(Studentai);
                if (ConsoleInput == "2") PrintStudents(Studentai);
                if (ConsoleInput == "3") Studentai = ReadFile();
            } while (true);
        }

        public static void Main(string[] args)
        {
            List<Studentas> Studentai = new List<Studentas>();
            Menu(Studentai);
        }
    }
}
