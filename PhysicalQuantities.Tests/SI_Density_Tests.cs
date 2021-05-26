using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Density_Tests
  {
    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToYottaKilogramPerCubicMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.YottaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to YottaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to YottaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to YottaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToZettaKilogramPerCubicMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.ZettaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to ZettaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to ZettaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to ZettaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToExaKilogramPerCubicMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.ExaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to ExaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to ExaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to ExaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToPetaKilogramPerCubicMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.PetaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to PetaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to PetaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to PetaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToTeraKilogramPerCubicMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.TeraKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to TeraKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to TeraKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to TeraKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToGigaKilogramPerCubicMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.GigaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to GigaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to GigaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to GigaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToMegaKilogramPerCubicMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.MegaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to MegaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to MegaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to MegaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToKiloKilogramPerCubicMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.KiloKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to KiloKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to KiloKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to KiloKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToHectoKilogramPerCubicMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.HectoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to HectoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to HectoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to HectoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToDecaKilogramPerCubicMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.DecaKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to DecaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to DecaKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to DecaKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToDeciKilogramPerCubicMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.DeciKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to DeciKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to DeciKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to DeciKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToCentiKilogramPerCubicMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.CentiKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to CentiKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to CentiKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to CentiKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToMilliKilogramPerCubicMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.MilliKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to MilliKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to MilliKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to MilliKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToMicroKilogramPerCubicMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.MicroKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to MicroKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to MicroKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to MicroKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToNanoKilogramPerCubicMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.NanoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to NanoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to NanoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to NanoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToPicoKilogramPerCubicMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.PicoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to PicoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to PicoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to PicoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToFemtoKilogramPerCubicMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.FemtoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to FemtoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to FemtoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to FemtoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToAttoKilogramPerCubicMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.AttoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to AttoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to AttoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to AttoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToZeptoKilogramPerCubicMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.ZeptoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to ZeptoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to ZeptoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to ZeptoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromKilogramPerCubicMetreToYoctoKilogramPerCubicMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Density.YoctoKilogramPerCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to YoctoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to YoctoKilogramPerCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to YoctoKilogramPerCubicMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKilogramPerCubicMetreToPoundPerCubicFootOnImperial()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Density.PoundPerCubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.624279608410023);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KilogramPerCubicMetre [SI] to PoundPerCubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KilogramPerCubicMetre [SI] to PoundPerCubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KilogramPerCubicMetre [SI] to PoundPerCubicFoot [Imperial]");
    }

  }
}
