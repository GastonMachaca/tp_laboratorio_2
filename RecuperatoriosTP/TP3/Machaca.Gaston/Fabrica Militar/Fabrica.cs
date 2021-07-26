using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanques;
using Aviones;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excepciones;


namespace Fabrica_Militar
{
    public class Fabrica<T, A> where T : Tanque, ITanque where A : Avion, IAvion
    {
        private int capacidadFabrica;

        private int capacidadFabricaTanquesDisponible;
        private int capacidadFabricaAvionesDisponible;

        private int CantidadMaterialesRecibidasTiger;
        private int CantidadMaterialesRecibidasSherman;
        private int CantidadMaterialesRecibidasT34;

        private int CantidadMaterialesRecibidasBlackWindow;
        private int CantidadMaterialesRecibidasIlyushin;
        private int CantidadMaterialesRecibidasHenschel;

        private int cantidadMotoresSobrantes;
        private int cantidadCañonesSobrantes;
        private int cantidadAmetralladorasSobrantes;

        #region Propiedades Materiales Excluidos
        public int CantidadMotorSobrantes { get => cantidadMotoresSobrantes; set => cantidadMotoresSobrantes = value; }

        public int CantidadCañonSobrantes { get => cantidadCañonesSobrantes; set => cantidadCañonesSobrantes = value; }

        public int CantidadAmetralladoraSobrantes { get => cantidadAmetralladorasSobrantes; set => cantidadAmetralladorasSobrantes = value; }

        #endregion

        #region Propiedad Capacidad
        public int CapacidadFabricaTanques
        {
            get
            {
                return capacidadFabricaTanquesDisponible;
            }
            set
            {
                capacidadFabricaTanquesDisponible = value;
            }
        }

        public int CapacidadFabricaAviones
        {
            get
            {
                return capacidadFabricaAvionesDisponible;
            }
            set
            {
                capacidadFabricaAvionesDisponible = value;
            }
        }

        #endregion

        #region Propiedades Tanques Creados
        public int CantidadTigerCreados { get => CantidadMaterialesRecibidasTiger; set => CantidadMaterialesRecibidasTiger = value; }

        public int CantidadShermansCreados { get => CantidadMaterialesRecibidasSherman; set => CantidadMaterialesRecibidasSherman = value; }

        public int CantidadT34Creados { get => CantidadMaterialesRecibidasT34; set => CantidadMaterialesRecibidasT34 = value; }
        #endregion

        #region Propiedades Aeronaves Creados
        public int CantidadBlackWindowCreados { get => CantidadMaterialesRecibidasBlackWindow; set => CantidadMaterialesRecibidasBlackWindow = value; }

        public int CantidadIlyushinCreados { get => CantidadMaterialesRecibidasIlyushin; set => CantidadMaterialesRecibidasIlyushin = value; }

        public int CantidadHenschelCreados { get => CantidadMaterialesRecibidasHenschel; set => CantidadMaterialesRecibidasHenschel = value; }
        #endregion

        /// <summary>
        /// Constructor que recibe la capacidad de produccion de la fabrica.
        /// </summary>
        /// <param name="capacidadTotal"></param>
        public Fabrica(int capacidadTotal)
        {
            this.capacidadFabrica = capacidadTotal;
        }

        /// <summary>
        /// Metodo que se encarga de identificar el tipo de tanque a producir y iniciar su emsamblado.
        /// </summary>
        /// <param name="tipo">Tipo de tanque</param>
        /// <returns>Cadena de caracteres del tipo de tanque en produccion</returns>
        public string EmsambladoTanques(T tipo)
        {
            StringBuilder mensaje = new StringBuilder();

            switch (tipo.ObtenerDatosTanques)
            {
                case TipoTanque.Panzer_VI_Tiger:

                    mensaje.Append("Se inicio el ensamblado de TANQUE TIGER en base a los materiales disponibles...");

                    FabricacionTanques(tipo);

                    break;
                case TipoTanque.Sherman_M4:

                    mensaje.Append("Se inicio el ensamblado de TANQUE SHERMAN en base a los materiales disponibles...");

                    FabricacionTanques(tipo);

                    break;
                case TipoTanque.T_34:

                    mensaje.Append("Se inicio el ensamblado de TANQUE T-34 en base a los materiales disponibles...");

                    FabricacionTanques(tipo);

                    break;
            }
            
            return mensaje.ToString();
        }

