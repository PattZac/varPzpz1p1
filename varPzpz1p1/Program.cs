using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varPzpz1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Unesite a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite d: ");
            d = Convert.ToDouble(Console.ReadLine());
            double x = (a + b) * 2 + (c + d) * 2;
            Console.WriteLine("x je " + x + ".");
            Console.ReadLine();
        }
    }
}
