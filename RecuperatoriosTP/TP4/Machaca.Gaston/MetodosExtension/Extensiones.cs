using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace MetodosExtension
{
    public static class Extensiones
    {
        public static string CantidadEmpleados(this ExcepcionCapacidad capacidad)
        {
            string mensaje = "Debe haber al menos 100 a 200 empleados...";

            return mensaje;
        }

        public static string ConfirmarEmpleados(this ExcepcionConfirmar confirmar)
        {
            string mensaje = "No se ha seleccionado todos los parametros solicitados...";

            return mensaje;
        }

        public static string MostrarCompatibilidad(this ExcepcionCompatibilidad confirmar)
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("Tanque Tiger: \nRequiere: \nMotor - Maybach || Cañon - KwK 43 || Ametralladora - MG 34");
            mensaje.AppendLine("\nTanque Sherman: \nRequiere: \nMotor - R975 || Cañon - M1 76 || Ametralladora - Browning");
            mensaje.AppendLine("\nTanque T-34: \nRequiere: \nMotor - Diesel || Cañon - F34 || Ametralladora - DT");
            mensaje.AppendLine("\nAvion BlackWidow \nRequiere: \nMotor - Pratt || Cañon - Hispano || Ametralladora - Browning");
            mensaje.AppendLine("\nAvion Ilyushin \nRequiere: \nMotor - Daimler || Cañon - Nudelman || Ametralladora - Berezin");
            mensaje.AppendLine("\nAvion Henschel \nRequiere: \nMotor - Gnome || Cañon - MG 151 20 || Ametralladora - MG 17");

            return mensaje.ToString();
        }
    }
}