        /// <summary>
        /// Metodo que se encarga de identificar el tipo de avion a producir y iniciar su emsamblado.
        /// </summary>
        /// <param name="tipo">Tipo de avion</param>
        /// <returns>Cadena de caracteres del tipo de avion en produccion</returns>
        public string EmsambladoAviones(A tipo)
        {
            StringBuilder mensaje = new StringBuilder();

            switch (tipo.ObtenerDatosAviones)
            {
                case Aeronaves.Northrop_P61_Black_Widow:
                    mensaje.Append("Se inicio el ensamblado de AERONAVE BLACK WIDOW en base a los materiales disponibles...");

                    FabricacionAviones(tipo);

                    break;

                case Aeronaves.Ilyushin_Il_10:
                    mensaje.Append("Se inicio el ensamblado de AERONAVE ILYUSHIN en base a los materiales disponibles...");

                    FabricacionAviones(tipo);

                    break;

                case Aeronaves.Henschel_Hs_129:
                    mensaje.Append("Se inicio el ensamblado de AERONAVE HENSCHEL en base a los materiales disponibles...");

                    FabricacionAviones(tipo);

                    break;
            }

            return mensaje.ToString();
        }

        /// <summary>
        /// Compara la cantidad de materiales.
        /// </summary>
        /// <param name="h1">Material 1</param>
        /// <param name="h2">Material 2</param>
        /// <param name="h3">Material 3</param>
        /// <returns>El numero de el material de mayor cantidad.</returns>
        private int ComparadorMateriales(int h1, int h2, int h3)
        {
            int retorno;

            retorno = h1 > h2 && h1 > h3 ? h1 : h2 > h1 && h2 > h3 ? h2 : h3;

            return retorno;
        }

