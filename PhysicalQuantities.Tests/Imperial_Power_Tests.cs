using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Power_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPoundPerMinuteToFootPoundPerSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPoundPerMinute [Imperial] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPoundPerMinute [Imperial] to FootPoundPerSecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPoundPerMinute [Imperial] to FootPoundPerSecond [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHorsepowerToFootPoundPerMinute()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.Horsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(330000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Horsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Horsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Horsepower [Imperial] to FootPoundPerMinute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMechanicalHorsepowerToHorsepower()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.MechanicalHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.Horsepower;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MechanicalHorsepower [Imperial] to Horsepower [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MechanicalHorsepower [Imperial] to Horsepower [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MechanicalHorsepower [Imperial] to Horsepower [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMetricHorsepowerToFootPoundPerMinute()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.MetricHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(325485.623122113);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MetricHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MetricHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MetricHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromElectricalHorsepowerToFootPoundPerMinute()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.ElectricalHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(330132.817831569);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ElectricalHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ElectricalHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ElectricalHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBoilerHorsepowerToFootPoundPerMinute()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.BoilerHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(4341069.5395694);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BoilerHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BoilerHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BoilerHorsepower [Imperial] to FootPoundPerMinute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHidraulicHorsepowerToHorsepower()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Power.HidraulicHorsepower;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Power.Horsepower;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from HidraulicHorsepower [Imperial] to Horsepower [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from HidraulicHorsepower [Imperial] to Horsepower [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from HidraulicHorsepower [Imperial] to Horsepower [Imperial]");
    }

  }
}
