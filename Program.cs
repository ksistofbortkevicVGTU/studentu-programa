﻿using System;
using System.Collections.Generic;

namespace studentuprograma
{
    class Program
    {
        private static List<Studentas> Studentai = new List<Studentas>();

        public static void Main(string[] args)
        {
            Menu.MainMenu(Studentai);
        }
    }
}