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
      public static partial class MagneticFlux
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Weber_(Wb)
        /// </summary>
        public static BaseUnit Weber { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaWeber { get; private set; }
        public static ScaledUnit MegaWeber { get; private set; }
        public static ScaledUnit KiloWeber { get; private set; }
        public static ScaledUnit HectoWeber { get; private set; }
        public static ScaledUnit DecaWeber { get; private set; }
        public static ScaledUnit DeciWeber { get; private set; }
        public static ScaledUnit CentiWeber { get; private set; }
        public static ScaledUnit MilliWeber { get; private set; }
        public static ScaledUnit MicroWeber { get; private set; }

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
          Weber = new BaseUnit(@"Weber", @"Wb", PhysicalQuantities.Quantities.MagneticFlux, unitSystem);
          GigaWeber = new ScaledUnit(@"GigaWeber", @"GWb", Weber, 1000000000, 0.0);
          MegaWeber = new ScaledUnit(@"MegaWeber", @"MWb", Weber, 1000000, 0.0);
          KiloWeber = new ScaledUnit(@"KiloWeber", @"kWb", Weber, 1000, 0.0);
          HectoWeber = new ScaledUnit(@"HectoWeber", @"hWb", Weber, 100, 0.0);
          DecaWeber = new ScaledUnit(@"DecaWeber", @"daWb", Weber, 10, 0.0);
          DeciWeber = new ScaledUnit(@"DeciWeber", @"dWb", Weber, 0.1, 0.0);
          CentiWeber = new ScaledUnit(@"CentiWeber", @"cWb", Weber, 0.01, 0.0);
          MilliWeber = new ScaledUnit(@"MilliWeber", @"mWb", Weber, 0.001, 0.0);
          MicroWeber = new ScaledUnit(@"MicroWeber", @"µWb", Weber, 1E-06, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Weber.Name, Weber },
            { GigaWeber.Name, GigaWeber },
            { MegaWeber.Name, MegaWeber },
            { KiloWeber.Name, KiloWeber },
            { HectoWeber.Name, HectoWeber },
            { DecaWeber.Name, DecaWeber },
            { DeciWeber.Name, DeciWeber },
            { CentiWeber.Name, CentiWeber },
            { MilliWeber.Name, MilliWeber },
            { MicroWeber.Name, MicroWeber },
          };
        }

        static MagneticFlux()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
