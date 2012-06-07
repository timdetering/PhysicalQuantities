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
      public static partial class Force
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pound-force
        /// </summary>
        public static BaseUnit PoundForce { get; private set; }

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
          PoundForce = new BaseUnit(@"PoundForce", @"lbf", PhysicalQuantities.Quantities.Force, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { PoundForce.Name, PoundForce },
          };
        }

        static Force()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
