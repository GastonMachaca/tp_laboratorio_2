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
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            string aux = ValidarOperador(Convert.ToChar(operador)); // Convierto el operador recibido en char para poder validar la operacion.

            if (aux == "+")
            {
                retorno = num1 + num2;
            }
            else if (aux == "-")
            {
                retorno = num1 - num2;
            }
            else if (aux == "*")
            {
                retorno = num1 * num2;
            }
            else if (aux == "/")
            {
                if (num2 != 0)
                {
                    retorno = num1 / num2;
                }
                else
                {
                    retorno = double.MinValue; //Devuelve el valor más pequeño posible de un Double.
                }
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
                auxOperador = Char.ToString(operador); // Convierto el operador tipo char a string para ser legible.
            }
            return auxOperador;
        }
    }
}
