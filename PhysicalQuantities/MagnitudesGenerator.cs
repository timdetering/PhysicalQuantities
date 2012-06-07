using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  /// <summary>
  /// Define unit systems: SI, Imperial, US
  /// </summary>
  public static partial class UnitSystems
  {
    public static readonly UnitConversionTable ConversionTable;

    #region [ Lookup ]
    private static Dictionary<string, UnitSystem> allUnitSystems;
    public static UnitSystem GetUnitSystem(string unitSystemName)
    {
      UnitSystem result;
      if (allUnitSystems.TryGetValue(unitSystemName, out result))
        return result;
      return null;
    }
    public static IEnumerable<UnitSystem> AllUnitSystems
    {
      get
      {
        return allUnitSystems.Values;
      }
    }
    public static IEnumerable<Unit> AllUnits
    {
      get
      {
        return AllUnitSystems.SelectMany(us => us.AllUnits);
      }
    }
    #endregion [ Lookup ]

    static UnitSystems()
    {
      ConversionTable = new UnitConversionTable();

      UnitSystems.SI.UnitSystem = SI.Create(ConversionTable);
      UnitSystems.Imperial.UnitSystem = Imperial.Create(ConversionTable);
      UnitSystems.US.UnitSystem = US.Create(ConversionTable);

      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Dimensionless.Unity, PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Length.Foot, PhysicalQuantities.UnitSystems.SI.Length.Metre, 0.3048, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Mass.Pound, PhysicalQuantities.UnitSystems.SI.Mass.Kilogram, 0.45359237, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Time.Second, PhysicalQuantities.UnitSystems.SI.Time.Second, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Temperature.Farenheit, PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin, 1.8, -459.66666667));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Angle.Degree, PhysicalQuantities.UnitSystems.SI.Angle.Radian, 0.0174532925199433, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Force.PoundForce, PhysicalQuantities.UnitSystems.SI.Force.Newton, 4.4482216, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot, PhysicalQuantities.UnitSystems.SI.Pressure.Pascal, 47.880258889, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce, PhysicalQuantities.UnitSystems.SI.Energy.Joule, 1.3558179483314, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond, PhysicalQuantities.UnitSystems.SI.Power.Watt, 1.3558179483314, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot, PhysicalQuantities.UnitSystems.SI.Area.SquareMetre, 0.09290304, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot, PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre, 0.028316846592, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond, PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond, 0.3048, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond, 0.028316846592, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond, PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond, 0.0174532925199433, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Density.PoundPerCubicFoot, PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre, 16.018463306, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Dimensionless.Unity, PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Length.Foot, PhysicalQuantities.UnitSystems.SI.Length.Metre, 0.3048, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Mass.Pound, PhysicalQuantities.UnitSystems.SI.Mass.Kilogram, 0.45359237, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Time.Second, PhysicalQuantities.UnitSystems.SI.Time.Second, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Temperature.Farenheit, PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin, 1.8, -459.66666667));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Angle.Degree, PhysicalQuantities.UnitSystems.SI.Angle.Radian, 0.0174532925199433, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Force.PoundForce, PhysicalQuantities.UnitSystems.SI.Force.Newton, 4.4482216, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareFoot, PhysicalQuantities.UnitSystems.SI.Pressure.Pascal, 47.880258889, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce, PhysicalQuantities.UnitSystems.SI.Energy.Joule, 1.3558179483314, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond, PhysicalQuantities.UnitSystems.SI.Power.Watt, 1.3558179483314, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Area.SquareFoot, PhysicalQuantities.UnitSystems.SI.Area.SquareMetre, 0.09290304, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Volume.CubicFoot, PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre, 0.028316846592, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond, PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond, 0.3048, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.VolumetricFlow.CubicFootPerSecond, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond, 0.028316846592, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.AngularVelocity.DegreesPerSecond, PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond, 0.0174532925199433, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.US.Density.PoundPerCubicFoot, PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre, 16.018463306, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Dimensionless.Unity, PhysicalQuantities.UnitSystems.US.Dimensionless.Unity, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Length.Foot, PhysicalQuantities.UnitSystems.US.Length.Foot, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Mass.Pound, PhysicalQuantities.UnitSystems.US.Mass.Pound, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Time.Second, PhysicalQuantities.UnitSystems.US.Time.Second, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Temperature.Farenheit, PhysicalQuantities.UnitSystems.US.Temperature.Farenheit, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Angle.Degree, PhysicalQuantities.UnitSystems.US.Angle.Degree, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Force.PoundForce, PhysicalQuantities.UnitSystems.US.Force.PoundForce, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Pressure.PoundPerSquareFoot, PhysicalQuantities.UnitSystems.US.Pressure.PoundPerSquareFoot, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Energy.FootPoundForce, PhysicalQuantities.UnitSystems.US.Energy.FootPoundForce, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Power.FootPoundPerSecond, PhysicalQuantities.UnitSystems.US.Power.FootPoundPerSecond, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Area.SquareFoot, PhysicalQuantities.UnitSystems.US.Area.SquareFoot, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Volume.CubicFoot, PhysicalQuantities.UnitSystems.US.Volume.CubicFoot, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Speed.FootPerSecond, PhysicalQuantities.UnitSystems.US.Speed.FootPerSecond, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.VolumetricFlow.CubicFootPerSecond, PhysicalQuantities.UnitSystems.US.VolumetricFlow.CubicFootPerSecond, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.AngularVelocity.DegreesPerSecond, PhysicalQuantities.UnitSystems.US.AngularVelocity.DegreesPerSecond, 1, 0));
      ConversionTable.AddConversion(new UnitConversion(PhysicalQuantities.UnitSystems.Imperial.Density.PoundPerCubicFoot, PhysicalQuantities.UnitSystems.US.Density.PoundPerCubicFoot, 1, 0));

      allUnitSystems = new Dictionary<string, UnitSystem>
      {
        { SI.UnitSystem.Name, SI.UnitSystem },
        { Imperial.UnitSystem.Name, Imperial.UnitSystem },
        { US.UnitSystem.Name, US.UnitSystem },
      };
    }
    internal static int StaticLoadField = 0;
  }
}

