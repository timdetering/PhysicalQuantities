using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Jerk_Tests
  {
    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToYottaMetrePerSecondCubed()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.YottaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to YottaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to YottaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to YottaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToZettaMetrePerSecondCubed()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.ZettaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to ZettaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to ZettaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to ZettaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToExaMetrePerSecondCubed()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.ExaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to ExaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to ExaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to ExaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToPetaMetrePerSecondCubed()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.PetaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to PetaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to PetaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to PetaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToTeraMetrePerSecondCubed()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.TeraMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to TeraMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to TeraMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to TeraMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToGigaMetrePerSecondCubed()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.GigaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to GigaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to GigaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to GigaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToMegaMetrePerSecondCubed()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MegaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to MegaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to MegaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to MegaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToKiloMetrePerSecondCubed()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.KiloMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to KiloMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to KiloMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to KiloMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToHectoMetrePerSecondCubed()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.HectoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to HectoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to HectoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to HectoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToDecaMetrePerSecondCubed()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.DecaMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to DecaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to DecaMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to DecaMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToDeciMetrePerSecondCubed()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.DeciMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to DeciMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to DeciMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to DeciMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToCentiMetrePerSecondCubed()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.CentiMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to CentiMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to CentiMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to CentiMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToMilliMetrePerSecondCubed()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MilliMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to MilliMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to MilliMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to MilliMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToMicroMetrePerSecondCubed()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MicroMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to MicroMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to MicroMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to MicroMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToNanoMetrePerSecondCubed()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.NanoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to NanoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to NanoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to NanoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToPicoMetrePerSecondCubed()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.PicoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to PicoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to PicoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to PicoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToFemtoMetrePerSecondCubed()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.FemtoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to FemtoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to FemtoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to FemtoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToAttoMetrePerSecondCubed()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.AttoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to AttoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to AttoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to AttoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToZeptoMetrePerSecondCubed()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.ZeptoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to ZeptoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to ZeptoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to ZeptoMetrePerSecondCubed [SI]");
    }

    [TestMethod()]
    public void ConvertFromMetrePerSecondCubedToYoctoMetrePerSecondCubed()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Jerk.YoctoMetrePerSecondCubed;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetrePerSecondCubed [SI] to YoctoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetrePerSecondCubed [SI] to YoctoMetrePerSecondCubed [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetrePerSecondCubed [SI] to YoctoMetrePerSecondCubed [SI]");
    }

  }
}
