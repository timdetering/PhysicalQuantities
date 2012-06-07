using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class SI
    {
      public static partial class Jounce
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre
        /// </summary>
        public static BaseUnit MetrePerQuarticSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit ZettaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit ExaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit PetaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit TeraMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit GigaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit MegaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit KiloMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit HectoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit DecaMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit DeciMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit CentiMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit MilliMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit MicroMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit NanoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit PicoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit FemtoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit AttoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit ZeptoMetrePerQuarticSecond { get; private set; }
        public static ScaledUnit YoctoMetrePerQuarticSecond { get; private set; }

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
          MetrePerQuarticSecond = new BaseUnit(@"MetrePerQuarticSecond", @"m/s4", PhysicalQuantities.Quantities.Jounce, unitSystem);
          YottaMetrePerQuarticSecond = new ScaledUnit(@"YottaMetrePerQuarticSecond", @"Ym/s4", MetrePerQuarticSecond, 1E+24, 0.0);
          ZettaMetrePerQuarticSecond = new ScaledUnit(@"ZettaMetrePerQuarticSecond", @"Zm/s4", MetrePerQuarticSecond, 1E+21, 0.0);
          ExaMetrePerQuarticSecond = new ScaledUnit(@"ExaMetrePerQuarticSecond", @"Em/s4", MetrePerQuarticSecond, 1E+18, 0.0);
          PetaMetrePerQuarticSecond = new ScaledUnit(@"PetaMetrePerQuarticSecond", @"Pm/s4", MetrePerQuarticSecond, 1E+15, 0.0);
          TeraMetrePerQuarticSecond = new ScaledUnit(@"TeraMetrePerQuarticSecond", @"Tm/s4", MetrePerQuarticSecond, 1000000000000, 0.0);
          GigaMetrePerQuarticSecond = new ScaledUnit(@"GigaMetrePerQuarticSecond", @"Gm/s4", MetrePerQuarticSecond, 1000000000, 0.0);
          MegaMetrePerQuarticSecond = new ScaledUnit(@"MegaMetrePerQuarticSecond", @"Mm/s4", MetrePerQuarticSecond, 1000000, 0.0);
          KiloMetrePerQuarticSecond = new ScaledUnit(@"KiloMetrePerQuarticSecond", @"km/s4", MetrePerQuarticSecond, 1000, 0.0);
          HectoMetrePerQuarticSecond = new ScaledUnit(@"HectoMetrePerQuarticSecond", @"hm/s4", MetrePerQuarticSecond, 100, 0.0);
          DecaMetrePerQuarticSecond = new ScaledUnit(@"DecaMetrePerQuarticSecond", @"dam/s4", MetrePerQuarticSecond, 10, 0.0);
          DeciMetrePerQuarticSecond = new ScaledUnit(@"DeciMetrePerQuarticSecond", @"dm/s4", MetrePerQuarticSecond, 0.1, 0.0);
          CentiMetrePerQuarticSecond = new ScaledUnit(@"CentiMetrePerQuarticSecond", @"cm/s4", MetrePerQuarticSecond, 0.01, 0.0);
          MilliMetrePerQuarticSecond = new ScaledUnit(@"MilliMetrePerQuarticSecond", @"mm/s4", MetrePerQuarticSecond, 0.001, 0.0);
          MicroMetrePerQuarticSecond = new ScaledUnit(@"MicroMetrePerQuarticSecond", @"µm/s4", MetrePerQuarticSecond, 1E-06, 0.0);
          NanoMetrePerQuarticSecond = new ScaledUnit(@"NanoMetrePerQuarticSecond", @"nm/s4", MetrePerQuarticSecond, 1E-09, 0.0);
          PicoMetrePerQuarticSecond = new ScaledUnit(@"PicoMetrePerQuarticSecond", @"pm/s4", MetrePerQuarticSecond, 1E-12, 0.0);
          FemtoMetrePerQuarticSecond = new ScaledUnit(@"FemtoMetrePerQuarticSecond", @"fm/s4", MetrePerQuarticSecond, 1E-15, 0.0);
          AttoMetrePerQuarticSecond = new ScaledUnit(@"AttoMetrePerQuarticSecond", @"am/s4", MetrePerQuarticSecond, 1E-18, 0.0);
          ZeptoMetrePerQuarticSecond = new ScaledUnit(@"ZeptoMetrePerQuarticSecond", @"zm/s4", MetrePerQuarticSecond, 1E-21, 0.0);
          YoctoMetrePerQuarticSecond = new ScaledUnit(@"YoctoMetrePerQuarticSecond", @"ym/s4", MetrePerQuarticSecond, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerQuarticSecond.Name, MetrePerQuarticSecond },
            { YottaMetrePerQuarticSecond.Name, YottaMetrePerQuarticSecond },
            { ZettaMetrePerQuarticSecond.Name, ZettaMetrePerQuarticSecond },
            { ExaMetrePerQuarticSecond.Name, ExaMetrePerQuarticSecond },
            { PetaMetrePerQuarticSecond.Name, PetaMetrePerQuarticSecond },
            { TeraMetrePerQuarticSecond.Name, TeraMetrePerQuarticSecond },
            { GigaMetrePerQuarticSecond.Name, GigaMetrePerQuarticSecond },
            { MegaMetrePerQuarticSecond.Name, MegaMetrePerQuarticSecond },
            { KiloMetrePerQuarticSecond.Name, KiloMetrePerQuarticSecond },
            { HectoMetrePerQuarticSecond.Name, HectoMetrePerQuarticSecond },
            { DecaMetrePerQuarticSecond.Name, DecaMetrePerQuarticSecond },
            { DeciMetrePerQuarticSecond.Name, DeciMetrePerQuarticSecond },
            { CentiMetrePerQuarticSecond.Name, CentiMetrePerQuarticSecond },
            { MilliMetrePerQuarticSecond.Name, MilliMetrePerQuarticSecond },
            { MicroMetrePerQuarticSecond.Name, MicroMetrePerQuarticSecond },
            { NanoMetrePerQuarticSecond.Name, NanoMetrePerQuarticSecond },
            { PicoMetrePerQuarticSecond.Name, PicoMetrePerQuarticSecond },
            { FemtoMetrePerQuarticSecond.Name, FemtoMetrePerQuarticSecond },
            { AttoMetrePerQuarticSecond.Name, AttoMetrePerQuarticSecond },
            { ZeptoMetrePerQuarticSecond.Name, ZeptoMetrePerQuarticSecond },
            { YoctoMetrePerQuarticSecond.Name, YoctoMetrePerQuarticSecond },
          };
        }

        static Jounce()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
