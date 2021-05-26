using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_CatalyticActivity_Tests
  {
    [TestMethod()]
    public void ConvertFromKatalToYottaKatal()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YottaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to YottaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to YottaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to YottaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToZettaKatal()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZettaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to ZettaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to ZettaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to ZettaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToExaKatal()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ExaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to ExaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to ExaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to ExaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToPetaKatal()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PetaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to PetaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to PetaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to PetaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToTeraKatal()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.TeraKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to TeraKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to TeraKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to TeraKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToGigaKatal()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.GigaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to GigaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to GigaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to GigaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToMegaKatal()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MegaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to MegaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to MegaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to MegaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToKiloKatal()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.KiloKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to KiloKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to KiloKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to KiloKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToHectoKatal()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.HectoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to HectoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to HectoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to HectoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToDecaKatal()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DecaKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to DecaKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to DecaKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to DecaKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToDeciKatal()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DeciKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to DeciKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to DeciKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to DeciKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToCentiKatal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.CentiKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to CentiKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to CentiKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to CentiKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToMilliKatal()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MilliKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to MilliKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to MilliKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to MilliKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToMicroKatal()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MicroKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to MicroKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to MicroKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to MicroKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToNanoKatal()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.NanoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to NanoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to NanoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to NanoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToPicoKatal()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PicoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to PicoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to PicoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to PicoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToFemtoKatal()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.FemtoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to FemtoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to FemtoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to FemtoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToAttoKatal()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.AttoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to AttoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to AttoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to AttoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToZeptoKatal()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZeptoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to ZeptoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to ZeptoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to ZeptoKatal [SI]");
    }

    [TestMethod()]
    public void ConvertFromKatalToYoctoKatal()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YoctoKatal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Katal [SI] to YoctoKatal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Katal [SI] to YoctoKatal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Katal [SI] to YoctoKatal [SI]");
    }

  }
}
