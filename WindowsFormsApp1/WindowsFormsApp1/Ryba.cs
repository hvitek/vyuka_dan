using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ryba : Zivocich
    {
        public int Delka { get; set; }

        public string Druh { get; set; }
        public Ryba(int delka, string druh)
        {
            Delka = delka;
            Druh = druh;
            Console.WriteLine(DateTime.Now + " obsah konstruktoru Ryba");
        }
        protected void Plavat()
        {
            
        }
        
    }
}
