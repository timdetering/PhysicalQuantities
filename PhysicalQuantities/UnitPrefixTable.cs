using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitPrefixTable : INamed
  {
    public UnitPrefixTable(string name, params UnitPrefix[] prefixes)
      : this(name, (IEnumerable<UnitPrefix>)prefixes)
    {
    }

    public UnitPrefixTable(string name, IEnumerable<UnitPrefix> prefixes)
    {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
      if (prefixes == null) throw new ArgumentNullException("prefixes");

      Name = name;
      this.prefixes = prefixes.ToArray();
      if (this.prefixes.Length == 0)
        throw new ArgumentOutOfRangeException("prefixes", "Non prefixes given");
      if (this.prefixes.Any(q => q == null))
        throw new ArgumentNullException("prefixes");
    }

    public string Name { get; private set; }

    UnitPrefix[] prefixes;
    public IEnumerable<UnitPrefix> Prefixes { get { return prefixes; } }
  }
}
