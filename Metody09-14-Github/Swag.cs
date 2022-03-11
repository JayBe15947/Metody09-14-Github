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



        public static int PocetSlov(string retezec, out string retezec2)
        {
            
            char[] separators = { ' ' };
            retezec = retezec.Trim();
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int PocetSlov = poleSlov.Length;
            int i = 0;
            
            while (retezec.Length > i)
            {
                if (Char.IsDigit(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                    
                }else i++;


            }
            retezec2 = retezec;
            return (PocetSlov);
        }



        public static bool Identicke(string s1, string s2, out int pocetOdlisnychPozici, out int prvniIndex)
        {
            string vymennyRetezec;
            bool identickeReterec = true, prvniPozice = false;
            pocetOdlisnychPozici = 0;
            prvniIndex = -1;
            if (s1.Length > s2.Length)
            {
                vymennyRetezec = s1;
                s1 = s2;
                s2 = vymennyRetezec;
            }
            int delkaRozdiluS1aS2 = s2.Length - s1.Length;
            for (int i = 0; i < s1.Length; ++i)
            {
                if(s1[i] != s2[i])
                {
                    pocetOdlisnychPozici++;
                    if(!prvniPozice)
                    {
                        prvniPozice = true;
                        prvniIndex = i;
                    }
                    if(identickeReterec) identickeReterec = false;
                }
            }
            if(prvniIndex == -1)
            {
                prvniIndex = s1.Length;
            }
            pocetOdlisnychPozici += delkaRozdiluS1aS2;

            return identickeReterec;
        }
    }
}
