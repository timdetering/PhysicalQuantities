using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Torque_Tests
  {
    [TestMethod()]
    public void ConvertFromNewtonMetreToYottaNewtonMetre()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.YottaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to YottaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to YottaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to YottaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToZettaNewtonMetre()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.ZettaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to ZettaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to ZettaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to ZettaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToExaNewtonMetre()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.ExaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to ExaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to ExaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to ExaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToPetaNewtonMetre()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.PetaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to PetaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to PetaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to PetaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToTeraNewtonMetre()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.TeraNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to TeraNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to TeraNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to TeraNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToGigaNewtonMetre()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.GigaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to GigaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to GigaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to GigaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToMegaNewtonMetre()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.MegaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to MegaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to MegaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to MegaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToKiloNewtonMetre()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.KiloNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to KiloNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to KiloNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to KiloNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToHectoNewtonMetre()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.HectoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to HectoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to HectoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to HectoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToDecaNewtonMetre()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.DecaNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to DecaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to DecaNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to DecaNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToDeciNewtonMetre()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.DeciNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to DeciNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to DeciNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to DeciNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToCentiNewtonMetre()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.CentiNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to CentiNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to CentiNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to CentiNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToMilliNewtonMetre()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.MilliNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to MilliNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to MilliNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to MilliNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToMicroNewtonMetre()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.MicroNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to MicroNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to MicroNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to MicroNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToNanoNewtonMetre()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.NanoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to NanoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to NanoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to NanoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToPicoNewtonMetre()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.PicoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to PicoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to PicoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to PicoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToFemtoNewtonMetre()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.FemtoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to FemtoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to FemtoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to FemtoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToAttoNewtonMetre()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.AttoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to AttoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to AttoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to AttoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToZeptoNewtonMetre()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.ZeptoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to ZeptoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to ZeptoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to ZeptoNewtonMetre [SI]");
    }

    [TestMethod()]
    public void ConvertFromNewtonMetreToYoctoNewtonMetre()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Torque.YoctoNewtonMetre;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from NewtonMetre [SI] to YoctoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from NewtonMetre [SI] to YoctoNewtonMetre [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from NewtonMetre [SI] to YoctoNewtonMetre [SI]");
    }

  }
}
