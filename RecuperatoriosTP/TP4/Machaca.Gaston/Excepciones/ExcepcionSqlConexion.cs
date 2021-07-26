using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionSqlConexion : Exception
    {
        public ExcepcionSqlConexion() : base("No se pudo conectar a la base de datos")
        {

        }
            
    }
}
