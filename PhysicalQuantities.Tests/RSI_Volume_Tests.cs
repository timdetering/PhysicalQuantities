using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Volume_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicKiloMetreToCubicMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicKiloMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicKiloMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicKiloMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicKiloMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicHectoMetreToCubicMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicHectoMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicHectoMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicHectoMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicHectoMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicDecaMetreToCubicMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicDecaMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicDecaMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicDecaMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicDecaMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicDeciMetreToCubicMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicDeciMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicDeciMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicDeciMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicDeciMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicCentiMetreToCubicMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicCentiMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicCentiMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicCentiMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicCentiMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMilliMetreToCubicMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMilliMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMilliMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMilliMetre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMilliMetre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLitreToCubicMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Litre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Litre [RSI] to CubicMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Litre [RSI] to CubicMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliLitreToLitre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.MilliLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliLitre [RSI] to Litre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentiLitreToLitre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.CentiLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CentiLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CentiLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CentiLitre [RSI] to Litre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDeciLitreToLitre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.DeciLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DeciLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DeciLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DeciLitre [RSI] to Litre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecaLitreToLitre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.DecaLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DecaLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DecaLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DecaLitre [RSI] to Litre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectoLitreToLitre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.HectoLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from HectoLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from HectoLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from HectoLitre [RSI] to Litre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloLitreToLitre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Volume.KiloLitre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Volume.Litre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloLitre [RSI] to Litre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloLitre [RSI] to Litre [RSI]");
    }

  }
}
