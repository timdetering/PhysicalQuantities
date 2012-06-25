using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_SpecificVolume_Tests
  {
    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToYottaCubicMetrePerKilogram()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.YottaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to YottaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to YottaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to YottaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToZettaCubicMetrePerKilogram()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZettaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to ZettaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to ZettaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to ZettaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToExaCubicMetrePerKilogram()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.ExaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to ExaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to ExaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to ExaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToPetaCubicMetrePerKilogram()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.PetaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to PetaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to PetaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to PetaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToTeraCubicMetrePerKilogram()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.TeraCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to TeraCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to TeraCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to TeraCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToGigaCubicMetrePerKilogram()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.GigaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to GigaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to GigaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to GigaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToMegaCubicMetrePerKilogram()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.MegaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to MegaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to MegaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to MegaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToKiloCubicMetrePerKilogram()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.KiloCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to KiloCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to KiloCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to KiloCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToHectoCubicMetrePerKilogram()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.HectoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to HectoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to HectoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to HectoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToDecaCubicMetrePerKilogram()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.DecaCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to DecaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to DecaCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to DecaCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToDeciCubicMetrePerKilogram()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.DeciCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to DeciCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to DeciCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to DeciCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToCentiCubicMetrePerKilogram()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CentiCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to CentiCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to CentiCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to CentiCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToMilliCubicMetrePerKilogram()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.MilliCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to MilliCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to MilliCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to MilliCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToMicroCubicMetrePerKilogram()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.MicroCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to MicroCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to MicroCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to MicroCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToNanoCubicMetrePerKilogram()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.NanoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to NanoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to NanoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to NanoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToPicoCubicMetrePerKilogram()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.PicoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to PicoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to PicoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to PicoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToFemtoCubicMetrePerKilogram()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.FemtoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to FemtoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to FemtoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to FemtoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToAttoCubicMetrePerKilogram()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.AttoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to AttoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to AttoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to AttoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToZeptoCubicMetrePerKilogram()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZeptoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to ZeptoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to ZeptoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to ZeptoCubicMetrePerKilogram [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerKilogramToYoctoCubicMetrePerKilogram()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SpecificVolume.YoctoCubicMetrePerKilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerKilogram [SI] to YoctoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerKilogram [SI] to YoctoCubicMetrePerKilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerKilogram [SI] to YoctoCubicMetrePerKilogram [SI]");
    }

  }
}
