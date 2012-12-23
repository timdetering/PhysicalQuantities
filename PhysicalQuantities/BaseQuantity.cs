using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class BaseQuantity : Quantity, IComparable<BaseQuantity>
  {
    public BaseQuantity(string name, string symbol)
      : base(name, symbol)
    {
      normalizedQuantity = new NormalizedQuantity(new QuantityExp(this, 1));
    }

    public override string ToString()
    {
      if (Symbol != null)
        return string.Format("Q: {0} ({1})", Name, Symbol);
      else
        return string.Format("Q: {0}", Name);
    }

    private NormalizedQuantity normalizedQuantity;
    public override NormalizedQuantity NormalizedQuantity
    {
      get { return normalizedQuantity; }
    }

    public override int CompareTo(Quantity other)
    {
      if (other is BaseQuantity)
        return CompareTo((BaseQuantity)other);
      return -1; // all base quantities are less than other types of quantity
    }

    public int CompareTo(BaseQuantity other)
    {
      if (ReferenceEquals(this, other)) return 0;
      return Name.CompareTo(other.Name);
    }
  }
}
