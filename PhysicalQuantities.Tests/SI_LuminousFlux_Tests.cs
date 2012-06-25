using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_LuminousFlux_Tests
  {
    [TestMethod()]
    public void ConvertFromLumenToYottaLumen()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.YottaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to YottaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to YottaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to YottaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToZettaLumen()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZettaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to ZettaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to ZettaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to ZettaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToExaLumen()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.ExaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to ExaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to ExaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to ExaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToPetaLumen()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.PetaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to PetaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to PetaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to PetaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToTeraLumen()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.TeraLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to TeraLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to TeraLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to TeraLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToGigaLumen()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.GigaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to GigaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to GigaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to GigaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToMegaLumen()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.MegaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to MegaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to MegaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to MegaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToKiloLumen()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.KiloLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to KiloLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to KiloLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to KiloLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToHectoLumen()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.HectoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to HectoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to HectoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to HectoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToDecaLumen()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.DecaLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to DecaLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to DecaLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to DecaLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToDeciLumen()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.DeciLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to DeciLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to DeciLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to DeciLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToCentiLumen()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.CentiLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to CentiLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to CentiLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to CentiLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToMilliLumen()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.MilliLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to MilliLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to MilliLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to MilliLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToMicroLumen()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.MicroLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to MicroLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to MicroLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to MicroLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToNanoLumen()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.NanoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to NanoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to NanoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to NanoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToPicoLumen()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.PicoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to PicoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to PicoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to PicoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToFemtoLumen()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.FemtoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to FemtoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to FemtoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to FemtoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToAttoLumen()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.AttoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to AttoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to AttoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to AttoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToZeptoLumen()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZeptoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to ZeptoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to ZeptoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to ZeptoLumen [SI]");
    }

    [TestMethod()]
    public void ConvertFromLumenToYoctoLumen()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.YoctoLumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to YoctoLumen [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to YoctoLumen [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to YoctoLumen [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLumenToLumenOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lumen [SI] to Lumen [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lumen [SI] to Lumen [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lumen [SI] to Lumen [RSI]");
    }

  }
}
