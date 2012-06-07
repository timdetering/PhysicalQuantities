using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public interface INamedSymbol : INamed
  {
    string Symbol { get; }
  }
}
