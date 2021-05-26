using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Speed_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilePerHourToFootPerSecond()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Speed.MilePerHour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(14.6666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilePerHour [US] to FootPerSecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilePerHour [US] to FootPerSecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilePerHour [US] to FootPerSecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKnotToFootPerSecond()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Speed.Knot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(16.8781);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Knot [US] to FootPerSecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Knot [US] to FootPerSecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Knot [US] to FootPerSecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPerSecondToFootPerSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPerSecond [US] to FootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPerSecond [US] to FootPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPerSecond [US] to FootPerSecond [Imperial]");
    }

  }
}
