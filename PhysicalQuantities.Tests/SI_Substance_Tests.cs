using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Substance_Tests
  {
    [TestMethod()]
    public void ConvertFromMoleToYottaMole()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.YottaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to YottaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to YottaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to YottaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToZettaMole()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.ZettaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to ZettaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to ZettaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to ZettaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToExaMole()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.ExaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to ExaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to ExaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to ExaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToPetaMole()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.PetaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to PetaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to PetaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to PetaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToTeraMole()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.TeraMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to TeraMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to TeraMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to TeraMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToGigaMole()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.GigaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to GigaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to GigaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to GigaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToMegaMole()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.MegaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to MegaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to MegaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to MegaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToKiloMole()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.KiloMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to KiloMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to KiloMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to KiloMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToHectoMole()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.HectoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to HectoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to HectoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to HectoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToDecaMole()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.DecaMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to DecaMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to DecaMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to DecaMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToDeciMole()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.DeciMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to DeciMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to DeciMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to DeciMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToCentiMole()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.CentiMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to CentiMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to CentiMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to CentiMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToMilliMole()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.MilliMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to MilliMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to MilliMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to MilliMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToMicroMole()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.MicroMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to MicroMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to MicroMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to MicroMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToNanoMole()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.NanoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to NanoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to NanoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to NanoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToPicoMole()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.PicoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to PicoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to PicoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to PicoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToFemtoMole()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.FemtoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to FemtoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to FemtoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to FemtoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToAttoMole()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.AttoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to AttoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to AttoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to AttoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToZeptoMole()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.ZeptoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to ZeptoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to ZeptoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to ZeptoMole [SI]");
    }

    [TestMethod()]
    public void ConvertFromMoleToYoctoMole()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Substance.Mole;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Substance.YoctoMole;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Mole [SI] to YoctoMole [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Mole [SI] to YoctoMole [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Mole [SI] to YoctoMole [SI]");
    }

  }
}
