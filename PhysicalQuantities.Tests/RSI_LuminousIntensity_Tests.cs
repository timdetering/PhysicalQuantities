using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_LuminousIntensity_Tests
  {
    [TestMethod()]
    public void ConvertFromCandelaToKiloCandela()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.KiloCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to KiloCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to KiloCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to KiloCandela [RSI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToHectoCandela()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.HectoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to HectoCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to HectoCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to HectoCandela [RSI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToDecaCandela()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DecaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to DecaCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to DecaCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to DecaCandela [RSI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToDeciCandela()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DeciCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to DeciCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to DeciCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to DeciCandela [RSI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToCentiCandela()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.CentiCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to CentiCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to CentiCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to CentiCandela [RSI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToMilliCandela()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.MilliCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [RSI] to MilliCandela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [RSI] to MilliCandela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [RSI] to MilliCandela [RSI]");
    }

  }
}
