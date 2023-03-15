using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Singulink.Numerics;

namespace Kalkulator
{
    internal class Dugacak
    {
        public BigDecimal broj;

        public Dugacak(BigDecimal broj)
        {
            this.broj = broj;
        }
        public Dugacak()
        {
            broj = 0;
        }
        public Dugacak(string a)
        {
            this.broj = BigDecimal.Parse(a);
        }
        public static bool provera(string a)
        {
            string s = "0123456789.";
            bool pom;
            for (int i = 0; i < a.Length; i++)
            {
                pom = false;
                for(int j=0; j<s.Length; j++)
                {
                    if (s[j] == a[i])
                    {
                        pom=true;
                    }
                }
                if (pom == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
