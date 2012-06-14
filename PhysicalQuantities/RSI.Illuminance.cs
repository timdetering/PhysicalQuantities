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
      public static partial class Illuminance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Lux
        /// </summary>
        public static BaseUnit Lux { get; private set; }
        // Prefix Table: R2ISUPrefixes
        public static ScaledUnit KiloLux { get; private set; }
        public static ScaledUnit HectoLux { get; private set; }
        public static ScaledUnit DecaLux { get; private set; }
        public static ScaledUnit DeciLux { get; private set; }
        public static ScaledUnit CentiLux { get; private set; }
        public static ScaledUnit MilliLux { get; private set; }

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
          Lux = new BaseUnit(@"Lux", @"lx", PhysicalQuantities.Quantities.Illuminance, unitSystem);
          KiloLux = new ScaledUnit(@"KiloLux", @"klx", Lux, 1000, 0.0);
          HectoLux = new ScaledUnit(@"HectoLux", @"hlx", Lux, 100, 0.0);
          DecaLux = new ScaledUnit(@"DecaLux", @"dalx", Lux, 10, 0.0);
          DeciLux = new ScaledUnit(@"DeciLux", @"dlx", Lux, 0.1, 0.0);
          CentiLux = new ScaledUnit(@"CentiLux", @"clx", Lux, 0.01, 0.0);
          MilliLux = new ScaledUnit(@"MilliLux", @"mlx", Lux, 0.001, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Lux.Name, Lux },
            { KiloLux.Name, KiloLux },
            { HectoLux.Name, HectoLux },
            { DecaLux.Name, DecaLux },
            { DeciLux.Name, DeciLux },
            { CentiLux.Name, CentiLux },
            { MilliLux.Name, MilliLux },
          };
        }

        static Illuminance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
