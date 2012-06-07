using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class QuantityValue
  {
    public QuantityValue(double value, Unit unit)
    {
      if (unit == null)
        throw new ArgumentException("unit");

      Value = value;
      Unit = unit;
    }

    public double Value { get; private set; }

    public Unit Unit { get; private set; }

    public override string ToString()
    {
      return string.Format("{0} {1}", Value, Unit.Symbol != null ? Unit.Symbol : Unit.Name);
    }

    public QuantityValue To(Unit otherUnit)
    {
      var conversion = Unit.GetConversionTo(otherUnit);
      var newValue = conversion(Value);
      return otherUnit.Times(newValue);
    }
  }
}
