﻿using System;

namespace _9_print_specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent = .7553;
            double currency = 98765.4321;
            Console.WriteLine("Percent: {0}\nCurrency: {1}", percent.ToString("0.00%").Replace("," ,"."), currency.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
