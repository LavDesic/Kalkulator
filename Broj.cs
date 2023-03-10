using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    struct struktura
    {
        public int val;
        public char slovo;
    }
    class Broj
    {

        public struktura[] niz = new struktura[7];

        public int vrednost;
        public Broj()
        {

        }
        public Broj(int x)
        {
            this.vrednost = x;
        }
        public Broj(string a)
        {
            niz[0].val = 1;
            niz[1].val = 5;
            niz[2].val = 10;
            niz[3].val = 50;
            niz[4].val = 100;
            niz[5].val = 500;
            niz[6].val = 1000;

            vrednost = 0;
            //int privremeno = 0;
            int trenutno = 0;
            int pom = 0;
            int val = 0;
            for (int i=0;i<a.Length;i++)
            {
                switch(a[i])
                {
                    case 'M':
                        val = 1000;
                        break;
                    case 'D':
                        val = 500;
                        break;
                    case 'C':
                        val = 100;
                        break;
                    case 'L':
                        val = 50;
                        break;
                    case 'X':
                        val = 10;
                        break;
                    case 'V':
                        val = 5;
                        break;
                    case 'I':
                        val = 1;
                        break;
                }
                if (val == trenutno)
                {
                    pom++;
                }
                if (val < trenutno)
                {
                    vrednost = vrednost + trenutno * pom;
                    pom = 0;
                }
                if (pom == 0)
                {
                    trenutno = val;
                    pom++;
                }
                if (val > trenutno)
                {
                    vrednost = vrednost + val - pom * trenutno;
                    pom = 0;
                }
                if (pom == 3)
                {
                    vrednost = vrednost + pom * trenutno;
                    pom = 0;
                }
                if (i==a.Length-1)
                {
                    vrednost = vrednost + pom * trenutno;
                }
            }
        }
        public string pretvori() //ne ispisuje nista
        {
            /*string s="";
            for (int i=niz.Length-1;i>=0;i--)
            {
                if (this.vrednost/niz[i].val>0)
                {
                    int pom = this.vrednost / niz[i].val;
                    for (int j=0;j<pom;j++)
                    {
                        s += niz[i].slovo;
                    }
                    this.vrednost = this.vrednost - pom * niz[i].val;
                }
                if (i != 0)
                {
                    if (this.vrednost == (niz[i].val - niz[i - 1].val))
                    {
                        s = s + niz[i - 1].slovo;
                        s = s + niz[i].slovo;
                        this.vrednost = this.vrednost - (niz[i].val - niz[i - 1].val);
                    }
                }
            }
            return s;*/
            string[] slova = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] vrednosti = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string s = "";
            int i = 0;
            while (this.vrednost != 0)
            {
                if (this.vrednost >= vrednosti[i])
                {
                    s = s + slova[i];
                    this.vrednost = this.vrednost - vrednosti[i];
                }
                else
                {
                    i++;
                }
            }
            return s;
        }
        public static Broj saberi(Broj broj1,Broj broj2)
        {
            Broj br = new Broj(broj1.vrednost + broj2.vrednost);
            return br;
        }
        public static Broj oduzmi(Broj broj1, Broj broj2)
        {
            Broj br = new Broj(broj1.vrednost - broj2.vrednost);
            return br;
        }
        public static Broj pomnozi(Broj broj1, Broj broj2)
        {
            Broj br = new Broj(broj1.vrednost * broj2.vrednost);
            return br;
        }
        public static Broj podeli(Broj broj1, Broj broj2)
        {
            Broj br = new Broj(broj1.vrednost / broj2.vrednost);
            return br;
        }
    }
}
