using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Yank_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonPerSecondToYottaNewtonPerSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.YottaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to YottaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to YottaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to YottaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToZettaNewtonPerSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.ZettaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to ZettaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to ZettaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to ZettaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToExaNewtonPerSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.ExaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to ExaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to ExaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to ExaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToPetaNewtonPerSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.PetaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to PetaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to PetaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to PetaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToTeraNewtonPerSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.TeraNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to TeraNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to TeraNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to TeraNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToGigaNewtonPerSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.GigaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to GigaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to GigaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to GigaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToMegaNewtonPerSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.MegaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to MegaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to MegaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to MegaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToKiloNewtonPerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.KiloNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to KiloNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to KiloNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to KiloNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToHectoNewtonPerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.HectoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to HectoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to HectoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to HectoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToDecaNewtonPerSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.DecaNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to DecaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to DecaNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to DecaNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToDeciNewtonPerSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.DeciNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to DeciNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to DeciNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to DeciNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToCentiNewtonPerSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.CentiNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to CentiNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to CentiNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to CentiNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToMilliNewtonPerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.MilliNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to MilliNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to MilliNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to MilliNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToMicroNewtonPerSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.MicroNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to MicroNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to MicroNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to MicroNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToNanoNewtonPerSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.NanoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to NanoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to NanoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to NanoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToPicoNewtonPerSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.PicoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to PicoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to PicoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to PicoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToFemtoNewtonPerSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.FemtoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to FemtoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to FemtoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to FemtoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToAttoNewtonPerSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.AttoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to AttoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to AttoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to AttoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToZeptoNewtonPerSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.ZeptoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to ZeptoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to ZeptoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to ZeptoNewtonPerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonPerSecondToYoctoNewtonPerSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Yank.YoctoNewtonPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonPerSecond [SI] to YoctoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonPerSecond [SI] to YoctoNewtonPerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonPerSecond [SI] to YoctoNewtonPerSecond [SI]");
    }

  }
}
