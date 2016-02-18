using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Grönalund
    {
        private string message;
        private int ungdom;
        private int vuxen;
        private int barn;
        //private string helg;
        private int pris;
        private int sum;

        public Grönalund()
        {
            pris = 100;
            sum = 0;
            
                    }

        public string getMessage()
        {
            return message;
        }
        public void Antalöver15(int v)
        {
            throw new NotImplementedException();
        }

        public void ålder(int v)
        {
            if (v <=7)
            {
                message = "Gratis";
                barn++;
            }
            else if (v >7 && v<=15)
            {
                message = "Ungdom";
                ungdom++;
            }
            else if (v >15)
            {
                message = "Vuxen";
                vuxen++;
            }
            
        }
        public int getUngdom()
        {
            return ungdom;
        }
        public int getVuxen()
        {
            return vuxen;
        }

        public void val(string v)
        {
        

                switch (v)
                {
                    case "ja":
                        Console.Write("Ange ålder ");
                        var input = Convert.ToInt16(Console.ReadLine());
                        ålder(input);



                        break;
                    case "nej":
                        Console.WriteLine("Ange Veckodag: ");
                        var dag = Console.ReadLine().ToLower();
                        Veckodag(dag);

                        break;
                    default:
                        Console.WriteLine("Något gick fel");
                        break;
                }
            if (v == "ja")
            {
                Console.WriteLine("Vill du fortsätta? Ja för att forsätta Nej för att gå vidare till betalning.");
                val(Console.ReadLine().ToLower());
            }
            
            }
            
        

        public int getSumma()
        {
            return sum;
        }

        public void Veckodag(string v)
        {
            if ((v == "fredag") || (v == "lördag") || (v == "söndag"))
            {
                sum = (pris * 2 * vuxen) + ((pris * 2)/2 * ungdom);
                int sumUng = (pris * 2) / 2 * ungdom;
                int sumVux = (pris * 2) * vuxen;
                Console.WriteLine("Antal barn = " + barn + " Barn under 7 kostar inget");
                Console.WriteLine("Antal ungdom = " + ungdom +  " totala priset för ungdom är :"+ sumUng);
                Console.WriteLine("Antal ungdom = " + vuxen + " totala priset för Vuxen är :" + sumVux);
                Console.WriteLine("Totala kostanden är " + sum + "Kronor");
            }
            else {
                sum = (pris * vuxen) + (pris / 2 * ungdom);
                int sumUng = (pris) / 2 * ungdom;
                int sumVux = (pris) * vuxen;
                Console.WriteLine("Antal barn = " + barn + " Barn under 7 kostar inget");
                Console.WriteLine("Antal ungdom = " + ungdom + " totala priset för ungdom är :" + sumUng);
                Console.WriteLine("Antal ungdom = " + vuxen + " totala priset för Vuxen är :" + sumVux);
                Console.WriteLine("Totala kostanden är " + sum + "Kronor");
            }
        }
        
    }
}
