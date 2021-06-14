﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanques;
using Aviones;
using Fabrica_Militar;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            Tanque T1 = new Tanque(TipoCañon.KwK_43,5, TipoMotor.Maybach_HL_230_P30,10, TipoAmetralladoras.MG_34,5); // Tiger

            Tanque T2 = new Tanque(TipoCañon.M1_76_mm,2, TipoMotor.R975_C4,2, TipoAmetralladoras.Browning_M1919A4,3); // Sherman

            Tanque T3 = new Tanque(TipoCañon.F34_de_76_2_mm,3, TipoMotor.Diesel_V2_34,3, TipoAmetralladoras.DT,6); // T-34

            Avion A1 = new Avion(Cañones.Hispano_M2,2,MotorRadial.Pratt_and_Whitney_R,5,Ametralladoras.Browning_M2,10);

            Avion A2 = new Avion(Cañones.MG_151_20,10, MotorRadial.Gnome_Rhône_14M_5, 11, Ametralladoras.MG_17, 9);

            Avion A3 = new Avion(Cañones.Nudelman_Suranov_NS_23, 1, MotorRadial.Daimler_Benz_DB_603,3, Ametralladoras.Berezin_UB,5);

            Fabrica<Tanque,Avion> fabricarTanquesyAviones = new Fabrica<Tanque,Avion>(100);

            DepositoFabrica<Tanque, Avion> depositofabrica = new DepositoFabrica<Tanque, Avion>();

            T1.IdentificarTanque();
            T2.IdentificarTanque();
            T3.IdentificarTanque();

            A1.IdentificarAvion();
            A2.IdentificarAvion();
            A3.IdentificarAvion();

            fabricarTanquesyAviones.AdministrarCapacidad();

            fabricarTanquesyAviones.ValidarIngresoTanques(T1);
            fabricarTanquesyAviones.ValidarIngresoTanques(T2);
            fabricarTanquesyAviones.ValidarIngresoTanques(T3);

            fabricarTanquesyAviones.ValidarIngresoAviones(A1);
            fabricarTanquesyAviones.ValidarIngresoAviones(A2);
            fabricarTanquesyAviones.ValidarIngresoAviones(A3);

            Console.WriteLine(fabricarTanquesyAviones.EmsambladoTanques(T1));
            Console.WriteLine(fabricarTanquesyAviones.EmsambladoTanques(T2));
            Console.WriteLine(fabricarTanquesyAviones.EmsambladoTanques(T3));

            Console.WriteLine(fabricarTanquesyAviones.EmsambladoAviones(A1));
            Console.WriteLine(fabricarTanquesyAviones.EmsambladoAviones(A2));
            Console.WriteLine(fabricarTanquesyAviones.EmsambladoAviones(A3));

            Console.WriteLine(fabricarTanquesyAviones.Mostrar());

            Console.ReadKey();
        }
    }
}
