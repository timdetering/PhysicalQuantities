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
      public static partial class Time
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Second
        /// </summary>
        public static BaseUnit Second { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Minute
        /// </summary>
        public static ScaledUnit Minute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hour
        /// </summary>
        public static ScaledUnit Hour { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Day
        /// </summary>
        public static ScaledUnit Day { get; private set; }

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
          Second = new BaseUnit(@"Second", @"s", PhysicalQuantities.Quantities.Time, unitSystem);
          Minute = new ScaledUnit(@"Minute", @"min", Second, 60, 0);
          Hour = new ScaledUnit(@"Hour", @"hr", Minute, 60, 0);
          Day = new ScaledUnit(@"Day", @"d", Hour, 24, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Second.Name, Second },
            { Minute.Name, Minute },
            { Hour.Name, Hour },
            { Day.Name, Day },
          };
        }

        static Time()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
