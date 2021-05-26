using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Mass_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromOunceToPound()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Ounce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.625);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ounce [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ounce [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ounce [US] to Pound [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDramToOunce()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Dram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Ounce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.625);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Dram [US] to Ounce [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Dram [US] to Ounce [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Dram [US] to Ounce [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGrainToPound()
    {
      double delta = 1E-11;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Grain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.00142857142857143);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Grain [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Grain [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Grain [US] to Pound [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHundredweightToPound()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Hundredweight;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hundredweight [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hundredweight [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hundredweight [US] to Pound [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLongHundredweightToPound()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.LongHundredweight;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1120);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from LongHundredweight [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from LongHundredweight [US] to Pound [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from LongHundredweight [US] to Pound [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromShortTonToHundredweight()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.ShortTon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Hundredweight;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(200);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ShortTon [US] to Hundredweight [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ShortTon [US] to Hundredweight [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ShortTon [US] to Hundredweight [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLongTonToLongHundredweight()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.LongTon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.LongHundredweight;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(200);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from LongTon [US] to LongHundredweight [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from LongTon [US] to LongHundredweight [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from LongTon [US] to LongHundredweight [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPennyweightToGrain()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Pennyweight;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Grain;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(240);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pennyweight [US] to Grain [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pennyweight [US] to Grain [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pennyweight [US] to Grain [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTroyOunceToPennyweight()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.TroyOunce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.Pennyweight;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(200);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from TroyOunce [US] to Pennyweight [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from TroyOunce [US] to Pennyweight [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from TroyOunce [US] to Pennyweight [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTroyPoundToTroyOunce()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.TroyPound;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Mass.TroyOunce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(120);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from TroyPound [US] to TroyOunce [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from TroyPound [US] to TroyOunce [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from TroyPound [US] to TroyOunce [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPoundToPoundOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Mass.Pound;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pound [US] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pound [US] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pound [US] to Pound [Imperial]");
    }

  }
}
