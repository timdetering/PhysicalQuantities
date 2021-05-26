using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Momentum_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloNewtonPerSecondToNewtonSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Momentum.KiloNewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Momentum.NewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloNewtonPerSecond [RSI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloNewtonPerSecond [RSI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloNewtonPerSecond [RSI] to NewtonSecond [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliNewtonPerSecondToNewtonSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Momentum.MilliNewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Momentum.NewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliNewtonPerSecond [RSI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliNewtonPerSecond [RSI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliNewtonPerSecond [RSI] to NewtonSecond [RSI]");
    }

  }
}
