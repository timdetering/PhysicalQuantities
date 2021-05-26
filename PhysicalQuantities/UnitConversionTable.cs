using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetFrameworkExtensions;

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
      ClearCache();
    }

    public void ClearCache()
    {
      cachedFromBaseConversions.Clear();
      cachedToBaseConversions.Clear();
      cachedConversions.Clear();
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
      List<Func<double, double>> conversionList = new List<Func<double, double>>();
      var units = new HashSet<Unit>();
      var cur = unit;
      while (true)
      {
        if (units.Contains(cur))
          throw new InvalidOperationException("Unit definition contains cycles: " + unit);
        units.Add(cur);
        if (cur is BaseUnit)
        {
          Func<double, double> func = v => conversionList.Aggregate(v, (val, f) => f(val));
          result = Tuple.Create(cur, func);
          break;
        }
        else
        {
          var scaledUnit = (ScaledUnit)cur;
          conversionList.Add(v => v * scaledUnit.Factor + scaledUnit.Offset);
          cur = scaledUnit.BaseUnit;
        }
      }
      if (result == null) throw new InvalidOperationException("Cannot convert to base unit: " + unit);
      cachedFromBaseConversions[unit] = result;
      return result;
    }
    private Tuple<Unit, Func<double, double>> FindConversionToBaseUnit2(Unit unit)
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
      List<Func<double, double>> conversionList = new List<Func<double, double>>();
      var units = new HashSet<Unit>();
      var cur = unit;
      while (true)
      {
        if (units.Contains(cur))
          throw new InvalidOperationException("Unit definition contains cycles: " + unit);
        units.Add(cur);
        if (cur is BaseUnit)
        {
          conversionList.Reverse();
          Func<double, double> func = v => conversionList.Aggregate(v, (val, f) => f(val));
          result = Tuple.Create(cur, func);
          break;
        }
        else
        {
          var scaledUnit = (ScaledUnit)cur;
          conversionList.Add(v => (v - scaledUnit.Offset) / scaledUnit.Factor);
          cur = scaledUnit.BaseUnit;
        }
      }
      if (result == null) return null;
      cachedToBaseConversions[unit] = result;
      return result;
    }
    private Tuple<Unit, Func<double, double>> FindConversionFromBaseUnit2(Unit unit)
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
      var path = FindShortestPath(fromBaseUnit, toBaseUnit);
      if (path == null) throw new InvalidOperationException("There is no defined path to convert from " + fromBaseUnit + " to " + toBaseUnit);
      result = v => path.Aggregate(v, (val, f) => f(val));

      if (result != null)
        cachedConversions[Tuple.Create(fromBaseUnit, toBaseUnit)] = result;
      return result;
    }

    private List<Func<double, double>> FindShortestPath(Unit fromBaseUnit, Unit toBaseUnit)
    {
      var path = fromBaseUnit.FindShortestPath(FSPGetArcs, u => u == toBaseUnit);
      if (path == null) return null;
      return path.Select(t => t.Arc).ToList();
    }
    private IEnumerable<Tup<Unit, Func<double, double>, Unit>> FSPGetArcs(Unit fromUnit)
    {
      foreach (var conversion in unitConversions)
      {
        var conv = conversion;
        Func<double, double> func;
        if (conv.SourceUnit == fromUnit)
          yield return Tup.Create(fromUnit, func = v => v * conv.Factor + conv.Offset, conv.TargetUnit);
        else if (conv.TargetUnit == fromUnit)
          yield return Tup.Create(fromUnit, func = v => (v - conv.Offset) / conv.Factor, conv.SourceUnit);
      }
    }
  }
}
