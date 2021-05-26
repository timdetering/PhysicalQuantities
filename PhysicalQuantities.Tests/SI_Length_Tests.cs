using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Length_Tests
  {
    [TestMethod()]
    public void ConvertFromMetreToYottaMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.YottaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to YottaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to YottaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to YottaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToZettaMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.ZettaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to ZettaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to ZettaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to ZettaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToExaMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.ExaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to ExaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to ExaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to ExaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToPetaMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.PetaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to PetaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to PetaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to PetaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToTeraMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.TeraMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to TeraMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to TeraMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to TeraMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToGigaMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.GigaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to GigaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to GigaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to GigaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMegaMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.MegaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to MegaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to MegaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to MegaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToKiloMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.KiloMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to KiloMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to KiloMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to KiloMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToHectoMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.HectoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to HectoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to HectoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to HectoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToDecaMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.DecaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to DecaMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to DecaMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to DecaMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToDeciMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.DeciMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to DeciMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to DeciMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to DeciMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToCentiMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.CentiMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to CentiMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to CentiMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to CentiMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMilliMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.MilliMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to MilliMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to MilliMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to MilliMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMicroMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.MicroMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to MicroMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to MicroMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to MicroMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToNanoMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.NanoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to NanoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to NanoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to NanoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToPicoMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.PicoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to PicoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to PicoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to PicoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToFemtoMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.FemtoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to FemtoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to FemtoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to FemtoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToAttoMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.AttoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to AttoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to AttoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to AttoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToZeptoMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.ZeptoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to ZeptoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to ZeptoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to ZeptoMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToYoctoMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.YoctoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to YoctoMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to YoctoMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to YoctoMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAstronomicalUnitToMetre()
    {
      double delta = 1E4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.AstronomicalUnit;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1495978707000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from AstronomicalUnit [SI] to Metre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from AstronomicalUnit [SI] to Metre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from AstronomicalUnit [SI] to Metre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBohrRadiusToMetre()
    {
      double delta = 1E-17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.BohrRadius;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5.29177210818E-10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BohrRadius [SI] to Metre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BohrRadius [SI] to Metre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BohrRadius [SI] to Metre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetreToFootOnImperial()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(32.8083989501312);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to Foot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetreToMetreOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [SI] to Metre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [SI] to Metre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [SI] to Metre [RSI]");
    }

  }
}
