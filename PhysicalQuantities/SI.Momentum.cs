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
      public static partial class Momentum
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_second
        /// </summary>
        public static BaseUnit NewtonSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewtonSecond { get; private set; }
        public static ScaledUnit ZettaNewtonSecond { get; private set; }
        public static ScaledUnit ExaNewtonSecond { get; private set; }
        public static ScaledUnit PetaNewtonSecond { get; private set; }
        public static ScaledUnit TeraNewtonSecond { get; private set; }
        public static ScaledUnit GigaNewtonSecond { get; private set; }
        public static ScaledUnit MegaNewtonSecond { get; private set; }
        public static ScaledUnit KiloNewtonSecond { get; private set; }
        public static ScaledUnit HectoNewtonSecond { get; private set; }
        public static ScaledUnit DecaNewtonSecond { get; private set; }
        public static ScaledUnit DeciNewtonSecond { get; private set; }
        public static ScaledUnit CentiNewtonSecond { get; private set; }
        public static ScaledUnit MilliNewtonSecond { get; private set; }
        public static ScaledUnit MicroNewtonSecond { get; private set; }
        public static ScaledUnit NanoNewtonSecond { get; private set; }
        public static ScaledUnit PicoNewtonSecond { get; private set; }
        public static ScaledUnit FemtoNewtonSecond { get; private set; }
        public static ScaledUnit AttoNewtonSecond { get; private set; }
        public static ScaledUnit ZeptoNewtonSecond { get; private set; }
        public static ScaledUnit YoctoNewtonSecond { get; private set; }

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
          NewtonSecond = new BaseUnit(@"NewtonSecond", @"N新", PhysicalQuantities.Quantities.Momentum, unitSystem);
          YottaNewtonSecond = new ScaledUnit(@"YottaNewtonSecond", @"YN新", NewtonSecond, 1E+24, 0.0);
          ZettaNewtonSecond = new ScaledUnit(@"ZettaNewtonSecond", @"ZN新", NewtonSecond, 1E+21, 0.0);
          ExaNewtonSecond = new ScaledUnit(@"ExaNewtonSecond", @"EN新", NewtonSecond, 1E+18, 0.0);
          PetaNewtonSecond = new ScaledUnit(@"PetaNewtonSecond", @"PN新", NewtonSecond, 1E+15, 0.0);
          TeraNewtonSecond = new ScaledUnit(@"TeraNewtonSecond", @"TN新", NewtonSecond, 1000000000000, 0.0);
          GigaNewtonSecond = new ScaledUnit(@"GigaNewtonSecond", @"GN新", NewtonSecond, 1000000000, 0.0);
          MegaNewtonSecond = new ScaledUnit(@"MegaNewtonSecond", @"MN新", NewtonSecond, 1000000, 0.0);
          KiloNewtonSecond = new ScaledUnit(@"KiloNewtonSecond", @"kN新", NewtonSecond, 1000, 0.0);
          HectoNewtonSecond = new ScaledUnit(@"HectoNewtonSecond", @"hN新", NewtonSecond, 100, 0.0);
          DecaNewtonSecond = new ScaledUnit(@"DecaNewtonSecond", @"daN新", NewtonSecond, 10, 0.0);
          DeciNewtonSecond = new ScaledUnit(@"DeciNewtonSecond", @"dN新", NewtonSecond, 0.1, 0.0);
          CentiNewtonSecond = new ScaledUnit(@"CentiNewtonSecond", @"cN新", NewtonSecond, 0.01, 0.0);
          MilliNewtonSecond = new ScaledUnit(@"MilliNewtonSecond", @"mN新", NewtonSecond, 0.001, 0.0);
          MicroNewtonSecond = new ScaledUnit(@"MicroNewtonSecond", @"煮新", NewtonSecond, 1E-06, 0.0);
          NanoNewtonSecond = new ScaledUnit(@"NanoNewtonSecond", @"nN新", NewtonSecond, 1E-09, 0.0);
          PicoNewtonSecond = new ScaledUnit(@"PicoNewtonSecond", @"pN新", NewtonSecond, 1E-12, 0.0);
          FemtoNewtonSecond = new ScaledUnit(@"FemtoNewtonSecond", @"fN新", NewtonSecond, 1E-15, 0.0);
          AttoNewtonSecond = new ScaledUnit(@"AttoNewtonSecond", @"aN新", NewtonSecond, 1E-18, 0.0);
          ZeptoNewtonSecond = new ScaledUnit(@"ZeptoNewtonSecond", @"zN新", NewtonSecond, 1E-21, 0.0);
          YoctoNewtonSecond = new ScaledUnit(@"YoctoNewtonSecond", @"yN新", NewtonSecond, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonSecond.Name, NewtonSecond },
            { YottaNewtonSecond.Name, YottaNewtonSecond },
            { ZettaNewtonSecond.Name, ZettaNewtonSecond },
            { ExaNewtonSecond.Name, ExaNewtonSecond },
            { PetaNewtonSecond.Name, PetaNewtonSecond },
            { TeraNewtonSecond.Name, TeraNewtonSecond },
            { GigaNewtonSecond.Name, GigaNewtonSecond },
            { MegaNewtonSecond.Name, MegaNewtonSecond },
            { KiloNewtonSecond.Name, KiloNewtonSecond },
            { HectoNewtonSecond.Name, HectoNewtonSecond },
            { DecaNewtonSecond.Name, DecaNewtonSecond },
            { DeciNewtonSecond.Name, DeciNewtonSecond },
            { CentiNewtonSecond.Name, CentiNewtonSecond },
            { MilliNewtonSecond.Name, MilliNewtonSecond },
            { MicroNewtonSecond.Name, MicroNewtonSecond },
            { NanoNewtonSecond.Name, NanoNewtonSecond },
            { PicoNewtonSecond.Name, PicoNewtonSecond },
            { FemtoNewtonSecond.Name, FemtoNewtonSecond },
            { AttoNewtonSecond.Name, AttoNewtonSecond },
            { ZeptoNewtonSecond.Name, ZeptoNewtonSecond },
            { YoctoNewtonSecond.Name, YoctoNewtonSecond },
          };
        }

        static Momentum()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
