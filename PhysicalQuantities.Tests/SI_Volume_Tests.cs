using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Volume_Tests
  {
    [TestMethod()]
    public void ConvertFromCubicMetreToYottaCubicMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.YottaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to YottaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to YottaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to YottaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToZettaCubicMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.ZettaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to ZettaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to ZettaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to ZettaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToExaCubicMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.ExaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to ExaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to ExaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to ExaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToPetaCubicMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.PetaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to PetaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to PetaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to PetaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToTeraCubicMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.TeraCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to TeraCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to TeraCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to TeraCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToGigaCubicMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.GigaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to GigaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to GigaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to GigaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToMegaCubicMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.MegaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to MegaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to MegaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to MegaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToKiloCubicMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.KiloCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to KiloCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to KiloCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to KiloCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToHectoCubicMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.HectoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to HectoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to HectoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to HectoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToDecaCubicMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.DecaCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to DecaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to DecaCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to DecaCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToDeciCubicMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.DeciCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to DeciCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to DeciCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to DeciCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToCentiCubicMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.CentiCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to CentiCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to CentiCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to CentiCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToMilliCubicMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.MilliCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to MilliCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to MilliCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to MilliCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToMicroCubicMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.MicroCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to MicroCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to MicroCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to MicroCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToNanoCubicMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.NanoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to NanoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to NanoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to NanoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToPicoCubicMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.PicoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to PicoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to PicoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to PicoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToFemtoCubicMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.FemtoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to FemtoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to FemtoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to FemtoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToAttoCubicMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.AttoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to AttoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to AttoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to AttoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToZeptoCubicMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.ZeptoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to ZeptoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to ZeptoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to ZeptoCubicMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromCubicMetreToYoctoCubicMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.YoctoCubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to YoctoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to YoctoCubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to YoctoCubicMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLitreToCubicMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Litre [SI] to CubicMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Litre [SI] to CubicMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Litre [SI] to CubicMetre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliLitreToLitre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.MilliLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentiLitreToLitre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CentiLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CentiLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CentiLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CentiLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDeciLitreToLitre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.DeciLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DeciLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DeciLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DeciLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecaLitreToLitre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.DecaLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DecaLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DecaLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DecaLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectoLitreToLitre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.HectoLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from HectoLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from HectoLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from HectoLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloLitreToLitre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.KiloLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloLitre [SI] to Litre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloLitre [SI] to Litre [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMetreToCubicFootOnImperial()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(353.146667214886);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to CubicFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMetreToCubicMetreOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMetre [SI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMetre [SI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMetre [SI] to CubicMetre [RSI]");
    }

  }
}
