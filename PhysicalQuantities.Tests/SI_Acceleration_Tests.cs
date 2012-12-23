using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Acceleration_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToYottaMetrePerSecondSquared()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.YottaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to YottaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to YottaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to YottaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToZettaMetrePerSecondSquared()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.ZettaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to ZettaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to ZettaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to ZettaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToExaMetrePerSecondSquared()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.ExaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to ExaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to ExaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to ExaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToPetaMetrePerSecondSquared()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.PetaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to PetaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to PetaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to PetaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToTeraMetrePerSecondSquared()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.TeraMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to TeraMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to TeraMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to TeraMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToGigaMetrePerSecondSquared()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.GigaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to GigaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to GigaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to GigaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToMegaMetrePerSecondSquared()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MegaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to MegaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to MegaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to MegaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToKiloMetrePerSecondSquared()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.KiloMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to KiloMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to KiloMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to KiloMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToHectoMetrePerSecondSquared()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.HectoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to HectoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to HectoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to HectoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToDecaMetrePerSecondSquared()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.DecaMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to DecaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to DecaMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to DecaMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToDeciMetrePerSecondSquared()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.DeciMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to DeciMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to DeciMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to DeciMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToCentiMetrePerSecondSquared()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.CentiMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to CentiMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to CentiMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to CentiMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToMilliMetrePerSecondSquared()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MilliMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to MilliMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to MilliMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to MilliMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToMicroMetrePerSecondSquared()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MicroMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to MicroMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to MicroMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to MicroMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToNanoMetrePerSecondSquared()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.NanoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to NanoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to NanoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to NanoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToPicoMetrePerSecondSquared()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.PicoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to PicoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to PicoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to PicoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToFemtoMetrePerSecondSquared()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.FemtoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to FemtoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to FemtoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to FemtoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToAttoMetrePerSecondSquared()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.AttoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to AttoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to AttoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to AttoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToZeptoMetrePerSecondSquared()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.ZeptoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to ZeptoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to ZeptoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to ZeptoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondSquaredToYoctoMetrePerSecondSquared()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.YoctoMetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to YoctoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to YoctoMetrePerSecondSquared [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to YoctoMetrePerSecondSquared [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetrePerSecondSquaredToMetrePerSecondSquaredOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondSquared [SI] to MetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondSquared [SI] to MetrePerSecondSquared [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondSquared [SI] to MetrePerSecondSquared [RSI]");
    }

  }
}
