using System;
using System.Collections.Generic;
using System.Linq;

namespace studentuprograma
{
    public class Menu
    {
        //deklaruojami kintamieji kurie bus naudojami pasirinkimams metoduose
        private static int egz, sel, kiek;

        //privatus metodas padalinti sugeneruota studentu faila
        private static void SplitStudentFile()
        {
            int path = 10;
            Console.WriteLine("Kiek studentu yra faile?");
            try
            {
                path = int.Parse(Console.ReadLine());
            } catch (FormatException ex)
            {
                Console.WriteLine("Ivedimo klaida, iveskite sveika skaiciu");
                SplitStudentFile();
            }

            List<Studentas> Studentai = new List<Studentas>();
            List<Studentas> StudentaiNusk = new List<Studentas>();
            List<Studentas> StudentaiGud = new List<Studentas>();

            Studentai = FileReader.ReadFile("../../kursiokai" + path + ".txt");

            foreach (Studentas stud in Studentai)
            {
                if (stud.Bendras < 5.0f)
                {
                    StudentaiNusk.Add(stud);
                } else StudentaiGud.Add(stud);
            }
            Studentai = null;
            StudentaiGud = StudentaiGud.OrderBy(x => x.Bendras).ToList();
            StudentaiNusk = StudentaiNusk.OrderBy(x => x.Bendras).ToList();
            System.IO.StreamWriter outfile = new System.IO.StreamWriter("../../gudruoliai" + path + ".txt", true);
            System.IO.StreamWriter outfile1 = new System.IO.StreamWriter("../../nuskriaustukai" + path + ".txt", true);
            outfile.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in StudentaiGud)
            {
                outfile.WriteLine("{0,-15}{1,-15}{2,16}", stud.Vardas, stud.Pavarde, stud.Bendras);
            }
            outfile1.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in StudentaiNusk)
            {
                outfile1.WriteLine("{0,-15}{1,-15}{2,16}", stud.Vardas, stud.Pavarde, stud.Bendras);
            }
            outfile.Flush(); outfile1.Flush(); outfile.Close(); outfile1.Close(); 
        }

        //viesas metodas naudojamas greicio skaiciavime
        public static void SplitStudentFile(int studnum)
        {
            List<Studentas> Studentai = new List<Studentas>();
            List<Studentas> StudentaiNusk = new List<Studentas>();
            List<Studentas> StudentaiGud = new List<Studentas>();

            Studentai = FileReader.ReadFile("../../kursiokai" + studnum + ".txt");

            foreach (Studentas stud in Studentai)
            {
                if (stud.Bendras < 5.0f)
                {
                    StudentaiNusk.Add(stud);
                }
                else StudentaiGud.Add(stud);
            }
            Studentai = null;
            StudentaiGud = StudentaiGud.OrderBy(x => x.Bendras).ToList();
            StudentaiNusk = StudentaiNusk.OrderBy(x => x.Bendras).ToList();
            System.IO.StreamWriter outfile = new System.IO.StreamWriter("../../gudruoliai" + studnum + ".txt", true);
            System.IO.StreamWriter outfile1 = new System.IO.StreamWriter("../../nuskriaustukai" + studnum + ".txt", true);
            outfile.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in StudentaiGud)
            {
                outfile.WriteLine("{0,-15}{1,-15}{2,16}", stud.Vardas, stud.Pavarde, stud.Bendras);
            }
            outfile1.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
            foreach (Studentas stud in StudentaiNusk)
            {
                outfile1.WriteLine("{0,-15}{1,-15}{2,16}", stud.Vardas, stud.Pavarde, stud.Bendras);
            }
            outfile.Flush(); outfile1.Flush(); outfile.Close(); outfile1.Close();
        }

        //privatus metodas sugeneruoti studento faila
        private static void GenerateStudents()
        {
            Console.WriteLine("Kiek studentų sugeneruoti?");
            try
            {
                Random rnd = new Random();
                string TempName, TempSurn;
                int stud = int.Parse(Console.ReadLine());
                System.IO.StreamWriter outfile = new System.IO.StreamWriter("../../kursiokai" + stud + ".txt", true);
                outfile.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
                for (int i = 1; i <= stud; i++)
                {
                    TempName = "Vardas" + i; TempSurn = "Pavarde" + i;
                    Studentas TempStud = new Studentas(TempName, TempSurn, Math.Round(rnd.NextDouble() * (10.0f - 2.0f) + 2.0f));
                    outfile.WriteLine("{0,-15}{1,-15}{2,16}", TempStud.Vardas, TempStud.Pavarde, TempStud.Bendras);
                }
                outfile.Flush(); outfile.Close();
            } catch (Exception ex)
            {
                Console.WriteLine("Ivedimo klaida, iveskite sveika skaiciu");
                GenerateStudents();
            }
        }

        //viesas metodas naudojamas greicio skaiciavime
        public static void GenerateStudents(int studn)
        {
            try
            {
                Random rnd = new Random();
                string TempName, TempSurn;
                System.IO.StreamWriter outfile = new System.IO.StreamWriter("../../kursiokai" + studn + ".txt", true);
                outfile.WriteLine("{0,-15}{1,-15}{2,16}\n----------------------------------------------", "Vardas", "Pavarde", "Galutinis");
                for (int i = 1; i <= studn; i++)
                {
                    TempName = "Vardas" + i; TempSurn = "Pavarde" + i;
                    Studentas TempStud = new Studentas(TempName, TempSurn, Math.Round(rnd.NextDouble() * (10.0f - 2.0f) + 2.0f));
                    outfile.WriteLine("{0,-15}{1,-15}{2,16}", TempStud.Vardas, TempStud.Pavarde, TempStud.Bendras);
                }
                outfile.Flush(); outfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ivyko klaida, {0}", ex.Message);
                GenerateStudents(studn);
            }
        }

        //prideti studenta prie konteinerio atmintyje
        private static void AddStudent(List<Studentas> Studentai)
        {
            Console.Write("Iveskite studento varda: "); string vard = Console.ReadLine();
            Console.Write("Iveskite studento pavarde: "); string pav = Console.ReadLine();
            if (!(vard.All(char.IsLetter)) || !(pav.All(char.IsLetter)))
            {
                Console.WriteLine("Vardas ir pavarde privalo susideti tik is raidziu");
                AddStudent(Studentai);
            }
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

        //atspausdinti ant ekrano studentu sarasa is atmintyje esancio konteinerio
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

        //pagrindinio meniu vaizdavimo ir veikimo metodas
        public static void MainMenu(List<Studentas> Studentai)
        {
            do
            {
                Console.WriteLine("Studentu programa:\n\n1 - Ivesti nauja studenta\n2 - Isvesti studentus ant ekrano\n3 - Nuskaityti studentus is failo\n4 - Generuoti studentų failą\n5 - Padalinti studentus is failo\n6 - Matuoti studentu generavimo ir padalinimo i failus laika\nx - Baigti darba");
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") Environment.Exit(0);
                if (ConsoleInput == "1") AddStudent(Studentai);
                if (ConsoleInput == "2") PrintStudents(Studentai);
                if (ConsoleInput == "3") Studentai.AddRange(FileReader.ReadFile().OrderBy(x => x.Vardas).ThenBy(x => x.Pavarde).ToList());
                if (ConsoleInput == "4") GenerateStudents();
                if (ConsoleInput == "5") SplitStudentFile();
                if (ConsoleInput == "6") SpeedMeasurement.MeasureGenSplitSpeed();
            } while (true);
        }
    }
}
