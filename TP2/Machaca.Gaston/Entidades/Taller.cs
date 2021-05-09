using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        /// <summary>
        /// Se iniciaria un nueva lista de vehiculos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Se iniciara el espacio del taller para vehiculos.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Lista de los vehiculos de todo el taller</returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Lista por tipo de vehiculo y sus detalles</returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", taller.vehiculos.Count, taller.espacioDisponible);

            foreach (Vehiculo v in taller.vehiculos)
            {

                if (tipo == ETipo.Ciclomotor && v is Ciclomotor)
                {
                    sb.AppendLine(v.Mostrar());
                }


                if (tipo == ETipo.Sedan && v is Sedan)
                {
                    sb.AppendLine(v.Mostrar());
                }


                if (tipo == ETipo.SUV && v is Suv)
                {
                    sb.AppendLine(v.Mostrar());
                }


                if (tipo == ETipo.Todos)
                {
                    sb.AppendLine(v.Mostrar());
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>Si no se encuentra el vehiculo en el taller, un espacio (max: 6).Al pasar de la capacidad, no se deja entrar. </returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            int count = 0;

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    count = 1;
                    break;
                }
            }

            if (count == 0 && taller.vehiculos.Count < taller.espacioDisponible)
            {
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>Remueve el vehiculo seleccionado del taller</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
