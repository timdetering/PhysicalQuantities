using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class QuantityValue : 
    IEquatable<QuantityValue>, 
    IComparable<QuantityValue>
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
      return string.Format("{0} {1}", Value, Unit.Symbol ?? Unit.Name);
    }

    public override bool Equals(object obj)
    {
      return Equals(obj as QuantityValue);
    }

    public override int GetHashCode()
    {
      return Value.GetHashCode() ^ Unit.GetHashCode();
    }

    public QuantityValue To(Unit otherUnit)
    {
      var conversion = Unit.GetConversionTo(otherUnit);
      var newValue = conversion(Value);
      return otherUnit.Times(newValue);
    }

    public bool Equals(QuantityValue other)
    {
      if (other == null) return false;
      if (other.Unit == this.Unit) return other.Value == this.Value;
      var otherValue = other.To(this.Unit);
      return otherValue.Value == Value;
    }

    public int CompareTo(QuantityValue other)
    {
      if (other == null) throw new ArgumentException("Not comparable values");
      if (other.Unit == this.Unit) return this.Value.CompareTo(other.Value);
      var otherValue = other.To(this.Unit);
      return this.Value.CompareTo(otherValue.Value);
    }
  }
}
