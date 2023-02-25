using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsumrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdToEur = 0.94;
            double UsdToCny = 6.96;
            double USD;

            Console.WriteLine("Einen Betrag in USD eingeben");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD in EUR =" + USD * UsdToEur);
            Console.WriteLine(USD + " USD in CNY =" + USD * UsdToCny);
        }
    }
}
