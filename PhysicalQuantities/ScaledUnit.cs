using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class ScaledUnit : Unit
  {
    public ScaledUnit(string name, string symbol, Unit baseUnit, double factor, double offset)
      : base(name, symbol)
    {
      if (baseUnit == null) throw new ArgumentNullException("baseUnit");
      if (double.IsNaN(factor) || double.IsInfinity(factor)) throw new ArgumentOutOfRangeException("factor");
      if (double.IsNaN(offset) || double.IsInfinity(offset)) throw new ArgumentOutOfRangeException("offset");

      BaseUnit = baseUnit;
      Factor = factor;
      Offset = offset;

      AddToUnitSystem();
    }

    public Unit BaseUnit { get; private set; }

    public double Factor { get; private set; }

    public double Offset { get; private set; }

    public override Quantity Quantity
    {
      get { return BaseUnit.Quantity; }
    }

    public override UnitSystem UnitSystem
    {
      get { return BaseUnit.UnitSystem; }
    }

    public override string ToString()
    {
      var str = Symbol != null ? Symbol : Name;
      str = str + " = ";
      str = str + string.Format("{0} {1}", Factor, BaseUnit.Symbol != null ? BaseUnit.Symbol : BaseUnit.Name);
      if (Offset != 0.0)
        str = str + string.Format(" + {0} {1}", Offset, Symbol != null ? Symbol : Name);
      str = str + string.Format(" ({0} on {1})", Quantity.Name, UnitSystem.Name);
      return str;
    }
  }
}
