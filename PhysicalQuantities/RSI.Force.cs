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
      public static partial class Force
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_(unit)
        /// </summary>
        public static BaseUnit Newton { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloNewton { get; private set; }
        public static ScaledUnit HectoNewton { get; private set; }
        public static ScaledUnit DecaNewton { get; private set; }
        public static ScaledUnit DeciNewton { get; private set; }
        public static ScaledUnit CentiNewton { get; private set; }
        public static ScaledUnit MilliNewton { get; private set; }

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
          Newton = new BaseUnit(@"Newton", @"N", PhysicalQuantities.Quantities.Force, unitSystem);
          KiloNewton = new ScaledUnit(@"KiloNewton", @"kN", Newton, 1000, 0.0);
          HectoNewton = new ScaledUnit(@"HectoNewton", @"hN", Newton, 100, 0.0);
          DecaNewton = new ScaledUnit(@"DecaNewton", @"daN", Newton, 10, 0.0);
          DeciNewton = new ScaledUnit(@"DeciNewton", @"dN", Newton, 0.1, 0.0);
          CentiNewton = new ScaledUnit(@"CentiNewton", @"cN", Newton, 0.01, 0.0);
          MilliNewton = new ScaledUnit(@"MilliNewton", @"mN", Newton, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Newton.Name, Newton },
            { KiloNewton.Name, KiloNewton },
            { HectoNewton.Name, HectoNewton },
            { DecaNewton.Name, DecaNewton },
            { DeciNewton.Name, DeciNewton },
            { CentiNewton.Name, CentiNewton },
            { MilliNewton.Name, MilliNewton },
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
