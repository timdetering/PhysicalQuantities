using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Mass_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGramToKilogram()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gram [RSI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gram [RSI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gram [RSI] to Kilogram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectogramToGram()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Hectogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hectogram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hectogram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hectogram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecagramToGram()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Decagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decagram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decagram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decagram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecigramToGram()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Decigram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decigram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decigram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decigram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentigramToGram()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Centigram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Centigram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Centigram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Centigram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilligramToGram()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Milligram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Milligram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Milligram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Milligram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicrogramToGram()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Microgram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Microgram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Microgram [RSI] to Gram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Microgram [RSI] to Gram [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTonneToKilogram()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Tonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tonne [RSI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tonne [RSI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tonne [RSI] to Kilogram [RSI]");
    }

  }
}
