using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaCelular
{
    public class Local : Llamada
    {
        protected float costo;

        /// <summary>
        /// Sobrecarga de propiedad encargada de calcular el costo de la llamada.
        /// </summary>
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        /// <summary>
        /// Constructor que recibe el codigo de area,la duracion,numero y costo de la llamada.
        /// </summary>
        /// <param name="codigoArea">Codigo de area</param>
        /// <param name="duracion">Duracion de la llamada</param>
        /// <param name="numero">Numero de la llamada</param>
        /// <param name="costo">Costo de la llamada</param>
        public Local(string codigoArea, float duracion, string numero, float costo) : base(duracion, numero, codigoArea)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Constructor que toma una llamada y su costo.
        /// </summary>
        /// <param name="llamada">Datos de la llamada</param>
        /// <param name="costo">Costo de la llamada</param>
        public Local(Llamada llamada, float costo) : this(llamada.CodigoArea, llamada.Duracion, llamada.Numero, costo)
        {
        }

        /// <summary>
        /// Metodo que se encarga de mostrar el numero,duracion,codigo de area y costo de la llamada local.
        /// </summary>
        /// <returns>Contenido de la llamada local</returns>
        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendFormat("Costo de la llamada local: $" + this.CostoLlamada);

            return cadena.ToString();
        }

        /// <summary>
        /// Metodo que calcula el costo de la llamada local.
        /// </summary>
        /// <returns>Valor flotante de la operacion.</returns>
        private float CalcularCosto()
        {
            float calculo = Duracion * this.costo;

            return calculo;
        }

        /// <summary>
        /// Sobrecarga de Equals.
        /// </summary>
        /// <param name="obj">Objeto</param>
        /// <returns>Devuelve true si el objeto a comparar es del tipo local.Caso contrario,false.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Local)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga para evitar al advertencia.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del ToString()
        /// </summary>
        /// <returns>Devuelve el contenido de la llamada local</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
