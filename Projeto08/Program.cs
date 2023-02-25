using System;
using System.Globalization;

namespace Projeto08
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do raio; ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferência; " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume; " + vol.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI; " + Pi.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r,3.0);
        }
    }
}
