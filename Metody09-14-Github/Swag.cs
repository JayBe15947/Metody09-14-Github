using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody09_14_Github
{
    class Swag
    {
        public static double Diskriminant(double a, double b, double c, out double x1, out double x2, out double diskriminant)
        {
            diskriminant = (b * b) - (4 * a * c);
            x1 = 0;
            x2 = 0;
            if (diskriminant < 0)
            {
                
                x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
            }
            else if (diskriminant > 0)
            {
                diskriminant = 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
            }
            return diskriminant;
        }


        public static bool ObsahujeCislici(string retezec, out int cifSoucet, out int soucetLichCif, out int soucetSudCif)
        {
            bool obsahujeCislici = false;
            cifSoucet = 0;
            soucetLichCif = 0;
            soucetSudCif = 0;
            for (int i = 0; i < retezec.Length; ++i)
            {
                if (Char.IsDigit(retezec[i]))
                {
                    obsahujeCislici = true;
                    cifSoucet += int.Parse(retezec[i].ToString());

                    if (int.Parse(retezec[i].ToString()) % 2 == 0)
                    {
                        soucetSudCif += int.Parse(retezec[i].ToString());
                    }
                    else if (int.Parse(retezec[i].ToString()) % 2 != 0)
                    {
                        soucetLichCif += int.Parse(retezec[i].ToString());
                    }
                }
            }

            return obsahujeCislici;
        }
    }
}
