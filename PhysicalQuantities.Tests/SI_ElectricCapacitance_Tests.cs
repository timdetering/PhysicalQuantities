using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_ElectricCapacitance_Tests
  {
    [TestMethod()]
    public void ConvertFromFaradToYottaFarad()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YottaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to YottaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to YottaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to YottaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToZettaFarad()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZettaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to ZettaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to ZettaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to ZettaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToExaFarad()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ExaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to ExaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to ExaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to ExaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToPetaFarad()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PetaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to PetaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to PetaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to PetaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToTeraFarad()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.TeraFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to TeraFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to TeraFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to TeraFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToGigaFarad()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.GigaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to GigaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to GigaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to GigaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMegaFarad()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MegaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to MegaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to MegaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to MegaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToKiloFarad()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.KiloFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to KiloFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to KiloFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to KiloFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToHectoFarad()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.HectoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to HectoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to HectoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to HectoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToDecaFarad()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DecaFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to DecaFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to DecaFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to DecaFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToDeciFarad()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DeciFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to DeciFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to DeciFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to DeciFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToCentiFarad()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.CentiFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to CentiFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to CentiFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to CentiFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMilliFarad()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MilliFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to MilliFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to MilliFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to MilliFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToMicroFarad()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MicroFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to MicroFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to MicroFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to MicroFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToNanoFarad()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.NanoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to NanoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to NanoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to NanoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToPicoFarad()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PicoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to PicoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to PicoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to PicoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToFemtoFarad()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.FemtoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to FemtoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to FemtoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to FemtoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToAttoFarad()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.AttoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to AttoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to AttoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to AttoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToZeptoFarad()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZeptoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to ZeptoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to ZeptoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to ZeptoFarad [SI]");
    }

    [TestMethod()]
    public void ConvertFromFaradToYoctoFarad()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YoctoFarad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to YoctoFarad [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to YoctoFarad [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to YoctoFarad [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFaradToFaradOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Farad [SI] to Farad [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Farad [SI] to Farad [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Farad [SI] to Farad [RSI]");
    }

  }
}
