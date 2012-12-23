using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_MagneticField_Tests
  {
    [TestMethod()]
    public void ConvertFromTeslaToYottaTesla()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.YottaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to YottaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to YottaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to YottaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToZettaTesla()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.ZettaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to ZettaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to ZettaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to ZettaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToExaTesla()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.ExaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to ExaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to ExaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to ExaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToPetaTesla()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.PetaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to PetaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to PetaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to PetaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToTeraTesla()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.TeraTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to TeraTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to TeraTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to TeraTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToGigaTesla()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.GigaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to GigaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to GigaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to GigaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToMegaTesla()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.MegaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to MegaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to MegaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to MegaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToKiloTesla()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.KiloTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to KiloTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to KiloTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to KiloTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToHectoTesla()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.HectoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to HectoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to HectoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to HectoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToDecaTesla()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.DecaTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to DecaTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to DecaTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to DecaTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToDeciTesla()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.DeciTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to DeciTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to DeciTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to DeciTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToCentiTesla()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.CentiTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to CentiTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to CentiTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to CentiTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToMilliTesla()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.MilliTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to MilliTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to MilliTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to MilliTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToMicroTesla()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.MicroTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to MicroTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to MicroTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to MicroTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToNanoTesla()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.NanoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to NanoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to NanoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to NanoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToPicoTesla()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.PicoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to PicoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to PicoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to PicoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToFemtoTesla()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.FemtoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to FemtoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to FemtoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to FemtoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToAttoTesla()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.AttoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to AttoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to AttoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to AttoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToZeptoTesla()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.ZeptoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to ZeptoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to ZeptoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to ZeptoTesla [SI]");
    }

    [TestMethod()]
    public void ConvertFromTeslaToYoctoTesla()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.YoctoTesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to YoctoTesla [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to YoctoTesla [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to YoctoTesla [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeslaToTeslaOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.MagneticField.Tesla;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tesla [SI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tesla [SI] to Tesla [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tesla [SI] to Tesla [RSI]");
    }

  }
}
