using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_EquivalentDose_Tests
  {
    [TestMethod()]
    public void ConvertFromSievertToYottaSievert()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.YottaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to YottaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to YottaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to YottaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToZettaSievert()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZettaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to ZettaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to ZettaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to ZettaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToExaSievert()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.ExaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to ExaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to ExaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to ExaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToPetaSievert()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.PetaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to PetaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to PetaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to PetaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToTeraSievert()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.TeraSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to TeraSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to TeraSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to TeraSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToGigaSievert()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.GigaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to GigaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to GigaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to GigaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToMegaSievert()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.MegaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to MegaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to MegaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to MegaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToKiloSievert()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.KiloSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to KiloSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to KiloSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to KiloSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToHectoSievert()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.HectoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to HectoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to HectoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to HectoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToDecaSievert()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.DecaSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to DecaSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to DecaSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to DecaSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToDeciSievert()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.DeciSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to DeciSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to DeciSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to DeciSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToCentiSievert()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.CentiSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to CentiSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to CentiSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to CentiSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToMilliSievert()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.MilliSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to MilliSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to MilliSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to MilliSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToMicroSievert()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.MicroSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to MicroSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to MicroSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to MicroSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToNanoSievert()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.NanoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to NanoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to NanoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to NanoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToPicoSievert()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.PicoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to PicoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to PicoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to PicoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToFemtoSievert()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.FemtoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to FemtoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to FemtoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to FemtoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToAttoSievert()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.AttoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to AttoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to AttoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to AttoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToZeptoSievert()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZeptoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to ZeptoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to ZeptoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to ZeptoSievert [SI]");
    }

    [TestMethod()]
    public void ConvertFromSievertToYoctoSievert()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.EquivalentDose.YoctoSievert;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Sievert [SI] to YoctoSievert [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Sievert [SI] to YoctoSievert [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Sievert [SI] to YoctoSievert [SI]");
    }

  }
}
