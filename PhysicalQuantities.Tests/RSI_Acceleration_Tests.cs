using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Acceleration_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToKiloMetrePerSecondSquared()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.KiloMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to KiloMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to KiloMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to KiloMetrePerSecondSquared [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToHectoMetrePerSecondSquared()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.HectoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to HectoMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to HectoMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to HectoMetrePerSecondSquared [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToDecaMetrePerSecondSquared()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.DecaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to DecaMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to DecaMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to DecaMetrePerSecondSquared [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToDeciMetrePerSecondSquared()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.DeciMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to DeciMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to DeciMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to DeciMetrePerSecondSquared [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToCentiMetrePerSecondSquared()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.CentiMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to CentiMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to CentiMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to CentiMetrePerSecondSquared [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToMilliMetrePerSecondSquared()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MilliMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [RSI] to MilliMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [RSI] to MilliMetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [RSI] to MilliMetrePerSecondSquared [RSI]");
    }

  }
}
