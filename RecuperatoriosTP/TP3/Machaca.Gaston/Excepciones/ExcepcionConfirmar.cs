using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionConfirmar : Exception
    {
        public ExcepcionConfirmar() : base("Rellene todo los campos antes de confirmar...")
        {

        }
    }

    public class ExcepcionCompatibilidad : Exception
    {
        public ExcepcionCompatibilidad() : base("Se a intentado iniciar la produccion de un tanque no disponible en esta fabrica...")
        {

        }
    }
}
