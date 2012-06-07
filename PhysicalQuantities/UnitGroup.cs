using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitGroup
  {
    internal List<Unit> _Units = new List<Unit>();

    public UnitSystem UnitSystem { get; internal set; }

    public Quantity Quantity { get; internal set; }

    public IEnumerable<Unit> Units { get { return _Units; } }
  }
}
