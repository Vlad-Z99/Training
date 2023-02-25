using Microsoft.SqlServer.Server;
using System;
using System.Globalization;

// Arithmetischer Mittelwert

namespace MyLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Geben Sie die Zahl 1 ein");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die Zahl 2 ein");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("Arithmetischer Mittelwert = " + result);
        }
    }
}
