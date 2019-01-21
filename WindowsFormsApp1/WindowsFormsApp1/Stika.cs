using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Stika : Ryba
    {
        public Stika() : base(5, "")
        {
            Console.WriteLine(DateTime.Now + " obsah konstruktoru");
        }

        public void LoviKapra()
        {
 
        }
    }
}
