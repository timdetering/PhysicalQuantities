using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/United_States_customary_units
    /// </summary>
    public static partial class US
    {
      public static UnitSystem UnitSystem { get; internal set; }


      #region [ Lookup ]
      private static Dictionary<string, Quantity> allQuantities;
      private static Dictionary<Quantity, Dictionary<string, Unit>> allUnits;
      public static Quantity GetQuantity(string quantityName)
      {
        Quantity result;
        if (allQuantities.TryGetValue(quantityName, out result))
          return result;
        return null;
      }
      public static Unit GetUnit(Quantity quantity, string unitName)
      {
        Dictionary<string, Unit> dict;
        Unit result;
        if (allUnits.TryGetValue(quantity, out dict))
          if (dict.TryGetValue(unitName, out result))
            return result;
        return null;
      }
      public static IEnumerable<Unit> AllQuantityUnits(Quantity quantity)
      {
        Dictionary<string, Unit> dict;
        if (allUnits.TryGetValue(quantity, out dict))
          return dict.Values;
        return Enumerable.Empty<Unit>();
      }
      public static IEnumerable<Unit> AllUnits
      {
        get
        {
          return allUnits.Values.SelectMany(d => d.Values);
        }
      }
      #endregion [ Lookup ]
	  
      internal static UnitSystem Create(UnitConversionTable ConversionTable)
      {
        var unitSystem = new UnitSystem(@"US", ConversionTable);

        Dimensionless.Initialize(unitSystem);
        Length.Initialize(unitSystem);
        Mass.Initialize(unitSystem);
        Time.Initialize(unitSystem);
        Temperature.Initialize(unitSystem);
        Angle.Initialize(unitSystem);
        Force.Initialize(unitSystem);
        Pressure.Initialize(unitSystem);
        Energy.Initialize(unitSystem);
        Power.Initialize(unitSystem);
        Area.Initialize(unitSystem);
        Volume.Initialize(unitSystem);
        Speed.Initialize(unitSystem);
        VolumetricFlow.Initialize(unitSystem);
        AngularVelocity.Initialize(unitSystem);
        Density.Initialize(unitSystem);

        allQuantities = new Dictionary<string, Quantity>
        {
          { @"Dimensionless", PhysicalQuantities.Quantities.Dimensionless },
          { @"Length", PhysicalQuantities.Quantities.Length },
          { @"Mass", PhysicalQuantities.Quantities.Mass },
          { @"Time", PhysicalQuantities.Quantities.Time },
          { @"Temperature", PhysicalQuantities.Quantities.Temperature },
          { @"Angle", PhysicalQuantities.Quantities.Angle },
          { @"Force", PhysicalQuantities.Quantities.Force },
          { @"Pressure", PhysicalQuantities.Quantities.Pressure },
          { @"Energy", PhysicalQuantities.Quantities.Energy },
          { @"Power", PhysicalQuantities.Quantities.Power },
          { @"Area", PhysicalQuantities.Quantities.Area },
          { @"Volume", PhysicalQuantities.Quantities.Volume },
          { @"Speed", PhysicalQuantities.Quantities.Speed },
          { @"VolumetricFlow", PhysicalQuantities.Quantities.VolumetricFlow },
          { @"AngularVelocity", PhysicalQuantities.Quantities.AngularVelocity },
          { @"Density", PhysicalQuantities.Quantities.Density },
        };

        allUnits = new Dictionary<Quantity, Dictionary<string, Unit>>(ReferenceEqualityComparer<Quantity>.Default)
        {
          { 
            PhysicalQuantities.Quantities.Dimensionless, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Dimensionless.Unity.Name, PhysicalQuantities.UnitSystems.US.Dimensionless.Unity },
            }
          },
          { 
            PhysicalQuantities.Quantities.Length, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Length.Foot.Name, PhysicalQuantities.UnitSystems.US.Length.Foot },
              { PhysicalQuantities.UnitSystems.US.Length.Inch.Name, PhysicalQuantities.UnitSystems.US.Length.Inch },
              { PhysicalQuantities.UnitSystems.US.Length.Pica.Name, PhysicalQuantities.UnitSystems.US.Length.Pica },
              { PhysicalQuantities.UnitSystems.US.Length.Point.Name, PhysicalQuantities.UnitSystems.US.Length.Point },
              { PhysicalQuantities.UnitSystems.US.Length.Yard.Name, PhysicalQuantities.UnitSystems.US.Length.Yard },
              { PhysicalQuantities.UnitSystems.US.Length.Mile.Name, PhysicalQuantities.UnitSystems.US.Length.Mile },
              { PhysicalQuantities.UnitSystems.US.Length.Link.Name, PhysicalQuantities.UnitSystems.US.Length.Link },
              { PhysicalQuantities.UnitSystems.US.Length.FootSurvey.Name, PhysicalQuantities.UnitSystems.US.Length.FootSurvey },
              { PhysicalQuantities.UnitSystems.US.Length.Rod.Name, PhysicalQuantities.UnitSystems.US.Length.Rod },
              { PhysicalQuantities.UnitSystems.US.Length.Chain.Name, PhysicalQuantities.UnitSystems.US.Length.Chain },
              { PhysicalQuantities.UnitSystems.US.Length.Furlong.Name, PhysicalQuantities.UnitSystems.US.Length.Furlong },
              { PhysicalQuantities.UnitSystems.US.Length.MileSurvey.Name, PhysicalQuantities.UnitSystems.US.Length.MileSurvey },
              { PhysicalQuantities.UnitSystems.US.Length.League.Name, PhysicalQuantities.UnitSystems.US.Length.League },
              { PhysicalQuantities.UnitSystems.US.Length.Fathom.Name, PhysicalQuantities.UnitSystems.US.Length.Fathom },
              { PhysicalQuantities.UnitSystems.US.Length.Cable.Name, PhysicalQuantities.UnitSystems.US.Length.Cable },
              { PhysicalQuantities.UnitSystems.US.Length.NauticalMile.Name, PhysicalQuantities.UnitSystems.US.Length.NauticalMile },
            }
          },
          { 
            PhysicalQuantities.Quantities.Mass, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Mass.Pound.Name, PhysicalQuantities.UnitSystems.US.Mass.Pound },
              { PhysicalQuantities.UnitSystems.US.Mass.Ounce.Name, PhysicalQuantities.UnitSystems.US.Mass.Ounce },
              { PhysicalQuantities.UnitSystems.US.Mass.Dram.Name, PhysicalQuantities.UnitSystems.US.Mass.Dram },
              { PhysicalQuantities.UnitSystems.US.Mass.Grain.Name, PhysicalQuantities.UnitSystems.US.Mass.Grain },
              { PhysicalQuantities.UnitSystems.US.Mass.Hundredweight.Name, PhysicalQuantities.UnitSystems.US.Mass.Hundredweight },
              { PhysicalQuantities.UnitSystems.US.Mass.LongHundredweight.Name, PhysicalQuantities.UnitSystems.US.Mass.LongHundredweight },
              { PhysicalQuantities.UnitSystems.US.Mass.ShortTon.Name, PhysicalQuantities.UnitSystems.US.Mass.ShortTon },
              { PhysicalQuantities.UnitSystems.US.Mass.LongTon.Name, PhysicalQuantities.UnitSystems.US.Mass.LongTon },
              { PhysicalQuantities.UnitSystems.US.Mass.Pennyweight.Name, PhysicalQuantities.UnitSystems.US.Mass.Pennyweight },
              { PhysicalQuantities.UnitSystems.US.Mass.TroyOunce.Name, PhysicalQuantities.UnitSystems.US.Mass.TroyOunce },
              { PhysicalQuantities.UnitSystems.US.Mass.TroyPound.Name, PhysicalQuantities.UnitSystems.US.Mass.TroyPound },
            }
          },
          { 
            PhysicalQuantities.Quantities.Time, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Time.Second.Name, PhysicalQuantities.UnitSystems.US.Time.Second },
              { PhysicalQuantities.UnitSystems.US.Time.Minute.Name, PhysicalQuantities.UnitSystems.US.Time.Minute },
              { PhysicalQuantities.UnitSystems.US.Time.Hour.Name, PhysicalQuantities.UnitSystems.US.Time.Hour },
              { PhysicalQuantities.UnitSystems.US.Time.Day.Name, PhysicalQuantities.UnitSystems.US.Time.Day },
            }
          },
          { 
            PhysicalQuantities.Quantities.Temperature, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Temperature.Farenheit.Name, PhysicalQuantities.UnitSystems.US.Temperature.Farenheit },
            }
          },
          { 
            PhysicalQuantities.Quantities.Angle, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Angle.Degree.Name, PhysicalQuantities.UnitSystems.US.Angle.Degree },
              { PhysicalQuantities.UnitSystems.US.Angle.Arcminute.Name, PhysicalQuantities.UnitSystems.US.Angle.Arcminute },
              { PhysicalQuantities.UnitSystems.US.Angle.Arcsecond.Name, PhysicalQuantities.UnitSystems.US.Angle.Arcsecond },
              { PhysicalQuantities.UnitSystems.US.Angle.Milliarcsecond.Name, PhysicalQuantities.UnitSystems.US.Angle.Milliarcsecond },
              { PhysicalQuantities.UnitSystems.US.Angle.Microarcsecond.Name, PhysicalQuantities.UnitSystems.US.Angle.Microarcsecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Force, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Force.PoundForce.Name, PhysicalQuantities.UnitSystems.US.Force.PoundForce },
            }
          },
          { 
            PhysicalQuantities.Quantities.Pressure, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareFoot.Name, PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareFoot },
              { PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareInch.Name, PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareInch },
            }
          },
          { 
            PhysicalQuantities.Quantities.Energy, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce.Name, PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce },
              { PhysicalQuantities.UnitSystems.US.Energy.FootPoundal.Name, PhysicalQuantities.UnitSystems.US.Energy.FootPoundal },
              { PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit.Name, PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnit },
              { PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitThermochemical.Name, PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitThermochemical },
              { PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitMean.Name, PhysicalQuantities.UnitSystems.US.Energy.BritishThermalUnitMean },
              { PhysicalQuantities.UnitSystems.US.Energy.Therm.Name, PhysicalQuantities.UnitSystems.US.Energy.Therm },
              { PhysicalQuantities.UnitSystems.US.Energy.WattHour.Name, PhysicalQuantities.UnitSystems.US.Energy.WattHour },
            }
          },
          { 
            PhysicalQuantities.Quantities.Power, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond.Name, PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond },
              { PhysicalQuantities.UnitSystems.US.Power.FootPoundPerMinute.Name, PhysicalQuantities.UnitSystems.US.Power.FootPoundPerMinute },
              { PhysicalQuantities.UnitSystems.US.Power.BritishThermalUnitPerHour.Name, PhysicalQuantities.UnitSystems.US.Power.BritishThermalUnitPerHour },
              { PhysicalQuantities.UnitSystems.US.Power.Horsepower.Name, PhysicalQuantities.UnitSystems.US.Power.Horsepower },
              { PhysicalQuantities.UnitSystems.US.Power.MechanicalHorsepower.Name, PhysicalQuantities.UnitSystems.US.Power.MechanicalHorsepower },
              { PhysicalQuantities.UnitSystems.US.Power.BoilerHorsepower.Name, PhysicalQuantities.UnitSystems.US.Power.BoilerHorsepower },
            }
          },
          { 
            PhysicalQuantities.Quantities.Area, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Area.SquareFoot.Name, PhysicalQuantities.UnitSystems.US.Area.SquareFoot },
              { PhysicalQuantities.UnitSystems.US.Area.SquareInch.Name, PhysicalQuantities.UnitSystems.US.Area.SquareInch },
              { PhysicalQuantities.UnitSystems.US.Area.SquareYard.Name, PhysicalQuantities.UnitSystems.US.Area.SquareYard },
              { PhysicalQuantities.UnitSystems.US.Area.SquareFootSurvey.Name, PhysicalQuantities.UnitSystems.US.Area.SquareFootSurvey },
              { PhysicalQuantities.UnitSystems.US.Area.SquareChain.Name, PhysicalQuantities.UnitSystems.US.Area.SquareChain },
              { PhysicalQuantities.UnitSystems.US.Area.Acre.Name, PhysicalQuantities.UnitSystems.US.Area.Acre },
              { PhysicalQuantities.UnitSystems.US.Area.Section.Name, PhysicalQuantities.UnitSystems.US.Area.Section },
              { PhysicalQuantities.UnitSystems.US.Area.SquareMileSurvey.Name, PhysicalQuantities.UnitSystems.US.Area.SquareMileSurvey },
              { PhysicalQuantities.UnitSystems.US.Area.SurveyTownship.Name, PhysicalQuantities.UnitSystems.US.Area.SurveyTownship },
            }
          },
          { 
            PhysicalQuantities.Quantities.Volume, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Volume.CubicFoot.Name, PhysicalQuantities.UnitSystems.US.Volume.CubicFoot },
              { PhysicalQuantities.UnitSystems.US.Volume.CubicInch.Name, PhysicalQuantities.UnitSystems.US.Volume.CubicInch },
              { PhysicalQuantities.UnitSystems.US.Volume.CubicYard.Name, PhysicalQuantities.UnitSystems.US.Volume.CubicYard },
              { PhysicalQuantities.UnitSystems.US.Volume.AcreFoot.Name, PhysicalQuantities.UnitSystems.US.Volume.AcreFoot },
              { PhysicalQuantities.UnitSystems.US.Volume.BoardFoot.Name, PhysicalQuantities.UnitSystems.US.Volume.BoardFoot },
              { PhysicalQuantities.UnitSystems.US.Volume.USGallon.Name, PhysicalQuantities.UnitSystems.US.Volume.USGallon },
              { PhysicalQuantities.UnitSystems.US.Volume.Barrel.Name, PhysicalQuantities.UnitSystems.US.Volume.Barrel },
              { PhysicalQuantities.UnitSystems.US.Volume.OilBarrel.Name, PhysicalQuantities.UnitSystems.US.Volume.OilBarrel },
              { PhysicalQuantities.UnitSystems.US.Volume.Hogshead.Name, PhysicalQuantities.UnitSystems.US.Volume.Hogshead },
              { PhysicalQuantities.UnitSystems.US.Volume.USQuart.Name, PhysicalQuantities.UnitSystems.US.Volume.USQuart },
              { PhysicalQuantities.UnitSystems.US.Volume.USPint.Name, PhysicalQuantities.UnitSystems.US.Volume.USPint },
              { PhysicalQuantities.UnitSystems.US.Volume.USCup.Name, PhysicalQuantities.UnitSystems.US.Volume.USCup },
              { PhysicalQuantities.UnitSystems.US.Volume.USGill.Name, PhysicalQuantities.UnitSystems.US.Volume.USGill },
              { PhysicalQuantities.UnitSystems.US.Volume.USFluidOunce.Name, PhysicalQuantities.UnitSystems.US.Volume.USFluidOunce },
              { PhysicalQuantities.UnitSystems.US.Volume.Tablespoon.Name, PhysicalQuantities.UnitSystems.US.Volume.Tablespoon },
              { PhysicalQuantities.UnitSystems.US.Volume.Teaspoon.Name, PhysicalQuantities.UnitSystems.US.Volume.Teaspoon },
              { PhysicalQuantities.UnitSystems.US.Volume.Jigger.Name, PhysicalQuantities.UnitSystems.US.Volume.Jigger },
              { PhysicalQuantities.UnitSystems.US.Volume.USFluidDram.Name, PhysicalQuantities.UnitSystems.US.Volume.USFluidDram },
              { PhysicalQuantities.UnitSystems.US.Volume.Minim.Name, PhysicalQuantities.UnitSystems.US.Volume.Minim },
              { PhysicalQuantities.UnitSystems.US.Volume.DryPint.Name, PhysicalQuantities.UnitSystems.US.Volume.DryPint },
              { PhysicalQuantities.UnitSystems.US.Volume.DryQuart.Name, PhysicalQuantities.UnitSystems.US.Volume.DryQuart },
              { PhysicalQuantities.UnitSystems.US.Volume.DryGallon.Name, PhysicalQuantities.UnitSystems.US.Volume.DryGallon },
              { PhysicalQuantities.UnitSystems.US.Volume.Peck.Name, PhysicalQuantities.UnitSystems.US.Volume.Peck },
              { PhysicalQuantities.UnitSystems.US.Volume.Bushel.Name, PhysicalQuantities.UnitSystems.US.Volume.Bushel },
              { PhysicalQuantities.UnitSystems.US.Volume.DryBarrel.Name, PhysicalQuantities.UnitSystems.US.Volume.DryBarrel },
            }
          },
          { 
            PhysicalQuantities.Quantities.Speed, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond.Name, PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond },
              { PhysicalQuantities.UnitSystems.US.Speed.MilePerHour.Name, PhysicalQuantities.UnitSystems.US.Speed.MilePerHour },
              { PhysicalQuantities.UnitSystems.US.Speed.Knot.Name, PhysicalQuantities.UnitSystems.US.Speed.Knot },
            }
          },
          { 
            PhysicalQuantities.Quantities.VolumetricFlow, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.VolumetricFlow.CubicFootPerSecond.Name, PhysicalQuantities.UnitSystems.US.VolumetricFlow.CubicFootPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.AngularVelocity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.AngularVelocity.DegreesPerSecond.Name, PhysicalQuantities.UnitSystems.US.AngularVelocity.DegreesPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Density, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.US.Density.PoundPerCubicFoot.Name, PhysicalQuantities.UnitSystems.US.Density.PoundPerCubicFoot },
            }
          },
        };

        return unitSystem;
      }	  

      static US()
      {
        var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
      }
    }
  }
}
