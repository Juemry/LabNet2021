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
        public void DividirPorTest_DivideBy0()
        {
            //Arrange 
            int a = 8;
            int b = 0;
            int? c = null;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
        
            //Act
            string actual = Extensions.DividirPor(a, b);

            //Assert
            Assert.AreNotEqual(expected,actual);
            //Assert.Fail();
        }


    }
}