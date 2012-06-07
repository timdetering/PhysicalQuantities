using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitConversionTable
  {
    public static UnitConversionTable Default = new UnitConversionTable();

    Dictionary<Unit, Tuple<Unit, Func<double, double>>> cachedFromBaseConversions;
    Dictionary<Unit, Tuple<Unit, Func<double, double>>> cachedToBaseConversions;
    Dictionary<Tuple<Unit, Unit>, Func<double, double>> cachedConversions;
    List<UnitConversion> unitConversions;

    public UnitConversionTable()
    {
      cachedConversions = new Dictionary<Tuple<Unit, Unit>, Func<double, double>>();
      cachedFromBaseConversions = new Dictionary<Unit, Tuple<Unit, Func<double, double>>>();
      cachedToBaseConversions = new Dictionary<Unit, Tuple<Unit, Func<double, double>>>();
      unitConversions = new List<UnitConversion>();
    }

    public void AddConversion(UnitConversion conversion)
    {
      if (conversion == null) throw new ArgumentNullException("conversion");
      unitConversions.Add(conversion);
    }

    public Func<double, double> GetConversion(Unit fromUnit, Unit toUnit)
    {
      if (fromUnit == null) throw new ArgumentNullException("fromUnit");
      if (toUnit == null) throw new ArgumentNullException("toUnit");
      if (!fromUnit.Quantity.Equals(toUnit.Quantity))
        throw new ArgumentException("Cannot convert between units of different quantities.");
      var result = GetCachedConversion(fromUnit, toUnit);
      if (result == null)
      {
        var key = Tuple.Create(fromUnit, toUnit);
        cachedConversions[key] = result = CreateConversion(fromUnit, toUnit);
      }
      return result;
    }

    private Func<double, double> GetCachedConversion(Unit fromUnit, Unit toUnit)
    {
      if (fromUnit == toUnit)
        return IdentityConversion;
      var key = Tuple.Create(fromUnit, toUnit);
      Func<double, double> result;
      if (cachedConversions.TryGetValue(key, out result))
        return result;
      return null;
    }

    private Tuple<Unit, Func<double, double>> GetCachedFromBaseConversion(Unit unit)
    {
      if (unit is BaseUnit)
        return Tuple.Create(unit, (Func<double, double>)IdentityConversion);
      Tuple<Unit, Func<double, double>> result;
      if (cachedFromBaseConversions.TryGetValue(unit, out result))
        return result;
      return null;
    }

    private Tuple<Unit, Func<double, double>> GetCachedToBaseConversion(Unit unit)
    {
      if (unit is BaseUnit)
        return Tuple.Create(unit, (Func<double, double>)IdentityConversion);
      Tuple<Unit, Func<double, double>> result;
      if (cachedToBaseConversions.TryGetValue(unit, out result))
        return result;
      return null;
    }

    private static double IdentityConversion(double value)
    {
      return value;
    }

    private Func<double, double> CreateConversion(Unit fromUnit, Unit toUnit)
    {
      var fromConversion = FindConversionToBaseUnit(fromUnit);
      var toConversion = FindConversionFromBaseUnit(toUnit);
      if (fromConversion.Item1 == toConversion.Item1)
      {
        return v => toConversion.Item2(fromConversion.Item2(v));
      }
      var baseConversion = FindBaseConversion(fromConversion.Item1, toConversion.Item1);
      return v => toConversion.Item2(baseConversion(fromConversion.Item2(v)));
    }

    private Tuple<Unit, Func<double, double>> FindConversionToBaseUnit(Unit unit)
    {
      var result = GetCachedFromBaseConversion(unit);
      if (result != null) return result;
      double factor = 1.0;
      double offset = 0.0;
      var units = new HashSet<Unit>();
      var cur = unit;
      while (true)
      {
        if (units.Contains(cur))
          throw new InvalidOperationException("Unit definition contains cycles: " + unit);
        units.Add(cur);
        if (cur is BaseUnit)
        {
          result = Tuple.Create(cur, (Func<double, double>)(v => v * factor + offset));
          break;
        }
        else
        {
          var scaledUnit = (ScaledUnit)cur;
          factor = factor * scaledUnit.Factor + scaledUnit.Offset;
          offset = offset * scaledUnit.Factor + scaledUnit.Offset;
          cur = scaledUnit.BaseUnit;
        }
      }
      if (result == null) throw new InvalidOperationException("Cannot convert to base unit: " + unit);
      cachedFromBaseConversions[unit] = result;
      return result;
    }

    private Tuple<Unit, Func<double, double>> FindConversionFromBaseUnit(Unit unit)
    {
      var result = GetCachedToBaseConversion(unit);
      if (result != null) return result;
      double factor = 1.0;
      double offset = 0.0;
      var units = new HashSet<Unit>();
      var cur = unit;
      while (true)
      {
        if (units.Contains(cur))
          throw new InvalidOperationException("Unit definition contains cycles: " + unit);
        units.Add(cur);
        if (cur is BaseUnit)
        {
          result = Tuple.Create(cur, (Func<double, double>)(v => (v - offset) / factor));
          break;
        }
        else
        {
          var scaledUnit = (ScaledUnit)cur;
          factor = factor * scaledUnit.Factor + scaledUnit.Offset;
          offset = offset * scaledUnit.Factor + scaledUnit.Offset;
          cur = scaledUnit.BaseUnit;
        }
      }
      if (result == null) return null;
      cachedToBaseConversions[unit] = result;
      return result;
    }

    private Func<double, double> FindBaseConversion(Unit fromBaseUnit, Unit toBaseUnit)
    {
      var result = GetCachedConversion(fromBaseUnit, toBaseUnit);
      if (result != null) return result;
      foreach (var conversion in unitConversions)
      {
        var conv = conversion;
        if (fromBaseUnit == conv.SourceUnit && toBaseUnit == conv.TargetUnit)
        {
          result = v => v * conv.Factor + conv.Offset;
          break;
        }
        if (fromBaseUnit == conv.TargetUnit && toBaseUnit == conv.SourceUnit)
        {
          result = v => (v - conv.Offset) / conv.Factor;
          break;
        }
      }
      /*
      if (result == null)
      {
        if (fromBaseUnit.Quantity is DerivedQuantity)
        {
          List<Func<double, double>> appliedConversions = new List<Func<double, double>>();
          foreach (var exp in fromBaseUnit.Quantity.NormalizedQuantity.Exponents)
          {
            var fromUnit = fromBaseUnit.UnitSystem.UnitSystemQuantities.Single(x => x.Quantity == exp.Quantity).Units.OfType<BaseUnit>().First();
            var toUnit = toBaseUnit.UnitSystem.UnitSystemQuantities.Single(x => x.Quantity == exp.Quantity).Units.OfType<BaseUnit>().First();
            if (exp.Exponent > 0)
            {
              var partialConvertion = GetConversion(fromUnit, toUnit);
              for (int i = 1; i <= exp.Exponent; i++)
              {
                appliedConversions.Add(partialConvertion);
              }
            }
            else
            {
              var partialConvertion = GetConversion(toUnit, fromUnit);
              Func<double, double> completeConversion = IdentityConversion;
              for (int i = -1; i >= exp.Exponent; i--)
              {
                appliedConversions.Add(partialConvertion);
              }
            }
          }
          result = v => appliedConversions.Aggregate(1.0, (a, func) => func(a));
        }
      }
      */
      if (result != null)
        cachedConversions[Tuple.Create(fromBaseUnit, toBaseUnit)] = result;
      return result;
    }
  }
}
