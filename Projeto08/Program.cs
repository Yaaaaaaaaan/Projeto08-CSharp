using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto08
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine(  "Insira o valor do raio; ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            double circ = Circunferencia(raio);

            Console.WriteLine("Circunferência; " + circ.ToString("F2",CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
    }
}
