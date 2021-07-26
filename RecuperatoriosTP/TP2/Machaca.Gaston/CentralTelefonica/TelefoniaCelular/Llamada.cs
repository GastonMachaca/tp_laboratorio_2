using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaCelular
{
    /// <summary>
    /// Formas de asignar la llamada.
    /// </summary>
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public abstract class Llamada
    {
        protected float duracion;
        protected string numero;
        protected string codigoArea;

        /// <summary>
        /// Propiedad de solo lectura que retornara el costo de la llamada.
        /// </summary>
        public abstract float CostoLlamada
        {
            get;
        }

        /// <summary>
        /// Propiedad que obtendra la duracion de la llamada.
        /// </summary>
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        /// <summary>
        /// Propiedad que obtendra el numero de la llamada.
        /// </summary>
        public string Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Propiedad que obtendra el codigo de area de la llamada.
        /// </summary>
        public string CodigoArea
        {
            get
            {
                return this.codigoArea;
            }

        }
        /// <summary>
        /// Constructor que tomara el numero,la duracion y codigo de area de la llamada.
        /// </summary>
        /// <param name="duracion">Duracion de la llamada</param>
        /// <param name="numero">Numero de la llamada</param>
        /// <param name="codigoArea">Codigo de area de la llamada</param>
        public Llamada(float duracion, string numero, string codigoArea)
        {
            this.duracion = duracion;
            this.numero = numero;
            this.codigoArea = codigoArea;
        }

        /// <summary>
        /// Metodo que se encarga de mostrar la informacion de la llamada.
        /// </summary>
        /// <returns>Contenido de la llamada</returns>
        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append("\nNumero: " + this.numero + "\n");
            cadena.AppendLine("Codigo de Area: " + this.codigoArea);
            cadena.AppendFormat("Duracion: " + this.duracion + " minutos");

            return cadena.ToString();
        }

        /// <summary>
        /// Ordena las llamadas por su duracion.
        /// </summary>
        /// <param name="llamada1">Llamada base</param>
        /// <param name="llamada2">Llamada a comparar</param>
        /// <returns>1 si la llamada base es superior en duracion. -1 si la llamada base es inferior en duracion.</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }

        /// <summary>
        /// Diferencia las llamadas.
        /// </summary>
        /// <param name="l1">Llamada base</param>
        /// <param name="l2">Llamada a comparar</param>
        /// <returns>True si las llamadas son distintas.Caso contrario,false.</returns>
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        /// <summary>
        /// Indentifica si las llamadas son identicas.
        /// </summary>
        /// <param name="l1">Llamada base</param>
        /// <param name="l2">Llamada a comparar</param>
        /// <returns>True si las llamadas tienen el mismo numero y codigo de area.Caso contrario,false.</returns>
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if (Equals(l1, l2))
            {
                if (l1.numero == l2.numero && l1.codigoArea == l2.codigoArea)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
    }
}
