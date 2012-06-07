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
      public static partial class Density
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kilogram_per_cubic_metre
        /// </summary>
        public static BaseUnit KilogramPerCubicMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit ZettaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit ExaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit PetaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit TeraKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit GigaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit MegaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit KiloKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit HectoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit DecaKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit DeciKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit CentiKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit MilliKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit MicroKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit NanoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit PicoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit FemtoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit AttoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit ZeptoKilogramPerCubicMetre { get; private set; }
        public static ScaledUnit YoctoKilogramPerCubicMetre { get; private set; }

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
          KilogramPerCubicMetre = new BaseUnit(@"KilogramPerCubicMetre", @"kg/m³", PhysicalQuantities.Quantities.Density, unitSystem);
          YottaKilogramPerCubicMetre = new ScaledUnit(@"YottaKilogramPerCubicMetre", @"Ykg/m³", KilogramPerCubicMetre, 1E+24, 0.0);
          ZettaKilogramPerCubicMetre = new ScaledUnit(@"ZettaKilogramPerCubicMetre", @"Zkg/m³", KilogramPerCubicMetre, 1E+21, 0.0);
          ExaKilogramPerCubicMetre = new ScaledUnit(@"ExaKilogramPerCubicMetre", @"Ekg/m³", KilogramPerCubicMetre, 1E+18, 0.0);
          PetaKilogramPerCubicMetre = new ScaledUnit(@"PetaKilogramPerCubicMetre", @"Pkg/m³", KilogramPerCubicMetre, 1E+15, 0.0);
          TeraKilogramPerCubicMetre = new ScaledUnit(@"TeraKilogramPerCubicMetre", @"Tkg/m³", KilogramPerCubicMetre, 1000000000000, 0.0);
          GigaKilogramPerCubicMetre = new ScaledUnit(@"GigaKilogramPerCubicMetre", @"Gkg/m³", KilogramPerCubicMetre, 1000000000, 0.0);
          MegaKilogramPerCubicMetre = new ScaledUnit(@"MegaKilogramPerCubicMetre", @"Mkg/m³", KilogramPerCubicMetre, 1000000, 0.0);
          KiloKilogramPerCubicMetre = new ScaledUnit(@"KiloKilogramPerCubicMetre", @"kkg/m³", KilogramPerCubicMetre, 1000, 0.0);
          HectoKilogramPerCubicMetre = new ScaledUnit(@"HectoKilogramPerCubicMetre", @"hkg/m³", KilogramPerCubicMetre, 100, 0.0);
          DecaKilogramPerCubicMetre = new ScaledUnit(@"DecaKilogramPerCubicMetre", @"dakg/m³", KilogramPerCubicMetre, 10, 0.0);
          DeciKilogramPerCubicMetre = new ScaledUnit(@"DeciKilogramPerCubicMetre", @"dkg/m³", KilogramPerCubicMetre, 0.1, 0.0);
          CentiKilogramPerCubicMetre = new ScaledUnit(@"CentiKilogramPerCubicMetre", @"ckg/m³", KilogramPerCubicMetre, 0.01, 0.0);
          MilliKilogramPerCubicMetre = new ScaledUnit(@"MilliKilogramPerCubicMetre", @"mkg/m³", KilogramPerCubicMetre, 0.001, 0.0);
          MicroKilogramPerCubicMetre = new ScaledUnit(@"MicroKilogramPerCubicMetre", @"µkg/m³", KilogramPerCubicMetre, 1E-06, 0.0);
          NanoKilogramPerCubicMetre = new ScaledUnit(@"NanoKilogramPerCubicMetre", @"nkg/m³", KilogramPerCubicMetre, 1E-09, 0.0);
          PicoKilogramPerCubicMetre = new ScaledUnit(@"PicoKilogramPerCubicMetre", @"pkg/m³", KilogramPerCubicMetre, 1E-12, 0.0);
          FemtoKilogramPerCubicMetre = new ScaledUnit(@"FemtoKilogramPerCubicMetre", @"fkg/m³", KilogramPerCubicMetre, 1E-15, 0.0);
          AttoKilogramPerCubicMetre = new ScaledUnit(@"AttoKilogramPerCubicMetre", @"akg/m³", KilogramPerCubicMetre, 1E-18, 0.0);
          ZeptoKilogramPerCubicMetre = new ScaledUnit(@"ZeptoKilogramPerCubicMetre", @"zkg/m³", KilogramPerCubicMetre, 1E-21, 0.0);
          YoctoKilogramPerCubicMetre = new ScaledUnit(@"YoctoKilogramPerCubicMetre", @"ykg/m³", KilogramPerCubicMetre, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { KilogramPerCubicMetre.Name, KilogramPerCubicMetre },
            { YottaKilogramPerCubicMetre.Name, YottaKilogramPerCubicMetre },
            { ZettaKilogramPerCubicMetre.Name, ZettaKilogramPerCubicMetre },
            { ExaKilogramPerCubicMetre.Name, ExaKilogramPerCubicMetre },
            { PetaKilogramPerCubicMetre.Name, PetaKilogramPerCubicMetre },
            { TeraKilogramPerCubicMetre.Name, TeraKilogramPerCubicMetre },
            { GigaKilogramPerCubicMetre.Name, GigaKilogramPerCubicMetre },
            { MegaKilogramPerCubicMetre.Name, MegaKilogramPerCubicMetre },
            { KiloKilogramPerCubicMetre.Name, KiloKilogramPerCubicMetre },
            { HectoKilogramPerCubicMetre.Name, HectoKilogramPerCubicMetre },
            { DecaKilogramPerCubicMetre.Name, DecaKilogramPerCubicMetre },
            { DeciKilogramPerCubicMetre.Name, DeciKilogramPerCubicMetre },
            { CentiKilogramPerCubicMetre.Name, CentiKilogramPerCubicMetre },
            { MilliKilogramPerCubicMetre.Name, MilliKilogramPerCubicMetre },
            { MicroKilogramPerCubicMetre.Name, MicroKilogramPerCubicMetre },
            { NanoKilogramPerCubicMetre.Name, NanoKilogramPerCubicMetre },
            { PicoKilogramPerCubicMetre.Name, PicoKilogramPerCubicMetre },
            { FemtoKilogramPerCubicMetre.Name, FemtoKilogramPerCubicMetre },
            { AttoKilogramPerCubicMetre.Name, AttoKilogramPerCubicMetre },
            { ZeptoKilogramPerCubicMetre.Name, ZeptoKilogramPerCubicMetre },
            { YoctoKilogramPerCubicMetre.Name, YoctoKilogramPerCubicMetre },
          };
        }

        static Density()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
