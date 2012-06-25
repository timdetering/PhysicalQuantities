using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Frequency_Tests
  {
    [TestMethod()]
    public void ConvertFromHertzToGigaHertz()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.GigaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to GigaHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to GigaHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to GigaHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMegaHertz()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.MegaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to MegaHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to MegaHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to MegaHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToKiloHertz()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.KiloHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to KiloHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to KiloHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to KiloHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToHectoHertz()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.HectoHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to HectoHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to HectoHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to HectoHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToDecaHertz()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.DecaHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to DecaHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to DecaHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to DecaHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToDeciHertz()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.DeciHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to DeciHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to DeciHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to DeciHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToCentiHertz()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.CentiHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to CentiHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to CentiHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to CentiHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMilliHertz()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.MilliHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to MilliHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to MilliHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to MilliHertz [RSI]");
    }

    [TestMethod()]
    public void ConvertFromHertzToMicroHertz()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Frequency.MicroHertz;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hertz [RSI] to MicroHertz [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hertz [RSI] to MicroHertz [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hertz [RSI] to MicroHertz [RSI]");
    }

  }
}
