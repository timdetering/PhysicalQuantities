using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_VolumetricFlow_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicKiloMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicKiloMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicKiloMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicKiloMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicKiloMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicHectoMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicHectoMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicHectoMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicHectoMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicHectoMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicDecaMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDecaMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicDecaMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicDecaMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicDecaMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicDeciMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDeciMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicDeciMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicDeciMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicDeciMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicCentiMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicCentiMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicCentiMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicCentiMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicCentiMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMilliMetrePerSecondToCubicMetrePerSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMilliMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMilliMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMilliMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMilliMetrePerSecond [RSI] to CubicMetrePerSecond [RSI]");
    }

  }
}
