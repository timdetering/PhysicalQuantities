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
      public static partial class LuminousFlux
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Lumen_(unit)
        /// </summary>
        public static BaseUnit Lumen { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloLumen { get; private set; }
        public static ScaledUnit HectoLumen { get; private set; }
        public static ScaledUnit DecaLumen { get; private set; }
        public static ScaledUnit DeciLumen { get; private set; }
        public static ScaledUnit CentiLumen { get; private set; }
        public static ScaledUnit MilliLumen { get; private set; }

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
          Lumen = new BaseUnit(@"Lumen", @"lm", PhysicalQuantities.Quantities.LuminousFlux, unitSystem);
          KiloLumen = new ScaledUnit(@"KiloLumen", @"klm", Lumen, 1000, 0.0);
          HectoLumen = new ScaledUnit(@"HectoLumen", @"hlm", Lumen, 100, 0.0);
          DecaLumen = new ScaledUnit(@"DecaLumen", @"dalm", Lumen, 10, 0.0);
          DeciLumen = new ScaledUnit(@"DeciLumen", @"dlm", Lumen, 0.1, 0.0);
          CentiLumen = new ScaledUnit(@"CentiLumen", @"clm", Lumen, 0.01, 0.0);
          MilliLumen = new ScaledUnit(@"MilliLumen", @"mlm", Lumen, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Lumen.Name, Lumen },
            { KiloLumen.Name, KiloLumen },
            { HectoLumen.Name, HectoLumen },
            { DecaLumen.Name, DecaLumen },
            { DeciLumen.Name, DeciLumen },
            { CentiLumen.Name, CentiLumen },
            { MilliLumen.Name, MilliLumen },
          };
        }

        static LuminousFlux()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
