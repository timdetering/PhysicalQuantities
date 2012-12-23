using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Angle_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcminuteToDegree()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Arcminute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Degree;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcminute [Imperial] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcminute [Imperial] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcminute [Imperial] to Degree [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcsecondToArcminute()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Arcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Arcminute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcsecond [Imperial] to Arcminute [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcsecond [Imperial] to Arcminute [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcsecond [Imperial] to Arcminute [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliarcsecondToArcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Milliarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Arcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Milliarcsecond [Imperial] to Arcsecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Milliarcsecond [Imperial] to Arcsecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Milliarcsecond [Imperial] to Arcsecond [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicroarcsecondToMilliarcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Microarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Milliarcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Microarcsecond [Imperial] to Milliarcsecond [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Microarcsecond [Imperial] to Milliarcsecond [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Microarcsecond [Imperial] to Milliarcsecond [Imperial]");
    }

  }
}
