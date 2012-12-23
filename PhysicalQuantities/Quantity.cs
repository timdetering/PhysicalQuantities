using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace PhysicalQuantities
{
  public abstract class Quantity : INamedSymbol, IEquatable<Quantity>, IComparable<Quantity>
  {
    protected Quantity(string name, string symbol)
    {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

      Name = name;
      Symbol = symbol;
    }

    public string Name { get; private set; }

    public string Caption { get; set; }

    public string Symbol { get; private set; }

    public abstract NormalizedQuantity NormalizedQuantity { get; }

    public override string ToString()
    {
      if (Symbol != null)
        return string.Format("Q: {0} ({1}) -> {2}", Caption ?? Name, Symbol, NormalizedQuantity);
      else
        return string.Format("Q: {0} -> {1}", Caption ?? Name, NormalizedQuantity);
    }

    public virtual bool Equals(Quantity other)
    {
      return ReferenceEquals(this, other);
    }

    public override bool Equals(object obj)
    {
      return obj is Quantity && Equals((Quantity)obj);
    }

    public override int GetHashCode()
    {
      return RuntimeHelpers.GetHashCode(this);
    }

    public static bool operator ==(Quantity q1, Quantity q2)
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
    public static bool operator !=(Quantity q1, Quantity q2)
    {
      return !(q1 == q2);
    }

    public abstract int CompareTo(Quantity other);
  }
}
