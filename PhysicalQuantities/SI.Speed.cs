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
      public static partial class Speed
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre_per_second
        /// </summary>
        public static BaseUnit MetrePerSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetrePerSecond { get; private set; }
        public static ScaledUnit ZettaMetrePerSecond { get; private set; }
        public static ScaledUnit ExaMetrePerSecond { get; private set; }
        public static ScaledUnit PetaMetrePerSecond { get; private set; }
        public static ScaledUnit TeraMetrePerSecond { get; private set; }
        public static ScaledUnit GigaMetrePerSecond { get; private set; }
        public static ScaledUnit MegaMetrePerSecond { get; private set; }
        public static ScaledUnit KiloMetrePerSecond { get; private set; }
        public static ScaledUnit HectoMetrePerSecond { get; private set; }
        public static ScaledUnit DecaMetrePerSecond { get; private set; }
        public static ScaledUnit DeciMetrePerSecond { get; private set; }
        public static ScaledUnit CentiMetrePerSecond { get; private set; }
        public static ScaledUnit MilliMetrePerSecond { get; private set; }
        public static ScaledUnit MicroMetrePerSecond { get; private set; }
        public static ScaledUnit NanoMetrePerSecond { get; private set; }
        public static ScaledUnit PicoMetrePerSecond { get; private set; }
        public static ScaledUnit FemtoMetrePerSecond { get; private set; }
        public static ScaledUnit AttoMetrePerSecond { get; private set; }
        public static ScaledUnit ZeptoMetrePerSecond { get; private set; }
        public static ScaledUnit YoctoMetrePerSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Speed_of_light
        /// </summary>
        public static ScaledUnit SpeedOfLight { get; private set; }

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
          MetrePerSecond = new BaseUnit(@"MetrePerSecond", @"m/s", PhysicalQuantities.Quantities.Speed, unitSystem);
          YottaMetrePerSecond = new ScaledUnit(@"YottaMetrePerSecond", @"Ym/s", MetrePerSecond, 1E+24, 0.0);
          ZettaMetrePerSecond = new ScaledUnit(@"ZettaMetrePerSecond", @"Zm/s", MetrePerSecond, 1E+21, 0.0);
          ExaMetrePerSecond = new ScaledUnit(@"ExaMetrePerSecond", @"Em/s", MetrePerSecond, 1E+18, 0.0);
          PetaMetrePerSecond = new ScaledUnit(@"PetaMetrePerSecond", @"Pm/s", MetrePerSecond, 1E+15, 0.0);
          TeraMetrePerSecond = new ScaledUnit(@"TeraMetrePerSecond", @"Tm/s", MetrePerSecond, 1000000000000, 0.0);
          GigaMetrePerSecond = new ScaledUnit(@"GigaMetrePerSecond", @"Gm/s", MetrePerSecond, 1000000000, 0.0);
          MegaMetrePerSecond = new ScaledUnit(@"MegaMetrePerSecond", @"Mm/s", MetrePerSecond, 1000000, 0.0);
          KiloMetrePerSecond = new ScaledUnit(@"KiloMetrePerSecond", @"km/s", MetrePerSecond, 1000, 0.0);
          HectoMetrePerSecond = new ScaledUnit(@"HectoMetrePerSecond", @"hm/s", MetrePerSecond, 100, 0.0);
          DecaMetrePerSecond = new ScaledUnit(@"DecaMetrePerSecond", @"dam/s", MetrePerSecond, 10, 0.0);
          DeciMetrePerSecond = new ScaledUnit(@"DeciMetrePerSecond", @"dm/s", MetrePerSecond, 0.1, 0.0);
          CentiMetrePerSecond = new ScaledUnit(@"CentiMetrePerSecond", @"cm/s", MetrePerSecond, 0.01, 0.0);
          MilliMetrePerSecond = new ScaledUnit(@"MilliMetrePerSecond", @"mm/s", MetrePerSecond, 0.001, 0.0);
          MicroMetrePerSecond = new ScaledUnit(@"MicroMetrePerSecond", @"µm/s", MetrePerSecond, 1E-06, 0.0);
          NanoMetrePerSecond = new ScaledUnit(@"NanoMetrePerSecond", @"nm/s", MetrePerSecond, 1E-09, 0.0);
          PicoMetrePerSecond = new ScaledUnit(@"PicoMetrePerSecond", @"pm/s", MetrePerSecond, 1E-12, 0.0);
          FemtoMetrePerSecond = new ScaledUnit(@"FemtoMetrePerSecond", @"fm/s", MetrePerSecond, 1E-15, 0.0);
          AttoMetrePerSecond = new ScaledUnit(@"AttoMetrePerSecond", @"am/s", MetrePerSecond, 1E-18, 0.0);
          ZeptoMetrePerSecond = new ScaledUnit(@"ZeptoMetrePerSecond", @"zm/s", MetrePerSecond, 1E-21, 0.0);
          YoctoMetrePerSecond = new ScaledUnit(@"YoctoMetrePerSecond", @"ym/s", MetrePerSecond, 1E-24, 0.0);
          SpeedOfLight = new ScaledUnit(@"SpeedOfLight", @"c", MetrePerSecond, 299792458, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecond.Name, MetrePerSecond },
            { YottaMetrePerSecond.Name, YottaMetrePerSecond },
            { ZettaMetrePerSecond.Name, ZettaMetrePerSecond },
            { ExaMetrePerSecond.Name, ExaMetrePerSecond },
            { PetaMetrePerSecond.Name, PetaMetrePerSecond },
            { TeraMetrePerSecond.Name, TeraMetrePerSecond },
            { GigaMetrePerSecond.Name, GigaMetrePerSecond },
            { MegaMetrePerSecond.Name, MegaMetrePerSecond },
            { KiloMetrePerSecond.Name, KiloMetrePerSecond },
            { HectoMetrePerSecond.Name, HectoMetrePerSecond },
            { DecaMetrePerSecond.Name, DecaMetrePerSecond },
            { DeciMetrePerSecond.Name, DeciMetrePerSecond },
            { CentiMetrePerSecond.Name, CentiMetrePerSecond },
            { MilliMetrePerSecond.Name, MilliMetrePerSecond },
            { MicroMetrePerSecond.Name, MicroMetrePerSecond },
            { NanoMetrePerSecond.Name, NanoMetrePerSecond },
            { PicoMetrePerSecond.Name, PicoMetrePerSecond },
            { FemtoMetrePerSecond.Name, FemtoMetrePerSecond },
            { AttoMetrePerSecond.Name, AttoMetrePerSecond },
            { ZeptoMetrePerSecond.Name, ZeptoMetrePerSecond },
            { YoctoMetrePerSecond.Name, YoctoMetrePerSecond },
            { SpeedOfLight.Name, SpeedOfLight },
          };
        }

        static Speed()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
