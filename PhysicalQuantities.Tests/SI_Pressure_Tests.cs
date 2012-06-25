using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Pressure_Tests
  {
    [TestMethod()]
    public void ConvertFromPascalToYottaPascal()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.YottaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to YottaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to YottaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to YottaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToZettaPascal()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.ZettaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to ZettaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to ZettaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to ZettaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToExaPascal()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.ExaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to ExaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to ExaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to ExaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToPetaPascal()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.PetaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to PetaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to PetaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to PetaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToTeraPascal()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.TeraPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to TeraPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to TeraPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to TeraPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToGigaPascal()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.GigaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to GigaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to GigaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to GigaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMegaPascal()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.MegaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to MegaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to MegaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to MegaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToKiloPascal()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.KiloPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to KiloPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to KiloPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to KiloPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToHectoPascal()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.HectoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to HectoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to HectoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to HectoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToDecaPascal()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.DecaPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to DecaPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to DecaPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to DecaPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToDeciPascal()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.DeciPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to DeciPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to DeciPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to DeciPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToCentiPascal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.CentiPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to CentiPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to CentiPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to CentiPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMilliPascal()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.MilliPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to MilliPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to MilliPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to MilliPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToMicroPascal()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.MicroPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to MicroPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to MicroPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to MicroPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToNanoPascal()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.NanoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to NanoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to NanoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to NanoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToPicoPascal()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.PicoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to PicoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to PicoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to PicoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToFemtoPascal()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.FemtoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to FemtoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to FemtoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to FemtoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToAttoPascal()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.AttoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to AttoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to AttoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to AttoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToZeptoPascal()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.ZeptoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to ZeptoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to ZeptoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to ZeptoPascal [SI]");
    }

    [TestMethod()]
    public void ConvertFromPascalToYoctoPascal()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.YoctoPascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to YoctoPascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to YoctoPascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to YoctoPascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBarToPascal()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Bar;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Bar [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Bar [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Bar [SI] to Pascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliBarToBar()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.MilliBar;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Bar;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliBar [SI] to Bar [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliBar [SI] to Bar [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliBar [SI] to Bar [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBaryeToPascal()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Barye;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Barye [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Barye [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Barye [SI] to Pascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAtmosphereToPascal()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Atmosphere;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1013250);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Atmosphere [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Atmosphere [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Atmosphere [SI] to Pascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMillimetreOfMercuryToPascal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.MillimetreOfMercury;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1333.22387415);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MillimetreOfMercury [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MillimetreOfMercury [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MillimetreOfMercury [SI] to Pascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTorrToPascal()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Torr;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1333.22368421);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Torr [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Torr [SI] to Pascal [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Torr [SI] to Pascal [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPascalToPoundPerSquareFootOnImperial()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.208854342729909);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to PoundPerSquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to PoundPerSquareFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to PoundPerSquareFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPascalToPascalOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Pressure.Pascal;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pascal [SI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pascal [SI] to Pascal [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pascal [SI] to Pascal [RSI]");
    }

  }
}
