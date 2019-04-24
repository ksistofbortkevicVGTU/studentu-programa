﻿using System;
using System.Collections.Generic;

namespace studentuprograma
{
    class Program
    {
        private static LinkedList<Studentas> Studentai = new LinkedList<Studentas>();

        public static void Main(string[] args)
        {
            Menu.MainMenu(Studentai);
        }
    }
}