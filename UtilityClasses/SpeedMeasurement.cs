using System;
using System.Diagnostics;

namespace studentuprograma
{
    public static class SpeedMeasurement
    {
        public static void MeasureGenSplitSpeed()
        {
            try
            {
                Console.Write("Su kokiu studentu skaiciumi tikrinti laika? ");
                int studnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Pradėtas generuoti failas su {0} studentu skaičiumi", studnum);

                //sukuriamas objektas laiko matavimui
                Stopwatch time = new Stopwatch();

                time.Start();
                Menu.GenerateStudents(studnum);
                Menu.SplitStudentFile(studnum);
                time.Stop();

                Console.WriteLine("Failas su {0} studentais sugeneruotas ir paskirstytas i skirtingus failus (gudruoliai{0} ir nuskriaustukai{0}) per {1}.{2} sekundziu", studnum, time.Elapsed.Seconds, time.Elapsed.Milliseconds);
            } catch (Exception ex)
            {
                Console.WriteLine("Ivyko klaida: {0}", ex.Message);
            }
        }
    }
}
