using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Dimensionless_Tests
  {
    [TestMethod()]
    public void ConvertFromUnityToYottaUnity()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.YottaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to YottaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to YottaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to YottaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToZettaUnity()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.ZettaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to ZettaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to ZettaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to ZettaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToExaUnity()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.ExaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to ExaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to ExaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to ExaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToPetaUnity()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.PetaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to PetaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to PetaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to PetaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToTeraUnity()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.TeraUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to TeraUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to TeraUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to TeraUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToGigaUnity()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.GigaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to GigaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to GigaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to GigaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMegaUnity()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.MegaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to MegaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to MegaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to MegaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToKiloUnity()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.KiloUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to KiloUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to KiloUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to KiloUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToHectoUnity()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.HectoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to HectoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to HectoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to HectoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToDecaUnity()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.DecaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to DecaUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to DecaUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to DecaUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToDeciUnity()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.DeciUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to DeciUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to DeciUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to DeciUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToCentiUnity()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.CentiUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to CentiUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to CentiUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to CentiUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMilliUnity()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.MilliUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to MilliUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to MilliUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to MilliUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMicroUnity()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.MicroUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to MicroUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to MicroUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to MicroUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToNanoUnity()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.NanoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to NanoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to NanoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to NanoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToPicoUnity()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.PicoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to PicoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to PicoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to PicoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToFemtoUnity()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.FemtoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to FemtoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to FemtoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to FemtoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToAttoUnity()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.AttoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to AttoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to AttoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to AttoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToZeptoUnity()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.ZeptoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to ZeptoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to ZeptoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to ZeptoUnity [SI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToYoctoUnity()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.YoctoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to YoctoUnity [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to YoctoUnity [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to YoctoUnity [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUnityToUnityOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Dimensionless.Unity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to Unity [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to Unity [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to Unity [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUnityToUnityOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [SI] to Unity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [SI] to Unity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [SI] to Unity [RSI]");
    }

  }
}
