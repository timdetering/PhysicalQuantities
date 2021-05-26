using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Force_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonToKiloNewton()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.KiloNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to KiloNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to KiloNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to KiloNewton [RSI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToHectoNewton()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.HectoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to HectoNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to HectoNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to HectoNewton [RSI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToDecaNewton()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.DecaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to DecaNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to DecaNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to DecaNewton [RSI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToDeciNewton()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.DeciNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to DeciNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to DeciNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to DeciNewton [RSI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToCentiNewton()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.CentiNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to CentiNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to CentiNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to CentiNewton [RSI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToMilliNewton()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.MilliNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [RSI] to MilliNewton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [RSI] to MilliNewton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [RSI] to MilliNewton [RSI]");
    }

  }
}
