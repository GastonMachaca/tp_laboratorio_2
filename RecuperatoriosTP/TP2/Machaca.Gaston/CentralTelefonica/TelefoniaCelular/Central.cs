using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaCelular
{
    public class Central
    {
        private List<Llamada> listaDeLlamadas;

        protected string empresa;

        /// <summary>
        /// Propiedad a cargo de calcular el costo de una llamada local.
        /// </summary>
        public float CostoLocal
        {
            get => CalcularCosto(TipoLlamada.Local);
        }

        /// <summary>
        /// Propiedad a cargo de calcular el costo de una llamada provincial.
        /// </summary>
        public float CostoProvincial
        {
            get => CalcularCosto(TipoLlamada.Provincial);
        }

        /// <summary>
        /// Propiedad a cargo de calcular el costo de todas las llamadas realizadas.
        /// </summary>
        public float CostoTotal
        {
            get => CalcularCosto(TipoLlamada.Todas);
        }

        /// <summary>
        /// Propiedad de lectura de la lista de llamadas.
        /// </summary>
        public List<Llamada> Llamadas
        {
            get => listaDeLlamadas;
        }

        /// <summary>
        /// Constructor sin parametros encargado de iniciar la lista.
        /// </summary>
        public Central()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        /// <summary>
        /// Constructor que asignara el nombre de la empresa.
        /// </summary>
        /// <param name="nombreEmpresa">Nombre de la empresa</param>
        public Central(string nombreEmpresa) : this()
        {
            this.empresa = nombreEmpresa;
        }
        /// <summary>
        /// Metodo que se encarga de calcular el costo de las llamadas.
        /// </summary>
        /// <param name="tipo">Tipo de llamada local,provincial o total</param>
        /// <returns></returns>
        private float CalcularCosto(TipoLlamada tipo)
        {
            float aux1 = 0;

            foreach (Llamada aux in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (aux is Local l)
                        {
                            aux1 = aux1 + l.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (aux is Provincial p)
                        {
                            aux1 = aux1 + p.CostoLlamada;
                        }

                        break;
                    case TipoLlamada.Todas:
                        if (aux is Local lTotal)
                        {
                            aux1 = aux1 + lTotal.CostoLlamada;
                        }
                        if (aux is Provincial pTotal)
                        {
                            aux1 = aux1 + pTotal.CostoLlamada;
                        }

                        break;
                }
            }

            return aux1;
        }

        /// <summary>
        /// Metodo que se encarga de juntar toda la informacion de la central y sus llamadas.
        /// </summary>
        /// <returns>Contenido de la central</returns>
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("----------------------------------------------");

            cadena.Append("Empresa: " + this.empresa + "\n");

            cadena.AppendLine("Lista ordenada por duracion");

            foreach (Llamada lista in listaDeLlamadas)
            {
                cadena.AppendLine(lista.ToString());
            }

            cadena.AppendFormat("\n Consumo Local: $" + this.CostoLocal);
            cadena.AppendFormat("\n Consumo Provincial: $" + this.CostoProvincial);
            cadena.AppendFormat("\n Consumo Total: $" + this.CostoTotal);

            cadena.AppendLine("\n----------------------------------------------");

            return cadena.ToString();
        }

        /// <summary>
        /// Ordena la lista de llamadas por la duracion.
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        /// <summary>
        /// Sobrecarga del ToString();
        /// </summary>
        /// <returns>Contenido de la central</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Metodo que asocia las llamadas a la lista.
        /// </summary>
        /// <param name="nuevaLlamada">Llamada</param>
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            Llamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// Compara si una llamada de la lista es identico.
        /// </summary>
        /// <param name="c">Central Telefonica</param>
        /// <param name="llamada">Llamada a comparar</param>
        /// <returns>Si coincide una llamada con otra de la central sera true.Caso contrario,false.</returns>
        public static bool operator ==(Central c, Llamada llamada)
        {
            bool retorno = false;

            if (c.listaDeLlamadas.Count >= 1)
            {
                foreach (Llamada auxLlamada in c.Llamadas)
                {
                    if (auxLlamada == llamada)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Diferencia si una llamada no se encuentra en la lista.
        /// </summary>
        /// <param name="c">Central Telefonica</param>
        /// <param name="llamada">Llamada a comparar</param>
        /// <returns>True si no coincide contenido de la central con la llamada a comparar.Caso contrario,false.</returns>
        public static bool operator !=(Central c, Llamada llamada)
        {
            return !(c == llamada);
        }

        /// <summary>
        /// Agregará una llamada a la lista.
        /// </summary>
        /// <param name="c">Central donde se agregará el elemento</param>
        /// <param name="nuevaLlamada">Llamada a agregar</param>
        /// <returns>Si la llamada a agregar es distinta de una existente en la central,se agregara a la lista.Caso contrario,no se agregara..</returns>
        public static Central operator +(Central c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }


    }
}
