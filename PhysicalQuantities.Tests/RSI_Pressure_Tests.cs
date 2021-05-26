using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Pressure_Tests
  {
    [TestMethod()]
    public void ConvertFromPascalToGigaPascal()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.GigaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to GigaPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to GigaPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to GigaPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMegaPascal()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.MegaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to MegaPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to MegaPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to MegaPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToKiloPascal()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.KiloPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to KiloPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to KiloPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to KiloPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToHectoPascal()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.HectoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to HectoPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to HectoPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to HectoPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToDecaPascal()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.DecaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to DecaPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to DecaPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to DecaPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToDeciPascal()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.DeciPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to DeciPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to DeciPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to DeciPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToCentiPascal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.CentiPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to CentiPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to CentiPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to CentiPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMilliPascal()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.MilliPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to MilliPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to MilliPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to MilliPascal [RSI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMicroPascal()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.MicroPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [RSI] to MicroPascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [RSI] to MicroPascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [RSI] to MicroPascal [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBarToPascal()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Bar;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Bar [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Bar [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Bar [RSI] to Pascal [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliBarToBar()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.MilliBar;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Bar;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliBar [RSI] to Bar [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliBar [RSI] to Bar [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliBar [RSI] to Bar [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAtmosphereToPascal()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Atmosphere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1013250);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Atmosphere [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Atmosphere [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Atmosphere [RSI] to Pascal [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMillimetreOfMercuryToPascal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.MillimetreOfMercury;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1333.22387415);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MillimetreOfMercury [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MillimetreOfMercury [RSI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MillimetreOfMercury [RSI] to Pascal [RSI]");
    }

  }
}
