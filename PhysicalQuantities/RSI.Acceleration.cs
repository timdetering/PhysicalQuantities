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
      public static partial class Acceleration
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second_squared
        /// </summary>
        public static BaseUnit MetrePerSecondSquared { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloMetrePerSecondSquared { get; private set; }
        public static ScaledUnit HectoMetrePerSecondSquared { get; private set; }
        public static ScaledUnit DecaMetrePerSecondSquared { get; private set; }
        public static ScaledUnit DeciMetrePerSecondSquared { get; private set; }
        public static ScaledUnit CentiMetrePerSecondSquared { get; private set; }
        public static ScaledUnit MilliMetrePerSecondSquared { get; private set; }

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
          MetrePerSecondSquared = new BaseUnit(@"MetrePerSecondSquared", @"m/s²", PhysicalQuantities.Quantities.Acceleration, unitSystem);
          KiloMetrePerSecondSquared = new ScaledUnit(@"KiloMetrePerSecondSquared", @"km/s²", MetrePerSecondSquared, 1000, 0.0);
          HectoMetrePerSecondSquared = new ScaledUnit(@"HectoMetrePerSecondSquared", @"hm/s²", MetrePerSecondSquared, 100, 0.0);
          DecaMetrePerSecondSquared = new ScaledUnit(@"DecaMetrePerSecondSquared", @"dam/s²", MetrePerSecondSquared, 10, 0.0);
          DeciMetrePerSecondSquared = new ScaledUnit(@"DeciMetrePerSecondSquared", @"dm/s²", MetrePerSecondSquared, 0.1, 0.0);
          CentiMetrePerSecondSquared = new ScaledUnit(@"CentiMetrePerSecondSquared", @"cm/s²", MetrePerSecondSquared, 0.01, 0.0);
          MilliMetrePerSecondSquared = new ScaledUnit(@"MilliMetrePerSecondSquared", @"mm/s²", MetrePerSecondSquared, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecondSquared.Name, MetrePerSecondSquared },
            { KiloMetrePerSecondSquared.Name, KiloMetrePerSecondSquared },
            { HectoMetrePerSecondSquared.Name, HectoMetrePerSecondSquared },
            { DecaMetrePerSecondSquared.Name, DecaMetrePerSecondSquared },
            { DeciMetrePerSecondSquared.Name, DeciMetrePerSecondSquared },
            { CentiMetrePerSecondSquared.Name, CentiMetrePerSecondSquared },
            { MilliMetrePerSecondSquared.Name, MilliMetrePerSecondSquared },
          };
        }

        static Acceleration()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
