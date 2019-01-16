using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole
{
    public class Clovek
    {

        public Clovek()
        {
            this.Zivy = true;
        }

        public Clovek(int vyska)
        {
            this.Vyska = vyska;
        }





        public int Vyska { get; set; }

        public int Vaha { get; set; }

        public string Jmeno { get; set; }

        public bool Zivy { get; set; }

        

    }
}
