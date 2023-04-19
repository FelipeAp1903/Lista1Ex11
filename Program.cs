using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double p;

            Console.Write("coloque o valor de x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("coloque o valor de y:");
            y = double.Parse(Console.ReadLine());
            p = Math.Pow(x, y);
            Console.WriteLine("a potencia é: {0}", p);
        }
    }
}
