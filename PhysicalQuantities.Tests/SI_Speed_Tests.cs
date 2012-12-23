using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Speed_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerSecondToYottaMetrePerSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.YottaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to YottaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to YottaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to YottaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToZettaMetrePerSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.ZettaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to ZettaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to ZettaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to ZettaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToExaMetrePerSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.ExaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to ExaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to ExaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to ExaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToPetaMetrePerSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.PetaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to PetaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to PetaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to PetaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToTeraMetrePerSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.TeraMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to TeraMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to TeraMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to TeraMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToGigaMetrePerSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.GigaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to GigaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to GigaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to GigaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToMegaMetrePerSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.MegaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to MegaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to MegaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to MegaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToKiloMetrePerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.KiloMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to KiloMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to KiloMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to KiloMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToHectoMetrePerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.HectoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to HectoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to HectoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to HectoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToDecaMetrePerSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.DecaMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to DecaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to DecaMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to DecaMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToDeciMetrePerSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.DeciMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to DeciMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to DeciMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to DeciMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToCentiMetrePerSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.CentiMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to CentiMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to CentiMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to CentiMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToMilliMetrePerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.MilliMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to MilliMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to MilliMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to MilliMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToMicroMetrePerSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.MicroMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to MicroMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to MicroMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to MicroMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToNanoMetrePerSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.NanoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to NanoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to NanoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to NanoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToPicoMetrePerSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.PicoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to PicoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to PicoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to PicoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToFemtoMetrePerSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.FemtoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to FemtoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to FemtoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to FemtoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToAttoMetrePerSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.AttoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to AttoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to AttoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to AttoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToZeptoMetrePerSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.ZeptoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to ZeptoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to ZeptoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to ZeptoMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondToYoctoMetrePerSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.YoctoMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to YoctoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to YoctoMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to YoctoMetrePerSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSpeedOfLightToMetrePerSecond()
    {
      double delta = 1E1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.SpeedOfLight;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2997924580);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SpeedOfLight [SI] to MetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SpeedOfLight [SI] to MetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SpeedOfLight [SI] to MetrePerSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetrePerSecondToFootPerSecondOnImperial()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(32.8083989501312);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to FootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to FootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to FootPerSecond [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetrePerSecondToMetrePerSecondOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecond [SI] to MetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecond [SI] to MetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecond [SI] to MetrePerSecond [RSI]");
    }

  }
}
