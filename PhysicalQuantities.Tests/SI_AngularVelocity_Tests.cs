using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_AngularVelocity_Tests
  {
    [TestMethod()]
    public void ConvertFromRadianPerSecondToYottaRadianPerSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.YottaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to YottaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to YottaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to YottaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToZettaRadianPerSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZettaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to ZettaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to ZettaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to ZettaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToExaRadianPerSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.ExaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to ExaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to ExaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to ExaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToPetaRadianPerSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.PetaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to PetaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to PetaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to PetaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToTeraRadianPerSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.TeraRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to TeraRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to TeraRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to TeraRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToGigaRadianPerSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.GigaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to GigaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to GigaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to GigaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToMegaRadianPerSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.MegaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to MegaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to MegaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to MegaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToKiloRadianPerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.KiloRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to KiloRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to KiloRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to KiloRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToHectoRadianPerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.HectoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to HectoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to HectoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to HectoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToDecaRadianPerSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.DecaRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to DecaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to DecaRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to DecaRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToDeciRadianPerSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.DeciRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to DeciRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to DeciRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to DeciRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToCentiRadianPerSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.CentiRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to CentiRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to CentiRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to CentiRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToMilliRadianPerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.MilliRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to MilliRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to MilliRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to MilliRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToMicroRadianPerSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.MicroRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to MicroRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to MicroRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to MicroRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToNanoRadianPerSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.NanoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to NanoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to NanoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to NanoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToPicoRadianPerSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.PicoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to PicoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to PicoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to PicoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToFemtoRadianPerSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.FemtoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to FemtoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to FemtoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to FemtoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToAttoRadianPerSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.AttoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to AttoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to AttoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to AttoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToZeptoRadianPerSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZeptoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to ZeptoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to ZeptoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to ZeptoRadianPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromRadianPerSecondToYoctoRadianPerSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.YoctoRadianPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to YoctoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to YoctoRadianPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to YoctoRadianPerSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRadianPerSecondToDegreesPerSecondOnImperial()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(572.957795130823);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from RadianPerSecond [SI] to DegreesPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from RadianPerSecond [SI] to DegreesPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from RadianPerSecond [SI] to DegreesPerSecond [Imperial]");
    }

  }
}
