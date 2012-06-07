using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace PhysicalQuantities
{
  public class ReferenceEqualityComparer<T> : 
    IEqualityComparer<T>
  {
    public static readonly ReferenceEqualityComparer<T> Default = new ReferenceEqualityComparer<T>();

    public bool Equals(T x, T y)
    {
      return ReferenceEquals(x, y);
    }

    public int GetHashCode(T obj)
    {
      return RuntimeHelpers.GetHashCode(obj);
    }
  }
}
