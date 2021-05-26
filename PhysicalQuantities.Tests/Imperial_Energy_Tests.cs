using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Energy_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBritishThermalUnitToFootPoundForce()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.BritishThermalUnit;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(7800);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BritishThermalUnit [Imperial] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BritishThermalUnit [Imperial] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BritishThermalUnit [Imperial] to FootPoundForce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHorsePowerHourToFootPoundForce()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.HorsePowerHour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(19803331.4153351);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from HorsePowerHour [Imperial] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from HorsePowerHour [Imperial] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from HorsePowerHour [Imperial] to FootPoundForce [Imperial]");
    }

  }
}
