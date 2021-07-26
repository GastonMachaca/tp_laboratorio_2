using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fabrica_Militar;
using Tanques;
using Aviones;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTestTanques
    {
        /// <summary>
        /// Prueba de Instancia de un Tanque
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaITanque()
        {
            Tanque T1 = new Tanque(TipoCañon.KwK_43, 10, TipoMotor.Maybach_HL_230_P30, 10, TipoAmetralladoras.MG_34, 10); // Tiger
            Assert.IsInstanceOfType(T1, typeof(ITanque));
        }

        /// <summary>
        /// Prueba de Instancia de un Tanque erronea.
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaIAvion()
        {
            Tanque T1 = new Tanque(TipoCañon.KwK_43, 10, TipoMotor.Maybach_HL_230_P30, 10, TipoAmetralladoras.MG_34, 10); // Tiger
            Assert.IsNotInstanceOfType(T1, typeof(IAvion));
        }

        /// <summary>
        /// Prueba de Emsamblado de Tanque no null.
        /// </summary>
        [TestMethod]
        public void ProbarEmsambladoIsNotNull()
        {
            Tanque T1 = new Tanque(TipoCañon.KwK_43, 10, TipoMotor.Maybach_HL_230_P30, 10, TipoAmetralladoras.MG_34, 10); // Tiger
            Fabrica<Tanque, Avion> fabrica = new Fabrica<Tanque, Avion>(100);

            Assert.IsNotNull(fabrica.EmsambladoTanques(T1));
        }

        /// <summary>
        /// Prueba de Emsamblado de Tanque null.
        /// </summary>
        [TestMethod]
        public void ProbarEmsambladoIsNull()
        {
            Tanque T1 = new Tanque();
            Fabrica<Tanque, Avion> fabrica = new Fabrica<Tanque, Avion>(100);

            Assert.IsNotNull(fabrica.EmsambladoTanques(T1));
        }
    }
}
