using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_MagneticFlux_Tests
  {
    [TestMethod()]
    public void ConvertFromWeberToYottaWeber()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.YottaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to YottaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to YottaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to YottaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToZettaWeber()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZettaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to ZettaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to ZettaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to ZettaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToExaWeber()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.ExaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to ExaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to ExaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to ExaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToPetaWeber()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.PetaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to PetaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to PetaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to PetaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToTeraWeber()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.TeraWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to TeraWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to TeraWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to TeraWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToGigaWeber()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.GigaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to GigaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to GigaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to GigaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMegaWeber()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.MegaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to MegaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to MegaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to MegaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToKiloWeber()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.KiloWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to KiloWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to KiloWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to KiloWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToHectoWeber()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.HectoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to HectoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to HectoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to HectoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToDecaWeber()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.DecaWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to DecaWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to DecaWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to DecaWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToDeciWeber()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.DeciWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to DeciWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to DeciWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to DeciWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToCentiWeber()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.CentiWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to CentiWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to CentiWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to CentiWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMilliWeber()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.MilliWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to MilliWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to MilliWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to MilliWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToMicroWeber()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.MicroWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to MicroWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to MicroWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to MicroWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToNanoWeber()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.NanoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to NanoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to NanoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to NanoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToPicoWeber()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.PicoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to PicoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to PicoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to PicoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToFemtoWeber()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.FemtoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to FemtoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to FemtoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to FemtoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToAttoWeber()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.AttoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to AttoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to AttoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to AttoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToZeptoWeber()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZeptoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to ZeptoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to ZeptoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to ZeptoWeber [SI]");
    }

    [TestMethod()]
    public void ConvertFromWeberToYoctoWeber()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.YoctoWeber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to YoctoWeber [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to YoctoWeber [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to YoctoWeber [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromWeberToWeberOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Weber [SI] to Weber [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Weber [SI] to Weber [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Weber [SI] to Weber [RSI]");
    }

  }
}
