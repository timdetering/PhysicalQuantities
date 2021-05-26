using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public class BaseUnit : Unit
  {
    public BaseUnit(string name, string symbol, Quantity quantity, UnitSystem unitSystem)
      : base(name, symbol)
    {
      if (quantity == null) throw new ArgumentNullException("quantity");
      if (unitSystem == null) throw new ArgumentNullException("unitSystem");

      this.quantity = quantity;
      this.unitSystem = unitSystem;

      AddToUnitSystem();
    }

    private Quantity quantity;
    public override Quantity Quantity 
    {
      get { return quantity; }
    }

    private UnitSystem unitSystem;
    public override UnitSystem UnitSystem 
    {
      get { return unitSystem; }
    }

    public override string ToString()
    {
      if (Symbol != null)
        return string.Format("{0} ({1} on {2})", Symbol, Quantity.Name, UnitSystem.Name);
      else
        return string.Format("{0} ({1} on {2})", Name, Quantity.Name, UnitSystem.Name);
    }
  }
}
