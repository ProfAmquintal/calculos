using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4+2=", aritmetica.Somar(4, 2));
            Console.WriteLine("4-2=", aritmetica.Subtrair(4, 2));
            double t1 = Conversao.ConverterTemperatura(Conversao.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversao.ConverterTemperatura(Conversao.ConversaoTemperatura.FahrenheitCelsius, 100);
            Console.WriteLine("36 graus Celsius=",t1, "Fahrenheit");
            Console.WriteLine("100 graus Fahrenheit=", t2, "Celsius");
            Console.ReadKey();
        }
    }
}
