using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_ElectricResistance_Tests
  {
    [TestMethod()]
    public void ConvertFromOhmToYottaOhm()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.YottaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to YottaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to YottaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to YottaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToZettaOhm()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZettaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to ZettaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to ZettaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to ZettaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToExaOhm()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.ExaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to ExaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to ExaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to ExaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToPetaOhm()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.PetaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to PetaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to PetaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to PetaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToTeraOhm()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.TeraOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to TeraOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to TeraOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to TeraOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToGigaOhm()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.GigaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to GigaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to GigaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to GigaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMegaOhm()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.MegaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to MegaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to MegaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to MegaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToKiloOhm()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.KiloOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to KiloOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to KiloOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to KiloOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToHectoOhm()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.HectoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to HectoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to HectoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to HectoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToDecaOhm()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.DecaOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to DecaOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to DecaOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to DecaOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToDeciOhm()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.DeciOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to DeciOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to DeciOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to DeciOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToCentiOhm()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.CentiOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to CentiOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to CentiOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to CentiOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMilliOhm()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.MilliOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to MilliOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to MilliOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to MilliOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToMicroOhm()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.MicroOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to MicroOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to MicroOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to MicroOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToNanoOhm()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.NanoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to NanoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to NanoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to NanoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToPicoOhm()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.PicoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to PicoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to PicoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to PicoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToFemtoOhm()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.FemtoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to FemtoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to FemtoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to FemtoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToAttoOhm()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.AttoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to AttoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to AttoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to AttoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToZeptoOhm()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZeptoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to ZeptoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to ZeptoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to ZeptoOhm [SI]");
    }

    [TestMethod()]
    public void ConvertFromOhmToYoctoOhm()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.YoctoOhm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to YoctoOhm [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to YoctoOhm [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to YoctoOhm [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromOhmToOhmOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ohm [SI] to Ohm [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ohm [SI] to Ohm [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ohm [SI] to Ohm [RSI]");
    }

  }
}
