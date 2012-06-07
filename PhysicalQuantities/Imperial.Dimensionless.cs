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
      public static partial class Dimensionless
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Dimensionless_quantity
        /// </summary>
        public static BaseUnit Unity { get; private set; }

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
          Unity = new BaseUnit(@"Unity", null, PhysicalQuantities.Quantities.Dimensionless, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { Unity.Name, Unity },
          };
        }

        static Dimensionless()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
