using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studentuprograma
{
    public static class FileReader
    {
        //pagalbinis metodas studentai.txt failo nuskaitymui
        public static Studentas ToObjectFromLine(string Line)
        {
            string[] SeparatedWords = Line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int ExamGrade = int.Parse(SeparatedWords[(SeparatedWords.Length - 1)]);
            List<int> grades = new List<int>();
            try
            {
                if (SeparatedWords.Length >= 4)
                {
                    for (int i = 2; i <= SeparatedWords.Length; i++)
                    {
                        grades.Add(int.Parse(SeparatedWords[i]));
                    }
                } else throw new Exception("WrongFileFormatException");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("kursiokai.txt failo formatas neteisingas, turi būti nurodyti vardas, pavardė, mažiausiai vienas ND pažymys ir egzamino įvertinimas");
                Environment.Exit(0);
            }
            Studentas StudentObject = new Studentas(SeparatedWords[0], SeparatedWords[1], ExamGrade, grades);
            return StudentObject;
        }

        //pagalbinis metodas sugeneruoto failo nuskaitymui
        public static Studentas ToObjectFromLineGen(string Line)
        {
            string[] SeparatedWords = Line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            double FinGrade = 6;
            try
            {
                if (SeparatedWords.Length == 3)
                {
                    FinGrade = double.Parse(SeparatedWords[2]);
                }
                else throw new Exception("WrongFileFormatException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("kursiokaiXX.txt failo formatas neteisingas, turi būti nurodyti vardas, pavardė ir galutinis pažymys");
                Environment.Exit(0);
            }
            Studentas StudentObject = new Studentas(SeparatedWords[0], SeparatedWords[1], FinGrade);
            return StudentObject;
        }

        //pagalbinis metodas studentai.txt failo nuskaitymui
        public static List<Studentas> ToObjectFromLines(string[] LinesFromFile)
        {
            List<Studentas> studentai = new List<Studentas>();

            foreach (string stud in LinesFromFile)
            {
                studentai.Add(ToObjectFromLine(stud));
            }
            return studentai;
        }

        //pagalbinis metodas sugeneruoto failo nuskaitymui
        public static List<Studentas> ToObjectFromLinesGen(string[] LinesFromFile)
        {
            List<Studentas> studentai = new List<Studentas>();

            foreach (string stud in LinesFromFile)
            {
                studentai.Add(ToObjectFromLineGen(stud));
            }
            return studentai;
        }

        //failo studentai.txt nuskaitymas
        public static List<Studentas> ReadFile()
        {
            List<Studentas> studentai = new List<Studentas>();
            try
            {
                string[] lines = File.ReadAllLines("../../Studentai.txt");
                lines = lines.Skip(1).ToArray();

                studentai.AddRange(ToObjectFromLines(lines));
            } catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Failas nerastas. Sukurkite arba teisingai pervadinkite faila i \"Studentai.txt\"\n Paspauskite bet kuri mygtuka, kad uzdaryti programa");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return studentai;
        }

        //sugeneruotu failu nuskaitymas
        public static List<Studentas> ReadFile(string path)
        {
            List<Studentas> studentai = new List<Studentas>();
            try
            {
                string[] lines = File.ReadAllLines(path);
                lines = lines.Skip(2).ToArray();

                studentai.AddRange(ToObjectFromLinesGen(lines));
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Failas nerastas. kad uzdaryti programa");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return studentai;
        }
    }
}
