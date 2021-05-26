using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_ElectricResistance_Tests
  {
    [TestMethod()]
    public void ConvertFromOhmToGigaOhm()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.GigaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to GigaOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to GigaOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to GigaOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMegaOhm()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MegaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to MegaOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to MegaOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to MegaOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToKiloOhm()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.KiloOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to KiloOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to KiloOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to KiloOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToHectoOhm()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.HectoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to HectoOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to HectoOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to HectoOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToDecaOhm()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DecaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to DecaOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to DecaOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to DecaOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToDeciOhm()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DeciOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to DeciOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to DeciOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to DeciOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToCentiOhm()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.CentiOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to CentiOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to CentiOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to CentiOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMilliOhm()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MilliOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to MilliOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to MilliOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to MilliOhm [RSI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMicroOhm()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MicroOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [RSI] to MicroOhm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [RSI] to MicroOhm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [RSI] to MicroOhm [RSI]");
    }

  }
}
