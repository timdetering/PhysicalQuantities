using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Frequency_Tests
  {
    [TestMethod()]
    public void ConvertFromHertzToYottaHertz()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.YottaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to YottaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to YottaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to YottaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToZettaHertz()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.ZettaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to ZettaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to ZettaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to ZettaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToExaHertz()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.ExaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to ExaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to ExaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to ExaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToPetaHertz()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.PetaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to PetaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to PetaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to PetaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToTeraHertz()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.TeraHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to TeraHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to TeraHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to TeraHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToGigaHertz()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.GigaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to GigaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to GigaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to GigaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMegaHertz()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.MegaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to MegaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to MegaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to MegaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToKiloHertz()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.KiloHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to KiloHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to KiloHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to KiloHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToHectoHertz()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.HectoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to HectoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to HectoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to HectoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToDecaHertz()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.DecaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to DecaHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to DecaHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to DecaHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToDeciHertz()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.DeciHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to DeciHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to DeciHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to DeciHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToCentiHertz()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.CentiHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to CentiHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to CentiHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to CentiHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMilliHertz()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.MilliHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to MilliHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to MilliHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to MilliHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMicroHertz()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.MicroHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to MicroHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to MicroHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to MicroHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToNanoHertz()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.NanoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to NanoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to NanoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to NanoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToPicoHertz()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.PicoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to PicoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to PicoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to PicoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToFemtoHertz()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.FemtoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to FemtoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to FemtoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to FemtoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToAttoHertz()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.AttoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to AttoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to AttoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to AttoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToZeptoHertz()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.ZeptoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to ZeptoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to ZeptoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to ZeptoHertz [SI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToYoctoHertz()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Frequency.YoctoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to YoctoHertz [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to YoctoHertz [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to YoctoHertz [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHertzToHertzOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [SI] to Hertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [SI] to Hertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [SI] to Hertz [RSI]");
    }

  }
}
