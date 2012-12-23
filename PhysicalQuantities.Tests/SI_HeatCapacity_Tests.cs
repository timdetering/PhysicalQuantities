using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_HeatCapacity_Tests
  {
    [TestMethod()]
    public void ConvertFromJoulePerKelvinToYottaJoulePerKelvin()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.YottaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to YottaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to YottaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to YottaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToZettaJoulePerKelvin()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZettaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to ZettaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to ZettaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to ZettaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToExaJoulePerKelvin()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.ExaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to ExaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to ExaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to ExaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToPetaJoulePerKelvin()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.PetaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to PetaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to PetaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to PetaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToTeraJoulePerKelvin()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.TeraJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to TeraJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to TeraJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to TeraJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToGigaJoulePerKelvin()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.GigaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to GigaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to GigaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to GigaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToMegaJoulePerKelvin()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.MegaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to MegaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to MegaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to MegaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToKiloJoulePerKelvin()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.KiloJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to KiloJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to KiloJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to KiloJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToHectoJoulePerKelvin()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.HectoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to HectoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to HectoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to HectoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToDecaJoulePerKelvin()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.DecaJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to DecaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to DecaJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to DecaJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToDeciJoulePerKelvin()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.DeciJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to DeciJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to DeciJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to DeciJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToCentiJoulePerKelvin()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.CentiJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to CentiJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to CentiJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to CentiJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToMilliJoulePerKelvin()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.MilliJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to MilliJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to MilliJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to MilliJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToMicroJoulePerKelvin()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.MicroJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to MicroJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to MicroJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to MicroJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToNanoJoulePerKelvin()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.NanoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to NanoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to NanoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to NanoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToPicoJoulePerKelvin()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.PicoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to PicoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to PicoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to PicoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToFemtoJoulePerKelvin()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.FemtoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to FemtoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to FemtoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to FemtoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToAttoJoulePerKelvin()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.AttoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to AttoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to AttoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to AttoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToZeptoJoulePerKelvin()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZeptoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to ZeptoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to ZeptoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to ZeptoJoulePerKelvin [SI]");
    }

    [TestMethod()]
    public void ConvertFromJoulePerKelvinToYoctoJoulePerKelvin()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.HeatCapacity.YoctoJoulePerKelvin;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JoulePerKelvin [SI] to YoctoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JoulePerKelvin [SI] to YoctoJoulePerKelvin [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JoulePerKelvin [SI] to YoctoJoulePerKelvin [SI]");
    }

  }
}
