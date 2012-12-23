using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Power_Tests
  {
    [TestMethod()]
    public void ConvertFromWattToGigaWatt()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.GigaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to GigaWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to GigaWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to GigaWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMegaWatt()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.MegaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to MegaWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to MegaWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to MegaWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToKiloWatt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.KiloWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to KiloWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to KiloWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to KiloWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToHectoWatt()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.HectoWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to HectoWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to HectoWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to HectoWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToDecaWatt()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.DecaWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to DecaWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to DecaWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to DecaWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToDeciWatt()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.DeciWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to DeciWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to DeciWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to DeciWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToCentiWatt()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.CentiWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to CentiWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to CentiWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to CentiWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMilliWatt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.MilliWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to MilliWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to MilliWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to MilliWatt [RSI]");
    }

    [TestMethod()]
    public void ConvertFromWattToMicroWatt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.MicroWatt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Watt [RSI] to MicroWatt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Watt [RSI] to MicroWatt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Watt [RSI] to MicroWatt [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeraWattToWatt()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Power.TeraWatt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Power.Watt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from TeraWatt [RSI] to Watt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from TeraWatt [RSI] to Watt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from TeraWatt [RSI] to Watt [RSI]");
    }

  }
}
