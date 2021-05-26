using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Time_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliSecondToSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Time.MilliSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliSecond [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliSecond [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliSecond [RSI] to Second [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicroSecondToSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Time.MicroSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MicroSecond [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MicroSecond [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MicroSecond [RSI] to Second [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMinuteToSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Time.Minute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Second;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Minute [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Minute [RSI] to Second [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Minute [RSI] to Second [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHourToMinute()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Time.Hour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Minute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hour [RSI] to Minute [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hour [RSI] to Minute [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hour [RSI] to Minute [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDayToHour()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Time.Day;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Time.Hour;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(240);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Day [RSI] to Hour [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Day [RSI] to Hour [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Day [RSI] to Hour [RSI]");
    }

  }
}
