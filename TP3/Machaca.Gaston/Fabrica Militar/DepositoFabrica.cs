using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Militar
{
    public class DepositoFabrica<T, A> where T : Tanque, ITanque where A : Avion, IAvion
    {
        public DepositoFabrica()
        {

        }

        //FALTO CREACION DE DEPOSITO O METODO DE FABRICA PARA CREAR UN XML Y MOSTRAR. LO MISMO PARA GUARDAR.
    }
}
