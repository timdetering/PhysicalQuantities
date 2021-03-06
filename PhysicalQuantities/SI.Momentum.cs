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
          NewtonSecond = new BaseUnit(@"NewtonSecond", @"N·s", PhysicalQuantities.Quantities.Momentum, unitSystem) { Caption = @"newton-segundo" };
          YottaNewtonSecond = new ScaledUnit(@"YottaNewtonSecond", @"YN·s", NewtonSecond, 1E+24, 0.0) { Caption = @"yottanewton-segundo" };
          ZettaNewtonSecond = new ScaledUnit(@"ZettaNewtonSecond", @"ZN·s", NewtonSecond, 1E+21, 0.0) { Caption = @"zettanewton-segundo" };
          ExaNewtonSecond = new ScaledUnit(@"ExaNewtonSecond", @"EN·s", NewtonSecond, 1E+18, 0.0) { Caption = @"exanewton-segundo" };
          PetaNewtonSecond = new ScaledUnit(@"PetaNewtonSecond", @"PN·s", NewtonSecond, 1E+15, 0.0) { Caption = @"petanewton-segundo" };
          TeraNewtonSecond = new ScaledUnit(@"TeraNewtonSecond", @"TN·s", NewtonSecond, 1000000000000, 0.0) { Caption = @"teranewton-segundo" };
          GigaNewtonSecond = new ScaledUnit(@"GigaNewtonSecond", @"GN·s", NewtonSecond, 1000000000, 0.0) { Caption = @"giganewton-segundo" };
          MegaNewtonSecond = new ScaledUnit(@"MegaNewtonSecond", @"MN·s", NewtonSecond, 1000000, 0.0) { Caption = @"meganewton-segundo" };
          KiloNewtonSecond = new ScaledUnit(@"KiloNewtonSecond", @"kN·s", NewtonSecond, 1000, 0.0) { Caption = @"kilonewton-segundo" };
          HectoNewtonSecond = new ScaledUnit(@"HectoNewtonSecond", @"hN·s", NewtonSecond, 100, 0.0) { Caption = @"hectonewton-segundo" };
          DecaNewtonSecond = new ScaledUnit(@"DecaNewtonSecond", @"daN·s", NewtonSecond, 10, 0.0) { Caption = @"decanewton-segundo" };
          DeciNewtonSecond = new ScaledUnit(@"DeciNewtonSecond", @"dN·s", NewtonSecond, 0.1, 0.0) { Caption = @"decinewton-segundo" };
          CentiNewtonSecond = new ScaledUnit(@"CentiNewtonSecond", @"cN·s", NewtonSecond, 0.01, 0.0) { Caption = @"centinewton-segundo" };
          MilliNewtonSecond = new ScaledUnit(@"MilliNewtonSecond", @"mN·s", NewtonSecond, 0.001, 0.0) { Caption = @"milinewton-segundo" };
          MicroNewtonSecond = new ScaledUnit(@"MicroNewtonSecond", @"μN·s", NewtonSecond, 1E-06, 0.0) { Caption = @"micronewton-segundo" };
          NanoNewtonSecond = new ScaledUnit(@"NanoNewtonSecond", @"nN·s", NewtonSecond, 1E-09, 0.0) { Caption = @"nanonewton-segundo" };
          PicoNewtonSecond = new ScaledUnit(@"PicoNewtonSecond", @"pN·s", NewtonSecond, 1E-12, 0.0) { Caption = @"piconewton-segundo" };
          FemtoNewtonSecond = new ScaledUnit(@"FemtoNewtonSecond", @"fN·s", NewtonSecond, 1E-15, 0.0) { Caption = @"femtonewton-segundo" };
          AttoNewtonSecond = new ScaledUnit(@"AttoNewtonSecond", @"aN·s", NewtonSecond, 1E-18, 0.0) { Caption = @"attonewton-segundo" };
          ZeptoNewtonSecond = new ScaledUnit(@"ZeptoNewtonSecond", @"zN·s", NewtonSecond, 1E-21, 0.0) { Caption = @"zeptonewton-segundo" };
          YoctoNewtonSecond = new ScaledUnit(@"YoctoNewtonSecond", @"yN·s", NewtonSecond, 1E-24, 0.0) { Caption = @"yoctonewton-segundo" };

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
