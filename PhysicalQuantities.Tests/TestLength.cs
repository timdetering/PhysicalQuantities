using PhysicalQuantities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhysicalQuantities.Tests
{
    
    
  [TestClass()]
  public class TestLength
  {
    private TestContext testContextInstance;

    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void SILengthConversionFromBaseUnit()
    {
      var units = new Unit[]
      {
        UnitSystems.SI.Length.AstronomicalUnit,
        UnitSystems.SI.Length.AttoMetre,
        UnitSystems.SI.Length.BohrRadius,
        UnitSystems.SI.Length.CentiMetre,
        UnitSystems.SI.Length.DecaMetre,
        UnitSystems.SI.Length.DeciMetre,
        UnitSystems.SI.Length.ExaMetre,
        UnitSystems.SI.Length.FemtoMetre,
        UnitSystems.SI.Length.GigaMetre,
        UnitSystems.SI.Length.HectoMetre,
        UnitSystems.SI.Length.KiloMetre,
        UnitSystems.SI.Length.MegaMetre,
        UnitSystems.SI.Length.Metre,
        UnitSystems.SI.Length.MicroMetre,
        UnitSystems.SI.Length.MilliMetre,
        UnitSystems.SI.Length.NanoMetre,
        UnitSystems.SI.Length.PetaMetre,
        UnitSystems.SI.Length.PicoMetre,
        UnitSystems.SI.Length.TeraMetre,
        UnitSystems.SI.Length.YoctoMetre,
        UnitSystems.SI.Length.YottaMetre,
        UnitSystems.SI.Length.ZeptoMetre,
        UnitSystems.SI.Length.ZettaMetre,
      };

      var distance = UnitSystems.SI.Length.Metre.Times(3.14);

      var conversions = new double[]
      {
        2.09896035639229e-11,
        3.140e18,
        59337400322.7804,
        314,
        0.314,
        31.4,
        3.14e-18,
        3.140e15,
        3.14e-9,
        0.0314,
        0.00314,
        0.00000314,
        3.14,
        3.140e6,
        3.140e3,
        3.140e9,
        3.140e-15,
        3.140e12,
        3.140e-12,
        3.140e24,
        3.140e-24,
        3.140e21,
        3.140e-21,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void SILengthConversionFromScaledUnit()
    {
      var units = new Unit[]
      {
        UnitSystems.SI.Length.AstronomicalUnit,
        UnitSystems.SI.Length.AttoMetre,
        UnitSystems.SI.Length.BohrRadius,
        UnitSystems.SI.Length.CentiMetre,
        UnitSystems.SI.Length.DecaMetre,
        UnitSystems.SI.Length.DeciMetre,
        UnitSystems.SI.Length.ExaMetre,
        UnitSystems.SI.Length.FemtoMetre,
        UnitSystems.SI.Length.GigaMetre,
        UnitSystems.SI.Length.HectoMetre,
        UnitSystems.SI.Length.KiloMetre,
        UnitSystems.SI.Length.MegaMetre,
        UnitSystems.SI.Length.Metre,
        UnitSystems.SI.Length.MicroMetre,
        UnitSystems.SI.Length.MilliMetre,
        UnitSystems.SI.Length.NanoMetre,
        UnitSystems.SI.Length.PetaMetre,
        UnitSystems.SI.Length.PicoMetre,
        UnitSystems.SI.Length.TeraMetre,
        UnitSystems.SI.Length.YoctoMetre,
        UnitSystems.SI.Length.YottaMetre,
        UnitSystems.SI.Length.ZeptoMetre,
        UnitSystems.SI.Length.ZettaMetre,
      };

      var distance = UnitSystems.SI.Length.KiloMetre.Times(3.14);

      var conversions = new double[]
      {
        2.09896035639229e-8,
        3.140e21,
        59337400322780.4,
        314000,
        314,
        31400,
        3.14e-15,
        3.140e18,
        3.14e-6,
        31.4,
        3.14,
        0.00314,
        3140,
        3.140e9,
        3.140e6,
        3.140e12,
        3.140e-12,
        3.140e15,
        3.140e-9,
        3.140e27,
        3.140e-21,
        3.140e24,
        3.140e-18,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void ImperialLengthConversionFromBaseUnit()
    {
      var units = new Unit[]
      {
        UnitSystems.Imperial.Length.Cable,
        UnitSystems.Imperial.Length.Chain,
        UnitSystems.Imperial.Length.Fathom,
        UnitSystems.Imperial.Length.Foot,
        UnitSystems.Imperial.Length.Furlong,
        UnitSystems.Imperial.Length.Inch,
        UnitSystems.Imperial.Length.League,
        UnitSystems.Imperial.Length.Link,
        UnitSystems.Imperial.Length.Mile,
        UnitSystems.Imperial.Length.NauticalMile,
        UnitSystems.Imperial.Length.Perch,
        UnitSystems.Imperial.Length.Rod,
        UnitSystems.Imperial.Length.Thou,
        UnitSystems.Imperial.Length.Yard,
      };

      var distance = UnitSystems.Imperial.Length.Foot.Times(3.14);

      var conversions = new double[]
      {
        5.1644736842e-3,
        4.75757575757576e-2,
        0.516447368421053,
        3.14,
        4.7575757576e-3,
        37.68,
        1.98232323232323e-4,
        4.75757575757576,
        5.946969697e-4,
        5.1644736842e-4,
        0.1903030303,
        0.1903030303,
        37680,
        1.0466666667,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void ImperialLengthConversionFromScaledUnit()
    {
      var units = new Unit[]
      {
        UnitSystems.Imperial.Length.Cable,
        UnitSystems.Imperial.Length.Chain,
        UnitSystems.Imperial.Length.Fathom,
        UnitSystems.Imperial.Length.Foot,
        UnitSystems.Imperial.Length.Furlong,
        UnitSystems.Imperial.Length.Inch,
        UnitSystems.Imperial.Length.League,
        UnitSystems.Imperial.Length.Link,
        UnitSystems.Imperial.Length.Mile,
        UnitSystems.Imperial.Length.NauticalMile,
        UnitSystems.Imperial.Length.Perch,
        UnitSystems.Imperial.Length.Rod,
        UnitSystems.Imperial.Length.Thou,
        UnitSystems.Imperial.Length.Yard,
      };

      var distance = UnitSystems.Imperial.Length.Rod.Times(3.14);

      var conversions = new double[]
      {
        5.1644736842e-3 * 16.5,
        4.75757575757576e-2 * 16.5,
        0.516447368421053 * 16.5,
        3.14 * 16.5,
        4.7575757576e-3 * 16.5,
        37.68 * 16.5,
        1.98232323232323e-4 * 16.5,
        4.75757575757576 * 16.5,
        5.946969697e-4 * 16.5,
        5.1644736842e-4 * 16.5,
        0.1903030303 * 16.5,
        0.1903030303 * 16.5,
        37680 * 16.5,
        1.0466666667 * 16.5,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void SIBaseToImperialLengthConversion()
    {
      var units = new Unit[]
      {
        UnitSystems.Imperial.Length.Cable,
        UnitSystems.Imperial.Length.Chain,
        UnitSystems.Imperial.Length.Fathom,
        UnitSystems.Imperial.Length.Foot,
        UnitSystems.Imperial.Length.Furlong,
        UnitSystems.Imperial.Length.Inch,
        UnitSystems.Imperial.Length.League,
        UnitSystems.Imperial.Length.Link,
        UnitSystems.Imperial.Length.Mile,
        UnitSystems.Imperial.Length.NauticalMile,
        UnitSystems.Imperial.Length.Perch,
        UnitSystems.Imperial.Length.Rod,
        UnitSystems.Imperial.Length.Thou,
        UnitSystems.Imperial.Length.Yard,
      };

      var distance = UnitSystems.SI.Length.Metre.Times(3.14);

      var conversions = new double[]
      {
        0.0169438112999033,
        0.156088443490018,
        1.69438112999033,
        10.30183727,
        0.015608844349,
        123.62204724,
        0.000650368514541743,
        15.6088443490018,
        0.0019511055436,
        0.00169438112999033,
        0.62435377396,
        0.62435377396,
        123622.04724,
        3.4339457568,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }

    [TestMethod()]
    [DeploymentItem("PhysicalQuantities.dll")]
    public void SIScaledToImperialLengthConversion()
    {
      var units = new Unit[]
      {
        UnitSystems.Imperial.Length.Cable,
        UnitSystems.Imperial.Length.Chain,
        UnitSystems.Imperial.Length.Fathom,
        UnitSystems.Imperial.Length.Foot,
        UnitSystems.Imperial.Length.Furlong,
        UnitSystems.Imperial.Length.Inch,
        UnitSystems.Imperial.Length.League,
        UnitSystems.Imperial.Length.Link,
        UnitSystems.Imperial.Length.Mile,
        UnitSystems.Imperial.Length.NauticalMile,
        UnitSystems.Imperial.Length.Perch,
        UnitSystems.Imperial.Length.Rod,
        UnitSystems.Imperial.Length.Thou,
        UnitSystems.Imperial.Length.Yard,
      };

      var distance = UnitSystems.SI.Length.KiloMetre.Times(3.14);

      var conversions = new double[]
      {
        1000 * 0.0169438112999033,
        1000 * 0.156088443490018,
        1000 * 1.69438112999033,
        1000 * 10.30183727,
        1000 * 0.015608844349,
        1000 * 123.62204724,
        1000 * 0.000650368514541743,
        1000 * 15.6088443490018,
        1000 * 0.0019511055436,
        1000 * 0.00169438112999033,
        1000 * 0.62435377396,
        1000 * 0.62435377396,
        1000 * 123622.04724,
        1000 * 3.4339457568,
      };

      for (int i = 0; i < units.Length; i++)
      {
        var dist2 = distance.To(units[i]);
        Assert.AreEqual(conversions[i], dist2.Value, conversions[i] * 1e-8);
      }
    }
  }
}
