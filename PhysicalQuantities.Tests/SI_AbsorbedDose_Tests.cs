using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_AbsorbedDose_Tests
  {
    [TestMethod()]
    public void ConvertFromGrayToYottaGray()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YottaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to YottaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to YottaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to YottaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToZettaGray()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZettaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to ZettaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to ZettaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to ZettaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToExaGray()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ExaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to ExaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to ExaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to ExaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToPetaGray()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PetaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to PetaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to PetaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to PetaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToTeraGray()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.TeraGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to TeraGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to TeraGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to TeraGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToGigaGray()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.GigaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to GigaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to GigaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to GigaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToMegaGray()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MegaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to MegaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to MegaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to MegaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToKiloGray()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.KiloGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to KiloGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to KiloGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to KiloGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToHectoGray()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.HectoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to HectoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to HectoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to HectoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToDecaGray()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DecaGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to DecaGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to DecaGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to DecaGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToDeciGray()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DeciGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to DeciGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to DeciGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to DeciGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToCentiGray()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.CentiGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to CentiGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to CentiGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to CentiGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToMilliGray()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MilliGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to MilliGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to MilliGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to MilliGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToMicroGray()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MicroGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to MicroGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to MicroGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to MicroGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToNanoGray()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.NanoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to NanoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to NanoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to NanoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToPicoGray()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PicoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to PicoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to PicoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to PicoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToFemtoGray()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.FemtoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to FemtoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to FemtoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to FemtoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToAttoGray()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.AttoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to AttoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to AttoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to AttoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToZeptoGray()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZeptoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to ZeptoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to ZeptoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to ZeptoGray [SI]");
    }

    [TestMethod()]
    public void ConvertFromGrayToYoctoGray()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YoctoGray;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gray [SI] to YoctoGray [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gray [SI] to YoctoGray [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gray [SI] to YoctoGray [SI]");
    }

  }
}
