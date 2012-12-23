using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class DerivedQuantity : Quantity, IComparable<DerivedQuantity>
  {

    public DerivedQuantity(string name, string symbol, params QuantityExp[] baseQuantities)
      : this(name, symbol, (IEnumerable<QuantityExp>)baseQuantities)
    {
    }

    public DerivedQuantity(string name, string symbol, IEnumerable<QuantityExp> baseQuantities)
      : base(name, symbol)
    {
      if (baseQuantities == null) throw new ArgumentNullException("baseQuantities");
      
      this.baseQuantities = baseQuantities.ToArray();
      if (this.baseQuantities.Any(q => q == null))
        throw new ArgumentNullException("baseQuantities");

      normalizedQuantity = new NormalizedQuantity(baseQuantities);
    }

    QuantityExp[] baseQuantities;
    public IEnumerable<QuantityExp> BaseQuantities { get { return baseQuantities.AsEnumerable(); } }

    public override string ToString()
    {
      if (Symbol != null)
        return string.Format("Q: {0} ({1}) -> {2}", Name, Symbol, NormalizedQuantity.ToStringExponents(baseQuantities));
      else
        return string.Format("Q: {0} -> {1}", Name, NormalizedQuantity.ToStringExponents(baseQuantities));
    }

    private NormalizedQuantity normalizedQuantity;
    public override NormalizedQuantity NormalizedQuantity
    {
      get { return normalizedQuantity; }
    }

    public override int CompareTo(Quantity other)
    {
      if (other is BaseQuantity)
        return -((BaseQuantity)other).CompareTo(this);
      if (other is DerivedQuantity)
        return CompareTo((DerivedQuantity)other);
      return -1;
    }

    public int CompareTo(DerivedQuantity other)
    {
      if (ReferenceEquals(this, other)) return 0;
      return Name.CompareTo(other.Name);
    }
  }
}
