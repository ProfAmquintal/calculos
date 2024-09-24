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

        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <returns>Retorna o resultado de dois numeros</returns>
        public static int Multiplicar(int x, int y)
        { return x * y; }


    }
}
