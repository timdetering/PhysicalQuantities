using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Energy_Tests
  {
    [TestMethod()]
    public void ConvertFromJouleToGigaJoule()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.GigaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to GigaJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to GigaJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to GigaJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMegaJoule()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.MegaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to MegaJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to MegaJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to MegaJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToKiloJoule()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.KiloJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to KiloJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to KiloJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to KiloJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToHectoJoule()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.HectoJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to HectoJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to HectoJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to HectoJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToDecaJoule()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.DecaJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to DecaJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to DecaJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to DecaJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToDeciJoule()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.DeciJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to DeciJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to DeciJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to DeciJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToCentiJoule()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.CentiJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to CentiJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to CentiJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to CentiJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMilliJoule()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.MilliJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to MilliJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to MilliJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to MilliJoule [RSI]");
    }

    [TestMethod()]
    public void ConvertFromJouleToMicroJoule()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.MicroJoule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Joule [RSI] to MicroJoule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Joule [RSI] to MicroJoule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Joule [RSI] to MicroJoule [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromElectronvoltToJoule()
    {
      double delta = 1E-26;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Joule;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.602176487E-18);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Electronvolt [RSI] to Joule [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Electronvolt [RSI] to Joule [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Electronvolt [RSI] to Joule [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilliElectronvoltToElectronvolt()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.MilliElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MilliElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MilliElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MilliElectronvolt [RSI] to Electronvolt [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloElectronvoltToElectronvolt()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.KiloElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloElectronvolt [RSI] to Electronvolt [RSI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMegaElectronvoltToElectronvolt()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Energy.MegaElectronvolt;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MegaElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MegaElectronvolt [RSI] to Electronvolt [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MegaElectronvolt [RSI] to Electronvolt [RSI]");
    }

  }
}
