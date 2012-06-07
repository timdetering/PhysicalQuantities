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
      public static partial class AngularMomentum
      {
        public static BaseUnit NewtonMetreSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewtonMetreSecond { get; private set; }
        public static ScaledUnit ZettaNewtonMetreSecond { get; private set; }
        public static ScaledUnit ExaNewtonMetreSecond { get; private set; }
        public static ScaledUnit PetaNewtonMetreSecond { get; private set; }
        public static ScaledUnit TeraNewtonMetreSecond { get; private set; }
        public static ScaledUnit GigaNewtonMetreSecond { get; private set; }
        public static ScaledUnit MegaNewtonMetreSecond { get; private set; }
        public static ScaledUnit KiloNewtonMetreSecond { get; private set; }
        public static ScaledUnit HectoNewtonMetreSecond { get; private set; }
        public static ScaledUnit DecaNewtonMetreSecond { get; private set; }
        public static ScaledUnit DeciNewtonMetreSecond { get; private set; }
        public static ScaledUnit CentiNewtonMetreSecond { get; private set; }
        public static ScaledUnit MilliNewtonMetreSecond { get; private set; }
        public static ScaledUnit MicroNewtonMetreSecond { get; private set; }
        public static ScaledUnit NanoNewtonMetreSecond { get; private set; }
        public static ScaledUnit PicoNewtonMetreSecond { get; private set; }
        public static ScaledUnit FemtoNewtonMetreSecond { get; private set; }
        public static ScaledUnit AttoNewtonMetreSecond { get; private set; }
        public static ScaledUnit ZeptoNewtonMetreSecond { get; private set; }
        public static ScaledUnit YoctoNewtonMetreSecond { get; private set; }

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
          NewtonMetreSecond = new BaseUnit(@"NewtonMetreSecond", @"N搶新", PhysicalQuantities.Quantities.AngularMomentum, unitSystem);
          YottaNewtonMetreSecond = new ScaledUnit(@"YottaNewtonMetreSecond", @"YN搶新", NewtonMetreSecond, 1E+24, 0.0);
          ZettaNewtonMetreSecond = new ScaledUnit(@"ZettaNewtonMetreSecond", @"ZN搶新", NewtonMetreSecond, 1E+21, 0.0);
          ExaNewtonMetreSecond = new ScaledUnit(@"ExaNewtonMetreSecond", @"EN搶新", NewtonMetreSecond, 1E+18, 0.0);
          PetaNewtonMetreSecond = new ScaledUnit(@"PetaNewtonMetreSecond", @"PN搶新", NewtonMetreSecond, 1E+15, 0.0);
          TeraNewtonMetreSecond = new ScaledUnit(@"TeraNewtonMetreSecond", @"TN搶新", NewtonMetreSecond, 1000000000000, 0.0);
          GigaNewtonMetreSecond = new ScaledUnit(@"GigaNewtonMetreSecond", @"GN搶新", NewtonMetreSecond, 1000000000, 0.0);
          MegaNewtonMetreSecond = new ScaledUnit(@"MegaNewtonMetreSecond", @"MN搶新", NewtonMetreSecond, 1000000, 0.0);
          KiloNewtonMetreSecond = new ScaledUnit(@"KiloNewtonMetreSecond", @"kN搶新", NewtonMetreSecond, 1000, 0.0);
          HectoNewtonMetreSecond = new ScaledUnit(@"HectoNewtonMetreSecond", @"hN搶新", NewtonMetreSecond, 100, 0.0);
          DecaNewtonMetreSecond = new ScaledUnit(@"DecaNewtonMetreSecond", @"daN搶新", NewtonMetreSecond, 10, 0.0);
          DeciNewtonMetreSecond = new ScaledUnit(@"DeciNewtonMetreSecond", @"dN搶新", NewtonMetreSecond, 0.1, 0.0);
          CentiNewtonMetreSecond = new ScaledUnit(@"CentiNewtonMetreSecond", @"cN搶新", NewtonMetreSecond, 0.01, 0.0);
          MilliNewtonMetreSecond = new ScaledUnit(@"MilliNewtonMetreSecond", @"mN搶新", NewtonMetreSecond, 0.001, 0.0);
          MicroNewtonMetreSecond = new ScaledUnit(@"MicroNewtonMetreSecond", @"煮搶新", NewtonMetreSecond, 1E-06, 0.0);
          NanoNewtonMetreSecond = new ScaledUnit(@"NanoNewtonMetreSecond", @"nN搶新", NewtonMetreSecond, 1E-09, 0.0);
          PicoNewtonMetreSecond = new ScaledUnit(@"PicoNewtonMetreSecond", @"pN搶新", NewtonMetreSecond, 1E-12, 0.0);
          FemtoNewtonMetreSecond = new ScaledUnit(@"FemtoNewtonMetreSecond", @"fN搶新", NewtonMetreSecond, 1E-15, 0.0);
          AttoNewtonMetreSecond = new ScaledUnit(@"AttoNewtonMetreSecond", @"aN搶新", NewtonMetreSecond, 1E-18, 0.0);
          ZeptoNewtonMetreSecond = new ScaledUnit(@"ZeptoNewtonMetreSecond", @"zN搶新", NewtonMetreSecond, 1E-21, 0.0);
          YoctoNewtonMetreSecond = new ScaledUnit(@"YoctoNewtonMetreSecond", @"yN搶新", NewtonMetreSecond, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonMetreSecond.Name, NewtonMetreSecond },
            { YottaNewtonMetreSecond.Name, YottaNewtonMetreSecond },
            { ZettaNewtonMetreSecond.Name, ZettaNewtonMetreSecond },
            { ExaNewtonMetreSecond.Name, ExaNewtonMetreSecond },
            { PetaNewtonMetreSecond.Name, PetaNewtonMetreSecond },
            { TeraNewtonMetreSecond.Name, TeraNewtonMetreSecond },
            { GigaNewtonMetreSecond.Name, GigaNewtonMetreSecond },
            { MegaNewtonMetreSecond.Name, MegaNewtonMetreSecond },
            { KiloNewtonMetreSecond.Name, KiloNewtonMetreSecond },
            { HectoNewtonMetreSecond.Name, HectoNewtonMetreSecond },
            { DecaNewtonMetreSecond.Name, DecaNewtonMetreSecond },
            { DeciNewtonMetreSecond.Name, DeciNewtonMetreSecond },
            { CentiNewtonMetreSecond.Name, CentiNewtonMetreSecond },
            { MilliNewtonMetreSecond.Name, MilliNewtonMetreSecond },
            { MicroNewtonMetreSecond.Name, MicroNewtonMetreSecond },
            { NanoNewtonMetreSecond.Name, NanoNewtonMetreSecond },
            { PicoNewtonMetreSecond.Name, PicoNewtonMetreSecond },
            { FemtoNewtonMetreSecond.Name, FemtoNewtonMetreSecond },
            { AttoNewtonMetreSecond.Name, AttoNewtonMetreSecond },
            { ZeptoNewtonMetreSecond.Name, ZeptoNewtonMetreSecond },
            { YoctoNewtonMetreSecond.Name, YoctoNewtonMetreSecond },
          };
        }

        static AngularMomentum()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
