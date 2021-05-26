using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_ElectricCapacitance_Tests
  {
    [TestMethod()]
    public void ConvertFromFaradToGigaFarad()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.GigaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to GigaFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to GigaFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to GigaFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMegaFarad()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MegaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to MegaFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to MegaFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to MegaFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToKiloFarad()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.KiloFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to KiloFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to KiloFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to KiloFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToHectoFarad()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.HectoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to HectoFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to HectoFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to HectoFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToDecaFarad()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DecaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to DecaFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to DecaFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to DecaFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToDeciFarad()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DeciFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to DeciFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to DeciFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to DeciFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToCentiFarad()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.CentiFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to CentiFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to CentiFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to CentiFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMilliFarad()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MilliFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to MilliFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to MilliFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to MilliFarad [RSI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMicroFarad()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MicroFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [RSI] to MicroFarad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [RSI] to MicroFarad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [RSI] to MicroFarad [RSI]");
    }

  }
}
