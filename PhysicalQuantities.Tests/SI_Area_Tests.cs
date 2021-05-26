using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Area_Tests
  {
    [TestMethod()]
    public void ConvertFromSquareMetreToYottaSquareMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.YottaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to YottaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to YottaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to YottaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToZettaSquareMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.ZettaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to ZettaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to ZettaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to ZettaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToExaSquareMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.ExaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to ExaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to ExaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to ExaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToPetaSquareMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.PetaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to PetaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to PetaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to PetaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToTeraSquareMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.TeraSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to TeraSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to TeraSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to TeraSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToGigaSquareMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.GigaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to GigaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to GigaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to GigaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToMegaSquareMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.MegaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to MegaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to MegaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to MegaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToKiloSquareMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.KiloSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to KiloSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to KiloSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to KiloSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToHectoSquareMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.HectoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to HectoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to HectoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to HectoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToDecaSquareMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.DecaSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to DecaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to DecaSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to DecaSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToDeciSquareMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.DeciSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to DeciSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to DeciSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to DeciSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToCentiSquareMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.CentiSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to CentiSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to CentiSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to CentiSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToMilliSquareMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.MilliSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to MilliSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to MilliSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to MilliSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToMicroSquareMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.MicroSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to MicroSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to MicroSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to MicroSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToNanoSquareMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.NanoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to NanoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to NanoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to NanoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToPicoSquareMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.PicoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to PicoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to PicoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to PicoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToFemtoSquareMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.FemtoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to FemtoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to FemtoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to FemtoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToAttoSquareMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.AttoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to AttoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to AttoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to AttoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToZeptoSquareMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.ZeptoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to ZeptoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to ZeptoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to ZeptoSquareMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromSquareMetreToYoctoSquareMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.YoctoSquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to YoctoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to YoctoSquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to YoctoSquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAreToSquareMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.Are;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Are [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Are [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Are [SI] to SquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentiareToSquareMetre()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.Centiare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Centiare [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Centiare [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Centiare [SI] to SquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecareToAre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.Decare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.Are;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decare [SI] to Are [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decare [SI] to Are [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decare [SI] to Are [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectareToAre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.Hectare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.Are;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hectare [SI] to Are [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hectare [SI] to Are [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hectare [SI] to Are [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareKilometreToSquareMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareKilometre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareKilometre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareKilometre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareKilometre [SI] to SquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareCentimetreToSquareMetre()
    {
      double delta = 1E-11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareCentimetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.001);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareCentimetre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareCentimetre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareCentimetre [SI] to SquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMillimetreToSquareMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMillimetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMillimetre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMillimetre [SI] to SquareMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMillimetre [SI] to SquareMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMetreToSquareFootOnImperial()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(107.639104167097);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to SquareFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMetreToSquareMetreOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Area.SquareMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMetre [SI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMetre [SI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMetre [SI] to SquareMetre [RSI]");
    }

  }
}
