using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studentuprograma
{
    public static class FileReader
    {
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

        public static LinkedList<Studentas> ToObjectFromLines(string[] LinesFromFile)
        {
            LinkedList<Studentas> studentai = new LinkedList<Studentas>();

            foreach (string stud in LinesFromFile)
            {
                studentai.AddLast(ToObjectFromLine(stud));
            }
            return studentai;
        }

        public static LinkedList<Studentas> ToObjectFromLinesGen(string[] LinesFromFile)
        {
            LinkedList<Studentas> studentai = new LinkedList<Studentas>();

            foreach (string stud in LinesFromFile)
            {
                studentai.AddLast(ToObjectFromLineGen(stud));
            }
            return studentai;
        }

        public static LinkedList<Studentas> ReadFile()
        {
            LinkedList<Studentas> studentai = new LinkedList<Studentas>();
            try
            {
                string[] lines = File.ReadAllLines("../../Studentai.txt");
                lines = lines.Skip(1).ToArray();

                LinkedListUtil.AddListToLinkedList(ToObjectFromLines(lines).ToList(), studentai);
            } catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Failas nerastas. Sukurkite arba teisingai pavadinkite faila i \"kursiokai.txt\"\n Paspauskite bet kuri mygtuka, kad uzdaryti programa");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return studentai;
        }

        public static LinkedList<Studentas> ReadFile(string path)
        {
            LinkedList<Studentas> studentai = new LinkedList<Studentas>();
            try
            {
                string[] lines = File.ReadAllLines(path);
                lines = lines.Skip(2).ToArray();

                LinkedListUtil.AddListToLinkedList(ToObjectFromLinesGen(lines).ToList(), studentai);
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
