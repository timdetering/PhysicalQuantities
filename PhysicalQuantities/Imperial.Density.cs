using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class Imperial
    {
      public static partial class Density
      {
        public static BaseUnit PoundPerCubicFoot { get; private set; }

        #region [ Lookup ]
        private static Dictionary<string, Unit> allUnits;
        public static Unit GetUnit(string unitName)
        {
          Unit result;
          if (allUnits.TryGetValue(unitName, out result))
            return result;
          return null;
        }
        public static IEnumerable<Unit> AllUnits
        {
          get
          {
            return allUnits.Values;
          }
        }
        #endregion [ Lookup ]

        internal static void Initialize(UnitSystem unitSystem)
        {
          PoundPerCubicFoot = new BaseUnit(@"PoundPerCubicFoot", @"lb/ft³", PhysicalQuantities.Quantities.Density, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { PoundPerCubicFoot.Name, PoundPerCubicFoot },
          };
        }

        static Density()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
