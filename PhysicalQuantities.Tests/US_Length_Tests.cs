using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Length_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromInchToFoot()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Inch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.833333333333333);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Inch [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Inch [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Inch [US] to Foot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPicaToInch()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Pica;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Inch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.66666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pica [US] to Inch [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pica [US] to Inch [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pica [US] to Inch [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPointToPica()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Point;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Pica;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.833333333333333);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Point [US] to Pica [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Point [US] to Pica [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Point [US] to Pica [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromYardToFoot()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Yard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Yard [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Yard [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Yard [US] to Foot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMileToFoot()
    {
      double delta = 1E-3;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Mile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(52800);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mile [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mile [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mile [US] to Foot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLinkToFoot()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Link;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(6.6);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Link [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Link [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Link [US] to Foot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootSurveyToFoot()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.FootSurvey;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10.0000200131234);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootSurvey [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootSurvey [US] to Foot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootSurvey [US] to Foot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromRodToLink()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Rod;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Link;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(250);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Rod [US] to Link [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Rod [US] to Link [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Rod [US] to Link [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromChainToRod()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Chain;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Rod;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Chain [US] to Rod [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Chain [US] to Rod [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Chain [US] to Rod [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFurlongToChain()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Furlong;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Chain;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Furlong [US] to Chain [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Furlong [US] to Chain [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Furlong [US] to Chain [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMileSurveyToFurlong()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.MileSurvey;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Furlong;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(80);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MileSurvey [US] to Furlong [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MileSurvey [US] to Furlong [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MileSurvey [US] to Furlong [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromLeagueToMileSurvey()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.League;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.MileSurvey;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from League [US] to MileSurvey [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from League [US] to MileSurvey [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from League [US] to MileSurvey [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFathomToYard()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Fathom;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Yard;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Fathom [US] to Yard [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Fathom [US] to Yard [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Fathom [US] to Yard [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCableToFathom()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Cable;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Fathom;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1200);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Cable [US] to Fathom [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Cable [US] to Fathom [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Cable [US] to Fathom [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNauticalMileToCable()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.NauticalMile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Length.Cable;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(84.4);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NauticalMile [US] to Cable [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NauticalMile [US] to Cable [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NauticalMile [US] to Cable [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootToFootOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Length.Foot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Length.Foot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Foot [US] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Foot [US] to Foot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Foot [US] to Foot [Imperial]");
    }

  }
}
