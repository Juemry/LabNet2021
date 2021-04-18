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
        public void DividirPorTest_()
        {
            //Arrange 
            int a = 8;
            int b = 2;
            int c = 4;
            int d = 0;
            string expected = $"El resultado de {a}, dividido en {b} es {c}";
            //Act
            string actual = ExtensionAndExceptionsMethods.Extensions.Extensions.DividirPor(a, b);
            //ExtensionAndExceptionsMethods.Exceptions.Logic.CorroborarMes();
            //Assert
            
            //Assert.Fail();
        }
    }
}