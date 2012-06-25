using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Temperature_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCelsiusToKelvin()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Temperature.Celsius;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Temperature.Kelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(-263.15);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Celsius [RSI] to Kelvin [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Celsius [RSI] to Kelvin [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Celsius [RSI] to Kelvin [RSI]");
    }

  }
}
