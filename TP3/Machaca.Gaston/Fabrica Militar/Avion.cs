using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviones;
using Tanques;

namespace Fabrica_Militar
{
    public class Avion: IAvion
    { 
        private Aeronaves aeronavesSolicitadas;
        private Ametralladoras armasSolicitadas;
        private Cañones cañonesSolicitadas;
        private MotorRadial motoresSolicitados;

        private readonly int cantidadMotores;
        private readonly int cantidadCañones;
        private readonly int cantidadAmetralladoras;

        private int cantidadMotoresBlackWindow;
        private int cantidadCañonesBlackWindow;
        private int cantidadAmetralladorasBlackWindow;

        private int cantidadMotoresIlyushin;
        private int cantidadCañonesIlyushin;
        private int cantidadAmetralladorasIlyushin;

        private int cantidadMotoresHenschel;
        private int cantidadCañonesHenschel;
        private int cantidadAmetralladorasHenschel;

        private static int validar = 0;
        private int mensaje = 0;

        #region Propiedades Interfaces

        public Aeronaves ObtenerDatosAviones { get => aeronavesSolicitadas; }

        #endregion

        #region Propiedades Motores
        public int CantidadMotoresBlackWindows { get => this.cantidadMotoresBlackWindow; set => cantidadMotoresBlackWindow = value; }

        public int CantidadMotoresIlyushins { get => this.cantidadMotoresIlyushin; set => cantidadMotoresIlyushin = value; }

        public int CantidadMotoresHenschels { get => this.cantidadMotoresHenschel; set => cantidadMotoresHenschel = value; }

        #endregion

        #region Propiedades Cañones

        public int CantidadCañonesBlackWindows { get => this.cantidadCañonesBlackWindow; set => cantidadCañonesBlackWindow = value; }

        public int CantidadCañonesIlyushins { get => this.cantidadCañonesIlyushin; set => cantidadCañonesIlyushin = value; }

        public int CantidadCañonesHenschels { get => this.cantidadCañonesHenschel; set => cantidadCañonesHenschel = value; }

        #endregion

        #region Propiedades Ametralladoras

        public int CantidadAmetralladorasBlackWindows { get => this.cantidadAmetralladorasBlackWindow; set => cantidadAmetralladorasBlackWindow = value; }

        public int CantidadAmetralladorasIlyushins { get => this.cantidadAmetralladorasIlyushin; set => cantidadAmetralladorasIlyushin = value; }

        public int CantidadAmetralladorasHenschels { get => this.cantidadAmetralladorasHenschel; set => cantidadAmetralladorasHenschel = value; }

        #endregion

        public Avion(Cañones cañon, int cantidadCañones, MotorRadial motor, int cantidadMotores, Ametralladoras ametralladoras, int cantidadAmetralladoras)
        {
            this.cantidadMotores = cantidadMotores;
            this.cantidadCañones = cantidadCañones;
            this.cantidadAmetralladoras = cantidadAmetralladoras;

            this.motoresSolicitados = motor;
            this.armasSolicitadas = ametralladoras;
            this.cañonesSolicitadas = cañon;
        }

        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            switch (IdentificarAvion())
            {
                case 0:
                    if (mensaje == 0)
                    {
                        mensaje++;
                        cadena.Append("\nNo se puede producir ninguna aeronave con un cañon " + cañonesSolicitadas.ToString() + " y un motor radial" + motoresSolicitados.ToString() + "...\n");
                    }
                    break;

                case 1:
                    cadena.AppendLine(" ------------------------------------");
                    cadena.AppendLine("| AERONAVE: " + this.aeronavesSolicitadas + " |");
                    cadena.AppendLine("| Motor: " + this.motoresSolicitados + "         |");
                    cadena.AppendLine("| Cañon: " + this.cañonesSolicitadas + "                  |");
                    cadena.AppendLine("| Ametralladora: " + this.armasSolicitadas + "         |");
                    cadena.AppendLine(" ---------------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.cantidadMotoresBlackWindow);
                    cadena.AppendLine("Cantidad de cañones: " + this.cantidadCañonesBlackWindow);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.cantidadAmetralladorasBlackWindow);

                    break;

                case 2:
                    cadena.AppendLine(" -------------------------------");
                    cadena.AppendLine("| AERONAVE: " + this.aeronavesSolicitadas + "      |");
                    cadena.AppendLine("| Motor: " + this.motoresSolicitados + "    |");
                    cadena.AppendLine("| Cañon: " + this.cañonesSolicitadas + " |");
                    cadena.AppendLine("| Ametralladora: " + this.armasSolicitadas + "     |");
                    cadena.AppendLine(" -------------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.cantidadMotoresIlyushin);
                    cadena.AppendLine("Cantidad de cañones: " + this.cantidadCañonesIlyushin);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.cantidadAmetralladorasIlyushin);

                    break;

                case 3:
                    cadena.AppendLine(" ---------------------------");
                    cadena.AppendLine("| AERONAVE: " + this.aeronavesSolicitadas + " |");
                    cadena.AppendLine("| Motor: " + this.motoresSolicitados + "  |");
                    cadena.AppendLine("| Cañon: " + this.cañonesSolicitadas + "          |");
                    cadena.AppendLine("| Ametralladora: " + this.armasSolicitadas + "      |");
                    cadena.AppendLine(" ---------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.cantidadMotoresHenschel);
                    cadena.AppendLine("Cantidad de cañones: " + this.cantidadCañonesHenschel);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.cantidadAmetralladorasHenschel);
                    break;
            }

            cadena.Replace('_', ' ');

            return cadena.ToString();
        }

        public int IdentificarAvion()
        {
            int auxModelo = 0;

            if (cañonesSolicitadas is Cañones.Hispano_M2 && motoresSolicitados is MotorRadial.Pratt_and_Whitney_R && armasSolicitadas is Ametralladoras.Browning_M2)
            {
                cantidadMotoresBlackWindow = this.cantidadMotores;
                cantidadCañonesBlackWindow = this.cantidadCañones;
                cantidadAmetralladorasBlackWindow = this.cantidadAmetralladoras;
                aeronavesSolicitadas = Aeronaves.Northrop_P61_Black_Widow;
                auxModelo = 1;
            }

            if (cañonesSolicitadas is Cañones.Nudelman_Suranov_NS_23 && motoresSolicitados is MotorRadial.Daimler_Benz_DB_603 && armasSolicitadas is Ametralladoras.Berezin_UB)
            {
                cantidadMotoresIlyushin = this.cantidadMotores;
                cantidadCañonesIlyushin = this.cantidadCañones;
                cantidadAmetralladorasIlyushin = this.cantidadAmetralladoras;
                aeronavesSolicitadas = Aeronaves.Ilyushin_Il_10;
                auxModelo = 2;
            }

            if (cañonesSolicitadas is Cañones.MG_151_20 && motoresSolicitados is MotorRadial.Gnome_Rhône_14M_5 && armasSolicitadas is Ametralladoras.MG_17)
            {
                cantidadMotoresHenschel = this.cantidadMotores;
                cantidadCañonesHenschel = this.cantidadCañones;
                cantidadAmetralladorasHenschel = this.cantidadAmetralladoras;
                aeronavesSolicitadas = Aeronaves.Henschel_Hs_129;
                auxModelo = 3;
            }

            if (validar < 3)
            {
                validar++;
            }
            return auxModelo;          
        }

        public static implicit operator string(Avion a)
        {
            return a.Mostrar();
        }
    }
}
