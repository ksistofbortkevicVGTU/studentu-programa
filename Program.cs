﻿﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studentuprograma
{
    class Program
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

            foreach (string stud in LinesFromFile)
            {
                studentai.Add(ToObjectFromLine(stud));
            }
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

        public static void Main(string[] args)
        {
            List<Studentas> Studentai = new List<Studentas>();
            Menu.MainMenu(Studentai);
        }
    }
}