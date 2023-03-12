using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Kompleksni
    {
        public double realan;
        public double imaginaran;

        public Kompleksni()
        {

        }
        public Kompleksni(double r,double i)
        {
            realan = r;
            imaginaran = i;
        }
        public static Kompleksni saberi(Kompleksni a,Kompleksni b)
        {
            double r = a.realan+b.realan;
            double i = a.imaginaran+b.imaginaran;
            Kompleksni k = new Kompleksni(r, i);
            return k;
        }
        public static Kompleksni oduzmi(Kompleksni a,Kompleksni b)
        {
            double r = a.realan - b.realan;
            double i = a.imaginaran - b.imaginaran;
            Kompleksni k = new Kompleksni(r,i);
            return k;
        }
        public static Kompleksni pomnozi(Kompleksni a,Kompleksni b)
        {
            double r = a.realan*b.realan - a.imaginaran*b.imaginaran;
            double i = a.realan*b.imaginaran + b.realan*a.imaginaran;
            Kompleksni k = new Kompleksni(r, i);
            return k;
        }
        public static Kompleksni podeli(Kompleksni a,Kompleksni b)
        {
            double r = Math.Round((a.realan * b.realan + a.imaginaran * b.imaginaran) / (b.imaginaran * b.imaginaran + b.realan * b.realan),2);
            double i = Math.Round((b.realan*a.imaginaran - a.realan*b.imaginaran) / (b.imaginaran * b.imaginaran + b.realan * b.realan),2);
            Kompleksni k = new Kompleksni(r, i);
            return k;
        }
        public string ispis()
        {
            string s = "";
            if (this.imaginaran < 0)
            {
                s = Convert.ToString(this.realan) + " - " + Convert.ToString(Math.Abs(this.imaginaran)+"i");

            }
            else
            {
                s = Convert.ToString(this.realan) + " + " + Convert.ToString(Math.Abs(this.imaginaran)+"i");
            }
            return s;
        }
    }
}
