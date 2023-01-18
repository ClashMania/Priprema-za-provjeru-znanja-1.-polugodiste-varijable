using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_za_provjeru_znanja_1_polugodište_1_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2, b = 1, c = 3, d = 4;
            double x= (a*2 + b*2 + c*2 + d*2)/((a + b)*2 + (c + d)*2);

            Console.WriteLine(x);
            Console.ReadKey();


        }
    }
}
