using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_ElectricCurrent_Tests
  {
    [TestMethod()]
    public void ConvertFromAmpereToYottaAmpere()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YottaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to YottaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to YottaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to YottaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToZettaAmpere()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZettaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to ZettaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to ZettaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to ZettaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToExaAmpere()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ExaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to ExaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to ExaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to ExaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToPetaAmpere()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PetaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to PetaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to PetaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to PetaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToTeraAmpere()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.TeraAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to TeraAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to TeraAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to TeraAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToGigaAmpere()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.GigaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to GigaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to GigaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to GigaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMegaAmpere()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MegaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to MegaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to MegaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to MegaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToKiloAmpere()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.KiloAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to KiloAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to KiloAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to KiloAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToHectoAmpere()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.HectoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to HectoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to HectoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to HectoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToDecaAmpere()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DecaAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to DecaAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to DecaAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to DecaAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToDeciAmpere()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DeciAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to DeciAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to DeciAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to DeciAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToCentiAmpere()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.CentiAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to CentiAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to CentiAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to CentiAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMilliAmpere()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MilliAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to MilliAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to MilliAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to MilliAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToMicroAmpere()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MicroAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to MicroAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to MicroAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to MicroAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToNanoAmpere()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.NanoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to NanoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to NanoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to NanoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToPicoAmpere()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PicoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to PicoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to PicoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to PicoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToFemtoAmpere()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.FemtoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to FemtoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to FemtoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to FemtoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToAttoAmpere()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.AttoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to AttoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to AttoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to AttoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToZeptoAmpere()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZeptoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to ZeptoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to ZeptoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to ZeptoAmpere [SI]");
    }

    [TestMethod()]
    public void ConvertFromAmpereToYoctoAmpere()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YoctoAmpere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to YoctoAmpere [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to YoctoAmpere [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to YoctoAmpere [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAmpereToAmpereOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Ampere [SI] to Ampere [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Ampere [SI] to Ampere [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Ampere [SI] to Ampere [RSI]");
    }

  }
}
