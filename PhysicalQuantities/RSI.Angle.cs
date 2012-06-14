using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class RSI
    {
      public static partial class Angle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Radian
        /// </summary>
        public static BaseUnit Radian { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Degree_(angle)
        /// </summary>
        public static ScaledUnit Degree { get; private set; }

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
          Radian = new BaseUnit(@"Radian", @"rad", PhysicalQuantities.Quantities.Angle, unitSystem);
          Degree = new ScaledUnit(@"Degree", @"°", Radian, 0.0174532925199433, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Radian.Name, Radian },
            { Degree.Name, Degree },
          };
        }

        static Angle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
