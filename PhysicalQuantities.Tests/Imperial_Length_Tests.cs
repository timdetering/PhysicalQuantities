using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Length_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromInchToFoot()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Inch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.833333333333333);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Inch [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Inch [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Inch [Imperial] to Foot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromThouToInch()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Thou;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Inch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Thou [Imperial] to Inch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Thou [Imperial] to Inch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Thou [Imperial] to Inch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromYardToFoot()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Yard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Yard [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Yard [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Yard [Imperial] to Foot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromChainToYard()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Chain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Yard;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(220);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Chain [Imperial] to Yard [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Chain [Imperial] to Yard [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Chain [Imperial] to Yard [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFurlongToChain()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Furlong;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Chain;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Furlong [Imperial] to Chain [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Furlong [Imperial] to Chain [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Furlong [Imperial] to Chain [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMileToFurlong()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Mile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Furlong;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(80);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mile [Imperial] to Furlong [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mile [Imperial] to Furlong [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mile [Imperial] to Furlong [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLeagueToMile()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.League;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Mile;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from League [Imperial] to Mile [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from League [Imperial] to Mile [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from League [Imperial] to Mile [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFathomToFoot()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Fathom;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(60.8);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Fathom [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Fathom [Imperial] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Fathom [Imperial] to Foot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCableToFathom()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Cable;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Fathom;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Cable [Imperial] to Fathom [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Cable [Imperial] to Fathom [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Cable [Imperial] to Fathom [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNauticalMileToCable()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.NauticalMile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Cable;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NauticalMile [Imperial] to Cable [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NauticalMile [Imperial] to Cable [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NauticalMile [Imperial] to Cable [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLinkToInch()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Link;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Inch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(79.2);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Link [Imperial] to Inch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Link [Imperial] to Inch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Link [Imperial] to Inch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRodToLink()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Rod;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Link;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(250);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Rod [Imperial] to Link [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Rod [Imperial] to Link [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Rod [Imperial] to Link [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPerchToRod()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Perch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Rod;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Perch [Imperial] to Rod [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Perch [Imperial] to Rod [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Perch [Imperial] to Rod [Imperial]");
    }

  }
}
