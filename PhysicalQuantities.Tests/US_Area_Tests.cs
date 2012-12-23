using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Area_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareInchToSquareFoot()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareInch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.0694444444444444);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareInch [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareInch [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareInch [US] to SquareFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareYardToSquareFoot()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareYard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(90);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareYard [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareYard [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareYard [US] to SquareFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareFootSurveyToSquareFoot()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFootSurvey;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10.0000400262868);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareFootSurvey [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareFootSurvey [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareFootSurvey [US] to SquareFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareChainToSquareFoot()
    {
      double delta = 1E-3;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareChain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(43560);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareChain [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareChain [US] to SquareFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareChain [US] to SquareFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAcreToSquareChain()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.Acre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.SquareChain;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Acre [US] to SquareChain [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Acre [US] to SquareChain [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Acre [US] to SquareChain [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSectionToAcre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.Section;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.Acre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(6400);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Section [US] to Acre [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Section [US] to Acre [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Section [US] to Acre [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMileSurveyToSection()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareMileSurvey;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.Section;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMileSurvey [US] to Section [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMileSurvey [US] to Section [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMileSurvey [US] to Section [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSurveyTownshipToSection()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SurveyTownship;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Area.Section;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(360);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SurveyTownship [US] to Section [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SurveyTownship [US] to Section [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SurveyTownship [US] to Section [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareFootToSquareFootOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Area.SquareFoot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareFoot [US] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareFoot [US] to SquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareFoot [US] to SquareFoot [Imperial]");
    }

  }
}
