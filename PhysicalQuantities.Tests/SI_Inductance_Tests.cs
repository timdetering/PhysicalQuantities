using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Inductance_Tests
  {
    [TestMethod()]
    public void ConvertFromHenryToYottaHenry()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.YottaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to YottaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to YottaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to YottaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToZettaHenry()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.ZettaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to ZettaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to ZettaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to ZettaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToExaHenry()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.ExaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to ExaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to ExaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to ExaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToPetaHenry()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.PetaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to PetaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to PetaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to PetaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToTeraHenry()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.TeraHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to TeraHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to TeraHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to TeraHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToGigaHenry()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.GigaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to GigaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to GigaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to GigaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToMegaHenry()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.MegaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to MegaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to MegaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to MegaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToKiloHenry()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.KiloHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to KiloHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to KiloHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to KiloHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToHectoHenry()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.HectoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to HectoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to HectoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to HectoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToDecaHenry()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.DecaHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to DecaHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to DecaHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to DecaHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToDeciHenry()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.DeciHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to DeciHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to DeciHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to DeciHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToCentiHenry()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.CentiHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to CentiHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to CentiHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to CentiHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToMilliHenry()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.MilliHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to MilliHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to MilliHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to MilliHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToMicroHenry()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.MicroHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to MicroHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to MicroHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to MicroHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToNanoHenry()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.NanoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to NanoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to NanoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to NanoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToPicoHenry()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.PicoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to PicoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to PicoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to PicoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToFemtoHenry()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.FemtoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to FemtoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to FemtoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to FemtoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToAttoHenry()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.AttoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to AttoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to AttoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to AttoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToZeptoHenry()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.ZeptoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to ZeptoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to ZeptoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to ZeptoHenry [SI]");
    }

    [TestMethod()]
    public void ConvertFromHenryToYoctoHenry()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Inductance.Henry;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Inductance.YoctoHenry;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Henry [SI] to YoctoHenry [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Henry [SI] to YoctoHenry [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Henry [SI] to YoctoHenry [SI]");
    }

  }
}
