using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_LuminousIntensity_Tests
  {
    [TestMethod()]
    public void ConvertFromCandelaToYottaCandela()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YottaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to YottaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to YottaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to YottaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToZettaCandela()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZettaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to ZettaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to ZettaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to ZettaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToExaCandela()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ExaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to ExaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to ExaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to ExaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToPetaCandela()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PetaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to PetaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to PetaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to PetaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToTeraCandela()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.TeraCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to TeraCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to TeraCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to TeraCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToGigaCandela()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.GigaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to GigaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to GigaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to GigaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToMegaCandela()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MegaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to MegaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to MegaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to MegaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToKiloCandela()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.KiloCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to KiloCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to KiloCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to KiloCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToHectoCandela()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.HectoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to HectoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to HectoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to HectoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToDecaCandela()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DecaCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to DecaCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to DecaCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to DecaCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToDeciCandela()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DeciCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to DeciCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to DeciCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to DeciCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToCentiCandela()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.CentiCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to CentiCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to CentiCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to CentiCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToMilliCandela()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MilliCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to MilliCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to MilliCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to MilliCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToMicroCandela()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MicroCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to MicroCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to MicroCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to MicroCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToNanoCandela()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.NanoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to NanoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to NanoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to NanoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToPicoCandela()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PicoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to PicoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to PicoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to PicoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToFemtoCandela()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.FemtoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to FemtoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to FemtoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to FemtoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToAttoCandela()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.AttoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to AttoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to AttoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to AttoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToZeptoCandela()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZeptoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to ZeptoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to ZeptoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to ZeptoCandela [SI]");
    }

    [TestMethod()]
    public void ConvertFromCandelaToYoctoCandela()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YoctoCandela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to YoctoCandela [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to YoctoCandela [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to YoctoCandela [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCandelaToCandelaOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Candela [SI] to Candela [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Candela [SI] to Candela [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Candela [SI] to Candela [RSI]");
    }

  }
}
