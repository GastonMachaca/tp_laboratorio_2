using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionCapacidad : Exception
    {
        public ExcepcionCapacidad() : base("Debe haber al menos 100 a 200 empleados...")
        {

        }
        
    }
}
