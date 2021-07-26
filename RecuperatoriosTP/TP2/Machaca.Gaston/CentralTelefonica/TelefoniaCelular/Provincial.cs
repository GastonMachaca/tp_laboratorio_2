using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaCelular
{
    public class Provincial : Llamada
    {
        /// <summary>
        /// Opciones de provincias disponibles para su seleccion.
        /// </summary>
        public enum Franja
        {
            Cordoba,
            Mendoza,
            Jujuy
        }

        protected Franja franjaSeccion;

        /// <summary>
        /// Propiedad que se encarga de calcular el costo de la llamada.
        /// </summary>
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        /// <summary>
        /// Constructor designado para establecer una llamada provincial.
        /// </summary>
        /// <param name="origen">Codigo de area de la provincia a contactar.</param>
        /// <param name="miFranja">Provincia a la que se realiza la llamada</param>
        /// <param name="duracion">Tiempo de llamada realizada</param>
        /// <param name="destino">Numero de celular de la persona a contactar</param>
        public Provincial(string codigoArea, Franja miFranja, float duracion, string numero) : base(duracion, numero, codigoArea)
        {
            this.franjaSeccion = miFranja;
        }

        /// <summary>
        /// Constructor para repetir una llamada realizada a otra provincia.
        /// </summary>
        /// <param name="miFranja">Provincia a la que se realiza la llamada</param>
        /// <param name="llamada">Datos de llamada realizada</param>
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.CodigoArea, miFranja, llamada.Duracion, llamada.Numero)
        {
        }

        /// <summary>
        /// Muestra los datos generales (numero,codigo de area,duracion)de la llamada junto con el costo y provincia dirigida. 
        /// </summary>
        /// <returns>Cadena de caracteres con todos los datos de la llamada.</returns>
        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append(base.Mostrar());
            cadena.AppendLine("\nCosto de la llamada provincial: $" + this.CostoLlamada);
            cadena.AppendFormat("Provincia: " + this.franjaSeccion);

            return cadena.ToString();
        }

        /// <summary>
        /// Calcula el costo en base a la provincia seleccionada a contactar.
        /// </summary>
        /// <returns>Precio de llamada en base a su duracion</returns>
        private float CalcularCosto()
        {
            double costoLlamada = 0;

            switch (this.franjaSeccion)
            {
                case Franja.Cordoba:
                    costoLlamada = 0.99;
                    break;
                case Franja.Jujuy:
                    costoLlamada = 1.25;
                    break;
                case Franja.Mendoza:
                    costoLlamada = 0.66;
                    break;
            }

            return (float)(Duracion * costoLlamada);

        }

        /// <summary>
        /// Publica todos los datos de la llamada provincial utilizando la funcion explicita que devuelve un string.
        /// </summary>
        /// <returns>Retorna los datos de la llamada</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Se encarga de preguntar si se trata de una llamada provincial.
        /// </summary>
        /// <param name="obj">Parametro a comparar</param>
        /// <returns>True : Si coincide ser una llamada provincial. False : Si no se trata de una llamada provincial.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Provincial)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Implementado para evitar la advertencia de invalidar el GetHashcode().
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
