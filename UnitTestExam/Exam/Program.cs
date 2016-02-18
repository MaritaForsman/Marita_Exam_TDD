using Exam.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Invånare i = new Invånare();
            Console.WriteLine("Ange slutår");
            try { var slutår = int.Parse(Console.ReadLine());

                Console.WriteLine("Antalet invånare mellan 2015 och " + slutår + " är " + i.AntalInvånare(slutår));
                
            }
            catch
            {
                throw new FormatException("Felaktigt inmating");
            }
            Console.ReadKey();
        }
    }
}
