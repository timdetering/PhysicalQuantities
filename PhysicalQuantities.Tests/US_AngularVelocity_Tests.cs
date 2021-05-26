using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_AngularVelocity_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDegreesPerSecondToDegreesPerSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.AngularVelocity.DegreesPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DegreesPerSecond [US] to DegreesPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DegreesPerSecond [US] to DegreesPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DegreesPerSecond [US] to DegreesPerSecond [Imperial]");
    }

  }
}
