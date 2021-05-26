using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Energy_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPoundalToFootPoundForce()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.FootPoundal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.310812804248414);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPoundal [US] to FootPoundForce [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPoundal [US] to FootPoundForce [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPoundal [US] to FootPoundForce [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBritishThermalUnitToFootPoundForce()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(7800);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BritishThermalUnit [US] to FootPoundForce [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BritishThermalUnit [US] to FootPoundForce [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BritishThermalUnit [US] to FootPoundForce [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBritishThermalUnitThermochemicalToBritishThermalUnit()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitThermochemical;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(9.99330841206533);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BritishThermalUnitThermochemical [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BritishThermalUnitThermochemical [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BritishThermalUnitThermochemical [US] to BritishThermalUnit [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBritishThermalUnitMeanToBritishThermalUnit()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitMean;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10.0077152302816);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BritishThermalUnitMean [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BritishThermalUnitMean [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BritishThermalUnitMean [US] to BritishThermalUnit [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromThermToBritishThermalUnit()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.Therm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Therm [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Therm [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Therm [US] to BritishThermalUnit [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromWattHourToBritishThermalUnit()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.WattHour;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(34.1214115648838);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from WattHour [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from WattHour [US] to BritishThermalUnit [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from WattHour [US] to BritishThermalUnit [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFootPoundForceToFootPoundForceOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FootPoundForce [US] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FootPoundForce [US] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FootPoundForce [US] to FootPoundForce [Imperial]");
    }

  }
}
