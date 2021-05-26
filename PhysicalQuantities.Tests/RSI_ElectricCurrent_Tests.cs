using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_ElectricCurrent_Tests
  {
    [TestMethod()]
    public void ConvertFromAmpereToGigaAmpere()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.GigaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to GigaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to GigaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to GigaAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMegaAmpere()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MegaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to MegaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to MegaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to MegaAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToKiloAmpere()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.KiloAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to KiloAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to KiloAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to KiloAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToHectoAmpere()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.HectoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to HectoAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to HectoAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to HectoAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToDecaAmpere()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DecaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to DecaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to DecaAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to DecaAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToDeciAmpere()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DeciAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to DeciAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to DeciAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to DeciAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToCentiAmpere()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.CentiAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to CentiAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to CentiAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to CentiAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMilliAmpere()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MilliAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to MilliAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to MilliAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to MilliAmpere [RSI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMicroAmpere()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MicroAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [RSI] to MicroAmpere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [RSI] to MicroAmpere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [RSI] to MicroAmpere [RSI]");
    }

  }
}
