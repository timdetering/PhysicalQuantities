using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Speed_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerSecondToKiloMetrePerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.KiloMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to KiloMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to KiloMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to KiloMetrePerSecond [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToHectoMetrePerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.HectoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to HectoMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to HectoMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to HectoMetrePerSecond [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToDecaMetrePerSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.DecaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to DecaMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to DecaMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to DecaMetrePerSecond [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToDeciMetrePerSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.DeciMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to DeciMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to DeciMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to DeciMetrePerSecond [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToCentiMetrePerSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.CentiMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to CentiMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to CentiMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to CentiMetrePerSecond [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToMilliMetrePerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MilliMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [RSI] to MilliMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [RSI] to MilliMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [RSI] to MilliMetrePerSecond [RSI]");
    }

  }
}
