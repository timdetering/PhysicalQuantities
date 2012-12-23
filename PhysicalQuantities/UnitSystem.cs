using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitSystem : INamed
  {
    private Dictionary<Quantity, UnitGroup> data;

    public UnitSystem(string name, UnitConversionTable conversionTable)
    {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
      if (conversionTable == null) throw new ArgumentNullException("conversionTable");

      Name = name;
      ConversionTable = conversionTable;
    }

    public UnitSystem(string name)
      : this(name, UnitConversionTable.Default)
    {
    }

    internal void AddUnit(Unit unit)
    {
      AddUnit<UnitGroup>(unit);
    }

    internal void AddUnit<TQuantity>(Unit unit)
      where TQuantity : UnitGroup, new()
    {
      if (unit == null) throw new ArgumentNullException("unit");
      if (unit.UnitSystem != this) throw new ArgumentOutOfRangeException("unit");

      var quantity = unit.Quantity;
      if (data == null)
        data = new Dictionary<Quantity, UnitGroup>();

      UnitGroup list;
      if (!data.TryGetValue(quantity, out list))
        data[quantity] = list = new TQuantity { UnitSystem = this, Quantity = quantity };
      list._Units.Add(unit);

    }

    public string Name { get; private set; }

    public string Caption { get; set; }

    public UnitConversionTable ConversionTable { get; private set; }

    public IEnumerable<UnitGroup> UnitSystemQuantities
    {
      get
      {
        if (data == null) return Enumerable.Empty<UnitGroup>();
        return data.Values.AsEnumerable();
      }
    }

    public IEnumerable<Quantity> Quantities 
    { 
      get 
      {
        return UnitSystemQuantities.Select(s => s.Quantity);
      } 
    }

    public IEnumerable<Unit> AllUnits
    {
      get
      {
        return UnitSystemQuantities.SelectMany(s => s.Units);
      }
    }

    public IEnumerable<Unit> GetUnits(Quantity quantity)
    {
      if (quantity == null) throw new ArgumentNullException("quantity");
      if (data == null) return Enumerable.Empty<Unit>();
      UnitGroup list;
      if (!data.TryGetValue(quantity, out list))
        return Enumerable.Empty<Unit>();
      return list.Units;
    }

    public Func<double, double> GetConversion(Unit fromUnit, Unit toUnit)
    {
      return ConversionTable.GetConversion(fromUnit, toUnit);
    }

    public override string ToString()
    {
      return Caption ?? Name;
    }
  }
}
