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
      public static partial class CatalyticActivity
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Katal
        /// </summary>
        public static BaseUnit Katal { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaKatal { get; private set; }
        public static ScaledUnit ZettaKatal { get; private set; }
        public static ScaledUnit ExaKatal { get; private set; }
        public static ScaledUnit PetaKatal { get; private set; }
        public static ScaledUnit TeraKatal { get; private set; }
        public static ScaledUnit GigaKatal { get; private set; }
        public static ScaledUnit MegaKatal { get; private set; }
        public static ScaledUnit KiloKatal { get; private set; }
        public static ScaledUnit HectoKatal { get; private set; }
        public static ScaledUnit DecaKatal { get; private set; }
        public static ScaledUnit DeciKatal { get; private set; }
        public static ScaledUnit CentiKatal { get; private set; }
        public static ScaledUnit MilliKatal { get; private set; }
        public static ScaledUnit MicroKatal { get; private set; }
        public static ScaledUnit NanoKatal { get; private set; }
        public static ScaledUnit PicoKatal { get; private set; }
        public static ScaledUnit FemtoKatal { get; private set; }
        public static ScaledUnit AttoKatal { get; private set; }
        public static ScaledUnit ZeptoKatal { get; private set; }
        public static ScaledUnit YoctoKatal { get; private set; }

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
          Katal = new BaseUnit(@"Katal", @"kat", PhysicalQuantities.Quantities.CatalyticActivity, unitSystem);
          YottaKatal = new ScaledUnit(@"YottaKatal", @"Ykat", Katal, 1E+24, 0.0);
          ZettaKatal = new ScaledUnit(@"ZettaKatal", @"Zkat", Katal, 1E+21, 0.0);
          ExaKatal = new ScaledUnit(@"ExaKatal", @"Ekat", Katal, 1E+18, 0.0);
          PetaKatal = new ScaledUnit(@"PetaKatal", @"Pkat", Katal, 1E+15, 0.0);
          TeraKatal = new ScaledUnit(@"TeraKatal", @"Tkat", Katal, 1000000000000, 0.0);
          GigaKatal = new ScaledUnit(@"GigaKatal", @"Gkat", Katal, 1000000000, 0.0);
          MegaKatal = new ScaledUnit(@"MegaKatal", @"Mkat", Katal, 1000000, 0.0);
          KiloKatal = new ScaledUnit(@"KiloKatal", @"kkat", Katal, 1000, 0.0);
          HectoKatal = new ScaledUnit(@"HectoKatal", @"hkat", Katal, 100, 0.0);
          DecaKatal = new ScaledUnit(@"DecaKatal", @"dakat", Katal, 10, 0.0);
          DeciKatal = new ScaledUnit(@"DeciKatal", @"dkat", Katal, 0.1, 0.0);
          CentiKatal = new ScaledUnit(@"CentiKatal", @"ckat", Katal, 0.01, 0.0);
          MilliKatal = new ScaledUnit(@"MilliKatal", @"mkat", Katal, 0.001, 0.0);
          MicroKatal = new ScaledUnit(@"MicroKatal", @"µkat", Katal, 1E-06, 0.0);
          NanoKatal = new ScaledUnit(@"NanoKatal", @"nkat", Katal, 1E-09, 0.0);
          PicoKatal = new ScaledUnit(@"PicoKatal", @"pkat", Katal, 1E-12, 0.0);
          FemtoKatal = new ScaledUnit(@"FemtoKatal", @"fkat", Katal, 1E-15, 0.0);
          AttoKatal = new ScaledUnit(@"AttoKatal", @"akat", Katal, 1E-18, 0.0);
          ZeptoKatal = new ScaledUnit(@"ZeptoKatal", @"zkat", Katal, 1E-21, 0.0);
          YoctoKatal = new ScaledUnit(@"YoctoKatal", @"ykat", Katal, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Katal.Name, Katal },
            { YottaKatal.Name, YottaKatal },
            { ZettaKatal.Name, ZettaKatal },
            { ExaKatal.Name, ExaKatal },
            { PetaKatal.Name, PetaKatal },
            { TeraKatal.Name, TeraKatal },
            { GigaKatal.Name, GigaKatal },
            { MegaKatal.Name, MegaKatal },
            { KiloKatal.Name, KiloKatal },
            { HectoKatal.Name, HectoKatal },
            { DecaKatal.Name, DecaKatal },
            { DeciKatal.Name, DeciKatal },
            { CentiKatal.Name, CentiKatal },
            { MilliKatal.Name, MilliKatal },
            { MicroKatal.Name, MicroKatal },
            { NanoKatal.Name, NanoKatal },
            { PicoKatal.Name, PicoKatal },
            { FemtoKatal.Name, FemtoKatal },
            { AttoKatal.Name, AttoKatal },
            { ZeptoKatal.Name, ZeptoKatal },
            { YoctoKatal.Name, YoctoKatal },
          };
        }

        static CatalyticActivity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
