using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Angle_Tests
  {
    [TestMethod()]
    public void ConvertFromRadianToYottaRadian()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.YottaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to YottaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to YottaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to YottaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToZettaRadian()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.ZettaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to ZettaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to ZettaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to ZettaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToExaRadian()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.ExaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to ExaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to ExaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to ExaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToPetaRadian()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.PetaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to PetaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to PetaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to PetaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToTeraRadian()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.TeraRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to TeraRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to TeraRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to TeraRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToGigaRadian()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.GigaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to GigaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to GigaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to GigaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToMegaRadian()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.MegaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to MegaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to MegaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to MegaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToKiloRadian()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.KiloRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to KiloRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to KiloRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to KiloRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToHectoRadian()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.HectoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to HectoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to HectoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to HectoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToDecaRadian()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.DecaRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to DecaRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to DecaRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to DecaRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToDeciRadian()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.DeciRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to DeciRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to DeciRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to DeciRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToCentiRadian()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.CentiRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to CentiRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to CentiRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to CentiRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToMilliRadian()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.MilliRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to MilliRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to MilliRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to MilliRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToMicroRadian()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.MicroRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to MicroRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to MicroRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to MicroRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToNanoRadian()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.NanoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to NanoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to NanoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to NanoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToPicoRadian()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.PicoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to PicoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to PicoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to PicoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToFemtoRadian()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.FemtoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to FemtoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to FemtoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to FemtoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToAttoRadian()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.AttoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to AttoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to AttoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to AttoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToZeptoRadian()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.ZeptoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to ZeptoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to ZeptoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to ZeptoRadian [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianToYoctoRadian()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.YoctoRadian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to YoctoRadian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to YoctoRadian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to YoctoRadian [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDegreeToRadian()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Degree;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.174532925199433);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Degree [SI] to Radian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Degree [SI] to Radian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Degree [SI] to Radian [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcminuteToDegree()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Arcminute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.Degree;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcminute [SI] to Degree [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcminute [SI] to Degree [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcminute [SI] to Degree [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcsecondToArcminute()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Arcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.Arcminute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcsecond [SI] to Arcminute [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcsecond [SI] to Arcminute [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcsecond [SI] to Arcminute [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliarcsecondToArcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Milliarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.Arcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Milliarcsecond [SI] to Arcsecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Milliarcsecond [SI] to Arcsecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Milliarcsecond [SI] to Arcsecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicroarcsecondToMilliarcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Microarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Angle.Milliarcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Microarcsecond [SI] to Milliarcsecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Microarcsecond [SI] to Milliarcsecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Microarcsecond [SI] to Milliarcsecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRadianToDegreeOnImperial()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Degree;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(572.957795130823);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to Degree [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRadianToRadianOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Angle.Radian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Angle.Radian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Radian [SI] to Radian [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Radian [SI] to Radian [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Radian [SI] to Radian [RSI]");
    }

  }
}
