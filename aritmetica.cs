using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }
        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns> Retorna a soma de 2 números </returns>
        public static int Somar(int x, int y)
        { return x + y; }
        /// <summary>
        /// Operação de Subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de 2 números</returns>
        public static int Subtrair(int x, int y)
        { return x - y; }

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return (temperatura * 1.000 + 32);
            }
            else if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return ((temperatura - 32) / 1.000);
            }
            else
                return -1;

        }

    }
}
