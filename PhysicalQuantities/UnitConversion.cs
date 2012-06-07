using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class UnitConversion
  {
    public UnitConversion(Unit sourceUnit, Unit targetUnit, double factor, double offset)
    {
      if (sourceUnit == null) throw new ArgumentNullException("sourceUnit");
      if (targetUnit == null) throw new ArgumentNullException("targetUnit");
      if (double.IsNaN(factor) || double.IsInfinity(factor)) throw new ArgumentOutOfRangeException("factor");
      if (double.IsNaN(offset) || double.IsInfinity(offset)) throw new ArgumentOutOfRangeException("offset");

      if (sourceUnit.UnitSystem == targetUnit.UnitSystem)
        throw new ArgumentException("Must select units from different unit systems");
      if (sourceUnit.Quantity != targetUnit.Quantity)
        throw new ArgumentException("Must select units from the same quantity");

      SourceUnit = sourceUnit;
      TargetUnit = targetUnit;
      Factor = factor;
      Offset = offset;
    }

    public Unit SourceUnit { get; set; }

    public Unit TargetUnit { get; set; }

    public double Factor { get; set; }

    public double Offset { get; set; }

    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.AppendFormat("{0} [{1}] = {2} {3}", 
        TargetUnit.Symbol != null ? TargetUnit.Symbol : TargetUnit.Name, 
        TargetUnit.UnitSystem.Name,
        Factor,
        SourceUnit.Symbol != null ? SourceUnit.Symbol : SourceUnit.Name);
      if (Offset > 0.0)
        sb.AppendFormat(" + {0} ", Offset);
      else if (Offset < 0.0)
        sb.AppendFormat(" - {0} ", -Offset);
      if (Offset != 0)
        sb.Append(TargetUnit.Symbol != null ? TargetUnit.Symbol : TargetUnit.Name);
      return sb.ToString();
    }
  }
}
