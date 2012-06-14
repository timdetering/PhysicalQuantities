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
      public static partial class VolumetricFlow
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static BaseUnit CubicMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicKiloMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicHectoMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicDecaMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicDeciMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicCentiMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static ScaledUnit CubicMilliMetrePerSecond { get; private set; }

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
          CubicMetrePerSecond = new BaseUnit(@"CubicMetrePerSecond", @"m³/s", PhysicalQuantities.Quantities.VolumetricFlow, unitSystem);
          CubicKiloMetrePerSecond = new ScaledUnit(@"CubicKiloMetrePerSecond", @"km³/s", CubicMetrePerSecond, 1000000000, 0);
          CubicHectoMetrePerSecond = new ScaledUnit(@"CubicHectoMetrePerSecond", @"hm³/s", CubicMetrePerSecond, 1000000, 0);
          CubicDecaMetrePerSecond = new ScaledUnit(@"CubicDecaMetrePerSecond", @"dam³/s", CubicMetrePerSecond, 1000, 0);
          CubicDeciMetrePerSecond = new ScaledUnit(@"CubicDeciMetrePerSecond", @"dm³/s", CubicMetrePerSecond, 0.001, 0);
          CubicCentiMetrePerSecond = new ScaledUnit(@"CubicCentiMetrePerSecond", @"cm³/s", CubicMetrePerSecond, 1E-06, 0);
          CubicMilliMetrePerSecond = new ScaledUnit(@"CubicMilliMetrePerSecond", @"mm³/s", CubicMetrePerSecond, 1E-09, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { CubicMetrePerSecond.Name, CubicMetrePerSecond },
            { CubicKiloMetrePerSecond.Name, CubicKiloMetrePerSecond },
            { CubicHectoMetrePerSecond.Name, CubicHectoMetrePerSecond },
            { CubicDecaMetrePerSecond.Name, CubicDecaMetrePerSecond },
            { CubicDeciMetrePerSecond.Name, CubicDeciMetrePerSecond },
            { CubicCentiMetrePerSecond.Name, CubicCentiMetrePerSecond },
            { CubicMilliMetrePerSecond.Name, CubicMilliMetrePerSecond },
          };
        }

        static VolumetricFlow()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
