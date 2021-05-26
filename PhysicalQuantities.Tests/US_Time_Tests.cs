using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Time_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMinuteToSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Time.Minute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Minute [US] to Second [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Minute [US] to Second [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Minute [US] to Second [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHourToMinute()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Time.Hour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Time.Minute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hour [US] to Minute [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hour [US] to Minute [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hour [US] to Minute [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDayToHour()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Time.Day;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Time.Hour;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(240);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Day [US] to Hour [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Day [US] to Hour [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Day [US] to Hour [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSecondToSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Time.Second;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Second [US] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Second [US] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Second [US] to Second [Imperial]");
    }

  }
}
