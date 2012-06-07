using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class US
    {
      public static partial class AngularVelocity
      {
        public static BaseUnit DegreesPerSecond { get; private set; }

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
          DegreesPerSecond = new BaseUnit(@"DegreesPerSecond", @"°/s", PhysicalQuantities.Quantities.AngularVelocity, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { DegreesPerSecond.Name, DegreesPerSecond },
          };
        }

        static AngularVelocity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
