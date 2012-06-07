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
      public static partial class Force
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_(unit)
        /// </summary>
        public static BaseUnit Newton { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewton { get; private set; }
        public static ScaledUnit ZettaNewton { get; private set; }
        public static ScaledUnit ExaNewton { get; private set; }
        public static ScaledUnit PetaNewton { get; private set; }
        public static ScaledUnit TeraNewton { get; private set; }
        public static ScaledUnit GigaNewton { get; private set; }
        public static ScaledUnit MegaNewton { get; private set; }
        public static ScaledUnit KiloNewton { get; private set; }
        public static ScaledUnit HectoNewton { get; private set; }
        public static ScaledUnit DecaNewton { get; private set; }
        public static ScaledUnit DeciNewton { get; private set; }
        public static ScaledUnit CentiNewton { get; private set; }
        public static ScaledUnit MilliNewton { get; private set; }
        public static ScaledUnit MicroNewton { get; private set; }
        public static ScaledUnit NanoNewton { get; private set; }
        public static ScaledUnit PicoNewton { get; private set; }
        public static ScaledUnit FemtoNewton { get; private set; }
        public static ScaledUnit AttoNewton { get; private set; }
        public static ScaledUnit ZeptoNewton { get; private set; }
        public static ScaledUnit YoctoNewton { get; private set; }

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
          Newton = new BaseUnit(@"Newton", @"N", PhysicalQuantities.Quantities.Force, unitSystem);
          YottaNewton = new ScaledUnit(@"YottaNewton", @"YN", Newton, 1E+24, 0.0);
          ZettaNewton = new ScaledUnit(@"ZettaNewton", @"ZN", Newton, 1E+21, 0.0);
          ExaNewton = new ScaledUnit(@"ExaNewton", @"EN", Newton, 1E+18, 0.0);
          PetaNewton = new ScaledUnit(@"PetaNewton", @"PN", Newton, 1E+15, 0.0);
          TeraNewton = new ScaledUnit(@"TeraNewton", @"TN", Newton, 1000000000000, 0.0);
          GigaNewton = new ScaledUnit(@"GigaNewton", @"GN", Newton, 1000000000, 0.0);
          MegaNewton = new ScaledUnit(@"MegaNewton", @"MN", Newton, 1000000, 0.0);
          KiloNewton = new ScaledUnit(@"KiloNewton", @"kN", Newton, 1000, 0.0);
          HectoNewton = new ScaledUnit(@"HectoNewton", @"hN", Newton, 100, 0.0);
          DecaNewton = new ScaledUnit(@"DecaNewton", @"daN", Newton, 10, 0.0);
          DeciNewton = new ScaledUnit(@"DeciNewton", @"dN", Newton, 0.1, 0.0);
          CentiNewton = new ScaledUnit(@"CentiNewton", @"cN", Newton, 0.01, 0.0);
          MilliNewton = new ScaledUnit(@"MilliNewton", @"mN", Newton, 0.001, 0.0);
          MicroNewton = new ScaledUnit(@"MicroNewton", @"µN", Newton, 1E-06, 0.0);
          NanoNewton = new ScaledUnit(@"NanoNewton", @"nN", Newton, 1E-09, 0.0);
          PicoNewton = new ScaledUnit(@"PicoNewton", @"pN", Newton, 1E-12, 0.0);
          FemtoNewton = new ScaledUnit(@"FemtoNewton", @"fN", Newton, 1E-15, 0.0);
          AttoNewton = new ScaledUnit(@"AttoNewton", @"aN", Newton, 1E-18, 0.0);
          ZeptoNewton = new ScaledUnit(@"ZeptoNewton", @"zN", Newton, 1E-21, 0.0);
          YoctoNewton = new ScaledUnit(@"YoctoNewton", @"yN", Newton, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Newton.Name, Newton },
            { YottaNewton.Name, YottaNewton },
            { ZettaNewton.Name, ZettaNewton },
            { ExaNewton.Name, ExaNewton },
            { PetaNewton.Name, PetaNewton },
            { TeraNewton.Name, TeraNewton },
            { GigaNewton.Name, GigaNewton },
            { MegaNewton.Name, MegaNewton },
            { KiloNewton.Name, KiloNewton },
            { HectoNewton.Name, HectoNewton },
            { DecaNewton.Name, DecaNewton },
            { DeciNewton.Name, DeciNewton },
            { CentiNewton.Name, CentiNewton },
            { MilliNewton.Name, MilliNewton },
            { MicroNewton.Name, MicroNewton },
            { NanoNewton.Name, NanoNewton },
            { PicoNewton.Name, PicoNewton },
            { FemtoNewton.Name, FemtoNewton },
            { AttoNewton.Name, AttoNewton },
            { ZeptoNewton.Name, ZeptoNewton },
            { YoctoNewton.Name, YoctoNewton },
          };
        }

        static Force()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
