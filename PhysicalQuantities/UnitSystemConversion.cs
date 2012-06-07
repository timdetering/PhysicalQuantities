using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitSystemConversion
  {
    public UnitSystemConversion(params UnitConversion[] conversions)
      : this((IEnumerable<UnitConversion>)conversions)
    {
    }

    public UnitSystemConversion(IEnumerable<UnitConversion> conversions)
    {
      if (conversions == null) throw new ArgumentNullException("conversions");

      this.conversions = conversions.ToArray();
      if (this.conversions.Length == 0)
        throw new ArgumentOutOfRangeException("conversions", "No conversions given");
      if (this.conversions.Any(q => q == null))
        throw new ArgumentNullException("conversions");
    }

    UnitConversion[] conversions;
    public IEnumerable<UnitConversion> Conversions { get { return conversions; } }
  }
}
