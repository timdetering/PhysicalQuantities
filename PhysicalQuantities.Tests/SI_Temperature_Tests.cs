using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Temperature_Tests
  {
    [TestMethod()]
    public void ConvertFromKelvinToYottaKelvin()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.YottaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to YottaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to YottaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to YottaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToZettaKelvin()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.ZettaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to ZettaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to ZettaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to ZettaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToExaKelvin()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.ExaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to ExaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to ExaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to ExaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToPetaKelvin()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.PetaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to PetaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to PetaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to PetaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToTeraKelvin()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.TeraKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to TeraKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to TeraKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to TeraKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToGigaKelvin()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.GigaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to GigaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to GigaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to GigaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToMegaKelvin()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.MegaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to MegaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to MegaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to MegaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToKiloKelvin()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.KiloKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to KiloKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to KiloKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to KiloKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToHectoKelvin()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.HectoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to HectoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to HectoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to HectoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToDecaKelvin()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.DecaKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to DecaKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to DecaKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to DecaKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToDeciKelvin()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.DeciKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to DeciKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to DeciKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to DeciKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToCentiKelvin()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.CentiKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to CentiKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to CentiKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to CentiKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToMilliKelvin()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.MilliKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to MilliKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to MilliKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to MilliKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToMicroKelvin()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.MicroKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to MicroKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to MicroKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to MicroKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToNanoKelvin()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.NanoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to NanoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to NanoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to NanoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToPicoKelvin()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.PicoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to PicoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to PicoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to PicoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToFemtoKelvin()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.FemtoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to FemtoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to FemtoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to FemtoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToAttoKelvin()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.AttoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to AttoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to AttoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to AttoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToZeptoKelvin()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.ZeptoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to ZeptoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to ZeptoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to ZeptoKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromKelvinToYoctoKelvin()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.YoctoKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to YoctoKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to YoctoKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to YoctoKelvin [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCelsiusToKelvin()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Celsius;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(-263.15);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Celsius [SI] to Kelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Celsius [SI] to Kelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Celsius [SI] to Kelvin [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKelvinToFarenheitOnImperial()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Temperature.Farenheit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(260.925925927778);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to Farenheit [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to Farenheit [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to Farenheit [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKelvinToKelvinOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Temperature.Kelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kelvin [SI] to Kelvin [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kelvin [SI] to Kelvin [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kelvin [SI] to Kelvin [RSI]");
    }

  }
}
