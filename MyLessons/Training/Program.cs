using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Geben Sie die Zahl 1 ein");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die Zahl 2 ein");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die Zahl 3 ein");

            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue  * thirdValue;

            Console.WriteLine("Summe von 3 Zahlen = " + sumResult);
            Console.WriteLine("Multiplikation von 3 Zahlen = " + multResult);
        }
    }
}
