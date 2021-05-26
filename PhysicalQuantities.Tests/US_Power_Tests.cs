using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Power_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPoundPerMinuteToFootPoundPerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.FootPoundPerMinute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPoundPerMinute [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPoundPerMinute [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPoundPerMinute [US] to FootPoundPerSecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBritishThermalUnitPerHourToFootPoundPerSecond()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.BritishThermalUnitPerHour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(21.616020061956);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BritishThermalUnitPerHour [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BritishThermalUnitPerHour [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BritishThermalUnitPerHour [US] to FootPoundPerSecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHorsepowerToFootPoundPerSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.Horsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5500);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Horsepower [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Horsepower [US] to FootPoundPerSecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Horsepower [US] to FootPoundPerSecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMechanicalHorsepowerToHorsepower()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.MechanicalHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Power.Horsepower;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MechanicalHorsepower [US] to Horsepower [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MechanicalHorsepower [US] to Horsepower [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MechanicalHorsepower [US] to Horsepower [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBoilerHorsepowerToMechanicalHorsepower()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.BoilerHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Power.MechanicalHorsepower;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(131.547556865704);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BoilerHorsepower [US] to MechanicalHorsepower [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BoilerHorsepower [US] to MechanicalHorsepower [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BoilerHorsepower [US] to MechanicalHorsepower [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPoundPerSecondToFootPoundPerSecondOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPoundPerSecond [US] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPoundPerSecond [US] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPoundPerSecond [US] to FootPoundPerSecond [Imperial]");
    }

  }
}
