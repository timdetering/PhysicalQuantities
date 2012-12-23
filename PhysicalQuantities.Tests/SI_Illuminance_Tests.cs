using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Illuminance_Tests
  {
    [TestMethod()]
    public void ConvertFromLuxToYottaLux()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.YottaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to YottaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to YottaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to YottaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToZettaLux()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.ZettaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to ZettaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to ZettaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to ZettaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToExaLux()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.ExaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to ExaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to ExaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to ExaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToPetaLux()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.PetaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to PetaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to PetaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to PetaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToTeraLux()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.TeraLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to TeraLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to TeraLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to TeraLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToGigaLux()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.GigaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to GigaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to GigaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to GigaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToMegaLux()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.MegaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to MegaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to MegaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to MegaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToKiloLux()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.KiloLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to KiloLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to KiloLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to KiloLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToHectoLux()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.HectoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to HectoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to HectoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to HectoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToDecaLux()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.DecaLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to DecaLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to DecaLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to DecaLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToDeciLux()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.DeciLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to DeciLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to DeciLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to DeciLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToCentiLux()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.CentiLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to CentiLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to CentiLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to CentiLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToMilliLux()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.MilliLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to MilliLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to MilliLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to MilliLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToMicroLux()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.MicroLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to MicroLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to MicroLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to MicroLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToNanoLux()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.NanoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to NanoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to NanoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to NanoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToPicoLux()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.PicoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to PicoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to PicoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to PicoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToFemtoLux()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.FemtoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to FemtoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to FemtoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to FemtoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToAttoLux()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.AttoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to AttoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to AttoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to AttoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToZeptoLux()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.ZeptoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to ZeptoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to ZeptoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to ZeptoLux [SI]");
    }

    [TestMethod()]
    public void ConvertFromLuxToYoctoLux()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.YoctoLux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to YoctoLux [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to YoctoLux [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to YoctoLux [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLuxToLuxOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Illuminance.Lux;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Lux [SI] to Lux [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Lux [SI] to Lux [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Lux [SI] to Lux [RSI]");
    }

  }
}
