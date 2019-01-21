using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kapr : Ryba
    {
        public string Jmeno { get; set;}



       
            public Kapr(string jmeno, int delka, int hmotnost, string druh) : base(delka, druh)
        {
        
            this.Jmeno = jmeno;
            Hmotnost = hmotnost;
            Console.WriteLine(DateTime.Now + " obsah konstruktoru Kapr");
        }
       
        public void UtikatPredStikou()
        {
            this.Zit();
            
        }

        public  void Zit()
        {
            //prace




        }
    }

}
