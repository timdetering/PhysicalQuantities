using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Area_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAreToSquareMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.Are;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Are [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Are [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Are [RSI] to SquareMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentiareToSquareMetre()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.Centiare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Centiare [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Centiare [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Centiare [RSI] to SquareMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecareToAre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.Decare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.Are;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decare [RSI] to Are [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decare [RSI] to Are [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decare [RSI] to Are [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectareToAre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.Hectare;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.Are;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hectare [RSI] to Are [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hectare [RSI] to Are [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hectare [RSI] to Are [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareKilometreToSquareMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareKilometre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareKilometre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareKilometre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareKilometre [RSI] to SquareMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareCentimetreToSquareMetre()
    {
      double delta = 1E-11;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareCentimetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.001);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareCentimetre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareCentimetre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareCentimetre [RSI] to SquareMetre [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSquareMillimetreToSquareMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMillimetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from SquareMillimetre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from SquareMillimetre [RSI] to SquareMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from SquareMillimetre [RSI] to SquareMetre [RSI]");
    }

  }
}
