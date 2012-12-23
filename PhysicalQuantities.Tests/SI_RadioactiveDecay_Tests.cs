using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_RadioactiveDecay_Tests
  {
    [TestMethod()]
    public void ConvertFromBecquerelToYottaBecquerel()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YottaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to YottaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to YottaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to YottaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToZettaBecquerel()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZettaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to ZettaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to ZettaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to ZettaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToExaBecquerel()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ExaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to ExaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to ExaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to ExaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToPetaBecquerel()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PetaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to PetaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to PetaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to PetaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToTeraBecquerel()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.TeraBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to TeraBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to TeraBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to TeraBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToGigaBecquerel()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.GigaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to GigaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to GigaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to GigaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToMegaBecquerel()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MegaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to MegaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to MegaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to MegaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToKiloBecquerel()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.KiloBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to KiloBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to KiloBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to KiloBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToHectoBecquerel()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.HectoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to HectoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to HectoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to HectoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToDecaBecquerel()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DecaBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to DecaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to DecaBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to DecaBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToDeciBecquerel()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DeciBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to DeciBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to DeciBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to DeciBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToCentiBecquerel()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.CentiBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to CentiBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to CentiBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to CentiBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToMilliBecquerel()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MilliBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to MilliBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to MilliBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to MilliBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToMicroBecquerel()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MicroBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to MicroBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to MicroBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to MicroBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToNanoBecquerel()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.NanoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to NanoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to NanoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to NanoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToPicoBecquerel()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PicoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to PicoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to PicoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to PicoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToFemtoBecquerel()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.FemtoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to FemtoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to FemtoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to FemtoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToAttoBecquerel()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.AttoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to AttoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to AttoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to AttoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToZeptoBecquerel()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZeptoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to ZeptoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to ZeptoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to ZeptoBecquerel [SI]");
    }

    [TestMethod()]
    public void ConvertFromBecquerelToYoctoBecquerel()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YoctoBecquerel;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Becquerel [SI] to YoctoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Becquerel [SI] to YoctoBecquerel [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Becquerel [SI] to YoctoBecquerel [SI]");
    }

  }
}
