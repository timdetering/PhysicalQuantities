using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_LuminousFlux_Tests
  {
    [TestMethod()]
    public void ConvertFromLumenToKiloLumen()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.KiloLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to KiloLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to KiloLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to KiloLumen [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToHectoLumen()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.HectoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to HectoLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to HectoLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to HectoLumen [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToDecaLumen()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DecaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to DecaLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to DecaLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to DecaLumen [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToDeciLumen()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DeciLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to DeciLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to DeciLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to DeciLumen [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToCentiLumen()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.CentiLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to CentiLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to CentiLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to CentiLumen [RSI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToMilliLumen()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.MilliLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [RSI] to MilliLumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [RSI] to MilliLumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [RSI] to MilliLumen [RSI]");
    }

  }
}
