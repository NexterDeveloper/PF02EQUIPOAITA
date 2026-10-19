using PF02EQUIPOAITA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestClass]
        public sealed class TestMethod1()
        {
            [TestMethod]
            [DataRow(-5, -1)] // n < 0 debe devolver -1
            [DataRow(0, 1)]   // factorial de 0 es 1
            [DataRow(1, 1)]   // factorial de 1 es 1
            [DataRow(5, 120)] // factorial de 5 es 120

            public void CalcularFactorial_VariosCasos(int n, long esperado)
            {
                long resultado = Funciones.CalcularFactorial(n);
                Assert.AreEqual(esperado, resultado);
            }
        }
    }
}
