using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Power_Tests
  {
    [TestMethod()]
    public void ConvertFromWattToYottaWatt()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.YottaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to YottaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to YottaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to YottaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToZettaWatt()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.ZettaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to ZettaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to ZettaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to ZettaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToExaWatt()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.ExaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to ExaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to ExaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to ExaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToPetaWatt()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.PetaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to PetaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to PetaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to PetaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToTeraWatt()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.TeraWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to TeraWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to TeraWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to TeraWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToGigaWatt()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.GigaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to GigaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to GigaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to GigaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMegaWatt()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.MegaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to MegaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to MegaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to MegaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToKiloWatt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.KiloWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to KiloWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to KiloWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to KiloWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToHectoWatt()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.HectoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to HectoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to HectoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to HectoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToDecaWatt()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.DecaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to DecaWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to DecaWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to DecaWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToDeciWatt()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.DeciWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to DeciWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to DeciWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to DeciWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToCentiWatt()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.CentiWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to CentiWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to CentiWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to CentiWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMilliWatt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.MilliWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to MilliWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to MilliWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to MilliWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMicroWatt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.MicroWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to MicroWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to MicroWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to MicroWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToNanoWatt()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.NanoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to NanoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to NanoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to NanoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToPicoWatt()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.PicoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to PicoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to PicoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to PicoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToFemtoWatt()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.FemtoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to FemtoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to FemtoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to FemtoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToAttoWatt()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.AttoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to AttoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to AttoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to AttoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToZeptoWatt()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.ZeptoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to ZeptoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to ZeptoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to ZeptoWatt [SI]");
    }

    [TestMethod()]
    public void ConvertFromWattToYoctoWatt()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Power.YoctoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to YoctoWatt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to YoctoWatt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to YoctoWatt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromWattToFootPoundPerSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(7.37562149277266);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to FootPoundPerSecond [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromWattToWattOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [SI] to Watt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [SI] to Watt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [SI] to Watt [RSI]");
    }

  }
}
