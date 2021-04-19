using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionAndExceptionsMethods.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Exceptions.Tests
{
    [TestClass()]
    public class LogicTests
    {
        //Primera vez trabajando con Testing, no se como estara
        [TestMethod()]
        public void CorroborarMesTest_GetMonthRight()
        {
            //Arrange 
            int a = 2;
            string expected = $"El numero {a} corresponde a Febrero";
            //Act
            string actual = Logic.CorroborarMes(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CorroborarMesTest_GetMonthWrong()
        {
            //Arrange 
            int a = 4;
            string expected = $"El numero {a} corresponde a Marzo";
            //Act
            string actual = Logic.CorroborarMes(a);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CorroborarMesTest_GetException()
        {
            //Arrange 
            int a = 13;
            
            //Act
            string actual = Logic.CorroborarMes(a);
            //Assert
            
        }

        [TestMethod()]
        public void CorroborarMesCustomTest_GetMonthRight()
        {
            //Arrange 
            int a = 2;
            string expected = $"El numero {a} corresponde a Febrero";
            //Act
            string actual = Logic.CorroborarMesCustom(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CorroborarMesCustomTest_GetMonthWrong()
        {
            //Arrange 
            int a = 4;
            string expected = $"El numero {a} corresponde a Marzo";
            //Act
            string actual = Logic.CorroborarMesCustom(a);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ExtensionAndExceptionsMethods.Exceptions.CustomException))]
        public void CorroborarMesCustomTest_GetException()
        {
            //Arrange 
            int a = 13;

            //Act
            string actual = Logic.CorroborarMesCustom(a);
            //Assert

        }
    }
}