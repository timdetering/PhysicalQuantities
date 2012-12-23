using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Angle_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDegreeToRadian()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Angle.Degree;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Angle.Radian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.174532925199433);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Degree [RSI] to Radian [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Degree [RSI] to Radian [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Degree [RSI] to Radian [RSI]");
    }

  }
}
