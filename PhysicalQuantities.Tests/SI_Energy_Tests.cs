using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Energy_Tests
  {
    [TestMethod()]
    public void ConvertFromJouleToYottaJoule()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.YottaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to YottaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to YottaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to YottaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToZettaJoule()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.ZettaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to ZettaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to ZettaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to ZettaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToExaJoule()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.ExaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to ExaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to ExaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to ExaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToPetaJoule()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.PetaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to PetaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to PetaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to PetaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToTeraJoule()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.TeraJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to TeraJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to TeraJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to TeraJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToGigaJoule()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.GigaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to GigaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to GigaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to GigaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMegaJoule()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.MegaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to MegaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to MegaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to MegaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToKiloJoule()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.KiloJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to KiloJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to KiloJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to KiloJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToHectoJoule()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.HectoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to HectoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to HectoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to HectoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToDecaJoule()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.DecaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to DecaJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to DecaJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to DecaJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToDeciJoule()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.DeciJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to DeciJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to DeciJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to DeciJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToCentiJoule()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.CentiJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to CentiJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to CentiJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to CentiJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMilliJoule()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.MilliJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to MilliJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to MilliJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to MilliJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMicroJoule()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.MicroJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to MicroJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to MicroJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to MicroJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToNanoJoule()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.NanoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to NanoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to NanoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to NanoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToPicoJoule()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.PicoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to PicoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to PicoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to PicoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToFemtoJoule()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.FemtoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to FemtoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to FemtoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to FemtoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToAttoJoule()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.AttoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to AttoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to AttoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to AttoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToZeptoJoule()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.ZeptoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to ZeptoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to ZeptoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to ZeptoJoule [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToYoctoJoule()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.YoctoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to YoctoJoule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to YoctoJoule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to YoctoJoule [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromElectronvoltToJoule()
    {
      double delta = 1E-26;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.602176487E-18);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Electronvolt [SI] to Joule [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Electronvolt [SI] to Joule [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Electronvolt [SI] to Joule [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliElectronvoltToElectronvolt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.MilliElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloElectronvoltToElectronvolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.KiloElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMegaElectronvoltToElectronvolt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.MegaElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MegaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MegaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MegaElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGigaElectronvoltToElectronvolt()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.GigaElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from GigaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from GigaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from GigaElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeraElectronvoltToElectronvolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.TeraElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from TeraElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from TeraElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from TeraElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPetaElectronvoltToElectronvolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.PetaElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from PetaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from PetaElectronvolt [SI] to Electronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from PetaElectronvolt [SI] to Electronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBevatronToGigaElectronvolt()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Bevatron;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Energy.GigaElectronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Bevatron [SI] to GigaElectronvolt [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Bevatron [SI] to GigaElectronvolt [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Bevatron [SI] to GigaElectronvolt [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromJouleToFootPoundForceOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(7.37562149277266);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to FootPoundForce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to FootPoundForce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromJouleToJouleOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [SI] to Joule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [SI] to Joule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [SI] to Joule [RSI]");
    }

  }
}
