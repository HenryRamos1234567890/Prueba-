using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSNR.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSNR.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestMethod]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly()
        {
            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldConvertCorrectly()
        {
            double result = converter.FahrenheitToCelsius(32);
            Assert.AreEqual(0, result);
        }
    }
}