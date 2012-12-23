using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Voltage_Tests
  {
    [TestMethod()]
    public void ConvertFromVoltToGigaVolt()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.GigaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to GigaVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to GigaVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to GigaVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMegaVolt()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.MegaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to MegaVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to MegaVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to MegaVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToKiloVolt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.KiloVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to KiloVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to KiloVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to KiloVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToHectoVolt()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.HectoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to HectoVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to HectoVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to HectoVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToDecaVolt()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.DecaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to DecaVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to DecaVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to DecaVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToDeciVolt()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.DeciVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to DeciVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to DeciVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to DeciVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToCentiVolt()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.CentiVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to CentiVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to CentiVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to CentiVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMilliVolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.MilliVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to MilliVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to MilliVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to MilliVolt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMicroVolt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.MicroVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [RSI] to MicroVolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [RSI] to MicroVolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [RSI] to MicroVolt [RSI]");
    }

  }
}
