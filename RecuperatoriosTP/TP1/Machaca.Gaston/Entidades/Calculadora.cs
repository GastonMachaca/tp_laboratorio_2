using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador y resuelve la operacion asignada entre 2 numeros.
        /// </summary>
        /// <param name="num1">Tipo Numero - 1er operador</param>
        /// <param name="num2">Tipo Numero - 2do operador</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Resultado en formato double de la operacion realizada</returns>
        public static double Operar(Numero num1, Numero num2, char operador)
        {
            double retorno = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Validar operador en caso de ser un operador matematico.
        /// </summary>
        /// <param name="operador">Operador</param>
        /// <returns>Si es un operador valido, retorna el mismo.Caso contrario retorna + </returns>
        private static string ValidarOperador(char operador)
        {
            string auxOperador = "+";

            if ((operador == '/') || (operador == '*') || (operador == '+') || (operador == '-'))
            {
                auxOperador = char.ToString(operador); // Convierto el operador tipo char a string para ser legible.
            }
            return auxOperador;
        }
    }
}