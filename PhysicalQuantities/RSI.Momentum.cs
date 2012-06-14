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
      public static partial class Momentum
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_second
        /// </summary>
        public static BaseUnit NewtonSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_second
        /// </summary>
        public static ScaledUnit KiloNewtonPerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_second
        /// </summary>
        public static ScaledUnit MilliNewtonPerSecond { get; private set; }

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
          NewtonSecond = new BaseUnit(@"NewtonSecond", @"N·s", PhysicalQuantities.Quantities.Momentum, unitSystem);
          KiloNewtonPerSecond = new ScaledUnit(@"KiloNewtonPerSecond", @"kN·s", NewtonSecond, 1000, 0);
          MilliNewtonPerSecond = new ScaledUnit(@"MilliNewtonPerSecond", @"mN·s", NewtonSecond, 0.001, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonSecond.Name, NewtonSecond },
            { KiloNewtonPerSecond.Name, KiloNewtonPerSecond },
            { MilliNewtonPerSecond.Name, MilliNewtonPerSecond },
          };
        }

        static Momentum()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
