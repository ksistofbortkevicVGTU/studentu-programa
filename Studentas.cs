using System;
using System.Collections.Generic;

namespace studentuprograma
{
    public class Studentas
    {
        //Declare variables
        private string Vardas;
        private string Pavarde;
        private double Vidurkis;
        private int EgzPazymys;
        private List<int> NdPazymiai = new List<int>();

        //Declare constructors
        public Studentas(string vard, string pav){
            this.Vardas = vard; this.Pavarde = pav;}

        public Studentas(string vard, string pav, int egz){
            this.Vardas = vard; this.Pavarde = pav; this.EgzPazymys = egz;}

        //Setters and getters:

        public void SetVardas(string vard) { this.Vardas = vard; }
        public void SetPavarde(string pav) { this.Pavarde = pav; }
        public void SetVidurkis(double vid) { this.Vidurkis = vid; }
        public void SetEgzPazymys(int paz) { this.EgzPazymys = paz; }

        public string GetVardas() { return this.Vardas; }
        public string GetPavarde() { return this.Pavarde; }
        public double GetVidurkis() { return this.Vidurkis; }
        public int GetEgzPazymys() { return this.EgzPazymys; }

        //Public methods:

        public void AddPazymiai()
        {
            do
            {
                Console.WriteLine("Irasykite po viena namu darbu pazymi, kai baigsite, iveskite \"x\"");
                string ConsoleInput = Console.ReadLine();
                if (ConsoleInput == "x") break;
                else NdPazymiai.Add(Convert.ToInt32(ConsoleInput));
            } while (true);
            Vidurkis = CountVidurkis();
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
