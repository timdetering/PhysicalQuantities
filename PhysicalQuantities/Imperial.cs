using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Imperial_units
    /// </summary>
    public static partial class Imperial
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
        var unitSystem = new UnitSystem(@"Imperial", ConversionTable);

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
              { PhysicalQuantities.UnitSystems.Imperial.Dimensionless.Unity.Name, PhysicalQuantities.UnitSystems.Imperial.Dimensionless.Unity },
            }
          },
          { 
            PhysicalQuantities.Quantities.Length, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Length.Foot.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Foot },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Inch.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Inch },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Thou.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Thou },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Yard.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Yard },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Chain.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Chain },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Furlong.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Furlong },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Mile.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Mile },
              { PhysicalQuantities.UnitSystems.Imperial.Length.League.Name, PhysicalQuantities.UnitSystems.Imperial.Length.League },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Fathom.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Fathom },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Cable.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Cable },
              { PhysicalQuantities.UnitSystems.Imperial.Length.NauticalMile.Name, PhysicalQuantities.UnitSystems.Imperial.Length.NauticalMile },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Link.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Link },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Rod.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Rod },
              { PhysicalQuantities.UnitSystems.Imperial.Length.Perch.Name, PhysicalQuantities.UnitSystems.Imperial.Length.Perch },
            }
          },
          { 
            PhysicalQuantities.Quantities.Mass, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Pound.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Pound },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Ounce.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Ounce },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Drachm.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Drachm },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Grain.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Grain },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Stone.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Stone },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Quarter.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Quarter },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Hundredweight.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Hundredweight },
              { PhysicalQuantities.UnitSystems.Imperial.Mass.Ton.Name, PhysicalQuantities.UnitSystems.Imperial.Mass.Ton },
            }
          },
          { 
            PhysicalQuantities.Quantities.Time, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Time.Second.Name, PhysicalQuantities.UnitSystems.Imperial.Time.Second },
              { PhysicalQuantities.UnitSystems.Imperial.Time.Minute.Name, PhysicalQuantities.UnitSystems.Imperial.Time.Minute },
              { PhysicalQuantities.UnitSystems.Imperial.Time.Hour.Name, PhysicalQuantities.UnitSystems.Imperial.Time.Hour },
              { PhysicalQuantities.UnitSystems.Imperial.Time.Day.Name, PhysicalQuantities.UnitSystems.Imperial.Time.Day },
            }
          },
          { 
            PhysicalQuantities.Quantities.Temperature, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Temperature.Farenheit.Name, PhysicalQuantities.UnitSystems.Imperial.Temperature.Farenheit },
            }
          },
          { 
            PhysicalQuantities.Quantities.Angle, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Angle.Degree.Name, PhysicalQuantities.UnitSystems.Imperial.Angle.Degree },
              { PhysicalQuantities.UnitSystems.Imperial.Angle.Arcminute.Name, PhysicalQuantities.UnitSystems.Imperial.Angle.Arcminute },
              { PhysicalQuantities.UnitSystems.Imperial.Angle.Arcsecond.Name, PhysicalQuantities.UnitSystems.Imperial.Angle.Arcsecond },
              { PhysicalQuantities.UnitSystems.Imperial.Angle.Milliarcsecond.Name, PhysicalQuantities.UnitSystems.Imperial.Angle.Milliarcsecond },
              { PhysicalQuantities.UnitSystems.Imperial.Angle.Microarcsecond.Name, PhysicalQuantities.UnitSystems.Imperial.Angle.Microarcsecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Force, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Force.PoundForce.Name, PhysicalQuantities.UnitSystems.Imperial.Force.PoundForce },
            }
          },
          { 
            PhysicalQuantities.Quantities.Pressure, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot.Name, PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot },
              { PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareInch.Name, PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareInch },
            }
          },
          { 
            PhysicalQuantities.Quantities.Energy, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce.Name, PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce },
              { PhysicalQuantities.UnitSystems.Imperial.Energy.BritishThermalUnit.Name, PhysicalQuantities.UnitSystems.Imperial.Energy.BritishThermalUnit },
              { PhysicalQuantities.UnitSystems.Imperial.Energy.HorsePowerHour.Name, PhysicalQuantities.UnitSystems.Imperial.Energy.HorsePowerHour },
            }
          },
          { 
            PhysicalQuantities.Quantities.Power, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond.Name, PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond },
              { PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute.Name, PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerMinute },
              { PhysicalQuantities.UnitSystems.Imperial.Power.Horsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.Horsepower },
              { PhysicalQuantities.UnitSystems.Imperial.Power.MechanicalHorsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.MechanicalHorsepower },
              { PhysicalQuantities.UnitSystems.Imperial.Power.MetricHorsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.MetricHorsepower },
              { PhysicalQuantities.UnitSystems.Imperial.Power.ElectricalHorsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.ElectricalHorsepower },
              { PhysicalQuantities.UnitSystems.Imperial.Power.BoilerHorsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.BoilerHorsepower },
              { PhysicalQuantities.UnitSystems.Imperial.Power.HidraulicHorsepower.Name, PhysicalQuantities.UnitSystems.Imperial.Power.HidraulicHorsepower },
            }
          },
          { 
            PhysicalQuantities.Quantities.Area, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareInch.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareInch },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareThou.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareThou },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareYard.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareYard },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareChain.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareChain },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareFurlong.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareFurlong },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareMile.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareMile },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareLeague.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareLeague },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareFathom.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareFathom },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareCable.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareCable },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareNauticalMile.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareNauticalMile },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareLink.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareLink },
              { PhysicalQuantities.UnitSystems.Imperial.Area.SquareRod.Name, PhysicalQuantities.UnitSystems.Imperial.Area.SquareRod },
              { PhysicalQuantities.UnitSystems.Imperial.Area.Perch.Name, PhysicalQuantities.UnitSystems.Imperial.Area.Perch },
              { PhysicalQuantities.UnitSystems.Imperial.Area.Rood.Name, PhysicalQuantities.UnitSystems.Imperial.Area.Rood },
              { PhysicalQuantities.UnitSystems.Imperial.Area.Acre.Name, PhysicalQuantities.UnitSystems.Imperial.Area.Acre },
              { PhysicalQuantities.UnitSystems.Imperial.Area.Pole.Name, PhysicalQuantities.UnitSystems.Imperial.Area.Pole },
            }
          },
          { 
            PhysicalQuantities.Quantities.Volume, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.CubicInch.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.CubicInch },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.CubicYard.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.CubicYard },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.CubicMile.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.CubicMile },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.FluidOunce.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.FluidOunce },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.FluidDram.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.FluidDram },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Gill.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Gill },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Pint.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Pint },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Quart.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Quart },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Gallon.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Gallon },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Peck.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Peck },
              { PhysicalQuantities.UnitSystems.Imperial.Volume.Bushel.Name, PhysicalQuantities.UnitSystems.Imperial.Volume.Bushel },
            }
          },
          { 
            PhysicalQuantities.Quantities.Speed, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond.Name, PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond },
              { PhysicalQuantities.UnitSystems.Imperial.Speed.MilePerHour.Name, PhysicalQuantities.UnitSystems.Imperial.Speed.MilePerHour },
              { PhysicalQuantities.UnitSystems.Imperial.Speed.Knot.Name, PhysicalQuantities.UnitSystems.Imperial.Speed.Knot },
            }
          },
          { 
            PhysicalQuantities.Quantities.VolumetricFlow, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond.Name, PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.AngularVelocity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond.Name, PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Density, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.Imperial.Density.PoundPerCubicFoot.Name, PhysicalQuantities.UnitSystems.Imperial.Density.PoundPerCubicFoot },
            }
          },
        };

        return unitSystem;
      }	  

      static Imperial()
      {
        var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
      }
    }
  }
}
