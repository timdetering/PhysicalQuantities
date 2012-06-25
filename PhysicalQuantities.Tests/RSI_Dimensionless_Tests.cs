using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class RSI_Dimensionless_Tests
  {
    [TestMethod()]
    public void ConvertFromUnityToGigaUnity()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.GigaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to GigaUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to GigaUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to GigaUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMegaUnity()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.MegaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to MegaUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to MegaUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to MegaUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToKiloUnity()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.KiloUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to KiloUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to KiloUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to KiloUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToHectoUnity()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.HectoUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to HectoUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to HectoUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to HectoUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToDecaUnity()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.DecaUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to DecaUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to DecaUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to DecaUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToDeciUnity()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.DeciUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to DeciUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to DeciUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to DeciUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToCentiUnity()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.CentiUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to CentiUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to CentiUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to CentiUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMilliUnity()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.MilliUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to MilliUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to MilliUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to MilliUnity [RSI]");
    }

    [TestMethod()]
    public void ConvertFromUnityToMicroUnity()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Dimensionless.MicroUnity;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Unity [RSI] to MicroUnity [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Unity [RSI] to MicroUnity [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Unity [RSI] to MicroUnity [RSI]");
    }

  }
}
