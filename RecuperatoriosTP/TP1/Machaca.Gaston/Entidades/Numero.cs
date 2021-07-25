using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades

        /// <summary>
        /// Validacion y asignacion del atributo numero.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Asignacion de constructor por defecto.
        /// </summary>
        public Numero() : this("0")
        {
        }

        /// <summary>
        /// Asignacion de numero por sobrecarga.
        /// </summary>
        /// <param name="num">Parametro Numero</param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        /// <summary>
        /// Asignacion de numero por sobrecarga.
        /// </summary>
        /// <param name="num">Parametro Numero</param>
        public Numero(double numero) : this(numero.ToString())
        {
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Conversion - Binario a Decimal de enteros positivos.
        /// </summary>
        /// <param name="binario">Numero Binario</param>
        /// <returns>Binario a Decimal. Caso contrario devuelve "Valor invalido"</returns>
        public string BinaroDecimal(string binario)
        {
            if (binario != "" && binario[0] != '-' && EsBinario(binario))//Si el binario no esta vacio, no es negativo y es binario.
            {
                return Convert.ToInt64(binario, 2).ToString(); //Convierto a Decimal.
            }
            else
            {
                return "Valor invalido"; //En caso de no cumplir la condicion,devuelve "Valor invalido".
            }   
        }

        /// <summary>
        /// Conversion - Decimal Binario de enteros positivos.
        /// </summary>
        /// <param name="numero">Numero Decimal</param>
        /// <returns>Decimal a Binario. Caso contrario devuelve "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            string auxNum = "";
            string auxBinario = "";

            int num = (int)numero; // Se toma la parte entera del numero.

            auxBinario = Convert.ToString(numero); // Convierto el double en string.

            if(EsBinario(auxBinario)) // Pregunto si es Binario.
            {
                if(numero == 1)
                {
                    auxBinario = Convert.ToString(numero);

                    return auxBinario; //Procedo a retonar el mismo numero ya que 1 sigue siendo 1 en binario.
                }

                return auxNum = "Valor invalido"; // Caso contrario devuelvo mensaje de error.
            }
            else
            {
                while (num > 0) // Mientras el numero sea mayor a 0
                {
                    if (num % 2 == 0) // Y el numero de resto 0
                    {
                        auxNum = "0" + auxNum;  // Asigno 0 al string.
                    }
                    else
                    {
                        auxNum = "1" + auxNum; // Asigno 1 al string.
                    }

                    num /= 2;
                }

                auxNum = '0' + auxNum; // Pongo un 0 para completar el binario(Ej: 110 sera 0110).

                return auxNum;
            }
        }

        public string DecimalBinario(string numero)
        {
            double dNumero;
            string mensaje = "Valor invalido";
            bool confirma = false;

            confirma = double.TryParse(numero, out dNumero);

            if (confirma)
            {
                mensaje = DecimalBinario(dNumero);
            }

            return mensaje;
        }

        /// <summary>
        /// Compruebo si un valor es Binario.
        /// </summary>
        /// <param name="binario">String binario a validar.</param>
        /// <returns>Devuelve true si es binario. Caso contrario devuelve false.</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char a in binario)
            {
                if (a != '1' && a != '0')
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba si el valor recibido es un numero y cambia su formato a double. 
        /// </summary>
        /// <param name="strNumero">String de Numero</param>
        /// <returns>El numero en formato double si es numerico.Caso contrario devuelvo 0.</returns>
        private double ValidarNumero(string strNumero)
        {
            double num;

            bool retorno = double.TryParse(strNumero, out num);

            if(!retorno)
            {
                num = 0;
            }
            return num;
        }
        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Suma de 2 numeros.
        /// </summary>
        /// <param name="num1">Tipo:Numero - 1er numero</param>
        /// <param name="num2">Tipo:Numero - 2do numero</param>
        /// <returns>Resultado en formato double de la suma entre num1 y num2</returns>
        public static double operator +(Numero num1 , Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Resta de 2 numeros.
        /// </summary>
        /// <param name="num1">Tipo:Numero - 1er numero</param>
        /// <param name="num2">Tipo:Numero - 2do numero</param>
        /// <returns>Resultado en formato double de la resta entre num1 y num2</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Multiplicacion de 2 numeros.
        /// </summary>
        /// <param name="num1">Tipo:Numero - 1er numero</param>
        /// <param name="num2">Tipo:Numero - 2do numero</param>
        /// <returns>Resultado en formato double de la multiplicacion entre num1 y num2</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Division de 2 numeros.
        /// </summary>
        /// <param name="num1">Tipo:Numero - 1er numero</param>
        /// <param name="num2">Tipo:Numero - 2do numero</param>
        /// <returns>Resultado en formato double de la division entre num1 y num2</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double numero;

            if(num2.numero == 0)
            {
                numero = double.MinValue;
            }
            else
            {
                numero = num1.numero / num2.numero;
            }

            return numero;
        }

        #endregion
    }
}
