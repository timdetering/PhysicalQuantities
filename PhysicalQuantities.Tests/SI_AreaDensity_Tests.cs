using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_AreaDensity_Tests
  {
    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToYottaKilogramPerSquareMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.YottaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to YottaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to YottaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to YottaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToZettaKilogramPerSquareMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.ZettaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to ZettaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to ZettaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to ZettaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToExaKilogramPerSquareMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.ExaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to ExaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to ExaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to ExaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToPetaKilogramPerSquareMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.PetaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to PetaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to PetaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to PetaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToTeraKilogramPerSquareMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.TeraKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to TeraKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to TeraKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to TeraKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToGigaKilogramPerSquareMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.GigaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to GigaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to GigaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to GigaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToMegaKilogramPerSquareMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.MegaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to MegaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to MegaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to MegaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToKiloKilogramPerSquareMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KiloKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to KiloKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to KiloKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to KiloKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToHectoKilogramPerSquareMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.HectoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to HectoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to HectoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to HectoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToDecaKilogramPerSquareMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.DecaKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to DecaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to DecaKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to DecaKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToDeciKilogramPerSquareMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.DeciKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to DeciKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to DeciKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to DeciKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToCentiKilogramPerSquareMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.CentiKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to CentiKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to CentiKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to CentiKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToMilliKilogramPerSquareMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.MilliKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to MilliKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to MilliKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to MilliKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToMicroKilogramPerSquareMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.MicroKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to MicroKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to MicroKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to MicroKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToNanoKilogramPerSquareMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.NanoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to NanoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to NanoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to NanoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToPicoKilogramPerSquareMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.PicoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to PicoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to PicoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to PicoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToFemtoKilogramPerSquareMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.FemtoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to FemtoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to FemtoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to FemtoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToAttoKilogramPerSquareMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.AttoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to AttoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to AttoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to AttoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToZeptoKilogramPerSquareMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.ZeptoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to ZeptoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to ZeptoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to ZeptoKilogramPerSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerSquareMetreToYoctoKilogramPerSquareMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AreaDensity.YoctoKilogramPerSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerSquareMetre [SI] to YoctoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerSquareMetre [SI] to YoctoKilogramPerSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerSquareMetre [SI] to YoctoKilogramPerSquareMetre [SI]");
    }

  }
}
