using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Force_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonToYottaNewton()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.YottaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to YottaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to YottaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to YottaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToZettaNewton()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.ZettaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to ZettaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to ZettaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to ZettaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToExaNewton()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.ExaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to ExaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to ExaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to ExaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToPetaNewton()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.PetaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to PetaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to PetaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to PetaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToTeraNewton()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.TeraNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to TeraNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to TeraNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to TeraNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToGigaNewton()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.GigaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to GigaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to GigaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to GigaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToMegaNewton()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.MegaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to MegaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to MegaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to MegaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToKiloNewton()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.KiloNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to KiloNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to KiloNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to KiloNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToHectoNewton()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.HectoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to HectoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to HectoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to HectoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToDecaNewton()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.DecaNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to DecaNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to DecaNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to DecaNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToDeciNewton()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.DeciNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to DeciNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to DeciNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to DeciNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToCentiNewton()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.CentiNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to CentiNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to CentiNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to CentiNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToMilliNewton()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.MilliNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to MilliNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to MilliNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to MilliNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToMicroNewton()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.MicroNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to MicroNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to MicroNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to MicroNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToNanoNewton()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.NanoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to NanoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to NanoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to NanoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToPicoNewton()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.PicoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to PicoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to PicoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to PicoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToFemtoNewton()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.FemtoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to FemtoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to FemtoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to FemtoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToAttoNewton()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.AttoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to AttoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to AttoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to AttoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToZeptoNewton()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.ZeptoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to ZeptoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to ZeptoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to ZeptoNewton [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonToYoctoNewton()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Force.YoctoNewton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to YoctoNewton [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to YoctoNewton [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to YoctoNewton [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNewtonToPoundForceOnImperial()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Force.PoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2.24808943870962);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to PoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to PoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to PoundForce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNewtonToNewtonOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Force.Newton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Force.Newton;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Newton [SI] to Newton [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Newton [SI] to Newton [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Newton [SI] to Newton [RSI]");
    }

  }
}
