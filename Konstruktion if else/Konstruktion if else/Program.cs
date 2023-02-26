using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Konstruktion if else
 */



/*
  
                   if (Aussage oder Außerung)
                    {
                      Tat 1;
                    }
                   else
                    {
                      Tat 2;
                    }                    
 */ 
 
namespace Konstruktion_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Schreiben Sie Ihre Nummer");

            a = int.Parse(Console.ReadLine());

            

            if (a % 2 == 0) 
            {
                Console.WriteLine("gerade Zahl");
                
            }
            
            else
            {
                Console.WriteLine("ungerade Zahl");
                
            }
            

        }
        
    }
}