        /// <summary>
        /// Se encarga de producir el tanque en base a la cantidad de materiales disponibles. 
        /// </summary>
        /// <param name="tipo">Tipo de tanque</param>
        private void FabricacionTanques(T tipo)
        {

            if (tipo.ObtenerDatosTanques == TipoTanque.Panzer_VI_Tiger)
            {
                int auxMotoresTigers = (tipo as Tanque).CantidadMotoresTigers;

                int auxCañonesTigers = (tipo as Tanque).CantidadCañonesTigers;

                int auxAmetralladorasTigers = (tipo as Tanque).CantidadAmetralladorasTigers;

                int cantidadMaximaTigers = ComparadorMateriales(auxMotoresTigers, auxCañonesTigers, auxAmetralladorasTigers);

                for (int i = 1; i <= cantidadMaximaTigers; i++)
                {
                    auxMotoresTigers = auxMotoresTigers - 1;
                    auxCañonesTigers = auxCañonesTigers - 1;
                    auxAmetralladorasTigers = auxAmetralladorasTigers - 1;

                    if (auxMotoresTigers == 0 || auxCañonesTigers == 0 || auxAmetralladorasTigers == 0)
                    {
                        CantidadTigerCreados += i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresTigers;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesTigers;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasTigers;

                        if (CapacidadFabricaTanques == 0)
                        {
                            CantidadTigerCreados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadTanques(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Tanques Tiger....");
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadTigerCreados;
                            }
                            else
                            {
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadTigerCreados;
                            }
                        }                    
                        break;
                    }
                }
            }

            if (tipo.ObtenerDatosTanques == TipoTanque.Sherman_M4)
            {
                int auxMotoresSherman = (tipo as Tanque).CantidadMotoresShermans;

                int auxCañonesSherman = (tipo as Tanque).CantidadCañonesShermans;

                int auxAmetralladorasSherman = (tipo as Tanque).CantidadAmetralladorasShermans;

                int cantidadMaximaShermans = ComparadorMateriales(auxMotoresSherman, auxCañonesSherman, auxAmetralladorasSherman);

                for (int i = 1; i <= cantidadMaximaShermans; i++)
                {
                    auxMotoresSherman = auxMotoresSherman - 1;
                    auxCañonesSherman = auxCañonesSherman - 1;
                    auxAmetralladorasSherman = auxAmetralladorasSherman - 1;

                    if (auxMotoresSherman == 0 || auxCañonesSherman == 0 || auxAmetralladorasSherman == 0)
                    {
                        CantidadShermansCreados = i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresSherman;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesSherman;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasSherman;

                        if (CapacidadFabricaTanques == 0)
                        {
                            CantidadShermansCreados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadTanques(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Tanques Sherman....");
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadShermansCreados;
                            }
                            else
                            {
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadShermansCreados;
                            }
                        }

                        break;
                    }
                }
            }

            if (tipo.ObtenerDatosTanques == TipoTanque.T_34)
            {
                int auxMotoresT34 = (tipo as Tanque).CantidadMotores_T34;

                int auxCañonesT34 = (tipo as Tanque).CantidadCañones_T34;

                int auxAmetralladorasT34 = (tipo as Tanque).CantidadAmetralladoras_T34;

                int cantidadMaximaT34 = ComparadorMateriales(auxMotoresT34, auxCañonesT34, auxAmetralladorasT34);

                for (int i = 1; i <= cantidadMaximaT34; i++)
                {
                    auxMotoresT34 = auxMotoresT34 - 1;
                    auxCañonesT34 = auxCañonesT34 - 1;
                    auxAmetralladorasT34 = auxAmetralladorasT34 - 1;

                    if (auxMotoresT34 == 0 || auxCañonesT34 == 0 || auxAmetralladorasT34 == 0)
                    {
                        CantidadT34Creados = i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresT34;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesT34;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasT34;

                        if (CapacidadFabricaTanques == 0)
                        {
                            CantidadT34Creados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadTanques(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Tanques T-34....");
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadT34Creados;
                            }
                            else
                            {
                                CapacidadFabricaTanques = CapacidadFabricaTanques - CantidadT34Creados;
                            }
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Se encarga de producir el avion en base a la cantidad de materiales disponibles. 
        /// </summary>
        /// <param name="tipo">Tipo de avion</param>
        private void FabricacionAviones(A tipo)
        {
            if (tipo.ObtenerDatosAviones == Aeronaves.Northrop_P61_Black_Widow)
            {
                int auxMotoresBlackWidow = (tipo as Avion).CantidadMotoresBlackWindows;

                int auxCañonesBlackWidow = (tipo as Avion).CantidadCañonesBlackWindows;

                int auxAmetralladorasBlackWidow = (tipo as Avion).CantidadAmetralladorasBlackWindows;

                int cantidadMaximaBlackWidow = ComparadorMateriales(auxMotoresBlackWidow, auxCañonesBlackWidow, auxAmetralladorasBlackWidow);

                for (int i = 1; i <= cantidadMaximaBlackWidow; i++)
                {
                    auxMotoresBlackWidow = auxMotoresBlackWidow - 1;
                    auxCañonesBlackWidow = auxCañonesBlackWidow - 1;
                    auxAmetralladorasBlackWidow = auxAmetralladorasBlackWidow - 1;

                    if (auxMotoresBlackWidow == 0 || auxCañonesBlackWidow == 0 || auxAmetralladorasBlackWidow == 0)
                    {
                        CantidadBlackWindowCreados = i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresBlackWidow;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesBlackWidow;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasBlackWidow;

                        if (CapacidadFabricaAviones == 0)
                        {
                            CantidadBlackWindowCreados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadAviones(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Aeronaves Black Widow....");
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadBlackWindowCreados;
                            }
                            else
                            {
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadBlackWindowCreados;
                            }
                        }

                        break;
                    }
                }
            }

            if (tipo.ObtenerDatosAviones == Aeronaves.Ilyushin_Il_10)
            {
                int auxMotoresIlyushin = (tipo as Avion).CantidadMotoresIlyushins;

                int auxCañonesIlyushin = (tipo as Avion).CantidadCañonesIlyushins;

                int auxAmetralladorasIlyushin = (tipo as Avion).CantidadAmetralladorasIlyushins;

                int cantidadMaximaIlyushin = ComparadorMateriales(auxMotoresIlyushin, auxCañonesIlyushin, auxAmetralladorasIlyushin);

                for (int i = 1; i <= cantidadMaximaIlyushin; i++)
                {
                    auxMotoresIlyushin = auxMotoresIlyushin - 1;
                    auxCañonesIlyushin = auxCañonesIlyushin - 1;
                    auxAmetralladorasIlyushin = auxAmetralladorasIlyushin - 1;

                    if (auxMotoresIlyushin == 0 || auxCañonesIlyushin == 0 || auxAmetralladorasIlyushin == 0)
                    {
                        CantidadIlyushinCreados = i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresIlyushin;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesIlyushin;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasIlyushin;

                        if (CapacidadFabricaAviones == 0)
                        {
                            CantidadBlackWindowCreados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadAviones(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Aeronaves Ilyushin....");
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadIlyushinCreados;
                            }
                            else
                            {
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadIlyushinCreados;
                            }
                        }

                        break;
                    }
                }
            }

            if (tipo.ObtenerDatosAviones == Aeronaves.Henschel_Hs_129)
            {
                int auxMotoresHenschel = (tipo as Avion).CantidadMotoresHenschels;

                int auxCañonesHenschel = (tipo as Avion).CantidadCañonesHenschels;

                int auxAmetralladorasHenschel = (tipo as Avion).CantidadAmetralladorasHenschels;

                int cantidadMaximaIlyushin = ComparadorMateriales(auxMotoresHenschel, auxCañonesHenschel, auxAmetralladorasHenschel);

                for (int i = 1; i <= cantidadMaximaIlyushin; i++)
                {
                    auxMotoresHenschel = auxMotoresHenschel - 1;
                    auxCañonesHenschel = auxCañonesHenschel - 1;
                    auxAmetralladorasHenschel = auxAmetralladorasHenschel - 1;

                    if (auxMotoresHenschel == 0 || auxCañonesHenschel == 0 || auxAmetralladorasHenschel == 0)
                    {
                        CantidadHenschelCreados = i;

                        CantidadMotorSobrantes = CantidadMotorSobrantes + auxMotoresHenschel;

                        CantidadCañonSobrantes = CantidadCañonSobrantes + auxCañonesHenschel;

                        CantidadAmetralladoraSobrantes = CantidadAmetralladoraSobrantes + auxAmetralladorasHenschel;

                        if (CapacidadFabricaAviones == 0)
                        {
                            CantidadBlackWindowCreados = 0;
                            break;
                        }
                        else
                        {
                            if (VerificarCapacidadAviones(tipo))
                            {
                                Console.WriteLine("El personal de la fabrica no puede producir mas de " + this.capacidadFabrica + " Aeronaves Henschel....");
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadHenschelCreados;
                            }
                            else
                            {
                                CapacidadFabricaAviones = CapacidadFabricaAviones - CantidadHenschelCreados;
                            }
                        }

                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Administra la capacidad de la fabrica para que sean 100 a 200 empleados.
        /// </summary>
        public void AdministrarCapacidad()
        {
            if(this.capacidadFabrica >= 100 && this.capacidadFabrica <= 200)
            {
                CapacidadFabricaTanques = this.capacidadFabrica / 2;
                CapacidadFabricaAviones = this.capacidadFabrica / 2;
            }
            else
            {
                Random random = new Random();
                capacidadFabrica = random.Next(100, 200);
                throw new ExcepcionCapacidad();
            }
        }

        /// <summary>
        /// Verifica la capacidad de la seccion tanques de la fabrica.
        /// </summary>
        /// <param name="tipo">Tipo de tanque</param>
        /// <returns>True si todavia cuenta con espacio para la produccion de tanques.Caso contrario,false.</returns>
        public bool VerificarCapacidadTanques(T tipo)
        {
            bool retorno = false;

            switch (tipo.ObtenerDatosTanques)
            {
                case TipoTanque.Panzer_VI_Tiger:
                    if (CapacidadFabricaTanques <= CantidadTigerCreados)
                    {
                        CantidadTigerCreados = CapacidadFabricaTanques;
                        retorno = true;
                    }
                    break;
                case TipoTanque.Sherman_M4:
                    if (CapacidadFabricaTanques <= CantidadShermansCreados)
                    {
                        CantidadShermansCreados = CapacidadFabricaTanques;
                        retorno = true;
                    }
                    break;
                case TipoTanque.T_34:
                    if (CapacidadFabricaTanques <= CantidadT34Creados)
                    {
                        CantidadT34Creados = CapacidadFabricaTanques;
                        retorno = true;
                    }
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Verifica la capacidad de la seccion tanques de la fabrica.
        /// </summary>
        /// <param name="tipo">Tipo de avion</param>
        /// <returns>True si todavia cuenta con espacio para la produccion de aviones.Caso contrario,false.</returns>
        public bool VerificarCapacidadAviones(A tipo)
        {
            bool retorno = false;

            switch (tipo.ObtenerDatosAviones)
            {
                case Aeronaves.Northrop_P61_Black_Widow:
                    if (CapacidadFabricaAviones <= CantidadBlackWindowCreados)
                    {
                        CantidadBlackWindowCreados = CapacidadFabricaAviones;
                        retorno = true;
                    }
                    break;
                case Aeronaves.Henschel_Hs_129:
                    if (CapacidadFabricaAviones <= CantidadHenschelCreados)
                    {
                        CantidadHenschelCreados = CapacidadFabricaAviones;
                        retorno = true;
                    }
                    break;
                case Aeronaves.Ilyushin_Il_10:
                    if (CapacidadFabricaAviones <= CantidadIlyushinCreados)
                    {
                        CantidadIlyushinCreados = CapacidadFabricaAviones;
                        retorno = true;
                    }
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida si el ingreso de materiales para tanques esta listo para iniciar la produccion.
        /// </summary>
        /// <param name="tipo">Tipo de tanque</param>
        public void ValidarIngresoTanques(T tipo)
        {
            Random random = new Random();

            switch (tipo.ObtenerDatosTanques)
            {
                case TipoTanque.Panzer_VI_Tiger:

                    if (tipo.CantidadMotoresTigers <= 0)
                    {
                        tipo.CantidadMotoresTigers = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadCañonesTigers <= 0)
                    {
                        tipo.CantidadCañonesTigers = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadAmetralladorasTigers <= 0)
                    {
                        tipo.CantidadAmetralladorasTigers = random.Next(1, CapacidadFabricaTanques);
                    }
                    break;

                case TipoTanque.Sherman_M4:

                    if (tipo.CantidadMotoresShermans <= 0)
                    {
                        tipo.CantidadMotoresShermans = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadCañonesShermans <= 0)
                    {
                        tipo.CantidadCañonesShermans = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadAmetralladorasShermans <= 0)
                    {
                        tipo.CantidadAmetralladorasShermans = random.Next(1, CapacidadFabricaTanques);
                    }
                    break;

                case TipoTanque.T_34:

                    if (tipo.CantidadMotores_T34 <= 0)
                    {
                        tipo.CantidadMotores_T34 = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadCañones_T34 <= 0)
                    {
                        tipo.CantidadCañones_T34 = random.Next(1, CapacidadFabricaTanques);
                    }

                    if (tipo.CantidadAmetralladoras_T34 <= 0)
                    {
                        tipo.CantidadAmetralladoras_T34 = random.Next(1, CapacidadFabricaTanques);
                    }

                    break;
            }
        }

        /// <summary>
        /// Valida si el ingreso de materiales para aviones esta listo para iniciar la produccion.
        /// </summary>
        /// <param name="tipo">Tipo de avion</param>
        public void ValidarIngresoAviones(A tipo)
        {
            Random random = new Random();
            
            switch (tipo.ObtenerDatosAviones)
            {
                case Aeronaves.Northrop_P61_Black_Widow:

                    if (tipo.CantidadMotoresBlackWindows <= 0)
                    {
                        tipo.CantidadMotoresBlackWindows = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadCañonesBlackWindows <= 0)
                    {
                        tipo.CantidadCañonesBlackWindows = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadAmetralladorasBlackWindows <= 0)
                    {
                        tipo.CantidadAmetralladorasBlackWindows = random.Next(1, CapacidadFabricaAviones);
                    }
                    break;
                case Aeronaves.Ilyushin_Il_10:

                    if (tipo.CantidadMotoresIlyushins <= 0)
                    {
                        tipo.CantidadMotoresIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadCañonesIlyushins <= 0)
                    {
                        tipo.CantidadCañonesIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadAmetralladorasIlyushins <= 0)
                    {
                        tipo.CantidadAmetralladorasIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }
                    break;

                case Aeronaves.Henschel_Hs_129:

                    if (tipo.CantidadMotoresHenschels <= 0)
                    {
                        tipo.CantidadMotoresIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadCañonesHenschels <= 0)
                    {
                        tipo.CantidadCañonesIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }

                    if (tipo.CantidadAmetralladorasHenschels <= 0)
                    {
                        tipo.CantidadAmetralladorasIlyushins = random.Next(1, CapacidadFabricaAviones);
                    }
                    break;
            }

        }

        /// <summary>
        /// Metodo que se encarga de mostrar los datos de fabricacion.
        /// </summary>
        /// <returns>Cadena de caracteres de informe de produccion</returns>
        public string Mostrar()
        {
            StringBuilder lista = new StringBuilder();

            lista.AppendFormat("\nCapacidad maxima de la fabrica: {0}\n", this.capacidadFabrica);

            lista.AppendFormat("Capacidad del area de creacion de Tanques actualmente sin usar: {0} \n", this.CapacidadFabricaTanques);

            lista.AppendFormat("Capacidad del area de creacion de Aeronaves actualmente sin usar: {0} \n", this.CapacidadFabricaAviones);

            if(this.CantidadTigerCreados != 0)
            {
                lista.AppendLine("Cantidad de Tanques Tigers creados: " + this.CantidadTigerCreados);
            }

            if (this.CantidadShermansCreados != 0)
            {
                lista.AppendLine("Cantidad de Tanques Shermans creados: " + this.CantidadShermansCreados);
            }

            if (this.CantidadT34Creados != 0)
            {
                lista.AppendLine("Cantidad de Tanques T-34 creados: " + this.CantidadT34Creados);
            }

            if (this.CantidadBlackWindowCreados != 0)
            {
                lista.AppendLine("Cantidad de Aeronaves Black Widow creadas:" + this.CantidadBlackWindowCreados);
            }

            if (this.CantidadIlyushinCreados != 0)
            {
                lista.AppendLine("Cantidad de Aeronaves Ilyushin creadas:" + this.CantidadIlyushinCreados);
            }

            if(this.CantidadHenschelCreados != 0)
            {
                lista.AppendLine("Cantidad de Aeronaves Henschel creadas:" + this.CantidadHenschelCreados);
            }

            return lista.ToString();
        }

        /// <summary>
        /// Metodo override de ToString()
        /// </summary>
        /// <returns>Cadena de caracteres con los datos de produccion de la fabrica</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
