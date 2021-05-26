using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class QuantityExp : IEquatable<QuantityExp>, IComparable<QuantityExp>
  {
    public QuantityExp(Quantity quantity, int exponent)
    {
      if (quantity == null) throw new ArgumentNullException("quantity");
      if (exponent == 0) throw new ArgumentOutOfRangeException("exponent");

      Quantity = quantity;
      Exponent = exponent;
    }

    public Quantity Quantity { get; private set; }

    public int Exponent { get; private set; }

    public override string ToString()
    {
      var str = Quantity.Symbol != null ? Quantity.Symbol : Quantity.Name;
      if (Exponent > 1)
      {
        if (Exponent == 2)
          str = str + "²";
        else if (Exponent == 3)
          str = str + "³";
        else
          str = str + "^" + Exponent;
      }
      else if (Exponent < 0)
        str = str + "^" + Exponent;
      return str;
    }

    public bool Equals(QuantityExp other)
    {
      return this.Quantity.Equals(other.Quantity) && this.Exponent == other.Exponent;
    }

    public override bool Equals(object obj)
    {
      return obj is QuantityExp && Equals((QuantityExp)obj);
    }

    public override int GetHashCode()
    {
      return Quantity.GetHashCode() ^ Exponent.GetHashCode();
    }

    public static bool operator==(QuantityExp q1, QuantityExp q2)
    {
      if (ReferenceEquals(q1, null))
        if (ReferenceEquals(q2, null))
          return true;
        else
          return false;
      else
        if (ReferenceEquals(q2, null))
          return false;
        else
          return q1.Equals(q2);
    }
    public static bool operator!=(QuantityExp q1, QuantityExp q2)
    {
      return !(q1 == q2);
    }

    public int CompareTo(QuantityExp other)
    {
      var comp = this.Quantity.CompareTo(other.Quantity);
      if (comp != 0) return comp;
      return this.Exponent.CompareTo(other.Exponent);
    }
  }
}
