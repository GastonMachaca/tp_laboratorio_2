using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanques;
using Aviones;

namespace Fabrica_Militar
{
    public interface IAvion
    {
        Aeronaves ObtenerDatosAviones { get; }
    }

    public interface ITanque
    {
        TipoTanque ObtenerDatosTanques { get; }
    }

}
