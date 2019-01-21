using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Rybnik
    {
        List<Stika> Stiky = new List<Stika>();
        List<Kapr> Kapri = new List<Kapr>();
        public void PridejStiku()
        {
            Stika stika = new Stika();

            Stiky.Add(stika);
        }
        public void PridejKapra()
        {
            Console.WriteLine(DateTime.Now + " volání konstruktoru start");


            Kapr kapr = new Kapr("Jan", 25, 2, "velky");
            Console.WriteLine(DateTime.Now + " volání konstruktoru end");
        }
    }
}
