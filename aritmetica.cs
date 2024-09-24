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
    internal class aritmetica
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
        public int Somar(int x, int y)
        { return x + y; }
        /// <summary>
        /// Operação de Subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de 2 números</returns>
        public int Subtrair(int x, int y)
        { return x - y; }

    }
}
