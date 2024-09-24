using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.aritmetica;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class Conversao
    {
       
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
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
       
        public enum ConversaoDistancia
        {
            Nulo=0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Converte distâncias
        /// </summary>
        /// <param name="conversao">Tipo de conversao</param>
        /// <param name="distancia">Distancia a converter</param>
        /// <returns>Retorna o resultado da conversão da distancia</returns>

        public static double converterDistancias(ConversaoDistancia conversao,double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
                return (distancia * 0.0006213712);
            else
                if (conversao == ConversaoDistancia.MilhasMetros)
                return (distancia * 1609.344);
            else
                return -1;
        }

       
    }
}
