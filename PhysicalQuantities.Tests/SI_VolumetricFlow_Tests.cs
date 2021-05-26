using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_VolumetricFlow_Tests
  {
    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToYottaCubicMetrePerSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YottaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to YottaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to YottaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to YottaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToZettaCubicMetrePerSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZettaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to ZettaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to ZettaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to ZettaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToExaCubicMetrePerSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ExaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to ExaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to ExaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to ExaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToPetaCubicMetrePerSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PetaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to PetaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to PetaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to PetaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToTeraCubicMetrePerSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.TeraCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to TeraCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to TeraCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to TeraCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToGigaCubicMetrePerSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.GigaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to GigaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to GigaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to GigaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToMegaCubicMetrePerSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MegaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to MegaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to MegaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to MegaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToKiloCubicMetrePerSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.KiloCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to KiloCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to KiloCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to KiloCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToHectoCubicMetrePerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.HectoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to HectoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to HectoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to HectoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToDecaCubicMetrePerSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DecaCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to DecaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to DecaCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to DecaCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToDeciCubicMetrePerSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DeciCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to DeciCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to DeciCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to DeciCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToCentiCubicMetrePerSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CentiCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to CentiCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to CentiCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to CentiCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToMilliCubicMetrePerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MilliCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to MilliCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to MilliCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to MilliCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToMicroCubicMetrePerSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MicroCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to MicroCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to MicroCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to MicroCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToNanoCubicMetrePerSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.NanoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to NanoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to NanoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to NanoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToPicoCubicMetrePerSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PicoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to PicoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to PicoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to PicoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToFemtoCubicMetrePerSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.FemtoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to FemtoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to FemtoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to FemtoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToAttoCubicMetrePerSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.AttoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to AttoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to AttoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to AttoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToZeptoCubicMetrePerSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZeptoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to ZeptoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to ZeptoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to ZeptoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetrePerSecondToYoctoCubicMetrePerSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YoctoCubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to YoctoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to YoctoCubicMetrePerSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to YoctoCubicMetrePerSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMetrePerSecondToCubicFootPerSecondOnImperial()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(353.146667214886);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to CubicFootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to CubicFootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to CubicFootPerSecond [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMetrePerSecondToCubicMetrePerSecondOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetrePerSecond [SI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetrePerSecond [SI] to CubicMetrePerSecond [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetrePerSecond [SI] to CubicMetrePerSecond [RSI]");
    }

  }
}
