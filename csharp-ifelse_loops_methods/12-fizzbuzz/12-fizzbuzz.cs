﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int number = 1; number < 100; number++)
            {
                if(number % 3 == 0)
                    Console.Write("Fizz ");
                else if(number % 5 == 0)
                    Console.Write("Buzz ");
                else if(number % 3 == 0 && number % 5 == 0)
                    Console.Write("FizzBuzz ");
                else
                    Console.Write($"{number} ");
            }
            Console.WriteLine("Buzz");
        }
    }
}
