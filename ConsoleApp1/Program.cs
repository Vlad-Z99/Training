using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * Beziehungsoperatoren
 * Vergleichsoperatoren
 */

/*
                    == Gleich
                    != Nicht Gleich
                    < Weniger 
                    > Großer
                    <= Weniger oder Gleich
                    >= Großer oder Gleich
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            
            int b = 4;

            bool result = a == b;

            Console.WriteLine(a == b);

            Console.WriteLine(a != b);

            Console.WriteLine(a > b);

            Console.WriteLine(a < b);

            Console.WriteLine(a >= b);

            Console.WriteLine(a <= b);
        }
    }
}
