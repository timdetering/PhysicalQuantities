using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Time_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMinuteToSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Minute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Minute [Imperial] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Minute [Imperial] to Second [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Minute [Imperial] to Second [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHourToMinute()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Hour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Minute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hour [Imperial] to Minute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hour [Imperial] to Minute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hour [Imperial] to Minute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDayToHour()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Day;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Time.Hour;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(240);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Day [Imperial] to Hour [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Day [Imperial] to Hour [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Day [Imperial] to Hour [Imperial]");
    }

  }
}
