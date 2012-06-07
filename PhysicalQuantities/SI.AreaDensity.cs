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
      public static partial class AreaDensity
      {
        public static BaseUnit KilogramPerSquareMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ZettaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ExaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit PetaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit TeraKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit GigaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MegaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit KiloKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit HectoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit DecaKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit DeciKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit CentiKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MilliKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit MicroKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit NanoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit PicoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit FemtoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit AttoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit ZeptoKilogramPerSquareMetre { get; private set; }
        public static ScaledUnit YoctoKilogramPerSquareMetre { get; private set; }

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
          KilogramPerSquareMetre = new BaseUnit(@"KilogramPerSquareMetre", @"kg/m²", PhysicalQuantities.Quantities.AreaDensity, unitSystem);
          YottaKilogramPerSquareMetre = new ScaledUnit(@"YottaKilogramPerSquareMetre", @"Ykg/m²", KilogramPerSquareMetre, 1E+24, 0.0);
          ZettaKilogramPerSquareMetre = new ScaledUnit(@"ZettaKilogramPerSquareMetre", @"Zkg/m²", KilogramPerSquareMetre, 1E+21, 0.0);
          ExaKilogramPerSquareMetre = new ScaledUnit(@"ExaKilogramPerSquareMetre", @"Ekg/m²", KilogramPerSquareMetre, 1E+18, 0.0);
          PetaKilogramPerSquareMetre = new ScaledUnit(@"PetaKilogramPerSquareMetre", @"Pkg/m²", KilogramPerSquareMetre, 1E+15, 0.0);
          TeraKilogramPerSquareMetre = new ScaledUnit(@"TeraKilogramPerSquareMetre", @"Tkg/m²", KilogramPerSquareMetre, 1000000000000, 0.0);
          GigaKilogramPerSquareMetre = new ScaledUnit(@"GigaKilogramPerSquareMetre", @"Gkg/m²", KilogramPerSquareMetre, 1000000000, 0.0);
          MegaKilogramPerSquareMetre = new ScaledUnit(@"MegaKilogramPerSquareMetre", @"Mkg/m²", KilogramPerSquareMetre, 1000000, 0.0);
          KiloKilogramPerSquareMetre = new ScaledUnit(@"KiloKilogramPerSquareMetre", @"kkg/m²", KilogramPerSquareMetre, 1000, 0.0);
          HectoKilogramPerSquareMetre = new ScaledUnit(@"HectoKilogramPerSquareMetre", @"hkg/m²", KilogramPerSquareMetre, 100, 0.0);
          DecaKilogramPerSquareMetre = new ScaledUnit(@"DecaKilogramPerSquareMetre", @"dakg/m²", KilogramPerSquareMetre, 10, 0.0);
          DeciKilogramPerSquareMetre = new ScaledUnit(@"DeciKilogramPerSquareMetre", @"dkg/m²", KilogramPerSquareMetre, 0.1, 0.0);
          CentiKilogramPerSquareMetre = new ScaledUnit(@"CentiKilogramPerSquareMetre", @"ckg/m²", KilogramPerSquareMetre, 0.01, 0.0);
          MilliKilogramPerSquareMetre = new ScaledUnit(@"MilliKilogramPerSquareMetre", @"mkg/m²", KilogramPerSquareMetre, 0.001, 0.0);
          MicroKilogramPerSquareMetre = new ScaledUnit(@"MicroKilogramPerSquareMetre", @"µkg/m²", KilogramPerSquareMetre, 1E-06, 0.0);
          NanoKilogramPerSquareMetre = new ScaledUnit(@"NanoKilogramPerSquareMetre", @"nkg/m²", KilogramPerSquareMetre, 1E-09, 0.0);
          PicoKilogramPerSquareMetre = new ScaledUnit(@"PicoKilogramPerSquareMetre", @"pkg/m²", KilogramPerSquareMetre, 1E-12, 0.0);
          FemtoKilogramPerSquareMetre = new ScaledUnit(@"FemtoKilogramPerSquareMetre", @"fkg/m²", KilogramPerSquareMetre, 1E-15, 0.0);
          AttoKilogramPerSquareMetre = new ScaledUnit(@"AttoKilogramPerSquareMetre", @"akg/m²", KilogramPerSquareMetre, 1E-18, 0.0);
          ZeptoKilogramPerSquareMetre = new ScaledUnit(@"ZeptoKilogramPerSquareMetre", @"zkg/m²", KilogramPerSquareMetre, 1E-21, 0.0);
          YoctoKilogramPerSquareMetre = new ScaledUnit(@"YoctoKilogramPerSquareMetre", @"ykg/m²", KilogramPerSquareMetre, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { KilogramPerSquareMetre.Name, KilogramPerSquareMetre },
            { YottaKilogramPerSquareMetre.Name, YottaKilogramPerSquareMetre },
            { ZettaKilogramPerSquareMetre.Name, ZettaKilogramPerSquareMetre },
            { ExaKilogramPerSquareMetre.Name, ExaKilogramPerSquareMetre },
            { PetaKilogramPerSquareMetre.Name, PetaKilogramPerSquareMetre },
            { TeraKilogramPerSquareMetre.Name, TeraKilogramPerSquareMetre },
            { GigaKilogramPerSquareMetre.Name, GigaKilogramPerSquareMetre },
            { MegaKilogramPerSquareMetre.Name, MegaKilogramPerSquareMetre },
            { KiloKilogramPerSquareMetre.Name, KiloKilogramPerSquareMetre },
            { HectoKilogramPerSquareMetre.Name, HectoKilogramPerSquareMetre },
            { DecaKilogramPerSquareMetre.Name, DecaKilogramPerSquareMetre },
            { DeciKilogramPerSquareMetre.Name, DeciKilogramPerSquareMetre },
            { CentiKilogramPerSquareMetre.Name, CentiKilogramPerSquareMetre },
            { MilliKilogramPerSquareMetre.Name, MilliKilogramPerSquareMetre },
            { MicroKilogramPerSquareMetre.Name, MicroKilogramPerSquareMetre },
            { NanoKilogramPerSquareMetre.Name, NanoKilogramPerSquareMetre },
            { PicoKilogramPerSquareMetre.Name, PicoKilogramPerSquareMetre },
            { FemtoKilogramPerSquareMetre.Name, FemtoKilogramPerSquareMetre },
            { AttoKilogramPerSquareMetre.Name, AttoKilogramPerSquareMetre },
            { ZeptoKilogramPerSquareMetre.Name, ZeptoKilogramPerSquareMetre },
            { YoctoKilogramPerSquareMetre.Name, YoctoKilogramPerSquareMetre },
          };
        }

        static AreaDensity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
