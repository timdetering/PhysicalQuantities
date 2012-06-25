using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Voltage_Tests
  {
    [TestMethod()]
    public void ConvertFromVoltToYottaVolt()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.YottaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to YottaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to YottaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to YottaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToZettaVolt()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.ZettaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to ZettaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to ZettaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to ZettaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToExaVolt()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.ExaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to ExaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to ExaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to ExaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToPetaVolt()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.PetaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to PetaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to PetaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to PetaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToTeraVolt()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.TeraVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to TeraVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to TeraVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to TeraVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToGigaVolt()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.GigaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to GigaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to GigaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to GigaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMegaVolt()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.MegaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to MegaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to MegaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to MegaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToKiloVolt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.KiloVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to KiloVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to KiloVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to KiloVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToHectoVolt()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.HectoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to HectoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to HectoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to HectoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToDecaVolt()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.DecaVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to DecaVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to DecaVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to DecaVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToDeciVolt()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.DeciVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to DeciVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to DeciVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to DeciVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToCentiVolt()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.CentiVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to CentiVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to CentiVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to CentiVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMilliVolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.MilliVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to MilliVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to MilliVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to MilliVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToMicroVolt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.MicroVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to MicroVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to MicroVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to MicroVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToNanoVolt()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.NanoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to NanoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to NanoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to NanoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToPicoVolt()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.PicoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to PicoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to PicoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to PicoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToFemtoVolt()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.FemtoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to FemtoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to FemtoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to FemtoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToAttoVolt()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.AttoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to AttoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to AttoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to AttoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToZeptoVolt()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.ZeptoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to ZeptoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to ZeptoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to ZeptoVolt [SI]");
    }

    [TestMethod()]
    public void ConvertFromVoltToYoctoVolt()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Voltage.YoctoVolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to YoctoVolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to YoctoVolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to YoctoVolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromVoltToVoltOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Voltage.Volt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Voltage.Volt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Volt [SI] to Volt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Volt [SI] to Volt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Volt [SI] to Volt [RSI]");
    }

  }
}
