using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
  [TestClass()]
  public class SI_Mass_Tests
  {
    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGramToKilogram()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gram [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gram [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gram [SI] to Kilogram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromYottagramToGram()
    {
      double delta = 1E17;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Yottagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+25);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Yottagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Yottagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Yottagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromZettagramToGram()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Zettagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Zettagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Zettagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Zettagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromExagramToGram()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Exagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Exagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Exagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Exagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPetagramToGram()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Petagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Petagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Petagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Petagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeragramToGram()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Teragram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Teragram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Teragram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Teragram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGigagramToGram()
    {
      double delta = 1E2;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gigagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Gigagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Gigagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Gigagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMegagramToGram()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Megagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Megagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Megagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Megagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromHectogramToGram()
    {
      double delta = 1E-5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Hectogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Hectogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Hectogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Hectogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecagramToGram()
    {
      double delta = 1E-6;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Decagram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(100);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decagram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decagram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDecigramToGram()
    {
      double delta = 1E-8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Decigram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Decigram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Decigram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Decigram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromCentigramToGram()
    {
      double delta = 1E-9;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Centigram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.1);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Centigram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Centigram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Centigram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMilligramToGram()
    {
      double delta = 1E-10;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Milligram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(0.01);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Milligram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Milligram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Milligram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMicrogramToGram()
    {
      double delta = 1E-13;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Microgram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-05);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Microgram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Microgram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Microgram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromNanogramToGram()
    {
      double delta = 1E-16;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Nanogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-08);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Nanogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Nanogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Nanogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPicogramToGram()
    {
      double delta = 1E-19;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Picogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-11);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Picogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Picogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Picogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromFemtogramToGram()
    {
      double delta = 1E-22;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Femtogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-14);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Femtogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Femtogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Femtogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAttogramToGram()
    {
      double delta = 1E-25;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Attogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-17);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Attogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Attogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Attogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromZeptogramToGram()
    {
      double delta = 1E-28;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Zeptogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-20);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Zeptogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Zeptogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Zeptogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromYoctogramToGram()
    {
      double delta = 1E-31;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Yoctogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Gram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E-23);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Yoctogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Yoctogram [SI] to Gram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Yoctogram [SI] to Gram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTonneToKilogram()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Tonne [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Tonne [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Tonne [SI] to Kilogram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKiloTonneToTonne()
    {
      double delta = 1E-4;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.KiloTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from KiloTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from KiloTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from KiloTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromMegaTonneToTonne()
    {
      double delta = 1E-1;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.MegaTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from MegaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from MegaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from MegaTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromGigaTonneToTonne()
    {
      double delta = 1E5;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.GigaTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10000000000000);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from GigaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from GigaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from GigaTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromTeraTonneToTonne()
    {
      double delta = 1E8;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.TeraTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+16);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from TeraTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from TeraTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from TeraTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromPetaTonneToTonne()
    {
      double delta = 1E11;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.PetaTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+19);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from PetaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from PetaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from PetaTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromExaTonneToTonne()
    {
      double delta = 1E14;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.ExaTonne;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Tonne;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1E+22);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ExaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ExaTonne [SI] to Tonne [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ExaTonne [SI] to Tonne [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromAtomicMassUnitToKilogram()
    {
      double delta = 1E-34;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.AtomicMassUnit;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(1.66053892173E-26);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from AtomicMassUnit [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from AtomicMassUnit [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from AtomicMassUnit [SI] to Kilogram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromDaltonToAtomicMassUnit()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Dalton;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.AtomicMassUnit;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Dalton [SI] to AtomicMassUnit [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Dalton [SI] to AtomicMassUnit [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Dalton [SI] to AtomicMassUnit [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromElectronRestMassToKilogram()
    {
      double delta = 1E-37;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.ElectronRestMass;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(9.109382616E-30);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from ElectronRestMass [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from ElectronRestMass [SI] to Kilogram [SI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from ElectronRestMass [SI] to Kilogram [SI]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKilogramToPoundOnImperial()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.Imperial.Mass.Pound;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(22.0462262184878);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kilogram [SI] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kilogram [SI] to Pound [Imperial]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kilogram [SI] to Pound [Imperial]");
    }

    [TestMethod()]
    //[DeploymentItem("PhysicalQuantities.dll")]
    public void ConvertFromKilogramToKilogramOnRSI()
    {
      double delta = 1E-7;
      var fromUnit = PhysicalQuantities.UnitSystems.SI.Mass.Kilogram;
      var fromValue = fromUnit.Times(10);
      var toUnit = PhysicalQuantities.UnitSystems.RSI.Mass.Kilogram;
      var toValue = fromValue.To(toUnit);
      var expectedValue = toUnit.Times(10);
      //Assert.AreEqual(expectedValue, toValue, "Error converting from Kilogram [SI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Value, toValue.Value, delta, "Error converting from Kilogram [SI] to Kilogram [RSI]");
      Assert.AreEqual(expectedValue.Unit, toValue.Unit, "Error converting from Kilogram [SI] to Kilogram [RSI]");
    }

  }
}
