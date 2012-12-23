using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Length_Tests
  {
    [TestMethod()]
    public void ConvertFromMetreToGigaMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.GigaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to GigaMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to GigaMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to GigaMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMegaMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.MegaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to MegaMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to MegaMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to MegaMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToKiloMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.KiloMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to KiloMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to KiloMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to KiloMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToHectoMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.HectoMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to HectoMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to HectoMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to HectoMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToDecaMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.DecaMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to DecaMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to DecaMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to DecaMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToDeciMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.DeciMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to DeciMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to DeciMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to DeciMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToCentiMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.CentiMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to CentiMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to CentiMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to CentiMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMilliMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.MilliMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to MilliMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to MilliMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to MilliMetre [RSI]");
    }

    [TestMethod()]
    public void ConvertFromMetreToMicroMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Length.Metre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Length.MicroMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Metre [RSI] to MicroMetre [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Metre [RSI] to MicroMetre [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Metre [RSI] to MicroMetre [RSI]");
    }

  }
}
