using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Pressure_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPoundPerSquareInchToPoundPerSquareFoot()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareInch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1440);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from PoundPerSquareInch [Imperial] to PoundPerSquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from PoundPerSquareInch [Imperial] to PoundPerSquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from PoundPerSquareInch [Imperial] to PoundPerSquareFoot [Imperial]");
    }

  }
}
