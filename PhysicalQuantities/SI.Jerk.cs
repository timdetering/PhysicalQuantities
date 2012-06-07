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
      public static partial class Jerk
      {
        public static BaseUnit MetrePerSecondCubed { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit ZettaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit ExaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit PetaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit TeraMetrePerSecondCubed { get; private set; }
        public static ScaledUnit GigaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit MegaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit KiloMetrePerSecondCubed { get; private set; }
        public static ScaledUnit HectoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit DecaMetrePerSecondCubed { get; private set; }
        public static ScaledUnit DeciMetrePerSecondCubed { get; private set; }
        public static ScaledUnit CentiMetrePerSecondCubed { get; private set; }
        public static ScaledUnit MilliMetrePerSecondCubed { get; private set; }
        public static ScaledUnit MicroMetrePerSecondCubed { get; private set; }
        public static ScaledUnit NanoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit PicoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit FemtoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit AttoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit ZeptoMetrePerSecondCubed { get; private set; }
        public static ScaledUnit YoctoMetrePerSecondCubed { get; private set; }

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
          MetrePerSecondCubed = new BaseUnit(@"MetrePerSecondCubed", @"m/s³", PhysicalQuantities.Quantities.Jerk, unitSystem);
          YottaMetrePerSecondCubed = new ScaledUnit(@"YottaMetrePerSecondCubed", @"Ym/s³", MetrePerSecondCubed, 1E+24, 0.0);
          ZettaMetrePerSecondCubed = new ScaledUnit(@"ZettaMetrePerSecondCubed", @"Zm/s³", MetrePerSecondCubed, 1E+21, 0.0);
          ExaMetrePerSecondCubed = new ScaledUnit(@"ExaMetrePerSecondCubed", @"Em/s³", MetrePerSecondCubed, 1E+18, 0.0);
          PetaMetrePerSecondCubed = new ScaledUnit(@"PetaMetrePerSecondCubed", @"Pm/s³", MetrePerSecondCubed, 1E+15, 0.0);
          TeraMetrePerSecondCubed = new ScaledUnit(@"TeraMetrePerSecondCubed", @"Tm/s³", MetrePerSecondCubed, 1000000000000, 0.0);
          GigaMetrePerSecondCubed = new ScaledUnit(@"GigaMetrePerSecondCubed", @"Gm/s³", MetrePerSecondCubed, 1000000000, 0.0);
          MegaMetrePerSecondCubed = new ScaledUnit(@"MegaMetrePerSecondCubed", @"Mm/s³", MetrePerSecondCubed, 1000000, 0.0);
          KiloMetrePerSecondCubed = new ScaledUnit(@"KiloMetrePerSecondCubed", @"km/s³", MetrePerSecondCubed, 1000, 0.0);
          HectoMetrePerSecondCubed = new ScaledUnit(@"HectoMetrePerSecondCubed", @"hm/s³", MetrePerSecondCubed, 100, 0.0);
          DecaMetrePerSecondCubed = new ScaledUnit(@"DecaMetrePerSecondCubed", @"dam/s³", MetrePerSecondCubed, 10, 0.0);
          DeciMetrePerSecondCubed = new ScaledUnit(@"DeciMetrePerSecondCubed", @"dm/s³", MetrePerSecondCubed, 0.1, 0.0);
          CentiMetrePerSecondCubed = new ScaledUnit(@"CentiMetrePerSecondCubed", @"cm/s³", MetrePerSecondCubed, 0.01, 0.0);
          MilliMetrePerSecondCubed = new ScaledUnit(@"MilliMetrePerSecondCubed", @"mm/s³", MetrePerSecondCubed, 0.001, 0.0);
          MicroMetrePerSecondCubed = new ScaledUnit(@"MicroMetrePerSecondCubed", @"µm/s³", MetrePerSecondCubed, 1E-06, 0.0);
          NanoMetrePerSecondCubed = new ScaledUnit(@"NanoMetrePerSecondCubed", @"nm/s³", MetrePerSecondCubed, 1E-09, 0.0);
          PicoMetrePerSecondCubed = new ScaledUnit(@"PicoMetrePerSecondCubed", @"pm/s³", MetrePerSecondCubed, 1E-12, 0.0);
          FemtoMetrePerSecondCubed = new ScaledUnit(@"FemtoMetrePerSecondCubed", @"fm/s³", MetrePerSecondCubed, 1E-15, 0.0);
          AttoMetrePerSecondCubed = new ScaledUnit(@"AttoMetrePerSecondCubed", @"am/s³", MetrePerSecondCubed, 1E-18, 0.0);
          ZeptoMetrePerSecondCubed = new ScaledUnit(@"ZeptoMetrePerSecondCubed", @"zm/s³", MetrePerSecondCubed, 1E-21, 0.0);
          YoctoMetrePerSecondCubed = new ScaledUnit(@"YoctoMetrePerSecondCubed", @"ym/s³", MetrePerSecondCubed, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { MetrePerSecondCubed.Name, MetrePerSecondCubed },
            { YottaMetrePerSecondCubed.Name, YottaMetrePerSecondCubed },
            { ZettaMetrePerSecondCubed.Name, ZettaMetrePerSecondCubed },
            { ExaMetrePerSecondCubed.Name, ExaMetrePerSecondCubed },
            { PetaMetrePerSecondCubed.Name, PetaMetrePerSecondCubed },
            { TeraMetrePerSecondCubed.Name, TeraMetrePerSecondCubed },
            { GigaMetrePerSecondCubed.Name, GigaMetrePerSecondCubed },
            { MegaMetrePerSecondCubed.Name, MegaMetrePerSecondCubed },
            { KiloMetrePerSecondCubed.Name, KiloMetrePerSecondCubed },
            { HectoMetrePerSecondCubed.Name, HectoMetrePerSecondCubed },
            { DecaMetrePerSecondCubed.Name, DecaMetrePerSecondCubed },
            { DeciMetrePerSecondCubed.Name, DeciMetrePerSecondCubed },
            { CentiMetrePerSecondCubed.Name, CentiMetrePerSecondCubed },
            { MilliMetrePerSecondCubed.Name, MilliMetrePerSecondCubed },
            { MicroMetrePerSecondCubed.Name, MicroMetrePerSecondCubed },
            { NanoMetrePerSecondCubed.Name, NanoMetrePerSecondCubed },
            { PicoMetrePerSecondCubed.Name, PicoMetrePerSecondCubed },
            { FemtoMetrePerSecondCubed.Name, FemtoMetrePerSecondCubed },
            { AttoMetrePerSecondCubed.Name, AttoMetrePerSecondCubed },
            { ZeptoMetrePerSecondCubed.Name, ZeptoMetrePerSecondCubed },
            { YoctoMetrePerSecondCubed.Name, YoctoMetrePerSecondCubed },
          };
        }

        static Jerk()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
