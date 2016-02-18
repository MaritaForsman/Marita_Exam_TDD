using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Invånare

    {
        private int inv;
        private int inflytt;
        private int utflytt;
        private int startår;
        
        public Invånare()
        {
            inv = 26000;
            inflytt = 300;
            utflytt = 325;
            startår = 2015;
        }
        public double AntalInvånare(int slutår)
        {

            if (slutår >= startår)
            {

                while (startår < slutår)
                {
                    int födda = Convert.ToInt32(0.007 * inv);
                    int döda = Convert.ToInt32(0.006 * inv);
                    inv += inflytt - utflytt + födda + döda;
                    startår++;
                }
                return inv;
            }
            else
                throw new Exception("Du har satt ett tidigare år");
        }

        
    }
}
