using System;
using System.Globalization;

namespace Projeto08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Console.WriteLine("Insira o valor do raio; ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            double circ = cal.Circunferencia(raio);
            double vol = cal.Volume(raio);

            Console.WriteLine("Circunferência; " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume; " + vol.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI; " + cal.Pi.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
