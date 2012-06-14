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
      public static partial class Length
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre
        /// </summary>
        public static BaseUnit Metre { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaMetre { get; private set; }
        public static ScaledUnit MegaMetre { get; private set; }
        public static ScaledUnit KiloMetre { get; private set; }
        public static ScaledUnit HectoMetre { get; private set; }
        public static ScaledUnit DecaMetre { get; private set; }
        public static ScaledUnit DeciMetre { get; private set; }
        public static ScaledUnit CentiMetre { get; private set; }
        public static ScaledUnit MilliMetre { get; private set; }
        public static ScaledUnit MicroMetre { get; private set; }

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
          Metre = new BaseUnit(@"Metre", @"m", PhysicalQuantities.Quantities.Length, unitSystem);
          GigaMetre = new ScaledUnit(@"GigaMetre", @"Gm", Metre, 1000000000, 0.0);
          MegaMetre = new ScaledUnit(@"MegaMetre", @"Mm", Metre, 1000000, 0.0);
          KiloMetre = new ScaledUnit(@"KiloMetre", @"km", Metre, 1000, 0.0);
          HectoMetre = new ScaledUnit(@"HectoMetre", @"hm", Metre, 100, 0.0);
          DecaMetre = new ScaledUnit(@"DecaMetre", @"dam", Metre, 10, 0.0);
          DeciMetre = new ScaledUnit(@"DeciMetre", @"dm", Metre, 0.1, 0.0);
          CentiMetre = new ScaledUnit(@"CentiMetre", @"cm", Metre, 0.01, 0.0);
          MilliMetre = new ScaledUnit(@"MilliMetre", @"mm", Metre, 0.001, 0.0);
          MicroMetre = new ScaledUnit(@"MicroMetre", @"µm", Metre, 1E-06, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Metre.Name, Metre },
            { GigaMetre.Name, GigaMetre },
            { MegaMetre.Name, MegaMetre },
            { KiloMetre.Name, KiloMetre },
            { HectoMetre.Name, HectoMetre },
            { DecaMetre.Name, DecaMetre },
            { DeciMetre.Name, DeciMetre },
            { CentiMetre.Name, CentiMetre },
            { MilliMetre.Name, MilliMetre },
            { MicroMetre.Name, MicroMetre },
          };
        }

        static Length()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
