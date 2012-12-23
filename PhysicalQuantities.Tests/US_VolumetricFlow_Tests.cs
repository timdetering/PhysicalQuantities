using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_VolumetricFlow_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicFootPerSecondToCubicFootPerSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.VolumetricFlow.CubicFootPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicFootPerSecond [US] to CubicFootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicFootPerSecond [US] to CubicFootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicFootPerSecond [US] to CubicFootPerSecond [Imperial]");
    }

  }
}
