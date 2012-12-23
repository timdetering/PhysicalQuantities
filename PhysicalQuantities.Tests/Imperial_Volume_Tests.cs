using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class Imperial_Volume_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicInchToCubicFoot()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicInch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.00578703703703704);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicInch [Imperial] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicInch [Imperial] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicInch [Imperial] to CubicFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicYardToCubicFoot()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicYard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(270);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicYard [Imperial] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicYard [Imperial] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicYard [Imperial] to CubicFoot [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicMileToCubicYard()
    {
      double delta = 1E3;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicMile;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicYard;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(54517760000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicMile [Imperial] to CubicYard [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicMile [Imperial] to CubicYard [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicMile [Imperial] to CubicYard [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFluidOunceToCubicInch()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.FluidOunce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(17.33871455);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FluidOunce [Imperial] to CubicInch [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FluidOunce [Imperial] to CubicInch [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FluidOunce [Imperial] to CubicInch [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFluidDramToFluidOunce()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.FluidDram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.FluidOunce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from FluidDram [Imperial] to FluidOunce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from FluidDram [Imperial] to FluidOunce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from FluidDram [Imperial] to FluidOunce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGillToFluidOunce()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Gill;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.FluidOunce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(50);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gill [Imperial] to FluidOunce [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gill [Imperial] to FluidOunce [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gill [Imperial] to FluidOunce [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPintToGill()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Pint;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Gill;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Pint [Imperial] to Gill [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Pint [Imperial] to Gill [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Pint [Imperial] to Gill [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromQuartToPint()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Quart;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Pint;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Quart [Imperial] to Pint [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Quart [Imperial] to Pint [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Quart [Imperial] to Pint [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGallonToQuart()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Gallon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Quart;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gallon [Imperial] to Quart [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gallon [Imperial] to Quart [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gallon [Imperial] to Quart [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPeckToGallon()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Peck;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Gallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Peck [Imperial] to Gallon [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Peck [Imperial] to Gallon [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Peck [Imperial] to Gallon [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBushelToPeck()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Bushel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.Peck;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Bushel [Imperial] to Peck [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Bushel [Imperial] to Peck [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Bushel [Imperial] to Peck [Imperial]");
    }

  }
}
