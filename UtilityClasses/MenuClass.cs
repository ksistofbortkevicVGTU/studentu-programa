using System;
using System.Collections.Generic;
using System.Linq;

namespace studentuprograma
{
    public class Menu
    {
        private static int egz, sel, kiek;


        private static void AddStudent(List<Studentas> Studentai)
        {
            Console.Write("Iveskite studento varda: "); string vard = Console.ReadLine();
            Console.Write("Iveskite studento pavarde: "); string pav = Console.ReadLine();
            Console.Write("Iveskite studento egzamino pazymi: ");
            try 
            { 
                egz = int.Parse(Console.ReadLine());
                if (egz < 1 || egz > 10) throw new Exception("GradeOutOfBoundsException");
            } 
            catch (FormatException ex)
            {
                Console.WriteLine("Ivedimo klaida, iveskite sveika skaiciu");
                AddStudent(Studentai);
            } catch (Exception ex) { Console.WriteLine("Ivestas blogas egzamino pazymys"); AddStudent(Studentai); }

            Studentas stud = new Studentas(vard, pav, egz);
            Console.WriteLine("iveskite 1, kad sugeneruoti atsitiktinius pazymius, iveskite kita skaiciu, kad ivesti pazymius ranka");
            try { sel = int.Parse(Console.ReadLine()); } 
            catch (Exception ex)
            {
                Console.WriteLine("Ivedimo klaida, iveskite skaiciu.");
                AddStudent(Studentai);
            }
            if (sel == 1)
            {
                Console.WriteLine("Kiek pazymiu sugeneruoti?"); 
                try { kiek = int.Parse(Console.ReadLine()); }
                catch (Exception ex)
                {
                    Console.WriteLine("Ivedimo klaida, iveskite skaiciu.");
                    AddStudent(Studentai);
                }
                stud.GeneratePazymiai(kiek);
            }
            else stud.AddPazymiai();
            Studentai.Add(stud);
        }

        private static void PrintStudents(List<Studentas> Studentai)
        {
            Console.WriteLine("Vesti bendra pazymi is 1 - vidurkio ar 2 - medianos?"); 
            try 
            { 
                sel = int.Parse(Console.ReadLine());
                if (sel != 1 && sel != 2) throw new Exception("WrongNumberException");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ivedimo klaida, iveskite skaiciu.");
                PrintStudents(Studentai);
            } catch (Exception ex)
            {
                Console.WriteLine("Ivestas neteisingas variantas");
                PrintStudents(Studentai);
            }
            Console.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in Studentai)
            {
                stud.GautiVidurki(sel);
                Console.WriteLine("{0,-15}{1,-15}{2,16}", stud.Vardas, stud.Pavarde, Math.Round(stud.BendrasPazymys(), 2));
            }
        }

        public static void MainMenu(List<Studentas> Studentai)
        {
            do
            {
                Console.WriteLine("Studentu programa:\n\n1 - Įvesti naują studentą\n2 - Isvesti studentus ant ekrano\n3 - Nuskaityti studentus is failo\nx - Baigti darba");
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") break;
                if (ConsoleInput == "1") AddStudent(Studentai);
                if (ConsoleInput == "2") PrintStudents(Studentai);
                if (ConsoleInput == "3") Studentai.AddRange(FileReader.ReadFile().OrderBy(x => x.Vardas).ThenBy(x => x.Pavarde).ToList());
            } while (true);
        }
    }
}
