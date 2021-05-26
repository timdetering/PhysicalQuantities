using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Action_Tests
  {
    [TestMethod()]
    public void ConvertFromJouleSecondToYottaJouleSecond()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.YottaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to YottaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to YottaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to YottaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToZettaJouleSecond()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.ZettaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to ZettaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to ZettaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to ZettaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToExaJouleSecond()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.ExaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to ExaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to ExaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to ExaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToPetaJouleSecond()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.PetaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to PetaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to PetaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to PetaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToTeraJouleSecond()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.TeraJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to TeraJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to TeraJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to TeraJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToGigaJouleSecond()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.GigaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to GigaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to GigaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to GigaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToMegaJouleSecond()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.MegaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to MegaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to MegaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to MegaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToKiloJouleSecond()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.KiloJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to KiloJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to KiloJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to KiloJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToHectoJouleSecond()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.HectoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to HectoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to HectoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to HectoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToDecaJouleSecond()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.DecaJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to DecaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to DecaJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to DecaJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToDeciJouleSecond()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.DeciJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to DeciJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to DeciJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to DeciJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToCentiJouleSecond()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.CentiJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to CentiJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to CentiJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to CentiJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToMilliJouleSecond()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.MilliJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to MilliJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to MilliJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to MilliJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToMicroJouleSecond()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.MicroJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to MicroJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to MicroJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to MicroJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToNanoJouleSecond()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.NanoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to NanoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to NanoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to NanoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToPicoJouleSecond()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.PicoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to PicoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to PicoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to PicoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToFemtoJouleSecond()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.FemtoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to FemtoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to FemtoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to FemtoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToAttoJouleSecond()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.AttoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to AttoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to AttoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to AttoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToZeptoJouleSecond()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.ZeptoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to ZeptoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to ZeptoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to ZeptoJouleSecond [SI]");
    }

    [TestMethod()]
    public void ConvertFromJouleSecondToYoctoJouleSecond()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.YoctoJouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from JouleSecond [SI] to YoctoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from JouleSecond [SI] to YoctoJouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from JouleSecond [SI] to YoctoJouleSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPlanckConstantToJouleSecond()
    {
      double delta = 1E-40;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.PlanckConstant;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.JouleSecond;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(6.6260695729E-33);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from PlanckConstant [SI] to JouleSecond [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from PlanckConstant [SI] to JouleSecond [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from PlanckConstant [SI] to JouleSecond [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromReducedPlanckConstantToPlanckConstant()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Action.ReducedPlanckConstant;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Action.PlanckConstant;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.59154943091895);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ReducedPlanckConstant [SI] to PlanckConstant [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ReducedPlanckConstant [SI] to PlanckConstant [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ReducedPlanckConstant [SI] to PlanckConstant [SI]");
    }

  }
}
