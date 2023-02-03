using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Broj
    {
        public int vrednost;
        public Broj()
        {

        }
        public Broj(string a)
        {
            int privremeno = 0;
            int trenutno = 0;
            int pom = 0;
            int val = 0;
            for (int i=0;i<a.Length;i++)
            {
                switch(a[i])
                {
                    case 'M':
                        val = 1000;
                        if (pom==0)
                        {
                            trenutno = trenutno + val;
                        }
                        if (val>trenutno)
                        {
                            vrednost = vrednost + val - trenutno;
                            pom = 0;
                        }
                        if (val==trenutno)
                        {
                            pom++;
                        }
                        if (val<trenutno)
                        {
                            vrednost = trenutno;
                        }
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
            }
        }
    }
}
