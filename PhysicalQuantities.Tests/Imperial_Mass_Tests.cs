using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Mass_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromOunceToPound()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Ounce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.625);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ounce [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ounce [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ounce [Imperial] to Pound [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDrachmToOunce()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Drachm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Ounce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.625);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Drachm [Imperial] to Ounce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Drachm [Imperial] to Ounce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Drachm [Imperial] to Ounce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGrainToPound()
    {
      double delta = 1E-11;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Grain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.00142857142857143);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Grain [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Grain [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Grain [Imperial] to Pound [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromStoneToPound()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Stone;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(140);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Stone [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Stone [Imperial] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Stone [Imperial] to Pound [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromQuarterToStone()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Quarter;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Stone;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Quarter [Imperial] to Stone [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Quarter [Imperial] to Stone [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Quarter [Imperial] to Stone [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHundredweightToQuarter()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Hundredweight;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Quarter;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hundredweight [Imperial] to Quarter [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hundredweight [Imperial] to Quarter [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hundredweight [Imperial] to Quarter [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTonToHundredweight()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Ton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Hundredweight;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(200);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ton [Imperial] to Hundredweight [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ton [Imperial] to Hundredweight [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ton [Imperial] to Hundredweight [Imperial]");
    }

  }
}
