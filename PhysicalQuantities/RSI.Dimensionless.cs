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
      public static partial class Dimensionless
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Dimensionless_quantity
        /// </summary>
        public static BaseUnit Unity { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaUnity { get; private set; }
        public static ScaledUnit MegaUnity { get; private set; }
        public static ScaledUnit KiloUnity { get; private set; }
        public static ScaledUnit HectoUnity { get; private set; }
        public static ScaledUnit DecaUnity { get; private set; }
        public static ScaledUnit DeciUnity { get; private set; }
        public static ScaledUnit CentiUnity { get; private set; }
        public static ScaledUnit MilliUnity { get; private set; }
        public static ScaledUnit MicroUnity { get; private set; }

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
          Unity = new BaseUnit(@"Unity", null, PhysicalQuantities.Quantities.Dimensionless, unitSystem) { Caption = @"unidad" };
          GigaUnity = new ScaledUnit(@"GigaUnity", null, Unity, 1000000000, 0.0) { Caption = @"gigaunidad" };
          MegaUnity = new ScaledUnit(@"MegaUnity", null, Unity, 1000000, 0.0) { Caption = @"megaunidad" };
          KiloUnity = new ScaledUnit(@"KiloUnity", null, Unity, 1000, 0.0) { Caption = @"kilounidad" };
          HectoUnity = new ScaledUnit(@"HectoUnity", null, Unity, 100, 0.0) { Caption = @"hectounidad" };
          DecaUnity = new ScaledUnit(@"DecaUnity", null, Unity, 10, 0.0) { Caption = @"decaunidad" };
          DeciUnity = new ScaledUnit(@"DeciUnity", null, Unity, 0.1, 0.0) { Caption = @"deciunidad" };
          CentiUnity = new ScaledUnit(@"CentiUnity", null, Unity, 0.01, 0.0) { Caption = @"centiunidad" };
          MilliUnity = new ScaledUnit(@"MilliUnity", null, Unity, 0.001, 0.0) { Caption = @"miliunidad" };
          MicroUnity = new ScaledUnit(@"MicroUnity", null, Unity, 1E-06, 0.0) { Caption = @"microunidad" };

          allUnits = new Dictionary<string, Unit>
          {
            { Unity.Name, Unity },
            { GigaUnity.Name, GigaUnity },
            { MegaUnity.Name, MegaUnity },
            { KiloUnity.Name, KiloUnity },
            { HectoUnity.Name, HectoUnity },
            { DecaUnity.Name, DecaUnity },
            { DeciUnity.Name, DeciUnity },
            { CentiUnity.Name, CentiUnity },
            { MilliUnity.Name, MilliUnity },
            { MicroUnity.Name, MicroUnity },
          };
        }

        static Dimensionless()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
