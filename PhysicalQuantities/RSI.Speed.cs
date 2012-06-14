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
      public static partial class Speed
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second
        /// </summary>
        public static BaseUnit MetrePerSecond { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloMetrePerSecond { get; private set; }
        public static ScaledUnit HectoMetrePerSecond { get; private set; }
        public static ScaledUnit DecaMetrePerSecond { get; private set; }
        public static ScaledUnit DeciMetrePerSecond { get; private set; }
        public static ScaledUnit CentiMetrePerSecond { get; private set; }
        public static ScaledUnit MilliMetrePerSecond { get; private set; }

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
          MetrePerSecond = new BaseUnit(@"MetrePerSecond", @"m/s", PhysicalQuantities.Quantities.Speed, unitSystem);
          KiloMetrePerSecond = new ScaledUnit(@"KiloMetrePerSecond", @"km/s", MetrePerSecond, 1000, 0.0);
          HectoMetrePerSecond = new ScaledUnit(@"HectoMetrePerSecond", @"hm/s", MetrePerSecond, 100, 0.0);
          DecaMetrePerSecond = new ScaledUnit(@"DecaMetrePerSecond", @"dam/s", MetrePerSecond, 10, 0.0);
          DeciMetrePerSecond = new ScaledUnit(@"DeciMetrePerSecond", @"dm/s", MetrePerSecond, 0.1, 0.0);
          CentiMetrePerSecond = new ScaledUnit(@"CentiMetrePerSecond", @"cm/s", MetrePerSecond, 0.01, 0.0);
          MilliMetrePerSecond = new ScaledUnit(@"MilliMetrePerSecond", @"mm/s", MetrePerSecond, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecond.Name, MetrePerSecond },
            { KiloMetrePerSecond.Name, KiloMetrePerSecond },
            { HectoMetrePerSecond.Name, HectoMetrePerSecond },
            { DecaMetrePerSecond.Name, DecaMetrePerSecond },
            { DeciMetrePerSecond.Name, DeciMetrePerSecond },
            { CentiMetrePerSecond.Name, CentiMetrePerSecond },
            { MilliMetrePerSecond.Name, MilliMetrePerSecond },
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
