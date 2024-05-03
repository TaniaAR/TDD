using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROYECTO_MCD;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaximoComunDivisorTestMethod1()
        {
            int nro1 = 10;
            int nro2 = 4;
            int esperado = 2;
            int prueba = TDD_MCD.MaximoComunDivisor(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
