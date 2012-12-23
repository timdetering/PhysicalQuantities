using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_AngularMomentum_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToYottaNewtonMetreSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.YottaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to YottaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to YottaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to YottaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToZettaNewtonMetreSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZettaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to ZettaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to ZettaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to ZettaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToExaNewtonMetreSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.ExaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to ExaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to ExaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to ExaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToPetaNewtonMetreSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.PetaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to PetaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to PetaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to PetaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToTeraNewtonMetreSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.TeraNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to TeraNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to TeraNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to TeraNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToGigaNewtonMetreSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.GigaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to GigaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to GigaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to GigaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToMegaNewtonMetreSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.MegaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to MegaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to MegaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to MegaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToKiloNewtonMetreSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.KiloNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to KiloNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to KiloNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to KiloNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToHectoNewtonMetreSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.HectoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to HectoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to HectoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to HectoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToDecaNewtonMetreSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.DecaNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to DecaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to DecaNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to DecaNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToDeciNewtonMetreSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.DeciNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to DeciNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to DeciNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to DeciNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToCentiNewtonMetreSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.CentiNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to CentiNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to CentiNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to CentiNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToMilliNewtonMetreSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.MilliNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to MilliNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to MilliNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to MilliNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToMicroNewtonMetreSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.MicroNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to MicroNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to MicroNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to MicroNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToNanoNewtonMetreSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NanoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to NanoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to NanoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to NanoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToPicoNewtonMetreSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.PicoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to PicoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to PicoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to PicoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToFemtoNewtonMetreSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.FemtoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to FemtoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to FemtoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to FemtoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToAttoNewtonMetreSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.AttoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to AttoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to AttoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to AttoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToZeptoNewtonMetreSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZeptoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to ZeptoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to ZeptoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to ZeptoNewtonMetreSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreSecondToYoctoNewtonMetreSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.AngularMomentum.YoctoNewtonMetreSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetreSecond [SI] to YoctoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetreSecond [SI] to YoctoNewtonMetreSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetreSecond [SI] to YoctoNewtonMetreSecond [SI]");
    }

  }
}
