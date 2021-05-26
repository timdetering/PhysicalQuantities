using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Jounce_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToYottaMetrePerQuarticSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.YottaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to YottaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to YottaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to YottaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToZettaMetrePerQuarticSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.ZettaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to ZettaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to ZettaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to ZettaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToExaMetrePerQuarticSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.ExaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to ExaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to ExaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to ExaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToPetaMetrePerQuarticSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.PetaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to PetaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to PetaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to PetaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToTeraMetrePerQuarticSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.TeraMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to TeraMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to TeraMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to TeraMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToGigaMetrePerQuarticSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.GigaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to GigaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to GigaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to GigaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToMegaMetrePerQuarticSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MegaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to MegaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to MegaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to MegaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToKiloMetrePerQuarticSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.KiloMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to KiloMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to KiloMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to KiloMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToHectoMetrePerQuarticSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.HectoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to HectoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to HectoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to HectoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToDecaMetrePerQuarticSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.DecaMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to DecaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to DecaMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to DecaMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToDeciMetrePerQuarticSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.DeciMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to DeciMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to DeciMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to DeciMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToCentiMetrePerQuarticSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.CentiMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to CentiMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to CentiMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to CentiMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToMilliMetrePerQuarticSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MilliMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to MilliMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to MilliMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to MilliMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToMicroMetrePerQuarticSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MicroMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to MicroMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to MicroMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to MicroMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToNanoMetrePerQuarticSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.NanoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to NanoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to NanoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to NanoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToPicoMetrePerQuarticSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.PicoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to PicoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to PicoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to PicoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToFemtoMetrePerQuarticSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.FemtoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to FemtoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to FemtoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to FemtoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToAttoMetrePerQuarticSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.AttoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to AttoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to AttoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to AttoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToZeptoMetrePerQuarticSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.ZeptoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to ZeptoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to ZeptoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to ZeptoMetrePerQuarticSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerQuarticSecondToYoctoMetrePerQuarticSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jounce.YoctoMetrePerQuarticSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerQuarticSecond [SI] to YoctoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerQuarticSecond [SI] to YoctoMetrePerQuarticSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerQuarticSecond [SI] to YoctoMetrePerQuarticSecond [SI]");
    }

  }
}
