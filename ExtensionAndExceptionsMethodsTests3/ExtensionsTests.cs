using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionAndExceptionsMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Extensions.Tests
{
    [TestClass()]
    public class ExtensionsTests
    {
        [TestMethod()]
        public void DividirPorTest_GetSameResult()
        {
            //Arrange 
            int a = 8;
            int b = 2;
            int c = 4;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
            //Act
            string actual = Extensions.DividirPor(a, b);
            
            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DividirPorTest_GetWrongResult()
        {
            //Arrange 
            int a = 8;
            int b = 2;
            int c = 0;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
            //Act
            string actual = Extensions.DividirPor(a, b);

            //Assert
            Assert.AreNotEqual(expected, actual);
            //Assert.Fail();
        }

        

       [TestMethod()]
        public void DividirALoNorrisTest_GetSameResult()
        {
            //Arrange 
            int a = 8;
            int b = 2;
            int c = 4;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
            //Act
            string actual = Extensions.DividirALoNorris(a, b);
            
            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DividirALoNorrisTest_GetWrongResult()
        {
            //Arrange 
            int a = 8;
            int b = 2;
            int c = 0;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
            //Act
            string actual = Extensions.DividirALoNorris(a, b);

            //Assert
            Assert.AreNotEqual(expected, actual);
            //Assert.Fail();
        }

        /*Pense en implementar una especie de Test para los casos de division por cero
        Efectivamente ocurre la excepcion pero la capturo en la ejecucion del programa para que
        continuar se ejecucion (evitar que crashee). Esto me trajo la duda ¿Esta mal pensado el test
        por que es un escenario que no va a ocurrir o hay otra forma de manejarlo para que ocurra? 
        Creo que esta mal pensado el test, pero no estoy seguro. Ya que no tendria sentido no manejar esa posibilidad
        en el programa 
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorTest_DivideBy0()
        {
            Arrange
            int a = 8;
            int b = 0;

            Act
            string actual = Extensions.DividirPor(a, b);

            Assert

        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirALoNorris_DivideBy0()
        {
            //Arrange 
            int a = 8;
            int b = 0;

            //Act
            string actual = Extensions.DividirALoNorris(a, b);

            //Assert
        */
    }


}