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

        //Uppgift 1
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
            // Uppgift 2
            Temprature temp = new Temprature();
            Console.Write("Ange en temperatur ");
            try {
                var angiventemp = int.Parse(Console.ReadLine());
                temp.CheckTemp(angiventemp);
                
            }
            catch
            {
                throw new FormatException("Felaktigt inmating");
            }
            Console.ReadKey();

            //Uppgift 7
            Grönalund g = new Grönalund();
            Console.WriteLine("Ange Ålder");
            try
            {
                g.ålder(int.Parse(Console.ReadLine()));

                Console.WriteLine("Vill du fortsätta? Ja för att forsätta Nej för att gå vidare till betalning.");
                g.val(Console.ReadLine().ToLower());
            }
            catch
            {
                throw new Exception("Något gick fel, har du fyllt i informationen rätt");
            }
            Console.ReadKey();
        }
    }
}
