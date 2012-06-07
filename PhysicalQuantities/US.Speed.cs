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
      public static partial class Speed
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot_per_second
        /// </summary>
        public static BaseUnit FootPerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Miles_per_hour
        /// </summary>
        public static ScaledUnit MilePerHour { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Knot_(unit)
        /// </summary>
        public static ScaledUnit Knot { get; private set; }

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
          FootPerSecond = new BaseUnit(@"FootPerSecond", @"ft/s", PhysicalQuantities.Quantities.Speed, unitSystem);
          MilePerHour = new ScaledUnit(@"MilePerHour", @"mph", FootPerSecond, 1.46666666666667, 0);
          Knot = new ScaledUnit(@"Knot", @"knot", FootPerSecond, 1.68781, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { FootPerSecond.Name, FootPerSecond },
            { MilePerHour.Name, MilePerHour },
            { Knot.Name, Knot },
          };
        }

        static Speed()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
