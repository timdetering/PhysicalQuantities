using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class US_Volume_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicInchToCubicFoot()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicInch;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.00578703703703704);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicInch [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicInch [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicInch [US] to CubicFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicYardToCubicFoot()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicYard;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(270);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicYard [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicYard [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicYard [US] to CubicFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAcreFootToCubicFoot()
    {
      double delta = 1E-2;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.AcreFoot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(435600);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from AcreFoot [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from AcreFoot [US] to CubicFoot [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from AcreFoot [US] to CubicFoot [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBoardFootToCubicInch()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.BoardFoot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1440);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from BoardFoot [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from BoardFoot [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from BoardFoot [US] to CubicInch [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSGallonToCubicInch()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USGallon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2310);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USGallon [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USGallon [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USGallon [US] to CubicInch [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBarrelToUSGallon()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Barrel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USGallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(315);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Barrel [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Barrel [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Barrel [US] to USGallon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromOilBarrelToUSGallon()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.OilBarrel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USGallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(420);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from OilBarrel [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from OilBarrel [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from OilBarrel [US] to USGallon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHogsheadToUSGallon()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Hogshead;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USGallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(630);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hogshead [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hogshead [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hogshead [US] to USGallon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSQuartToUSGallon()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USQuart;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USGallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2.5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USQuart [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USQuart [US] to USGallon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USQuart [US] to USGallon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSPintToUSQuart()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USPint;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USQuart;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USPint [US] to USQuart [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USPint [US] to USQuart [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USPint [US] to USQuart [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSCupToUSPint()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USCup;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USPint;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USCup [US] to USPint [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USCup [US] to USPint [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USCup [US] to USPint [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSGillToUSCup()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USGill;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USCup;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USGill [US] to USCup [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USGill [US] to USCup [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USGill [US] to USCup [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSFluidOunceToUSGill()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USFluidOunce;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USGill;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2.5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USFluidOunce [US] to USGill [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USFluidOunce [US] to USGill [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USFluidOunce [US] to USGill [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTablespoonToUSFluidOunce()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Tablespoon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.USFluidOunce;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tablespoon [US] to USFluidOunce [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tablespoon [US] to USFluidOunce [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tablespoon [US] to USFluidOunce [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeaspoonToTablespoon()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Teaspoon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.Tablespoon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(3.33333333333333);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Teaspoon [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Teaspoon [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Teaspoon [US] to Tablespoon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromJiggerToTablespoon()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Jigger;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.Tablespoon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Jigger [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Jigger [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Jigger [US] to Tablespoon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromUSFluidDramToTablespoon()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.USFluidDram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.Tablespoon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(2.5);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from USFluidDram [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from USFluidDram [US] to Tablespoon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from USFluidDram [US] to Tablespoon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMinimToTeaspoon()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Minim;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.Teaspoon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.125);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Minim [US] to Teaspoon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Minim [US] to Teaspoon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Minim [US] to Teaspoon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDryPintToCubicInch()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.DryPint;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(336);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DryPint [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DryPint [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DryPint [US] to CubicInch [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDryQuartToDryPint()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.DryQuart;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.DryPint;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DryQuart [US] to DryPint [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DryQuart [US] to DryPint [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DryQuart [US] to DryPint [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDryGallonToDryQuart()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.DryGallon;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.DryQuart;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DryGallon [US] to DryQuart [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DryGallon [US] to DryQuart [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DryGallon [US] to DryQuart [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPeckToDryGallon()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Peck;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.DryGallon;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Peck [US] to DryGallon [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Peck [US] to DryGallon [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Peck [US] to DryGallon [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromBushelToPeck()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.Bushel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.Peck;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(40);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Bushel [US] to Peck [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Bushel [US] to Peck [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Bushel [US] to Peck [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDryBarrelToCubicInch()
    {
      double delta = 1E-3;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.DryBarrel;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicInch;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(70560);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from DryBarrel [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from DryBarrel [US] to CubicInch [US]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from DryBarrel [US] to CubicInch [US]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCubicFootToCubicFootOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.US.Volume.CubicFoot;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from CubicFoot [US] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from CubicFoot [US] to CubicFoot [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from CubicFoot [US] to CubicFoot [Imperial]");
    }

  }
}
