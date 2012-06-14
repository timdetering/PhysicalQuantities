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
      public static partial class LuminousIntensity
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Candela
        /// </summary>
        public static BaseUnit Candela { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloCandela { get; private set; }
        public static ScaledUnit HectoCandela { get; private set; }
        public static ScaledUnit DecaCandela { get; private set; }
        public static ScaledUnit DeciCandela { get; private set; }
        public static ScaledUnit CentiCandela { get; private set; }
        public static ScaledUnit MilliCandela { get; private set; }

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
          Candela = new BaseUnit(@"Candela", @"cd", PhysicalQuantities.Quantities.LuminousIntensity, unitSystem);
          KiloCandela = new ScaledUnit(@"KiloCandela", @"kcd", Candela, 1000, 0.0);
          HectoCandela = new ScaledUnit(@"HectoCandela", @"hcd", Candela, 100, 0.0);
          DecaCandela = new ScaledUnit(@"DecaCandela", @"dacd", Candela, 10, 0.0);
          DeciCandela = new ScaledUnit(@"DeciCandela", @"dcd", Candela, 0.1, 0.0);
          CentiCandela = new ScaledUnit(@"CentiCandela", @"ccd", Candela, 0.01, 0.0);
          MilliCandela = new ScaledUnit(@"MilliCandela", @"mcd", Candela, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Candela.Name, Candela },
            { KiloCandela.Name, KiloCandela },
            { HectoCandela.Name, HectoCandela },
            { DecaCandela.Name, DecaCandela },
            { DeciCandela.Name, DeciCandela },
            { CentiCandela.Name, CentiCandela },
            { MilliCandela.Name, MilliCandela },
          };
        }

        static LuminousIntensity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
