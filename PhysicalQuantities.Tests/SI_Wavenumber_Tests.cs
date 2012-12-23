using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Wavenumber_Tests
  {
    [TestMethod()]
    public void ConvertFromReciprocalMetreToYottaReciprocalMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.YottaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to YottaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to YottaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to YottaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToZettaReciprocalMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ZettaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to ZettaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to ZettaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to ZettaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToExaReciprocalMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ExaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to ExaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to ExaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to ExaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToPetaReciprocalMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.PetaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to PetaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to PetaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to PetaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToTeraReciprocalMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.TeraReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to TeraReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to TeraReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to TeraReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToGigaReciprocalMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.GigaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to GigaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to GigaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to GigaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToMegaReciprocalMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.MegaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to MegaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to MegaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to MegaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToKiloReciprocalMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.KiloReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to KiloReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to KiloReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to KiloReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToHectoReciprocalMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.HectoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to HectoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to HectoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to HectoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToDecaReciprocalMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.DecaReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to DecaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to DecaReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to DecaReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToDeciReciprocalMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.DeciReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to DeciReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to DeciReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to DeciReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToCentiReciprocalMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.CentiReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to CentiReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to CentiReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to CentiReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToMilliReciprocalMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.MilliReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to MilliReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to MilliReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to MilliReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToMicroReciprocalMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.MicroReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to MicroReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to MicroReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to MicroReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToNanoReciprocalMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.NanoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to NanoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to NanoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to NanoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToPicoReciprocalMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.PicoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to PicoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to PicoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to PicoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToFemtoReciprocalMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.FemtoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to FemtoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to FemtoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to FemtoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToAttoReciprocalMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.AttoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to AttoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to AttoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to AttoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToZeptoReciprocalMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ZeptoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to ZeptoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to ZeptoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to ZeptoReciprocalMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromReciprocalMetreToYoctoReciprocalMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Wavenumber.YoctoReciprocalMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReciprocalMetre [SI] to YoctoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReciprocalMetre [SI] to YoctoReciprocalMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReciprocalMetre [SI] to YoctoReciprocalMetre [SI]");
    }

  }
}
