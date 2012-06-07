using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class NormalizedQuantity : IEquatable<NormalizedQuantity>, IComparable<NormalizedQuantity>
  {
    public NormalizedQuantity(params QuantityExp[] exponents)
      : this((IEnumerable<QuantityExp>)exponents)
    {
    }
    public NormalizedQuantity(IEnumerable<QuantityExp> exponents)
    {
      if (exponents == null) throw new ArgumentNullException("exponents");

      var temp = exponents.ToArray();
      if (temp.Any(q => q == null))
        throw new ArgumentNullException("exponents");

      this.exponents = Normalize(temp);
    }

    private QuantityExp[] Normalize(QuantityExp[] exps)
    {
      var accum = new Dictionary<BaseQuantity, int>(ReferenceEqualityComparer<BaseQuantity>.Default);
      var queue = new Queue<QuantityExp>(exps);
      while (queue.Count > 0)
      {
        var exp = queue.Dequeue();
        if (exp.Quantity is BaseQuantity)
        {
          var baseQuantity = exp.Quantity as BaseQuantity;
          int val;
          if (!accum.TryGetValue(baseQuantity, out val))
            accum[baseQuantity] = val = 0;
          val += exp.Exponent;
          accum[baseQuantity] = val;
        }
        else if (exp.Quantity is DerivedQuantity)
        {
          var derivedQuantity = exp.Quantity as DerivedQuantity;
          foreach (var baseQuantityExp in derivedQuantity.BaseQuantities)
            queue.Enqueue(new QuantityExp(baseQuantityExp.Quantity, baseQuantityExp.Exponent * exp.Exponent));
        }
      }
      return accum
        .Where(p => p.Value != 0)
        .OrderBy(p => p.Key.Name)
        .Select(p => new QuantityExp(p.Key, p.Value))
        .ToArray();
    }

    QuantityExp[] exponents;
    public IEnumerable<QuantityExp> Exponents { get { return exponents.AsEnumerable(); } }

    public bool Equals(NormalizedQuantity other)
    {
      if (exponents.Length != other.exponents.Length) return false;
      for (int i = 0; i < exponents.Length; i++)
      {
        if (!exponents[i].Equals(other.exponents[i]))
          return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int hash = 0;
        foreach (var q in exponents)
        {
          hash = hash * 37 ^ q.GetHashCode();
        }
        return hash;
      }
    }

    public override bool Equals(object obj)
    {
      return obj is NormalizedQuantity && Equals((NormalizedQuantity)obj);
    }

    public override string ToString()
    {
      return ToStringExponents(exponents);
    }

    public static string ToStringExponents(IEnumerable<QuantityExp> exponents)
    {
      var posStr = exponents
        .Where(q => q.Exponent > 0)
        .Aggregate("", AccumulateExponent);
      var negStr = exponents
        .Where(q => q.Exponent < 0)
        .Aggregate("", AccumulateExponent);
      if (negStr == "")
        if (posStr == "")
          return "1";
        else
          return posStr;
      else
        if (posStr == "")
          return "1/"+negStr;
        else
          return posStr + "/" + negStr;
    }
    private static string AccumulateExponent(string a, QuantityExp q)
    {
      if (q.Exponent == 0) return a;
      string str = a;
      if (str.Length > 0) str = str + "·";
      if (q.Quantity.Symbol != null)
        str = str + q.Quantity.Symbol;
      else
        str = str + q.Quantity.Name;

      var exp = q.Exponent;
      if (exp < 0) exp = -exp;
      if (exp > 1)
      {
        if (exp == 2)
          str = str + "²";
        else if (exp == 3)
          str = str + "³";
        else
          str = str + "^" + exp;
      }
      return str;
    }

    public int CompareTo(NormalizedQuantity other)
    {
      for (int i = 0; i < Math.Min(exponents.Length, other.exponents.Length); i++)
      {
        var comp = exponents[i].CompareTo(other.exponents[i]);
        if (comp != 0) return comp;
      }
      return exponents.Length.CompareTo(other.exponents.Length);
    }

    public static bool operator ==(NormalizedQuantity q1, NormalizedQuantity q2)
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
    public static bool operator !=(NormalizedQuantity q1, NormalizedQuantity q2)
    {
      return !(q1 == q2);
    }
  }
}
