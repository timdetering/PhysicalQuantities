using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Momentum_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonSecondToYottaNewtonSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.YottaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to YottaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to YottaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to YottaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToZettaNewtonSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.ZettaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to ZettaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to ZettaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to ZettaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToExaNewtonSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.ExaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to ExaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to ExaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to ExaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToPetaNewtonSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.PetaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to PetaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to PetaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to PetaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToTeraNewtonSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.TeraNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to TeraNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to TeraNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to TeraNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToGigaNewtonSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.GigaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to GigaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to GigaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to GigaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToMegaNewtonSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.MegaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to MegaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to MegaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to MegaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToKiloNewtonSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.KiloNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to KiloNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to KiloNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to KiloNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToHectoNewtonSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.HectoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to HectoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to HectoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to HectoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToDecaNewtonSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.DecaNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to DecaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to DecaNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to DecaNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToDeciNewtonSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.DeciNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to DeciNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to DeciNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to DeciNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToCentiNewtonSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.CentiNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to CentiNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to CentiNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to CentiNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToMilliNewtonSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.MilliNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to MilliNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to MilliNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to MilliNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToMicroNewtonSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.MicroNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to MicroNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to MicroNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to MicroNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToNanoNewtonSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NanoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to NanoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to NanoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to NanoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToPicoNewtonSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.PicoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to PicoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to PicoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to PicoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToFemtoNewtonSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.FemtoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to FemtoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to FemtoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to FemtoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToAttoNewtonSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.AttoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to AttoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to AttoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to AttoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToZeptoNewtonSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.ZeptoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to ZeptoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to ZeptoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to ZeptoNewtonSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonSecondToYoctoNewtonSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Momentum.YoctoNewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to YoctoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to YoctoNewtonSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to YoctoNewtonSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNewtonSecondToNewtonSecondOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Momentum.NewtonSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonSecond [SI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonSecond [SI] to NewtonSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonSecond [SI] to NewtonSecond [RSI]");
    }

  }
}
