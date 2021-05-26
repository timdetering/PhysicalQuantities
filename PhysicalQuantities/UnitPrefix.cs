using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitPrefix : INamedSymbol
  {
    protected UnitPrefix(string name, string symbol, double factor)
    {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
      if (double.IsNaN(factor) || double.IsInfinity(factor)) throw new ArgumentOutOfRangeException("factor");

      Name = name;
      Symbol = symbol;
      Factor = factor;
    }

    public string Name { get; private set; }

    public string Symbol { get; private set; }

    public double Factor { get; private set; }

    public override string ToString()
    {
      return string.Format("{0} ({1}) - X{2}", Name, Symbol, Factor);
    }
  }
}
