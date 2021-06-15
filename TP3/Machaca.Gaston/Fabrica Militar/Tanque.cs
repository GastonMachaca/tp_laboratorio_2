using Aviones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanques;

namespace Fabrica_Militar
{
    public class Tanque : ITanque
    {
        private TipoTanque tanque_A_Fabricar;
        private TipoCañon cañon_A_Fabricar;
        private TipoMotor motor_A_Fabricar;
        private TipoAmetralladoras ametralladoras_A_Fabricar;

        private readonly int cantidadMotores;
        private readonly int cantidadCañones;
        private readonly int cantidadAmetralladoras;

        private int CantidadMotoresTiger;
        private int CantidadCañonesTiger;
        private int CantidadAmetralladorasTiger;

        private int CantidadMotoresSherman;
        private int CantidadCañonesSherman;
        private int CantidadAmetralladorasSherman;

        private int CantidadMotoresT34;
        private int CantidadCañonesT34;
        private int CantidadAmetralladorasT34;

        private static int validar = 0;
        private int mensaje = 0;

        public TipoTanque ObtenerDatosTanques { get => tanque_A_Fabricar; }

        #region Propiedades Motores
        public int CantidadMotoresTigers { get => this.CantidadMotoresTiger; set => CantidadMotoresTiger = value; }

        public int CantidadMotoresShermans { get => this.CantidadMotoresSherman; set => CantidadMotoresSherman = value; }

        public int CantidadMotores_T34 { get => this.CantidadMotoresT34; set => CantidadMotoresT34 = value; }

        #endregion


        #region Propiedades Cañones

        public int CantidadCañonesTigers { get => this.CantidadCañonesTiger; set => CantidadCañonesTiger = value; }

        public int CantidadCañonesShermans { get => this.CantidadCañonesSherman; set => CantidadCañonesSherman = value; }

        public int CantidadCañones_T34 { get => this.CantidadCañonesT34; set => CantidadCañonesT34 = value; }

        #endregion


        #region Propiedades Ametralladoras

        public int CantidadAmetralladorasTigers { get => this.CantidadAmetralladorasTiger; set => CantidadAmetralladorasTiger = value; }

        public int CantidadAmetralladorasShermans { get => this.CantidadAmetralladorasSherman; set => CantidadAmetralladorasSherman = value; }

        public int CantidadAmetralladoras_T34 { get => this.CantidadAmetralladorasT34; set => CantidadAmetralladorasT34 = value; }

        #endregion

        public Tanque(TipoCañon cañon, int cantidadCañones, TipoMotor motor, int cantidadMotores, TipoAmetralladoras ametralladoras, int cantidadAmetralladoras)
        {
            this.cañon_A_Fabricar = cañon;
            this.motor_A_Fabricar = motor;
            this.ametralladoras_A_Fabricar = ametralladoras;

            this.cantidadMotores = cantidadMotores;
            this.cantidadCañones = cantidadCañones;
            this.cantidadAmetralladoras = cantidadAmetralladoras;
        }

        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("\nSe indentificaron los materiales...");

            switch (IdentificarTanque())
            {
                case 0:
                    if (mensaje == 0)
                    {
                        mensaje++;
                        cadena.Append("\nNo se puede producir ningun tanque con un cañon " + cañon_A_Fabricar.ToString() + " y un motor " + motor_A_Fabricar.ToString() + "...\n");
                    }                  
                    break;

                case 1:
                    cadena.AppendLine(" ---------------------------------");
                    cadena.AppendLine("| TANQUE TIGER                    |");
                    cadena.AppendLine("| Motor: " + this.motor_A_Fabricar + "       |");
                    cadena.AppendLine("| Cañon: " + this.cañon_A_Fabricar + "                   |");
                    cadena.AppendLine("| Ametralladora: " + this.ametralladoras_A_Fabricar + "            |");
                    cadena.AppendLine(" ---------------------------------");

                    cadena.AppendLine("\nCantidad de motores de Tiger: " + this.CantidadMotoresTiger);
                    cadena.AppendLine("Cantidad de cañones de Tiger: " + this.CantidadCañonesTiger);
                    cadena.AppendLine("Cantidad de ametralladoras de Tiger: " + this.CantidadAmetralladorasTiger);
                    break;

                case 2:
                    cadena.AppendLine(" --------------------------------");
                    cadena.AppendLine("| TANQUE SHERMAN                 |");
                    cadena.AppendLine("| Motor: " + this.motor_A_Fabricar + "                 |");
                    cadena.AppendLine("| Cañon: " + this.cañon_A_Fabricar + "                |");
                    cadena.AppendLine("| Ametralladora: " + this.ametralladoras_A_Fabricar + "|");
                    cadena.AppendLine(" --------------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.CantidadMotoresSherman);
                    cadena.AppendLine("Cantidad de cañones: " + this.CantidadCañonesSherman);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.CantidadAmetralladorasSherman);
                    break;

                case 3:
                    cadena.AppendLine(" --------------------------------");
                    cadena.AppendLine("| TANQUE T-34                    |");
                    cadena.AppendLine("| Motor: " + this.motor_A_Fabricar + "            |");
                    cadena.AppendLine("| Cañon: " + this.cañon_A_Fabricar + "          |");
                    cadena.AppendLine("| Ametralladora: " + this.ametralladoras_A_Fabricar + "              |");
                    cadena.AppendLine(" --------------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.CantidadMotoresT34);
                    cadena.AppendLine("Cantidad de cañones: " + this.CantidadCañonesT34);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.CantidadAmetralladorasT34);
                    break;
            }

            cadena.Replace('_', ' ');

            return cadena.ToString();
        }

        public int IdentificarTanque()
        {
            int auxModelo = 0;

            if (cañon_A_Fabricar is TipoCañon.KwK_43 && motor_A_Fabricar is TipoMotor.Maybach_HL_230_P30 && ametralladoras_A_Fabricar is TipoAmetralladoras.MG_34)
            {
                CantidadMotoresTiger = this.cantidadMotores;
                CantidadCañonesTiger = this.cantidadCañones;
                CantidadAmetralladorasTiger = this.cantidadAmetralladoras;
                tanque_A_Fabricar = TipoTanque.Panzer_VI_Tiger;
                auxModelo = 1;
            }

            if (cañon_A_Fabricar is TipoCañon.M1_76_mm && motor_A_Fabricar is TipoMotor.R975_C4 && ametralladoras_A_Fabricar is TipoAmetralladoras.Browning_M1919A4)
            {
                CantidadMotoresSherman = this.cantidadMotores;
                CantidadCañonesSherman = this.cantidadCañones;
                CantidadAmetralladorasSherman = this.cantidadAmetralladoras;
                tanque_A_Fabricar = TipoTanque.Sherman_M4;
                auxModelo = 2;
            }

            if (cañon_A_Fabricar is TipoCañon.F34_de_76_2_mm && motor_A_Fabricar is TipoMotor.Diesel_V2_34 && ametralladoras_A_Fabricar is TipoAmetralladoras.DT)
            {
                CantidadMotoresT34 = this.cantidadMotores;
                CantidadCañonesT34 = this.cantidadCañones;
                CantidadAmetralladorasT34 = this.cantidadAmetralladoras;
                tanque_A_Fabricar = TipoTanque.T_34;
                auxModelo = 3;
            }

            if (validar < 3)
            {
                validar++;
            }

            return auxModelo;
        }

        public static implicit operator string(Tanque t)
        {
            return t.Mostrar();
        }
    }
}
