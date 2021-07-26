using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fabrica_Militar;
using Tanques;
using Aviones;
namespace TestUnitarios
{
    [TestClass]
    public class UniTestAviones
    {
        /// <summary>
        /// Prueba de Instancia de un Avion
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaIAvion()
        {
            Avion A1 = new Avion(Cañones.Hispano_M2, 2, MotorRadial.Pratt_and_Whitney_R, 5, Ametralladoras.Browning_M2, 10);
            Assert.IsInstanceOfType(A1, typeof(IAvion));
        }

        /// <summary>
        /// Prueba de Instancia de un Avion erronea.
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaITanque()
        {
            Avion A1 = new Avion(Cañones.Hispano_M2, 2, MotorRadial.Pratt_and_Whitney_R, 5, Ametralladoras.Browning_M2, 10);
            Assert.IsNotInstanceOfType(A1, typeof(ITanque));
        }

        /// <summary>
        /// Prueba de Emsamblado de Avion no null.
        /// </summary>
        [TestMethod]
        public void ProbarEmsambladoIsNotNull()
        {
            Avion A1 = new Avion(Cañones.Hispano_M2, 2, MotorRadial.Pratt_and_Whitney_R, 5, Ametralladoras.Browning_M2, 10);
            Fabrica<Tanque, Avion> fabrica = new Fabrica<Tanque, Avion>(100);

            Assert.IsNotNull(fabrica.EmsambladoAviones(A1));
        }

        /// <summary>
        /// Prueba de Emsamblado de Avion null.
        /// </summary>
        [TestMethod]
        public void ProbarEmsambladoIsNull()
        {
            Avion A1 = new Avion();
            Fabrica<Tanque, Avion> fabrica = new Fabrica<Tanque, Avion>(100);

            Assert.IsNotNull(fabrica.EmsambladoAviones(A1));
        }
    }
}
