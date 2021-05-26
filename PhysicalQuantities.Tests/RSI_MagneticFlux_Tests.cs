using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_MagneticFlux_Tests
  {
    [TestMethod()]
    public void ConvertFromWeberToGigaWeber()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.GigaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to GigaWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to GigaWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to GigaWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMegaWeber()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MegaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to MegaWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to MegaWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to MegaWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToKiloWeber()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.KiloWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to KiloWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to KiloWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to KiloWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToHectoWeber()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.HectoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to HectoWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to HectoWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to HectoWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToDecaWeber()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DecaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to DecaWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to DecaWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to DecaWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToDeciWeber()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DeciWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to DeciWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to DeciWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to DeciWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToCentiWeber()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.CentiWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to CentiWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to CentiWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to CentiWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMilliWeber()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MilliWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to MilliWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to MilliWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to MilliWeber [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMicroWeber()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MicroWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [RSI] to MicroWeber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [RSI] to MicroWeber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [RSI] to MicroWeber [RSI]");
    }

  }
}
