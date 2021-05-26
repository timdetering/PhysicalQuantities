using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_SolidAngle_Tests
  {
    [TestMethod()]
    public void ConvertFromSteradianToYottaSteradian()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.YottaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to YottaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to YottaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to YottaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToZettaSteradian()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.ZettaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to ZettaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to ZettaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to ZettaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToExaSteradian()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.ExaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to ExaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to ExaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to ExaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToPetaSteradian()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.PetaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to PetaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to PetaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to PetaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToTeraSteradian()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.TeraSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to TeraSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to TeraSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to TeraSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToGigaSteradian()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.GigaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to GigaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to GigaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to GigaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToMegaSteradian()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.MegaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to MegaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to MegaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to MegaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToKiloSteradian()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.KiloSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to KiloSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to KiloSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to KiloSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToHectoSteradian()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.HectoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to HectoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to HectoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to HectoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToDecaSteradian()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.DecaSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to DecaSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to DecaSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to DecaSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToDeciSteradian()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.DeciSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to DeciSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to DeciSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to DeciSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToCentiSteradian()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.CentiSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to CentiSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to CentiSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to CentiSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToMilliSteradian()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.MilliSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to MilliSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to MilliSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to MilliSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToMicroSteradian()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.MicroSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to MicroSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to MicroSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to MicroSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToNanoSteradian()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.NanoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to NanoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to NanoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to NanoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToPicoSteradian()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.PicoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to PicoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to PicoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to PicoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToFemtoSteradian()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.FemtoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to FemtoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to FemtoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to FemtoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToAttoSteradian()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.AttoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to AttoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to AttoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to AttoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToZeptoSteradian()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.ZeptoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to ZeptoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to ZeptoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to ZeptoSteradian [SI]");
    }

    [TestMethod()]
    public void ConvertFromSteradianToYoctoSteradian()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.SolidAngle.YoctoSteradian;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Steradian [SI] to YoctoSteradian [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Steradian [SI] to YoctoSteradian [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Steradian [SI] to YoctoSteradian [SI]");
    }

  }
}
