using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTestMsTest.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Calcular_Somar_1Mais2_Resultado3()
        {
            //Arrange
            Calculadora.Calcular calcular = new Calculadora.Calcular();
            decimal resultadoEsperado = 3;

            //Act
            decimal resultado = calcular.Somar(1, 2);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
