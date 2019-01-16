using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole
{
    public static class MathOprBase
    {
        public static int Secti(int a, int b)
        {
            var vysledek = a + b;
            return vysledek;
        }

        public static int Odecti(int a, int b)
        {
            var vysledek = a - b;
            return vysledek;
        }
        public static int Vynasob(int a, int b)
        {
            var vysledek = a * b;
            return vysledek;
        }
    }
}
