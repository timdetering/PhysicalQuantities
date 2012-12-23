using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Time_Tests
  {
    [TestMethod()]
    public void ConvertFromSecondToYottaSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.YottaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to YottaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to YottaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to YottaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToZettaSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.ZettaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to ZettaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to ZettaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to ZettaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToExaSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.ExaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to ExaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to ExaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to ExaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToPetaSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.PetaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to PetaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to PetaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to PetaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToTeraSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.TeraSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to TeraSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to TeraSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to TeraSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToGigaSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.GigaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to GigaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to GigaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to GigaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToMegaSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.MegaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to MegaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to MegaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to MegaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToKiloSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.KiloSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to KiloSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to KiloSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to KiloSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToHectoSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.HectoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to HectoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to HectoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to HectoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToDecaSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.DecaSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to DecaSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to DecaSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to DecaSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToDeciSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.DeciSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to DeciSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to DeciSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to DeciSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToCentiSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.CentiSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to CentiSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to CentiSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to CentiSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToMilliSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.MilliSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to MilliSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to MilliSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to MilliSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToMicroSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.MicroSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to MicroSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to MicroSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to MicroSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToNanoSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.NanoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to NanoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to NanoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to NanoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToPicoSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.PicoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to PicoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to PicoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to PicoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToFemtoSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.FemtoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to FemtoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to FemtoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to FemtoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToAttoSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.AttoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to AttoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to AttoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to AttoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToZeptoSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.ZeptoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to ZeptoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to ZeptoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to ZeptoSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromSecondToYoctoSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.YoctoSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to YoctoSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to YoctoSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to YoctoSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMinuteToSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Minute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Minute [SI] to Second [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Minute [SI] to Second [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Minute [SI] to Second [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHourToMinute()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Hour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.Minute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hour [SI] to Minute [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hour [SI] to Minute [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hour [SI] to Minute [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDayToHour()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Day;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.Hour;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(240);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Day [SI] to Hour [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Day [SI] to Hour [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Day [SI] to Hour [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNaturalUnitOfTimeToSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.NaturalUnitOfTime;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.288088667786E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NaturalUnitOfTime [SI] to Second [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NaturalUnitOfTime [SI] to Second [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NaturalUnitOfTime [SI] to Second [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSecondToSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to Second [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSecondToSecondOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [SI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [SI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [SI] to Second [RSI]");
    }

  }
}
