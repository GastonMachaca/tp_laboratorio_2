using Aviones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanques;
using Excepciones;

namespace Fabrica_Militar
{
    public delegate void DelegadoEvento(string mensaje);
    public class Tanque : ITanque
    {
        private TipoTanque tanqueSolicitado;
        private TipoCañon cañonSolicitado;
        private TipoMotor motorSolicitado;
        private TipoAmetralladoras armaSolicitada;

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

        public event DelegadoEvento Evento;

        public TipoTanque ObtenerDatosTanques { get => tanqueSolicitado; }

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


        /// <summary>
        /// Constructor sin parametros para XML.
        /// </summary>
        public Tanque()
        {

        }

        /// <summary>
        /// Constructor que recibe los parametros para la fabricacion de un tanque.
        /// </summary>
        /// <param name="cañon">cañon del tanque</param>
        /// <param name="cantidadCañones">cantidad de cañones del tanque</param>
        /// <param name="motor">motor del tanque</param>
        /// <param name="cantidadMotores">cantidad de motores del tanque</param>
        /// <param name="ametralladoras">ametralladora del tanque</param>
        /// <param name="cantidadAmetralladoras">cantidad de ametralladoras del tanque</param>
        public Tanque(TipoCañon cañon, int cantidadCañones, TipoMotor motor, int cantidadMotores, TipoAmetralladoras ametralladoras, int cantidadAmetralladoras)
        {
            this.cañonSolicitado = cañon;
            this.motorSolicitado = motor;
            this.armaSolicitada = ametralladoras;

            this.cantidadMotores = cantidadMotores;
            this.cantidadCañones = cantidadCañones;
            this.cantidadAmetralladoras = cantidadAmetralladoras;
        }

        /// <summary>
        /// Metodo que se encarga de mostrar los datos del tanque a producir.
        /// </summary>
        /// <returns>Cadena de caracteres con los datos del tanque a fabricar</returns>
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("\nSe indentificaron los materiales... \nIniciando proceso de produccion de: \n");

            switch (IdentificarTanque())
            {
                case 0:
                    if (mensaje == 0)
                    {
                        mensaje++;
                        cadena.Append("\nNo se puede producir ningun tanque con un cañon " + cañonSolicitado.ToString() + " y un motor " + motorSolicitado.ToString() + "...\n");
                    }                  
                    break;

                case 1:
                    cadena.AppendLine("TANQUE TIGER");
                    cadena.AppendLine("Motor: " + this.motorSolicitado);
                    cadena.AppendLine("Cañon: " + this.cañonSolicitado);
                    cadena.AppendLine("Ametralladora: " + this.armaSolicitada);

                    cadena.AppendLine("\nCantidad de motores de Tiger: " + this.CantidadMotoresTiger);
                    cadena.AppendLine("Cantidad de cañones de Tiger: " + this.CantidadCañonesTiger);
                    cadena.AppendLine("Cantidad de ametralladoras de Tiger: " + this.CantidadAmetralladorasTiger);
                    break;

                case 2:
                    cadena.AppendLine("TANQUE SHERMAN");
                    cadena.AppendLine("Motor: " + this.motorSolicitado);
                    cadena.AppendLine("Cañon: " + this.cañonSolicitado);
                    cadena.AppendLine("Ametralladora: " + this.armaSolicitada);
                    cadena.AppendLine(" --------------------------------");

                    cadena.AppendLine("\nCantidad de motores: " + this.CantidadMotoresSherman);
                    cadena.AppendLine("Cantidad de cañones: " + this.CantidadCañonesSherman);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.CantidadAmetralladorasSherman);
                    break;

                case 3:
                    cadena.AppendLine("TANQUE T-34");
                    cadena.AppendLine("Motor: " + this.motorSolicitado);
                    cadena.AppendLine("Cañon: " + this.cañonSolicitado);
                    cadena.AppendLine("Ametralladora: " + this.armaSolicitada);

                    cadena.AppendLine("\nCantidad de motores: " + this.CantidadMotoresT34);
                    cadena.AppendLine("Cantidad de cañones: " + this.CantidadCañonesT34);
                    cadena.AppendLine("Cantidad de ametralladoras: " + this.CantidadAmetralladorasT34);
                    break;
            }

            cadena.Replace('_', ' ');

            return cadena.ToString();
        }

        /// <summary>
        /// Metodo que se encarga de identificar el tipo de tanque en base al motor,cañon y ametralladora recibido.
        /// </summary>
        /// <returns>0 si no se reconoce el tanque,1 si es un tanque tiger,2 si es un tanque Sherman,3 si es un tanque T-34</returns>
        public int IdentificarTanque()
        {
            int auxModelo = 0;

            if (cañonSolicitado is TipoCañon.KwK_43 && motorSolicitado is TipoMotor.Maybach_HL_230_P30 && armaSolicitada is TipoAmetralladoras.MG_34)
            {
                CantidadMotoresTiger = this.cantidadMotores;
                CantidadCañonesTiger = this.cantidadCañones;
                CantidadAmetralladorasTiger = this.cantidadAmetralladoras;
                tanqueSolicitado = TipoTanque.Panzer_VI_Tiger;
                auxModelo = 1;
            }

            if (cañonSolicitado is TipoCañon.M1_76_mm && motorSolicitado is TipoMotor.R975_C4 && armaSolicitada is TipoAmetralladoras.Browning_M1919A4)
            {
                CantidadMotoresSherman = this.cantidadMotores;
                CantidadCañonesSherman = this.cantidadCañones;
                CantidadAmetralladorasSherman = this.cantidadAmetralladoras;
                tanqueSolicitado = TipoTanque.Sherman_M4;
                auxModelo = 2;
            }

            if (cañonSolicitado is TipoCañon.F34_de_76_2_mm && motorSolicitado is TipoMotor.Diesel_V2_34 && armaSolicitada is TipoAmetralladoras.DT)
            {
                CantidadMotoresT34 = this.cantidadMotores;
                CantidadCañonesT34 = this.cantidadCañones;
                CantidadAmetralladorasT34 = this.cantidadAmetralladoras;
                tanqueSolicitado = TipoTanque.T_34;
                auxModelo = 3;
            }

            if (validar < 3)
            {
                validar++;
            }

            if(auxModelo == 0)
            {
                throw new ExcepcionCompatibilidad(); 
            }

            return auxModelo;
        }

        /// <summary>
        /// Evento para Clase 24, guarda txt.
        /// </summary>
        /// <param name="info">Contenido de tanque</param>
        public void PasarInformacion(string info)
        {
            if(!object.ReferenceEquals(this.Evento,null))
            {
                this.Evento.Invoke(info);
            }
        }

        /// <summary>
        /// Operador explicito para mostrar el contenido del tanque.
        /// </summary>
        /// <param name="t">Tanque fabricado</param>
        public static implicit operator string(Tanque t)
        {
            return t.Mostrar();
        }

        /// <summary>
        /// Metodo override de ToString()
        /// </summary>
        /// <returns>Cadena de caracteres con los datos del tanque</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
