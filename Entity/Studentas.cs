﻿using System;
using System.Collections.Generic;

namespace studentuprograma
{
    public class Studentas
    {
        //Declare variables
        public string Vardas;
        public string Pavarde;
        public double Vidurkis;
        public int EgzPazymys;
        public List<int> NdPazymiai = new List<int>();

        //Declare constructors
        public Studentas(string vard, string pav){
            this.Vardas = vard; this.Pavarde = pav;}

        public Studentas(string vard, string pav, int egz){
            this.Vardas = vard; this.Pavarde = pav; this.EgzPazymys = egz;}

        public Studentas(string vard, string pav, int egz, List<int> grades){
            this.Vardas = vard; this.Pavarde = pav; this.EgzPazymys = egz; this.NdPazymiai = grades;}


        //Public methods:

        public void AddPazymiai()
        {
            Console.WriteLine("Irasykite po viena namu darbu pazymi, kai baigsite, iveskite \"x\"");
            do
            {
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") break;
                else NdPazymiai.Add(Convert.ToInt32(ConsoleInput));
            } while (true);

        }

        public void GeneratePazymiai(int n)
        {
            Random rnd = new Random();
            for(int i = 0; i <= n; i++) NdPazymiai.Add(rnd.Next(2, 11));
        }

        public void GautiVidurki(int type)
        {
            if (type == 1) Vidurkis = CountVidurkis();
            if (type == 2)
            {
                int[] TempArr = NdPazymiai.ToArray();
                Array.Sort(TempArr);
                if (TempArr.Length % 2 == 0)
                {
                    Vidurkis = ((TempArr[(TempArr.Length / 2) - 1] + TempArr[(TempArr.Length / 2)]) / 2);
                }
                else Vidurkis = TempArr[(TempArr.Length / 2 - 1)];
            }
        }

        public double BendrasPazymys(){ return (0.7f * EgzPazymys) + (0.3f * Vidurkis); }

        //Private methods:
        private double CountVidurkis()
        {
            double vid = 0; int i = 0;
            foreach (int paz in NdPazymiai)
            {
                i++;
                vid += paz;
            }
            vid /= i;
            return vid;
        }
    }
}