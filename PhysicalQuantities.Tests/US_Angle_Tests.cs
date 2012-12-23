using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Angle_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcminuteToDegree()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Angle.Arcminute;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Angle.Degree;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcminute [US] to Degree [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcminute [US] to Degree [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcminute [US] to Degree [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromArcsecondToArcminute()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Angle.Arcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Angle.Arcminute;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.166666666666667);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Arcsecond [US] to Arcminute [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Arcsecond [US] to Arcminute [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Arcsecond [US] to Arcminute [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliarcsecondToArcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Angle.Milliarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Angle.Arcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Milliarcsecond [US] to Arcsecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Milliarcsecond [US] to Arcsecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Milliarcsecond [US] to Arcsecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicroarcsecondToMilliarcsecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Angle.Microarcsecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Angle.Milliarcsecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Microarcsecond [US] to Milliarcsecond [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Microarcsecond [US] to Milliarcsecond [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Microarcsecond [US] to Milliarcsecond [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDegreeToDegreeOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Angle.Degree;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Angle.Degree;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Degree [US] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Degree [US] to Degree [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Degree [US] to Degree [Imperial]");
    }

  }
}
