using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole
{
   
    class Program
    {
       

        static void Main(string[] args)
        {
            Clovek clovekInst = new Clovek();
            clovekInst.Jmeno = "Jakub";
            clovekInst.Vaha = 80;
            clovekInst.Vyska = 180;
            Clovek clovekInst2 = new Clovek(185);
            clovekInst2.Jmeno = "Josef";
            clovekInst2.Vaha = 70;
            clovekInst2.Vyska = 170;
            Clovek kopiecloveka = clovekInst2;
            
           
            ;

        }
        public static void Vrah(Clovek a)
        {
            a.Zivy = false;
        }
        
         


    }
}
