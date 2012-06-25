using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Illuminance_Tests
  {
    [TestMethod()]
    public void ConvertFromLuxToKiloLux()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.KiloLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to KiloLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to KiloLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to KiloLux [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToHectoLux()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.HectoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to HectoLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to HectoLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to HectoLux [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToDecaLux()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.DecaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to DecaLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to DecaLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to DecaLux [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToDeciLux()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.DeciLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to DeciLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to DeciLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to DeciLux [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToCentiLux()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.CentiLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to CentiLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to CentiLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to CentiLux [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToMilliLux()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.MilliLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [RSI] to MilliLux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [RSI] to MilliLux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [RSI] to MilliLux [RSI]");
    }

  }
}
