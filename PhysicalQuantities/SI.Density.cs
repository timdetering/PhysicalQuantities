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
          KilogramPerCubicMetre = new BaseUnit(@"KilogramPerCubicMetre", @"kg/m³", PhysicalQuantities.Quantities.Density, unitSystem) { Caption = @"kilogramo por metro cúbico" };
          YottaKilogramPerCubicMetre = new ScaledUnit(@"YottaKilogramPerCubicMetre", @"Ykg/m³", KilogramPerCubicMetre, 1E+24, 0.0) { Caption = @"yottakilogramo por metro cúbico" };
          ZettaKilogramPerCubicMetre = new ScaledUnit(@"ZettaKilogramPerCubicMetre", @"Zkg/m³", KilogramPerCubicMetre, 1E+21, 0.0) { Caption = @"zettakilogramo por metro cúbico" };
          ExaKilogramPerCubicMetre = new ScaledUnit(@"ExaKilogramPerCubicMetre", @"Ekg/m³", KilogramPerCubicMetre, 1E+18, 0.0) { Caption = @"exakilogramo por metro cúbico" };
          PetaKilogramPerCubicMetre = new ScaledUnit(@"PetaKilogramPerCubicMetre", @"Pkg/m³", KilogramPerCubicMetre, 1E+15, 0.0) { Caption = @"petakilogramo por metro cúbico" };
          TeraKilogramPerCubicMetre = new ScaledUnit(@"TeraKilogramPerCubicMetre", @"Tkg/m³", KilogramPerCubicMetre, 1000000000000, 0.0) { Caption = @"terakilogramo por metro cúbico" };
          GigaKilogramPerCubicMetre = new ScaledUnit(@"GigaKilogramPerCubicMetre", @"Gkg/m³", KilogramPerCubicMetre, 1000000000, 0.0) { Caption = @"gigakilogramo por metro cúbico" };
          MegaKilogramPerCubicMetre = new ScaledUnit(@"MegaKilogramPerCubicMetre", @"Mkg/m³", KilogramPerCubicMetre, 1000000, 0.0) { Caption = @"megakilogramo por metro cúbico" };
          KiloKilogramPerCubicMetre = new ScaledUnit(@"KiloKilogramPerCubicMetre", @"kkg/m³", KilogramPerCubicMetre, 1000, 0.0) { Caption = @"kilokilogramo por metro cúbico" };
          HectoKilogramPerCubicMetre = new ScaledUnit(@"HectoKilogramPerCubicMetre", @"hkg/m³", KilogramPerCubicMetre, 100, 0.0) { Caption = @"hectokilogramo por metro cúbico" };
          DecaKilogramPerCubicMetre = new ScaledUnit(@"DecaKilogramPerCubicMetre", @"dakg/m³", KilogramPerCubicMetre, 10, 0.0) { Caption = @"decakilogramo por metro cúbico" };
          DeciKilogramPerCubicMetre = new ScaledUnit(@"DeciKilogramPerCubicMetre", @"dkg/m³", KilogramPerCubicMetre, 0.1, 0.0) { Caption = @"decikilogramo por metro cúbico" };
          CentiKilogramPerCubicMetre = new ScaledUnit(@"CentiKilogramPerCubicMetre", @"ckg/m³", KilogramPerCubicMetre, 0.01, 0.0) { Caption = @"centikilogramo por metro cúbico" };
          MilliKilogramPerCubicMetre = new ScaledUnit(@"MilliKilogramPerCubicMetre", @"mkg/m³", KilogramPerCubicMetre, 0.001, 0.0) { Caption = @"milikilogramo por metro cúbico" };
          MicroKilogramPerCubicMetre = new ScaledUnit(@"MicroKilogramPerCubicMetre", @"μkg/m³", KilogramPerCubicMetre, 1E-06, 0.0) { Caption = @"microkilogramo por metro cúbico" };
          NanoKilogramPerCubicMetre = new ScaledUnit(@"NanoKilogramPerCubicMetre", @"nkg/m³", KilogramPerCubicMetre, 1E-09, 0.0) { Caption = @"nanokilogramo por metro cúbico" };
          PicoKilogramPerCubicMetre = new ScaledUnit(@"PicoKilogramPerCubicMetre", @"pkg/m³", KilogramPerCubicMetre, 1E-12, 0.0) { Caption = @"picokilogramo por metro cúbico" };
          FemtoKilogramPerCubicMetre = new ScaledUnit(@"FemtoKilogramPerCubicMetre", @"fkg/m³", KilogramPerCubicMetre, 1E-15, 0.0) { Caption = @"femtokilogramo por metro cúbico" };
          AttoKilogramPerCubicMetre = new ScaledUnit(@"AttoKilogramPerCubicMetre", @"akg/m³", KilogramPerCubicMetre, 1E-18, 0.0) { Caption = @"attokilogramo por metro cúbico" };
          ZeptoKilogramPerCubicMetre = new ScaledUnit(@"ZeptoKilogramPerCubicMetre", @"zkg/m³", KilogramPerCubicMetre, 1E-21, 0.0) { Caption = @"zeptokilogramo por metro cúbico" };
          YoctoKilogramPerCubicMetre = new ScaledUnit(@"YoctoKilogramPerCubicMetre", @"ykg/m³", KilogramPerCubicMetre, 1E-24, 0.0) { Caption = @"yoctokilogramo por metro cúbico" };

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
