using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_ElectricCharge_Tests
  {
    [TestMethod()]
    public void ConvertFromCoulombToYottaCoulomb()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.YottaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to YottaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to YottaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to YottaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToZettaCoulomb()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZettaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to ZettaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to ZettaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to ZettaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToExaCoulomb()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.ExaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to ExaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to ExaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to ExaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToPetaCoulomb()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.PetaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to PetaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to PetaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to PetaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToTeraCoulomb()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.TeraCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to TeraCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to TeraCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to TeraCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToGigaCoulomb()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.GigaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to GigaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to GigaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to GigaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToMegaCoulomb()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.MegaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to MegaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to MegaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to MegaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToKiloCoulomb()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.KiloCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to KiloCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to KiloCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to KiloCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToHectoCoulomb()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.HectoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to HectoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to HectoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to HectoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToDecaCoulomb()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.DecaCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to DecaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to DecaCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to DecaCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToDeciCoulomb()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.DeciCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to DeciCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to DeciCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to DeciCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToCentiCoulomb()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.CentiCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to CentiCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to CentiCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to CentiCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToMilliCoulomb()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.MilliCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to MilliCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to MilliCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to MilliCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToMicroCoulomb()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.MicroCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to MicroCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to MicroCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to MicroCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToNanoCoulomb()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.NanoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to NanoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to NanoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to NanoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToPicoCoulomb()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.PicoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to PicoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to PicoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to PicoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToFemtoCoulomb()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.FemtoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to FemtoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to FemtoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to FemtoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToAttoCoulomb()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.AttoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to AttoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to AttoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to AttoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToZeptoCoulomb()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZeptoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to ZeptoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to ZeptoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to ZeptoCoulomb [SI]");
    }

    [TestMethod()]
    public void ConvertFromCoulombToYoctoCoulomb()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.YoctoCoulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Coulomb [SI] to YoctoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Coulomb [SI] to YoctoCoulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Coulomb [SI] to YoctoCoulomb [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromElementaryChargeToCoulomb()
    {
      double delta = 1E-26;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.ElementaryCharge;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.60217656535E-18);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ElementaryCharge [SI] to Coulomb [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ElementaryCharge [SI] to Coulomb [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ElementaryCharge [SI] to Coulomb [SI]");
    }

  }
}
