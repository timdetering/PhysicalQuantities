using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_ElectricConductance_Tests
  {
    [TestMethod()]
    public void ConvertFromSiemensToYottaSiemens()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.YottaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to YottaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to YottaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to YottaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToZettaSiemens()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZettaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to ZettaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to ZettaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to ZettaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToExaSiemens()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.ExaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to ExaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to ExaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to ExaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToPetaSiemens()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.PetaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to PetaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to PetaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to PetaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToTeraSiemens()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.TeraSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to TeraSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to TeraSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to TeraSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToGigaSiemens()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.GigaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to GigaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to GigaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to GigaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToMegaSiemens()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.MegaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to MegaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to MegaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to MegaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToKiloSiemens()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.KiloSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to KiloSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to KiloSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to KiloSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToHectoSiemens()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.HectoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to HectoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to HectoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to HectoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToDecaSiemens()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.DecaSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to DecaSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to DecaSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to DecaSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToDeciSiemens()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.DeciSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to DeciSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to DeciSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to DeciSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToCentiSiemens()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.CentiSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to CentiSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to CentiSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to CentiSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToMilliSiemens()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.MilliSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to MilliSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to MilliSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to MilliSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToMicroSiemens()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.MicroSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to MicroSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to MicroSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to MicroSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToNanoSiemens()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.NanoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to NanoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to NanoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to NanoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToPicoSiemens()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.PicoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to PicoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to PicoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to PicoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToFemtoSiemens()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.FemtoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to FemtoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to FemtoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to FemtoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToAttoSiemens()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.AttoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to AttoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to AttoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to AttoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToZeptoSiemens()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZeptoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to ZeptoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to ZeptoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to ZeptoSiemens [SI]");
    }

    [TestMethod()]
    public void ConvertFromSiemensToYoctoSiemens()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.YoctoSiemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to YoctoSiemens [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to YoctoSiemens [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to YoctoSiemens [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromSiemensToSiemensOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.ElectricConductance.Siemens;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Siemens [SI] to Siemens [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Siemens [SI] to Siemens [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Siemens [SI] to Siemens [RSI]");
    }

  }
}
