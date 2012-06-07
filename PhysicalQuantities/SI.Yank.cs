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
      public static partial class Yank
      {
        public static BaseUnit NewtonPerSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewtonPerSecond { get; private set; }
        public static ScaledUnit ZettaNewtonPerSecond { get; private set; }
        public static ScaledUnit ExaNewtonPerSecond { get; private set; }
        public static ScaledUnit PetaNewtonPerSecond { get; private set; }
        public static ScaledUnit TeraNewtonPerSecond { get; private set; }
        public static ScaledUnit GigaNewtonPerSecond { get; private set; }
        public static ScaledUnit MegaNewtonPerSecond { get; private set; }
        public static ScaledUnit KiloNewtonPerSecond { get; private set; }
        public static ScaledUnit HectoNewtonPerSecond { get; private set; }
        public static ScaledUnit DecaNewtonPerSecond { get; private set; }
        public static ScaledUnit DeciNewtonPerSecond { get; private set; }
        public static ScaledUnit CentiNewtonPerSecond { get; private set; }
        public static ScaledUnit MilliNewtonPerSecond { get; private set; }
        public static ScaledUnit MicroNewtonPerSecond { get; private set; }
        public static ScaledUnit NanoNewtonPerSecond { get; private set; }
        public static ScaledUnit PicoNewtonPerSecond { get; private set; }
        public static ScaledUnit FemtoNewtonPerSecond { get; private set; }
        public static ScaledUnit AttoNewtonPerSecond { get; private set; }
        public static ScaledUnit ZeptoNewtonPerSecond { get; private set; }
        public static ScaledUnit YoctoNewtonPerSecond { get; private set; }

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
          NewtonPerSecond = new BaseUnit(@"NewtonPerSecond", @"N/s", PhysicalQuantities.Quantities.Yank, unitSystem);
          YottaNewtonPerSecond = new ScaledUnit(@"YottaNewtonPerSecond", @"YN/s", NewtonPerSecond, 1E+24, 0.0);
          ZettaNewtonPerSecond = new ScaledUnit(@"ZettaNewtonPerSecond", @"ZN/s", NewtonPerSecond, 1E+21, 0.0);
          ExaNewtonPerSecond = new ScaledUnit(@"ExaNewtonPerSecond", @"EN/s", NewtonPerSecond, 1E+18, 0.0);
          PetaNewtonPerSecond = new ScaledUnit(@"PetaNewtonPerSecond", @"PN/s", NewtonPerSecond, 1E+15, 0.0);
          TeraNewtonPerSecond = new ScaledUnit(@"TeraNewtonPerSecond", @"TN/s", NewtonPerSecond, 1000000000000, 0.0);
          GigaNewtonPerSecond = new ScaledUnit(@"GigaNewtonPerSecond", @"GN/s", NewtonPerSecond, 1000000000, 0.0);
          MegaNewtonPerSecond = new ScaledUnit(@"MegaNewtonPerSecond", @"MN/s", NewtonPerSecond, 1000000, 0.0);
          KiloNewtonPerSecond = new ScaledUnit(@"KiloNewtonPerSecond", @"kN/s", NewtonPerSecond, 1000, 0.0);
          HectoNewtonPerSecond = new ScaledUnit(@"HectoNewtonPerSecond", @"hN/s", NewtonPerSecond, 100, 0.0);
          DecaNewtonPerSecond = new ScaledUnit(@"DecaNewtonPerSecond", @"daN/s", NewtonPerSecond, 10, 0.0);
          DeciNewtonPerSecond = new ScaledUnit(@"DeciNewtonPerSecond", @"dN/s", NewtonPerSecond, 0.1, 0.0);
          CentiNewtonPerSecond = new ScaledUnit(@"CentiNewtonPerSecond", @"cN/s", NewtonPerSecond, 0.01, 0.0);
          MilliNewtonPerSecond = new ScaledUnit(@"MilliNewtonPerSecond", @"mN/s", NewtonPerSecond, 0.001, 0.0);
          MicroNewtonPerSecond = new ScaledUnit(@"MicroNewtonPerSecond", @"µN/s", NewtonPerSecond, 1E-06, 0.0);
          NanoNewtonPerSecond = new ScaledUnit(@"NanoNewtonPerSecond", @"nN/s", NewtonPerSecond, 1E-09, 0.0);
          PicoNewtonPerSecond = new ScaledUnit(@"PicoNewtonPerSecond", @"pN/s", NewtonPerSecond, 1E-12, 0.0);
          FemtoNewtonPerSecond = new ScaledUnit(@"FemtoNewtonPerSecond", @"fN/s", NewtonPerSecond, 1E-15, 0.0);
          AttoNewtonPerSecond = new ScaledUnit(@"AttoNewtonPerSecond", @"aN/s", NewtonPerSecond, 1E-18, 0.0);
          ZeptoNewtonPerSecond = new ScaledUnit(@"ZeptoNewtonPerSecond", @"zN/s", NewtonPerSecond, 1E-21, 0.0);
          YoctoNewtonPerSecond = new ScaledUnit(@"YoctoNewtonPerSecond", @"yN/s", NewtonPerSecond, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonPerSecond.Name, NewtonPerSecond },
            { YottaNewtonPerSecond.Name, YottaNewtonPerSecond },
            { ZettaNewtonPerSecond.Name, ZettaNewtonPerSecond },
            { ExaNewtonPerSecond.Name, ExaNewtonPerSecond },
            { PetaNewtonPerSecond.Name, PetaNewtonPerSecond },
            { TeraNewtonPerSecond.Name, TeraNewtonPerSecond },
            { GigaNewtonPerSecond.Name, GigaNewtonPerSecond },
            { MegaNewtonPerSecond.Name, MegaNewtonPerSecond },
            { KiloNewtonPerSecond.Name, KiloNewtonPerSecond },
            { HectoNewtonPerSecond.Name, HectoNewtonPerSecond },
            { DecaNewtonPerSecond.Name, DecaNewtonPerSecond },
            { DeciNewtonPerSecond.Name, DeciNewtonPerSecond },
            { CentiNewtonPerSecond.Name, CentiNewtonPerSecond },
            { MilliNewtonPerSecond.Name, MilliNewtonPerSecond },
            { MicroNewtonPerSecond.Name, MicroNewtonPerSecond },
            { NanoNewtonPerSecond.Name, NanoNewtonPerSecond },
            { PicoNewtonPerSecond.Name, PicoNewtonPerSecond },
            { FemtoNewtonPerSecond.Name, FemtoNewtonPerSecond },
            { AttoNewtonPerSecond.Name, AttoNewtonPerSecond },
            { ZeptoNewtonPerSecond.Name, ZeptoNewtonPerSecond },
            { YoctoNewtonPerSecond.Name, YoctoNewtonPerSecond },
          };
        }

        static Yank()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
