using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_MagneticField_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliTeslaToTesla()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticField.MilliTesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticField.Tesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliTesla [RSI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliTesla [RSI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliTesla [RSI] to Tesla [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicroTeslaToTesla()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticField.MicroTesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticField.Tesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MicroTesla [RSI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MicroTesla [RSI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MicroTesla [RSI] to Tesla [RSI]");
    }

  }
}
