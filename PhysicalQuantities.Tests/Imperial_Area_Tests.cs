using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Area_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareInchToSquareFoot()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareInch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.0694444444444444);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareInch [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareInch [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareInch [Imperial] to SquareFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareThouToSquareInch()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareThou;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareThou [Imperial] to SquareInch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareThou [Imperial] to SquareInch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareThou [Imperial] to SquareInch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareYardToSquareFoot()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareYard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(90);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareYard [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareYard [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareYard [Imperial] to SquareFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareChainToSquareYard()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareChain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareYard;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(4840);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareChain [Imperial] to SquareYard [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareChain [Imperial] to SquareYard [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareChain [Imperial] to SquareYard [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareFurlongToSquareChain()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFurlong;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareChain;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareFurlong [Imperial] to SquareChain [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareFurlong [Imperial] to SquareChain [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareFurlong [Imperial] to SquareChain [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMileToSquareFurlong()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareMile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFurlong;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(640);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMile [Imperial] to SquareFurlong [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMile [Imperial] to SquareFurlong [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMile [Imperial] to SquareFurlong [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareLeagueToSquareMile()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareLeague;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareMile;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(90);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareLeague [Imperial] to SquareMile [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareLeague [Imperial] to SquareMile [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareLeague [Imperial] to SquareMile [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareFathomToSquareFoot()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFathom;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(369.664);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareFathom [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareFathom [Imperial] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareFathom [Imperial] to SquareFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareCableToSquareFathom()
    {
      double delta = 1E-3;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareCable;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFathom;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareCable [Imperial] to SquareFathom [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareCable [Imperial] to SquareFathom [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareCable [Imperial] to SquareFathom [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareNauticalMileToSquareCable()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareNauticalMile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareCable;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareNauticalMile [Imperial] to SquareCable [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareNauticalMile [Imperial] to SquareCable [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareNauticalMile [Imperial] to SquareCable [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareLinkToSquareInch()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareLink;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(627.264);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareLink [Imperial] to SquareInch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareLink [Imperial] to SquareInch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareLink [Imperial] to SquareInch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareRodToSquareLink()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareRod;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareLink;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(6250);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareRod [Imperial] to SquareLink [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareRod [Imperial] to SquareLink [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareRod [Imperial] to SquareLink [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPerchToSquareRod()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Perch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareRod;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Perch [Imperial] to SquareRod [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Perch [Imperial] to SquareRod [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Perch [Imperial] to SquareRod [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRoodToPerch()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Rood;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Perch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(400);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Rood [Imperial] to Perch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Rood [Imperial] to Perch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Rood [Imperial] to Perch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAcreToRood()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Acre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Rood;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Acre [Imperial] to Rood [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Acre [Imperial] to Rood [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Acre [Imperial] to Rood [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPoleToSquareYard()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Area.Pole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareYard;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(302.5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pole [Imperial] to SquareYard [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pole [Imperial] to SquareYard [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pole [Imperial] to SquareYard [Imperial]");
    }

  }
}
