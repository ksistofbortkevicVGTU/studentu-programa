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
        private List<int> Pazymiai = new List<int>();

        //Declare constructors
        public Studentas(string vard, string pav)
        {
            this.Vardas = vard; this.Pavarde = pav;
        }

        public Studentas(string vard, string pav, double vid)
        {
            this.Vardas = vard; this.Pavarde = pav; this.Vidurkis = vid;
        }

        //Public methods:

        //Private methods:
    }
}
