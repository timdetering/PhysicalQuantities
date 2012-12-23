using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public abstract class Unit : INamedSymbol
  {
    protected Unit(string name, string symbol)
    {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

      Name = name;
      Symbol = symbol;
    }

    public string Name { get; private set; }

    public string Caption { get; set; }

    public string Symbol { get; private set; }

    public abstract Quantity Quantity { get; }

    public abstract UnitSystem UnitSystem { get; }

    protected virtual void AddToUnitSystem()
    {
      UnitSystem.AddUnit(this);
    }

    public QuantityValue Times(double value)
    {
      return new QuantityValue(value, this);
    }

    public Func<double, double> GetConversionTo(Unit otherUnit)
    {
      return UnitSystem.GetConversion(this, otherUnit);
    }

    public override string ToString()
    {
      if (string.IsNullOrEmpty(Symbol))
        return Name;
      return String.Format("{0} ({1})", Caption ?? Name, Symbol);
    }
  }
}
