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
      public static partial class Torque
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Newton_metre
        /// </summary>
        public static BaseUnit NewtonMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaNewtonMetre { get; private set; }
        public static ScaledUnit ZettaNewtonMetre { get; private set; }
        public static ScaledUnit ExaNewtonMetre { get; private set; }
        public static ScaledUnit PetaNewtonMetre { get; private set; }
        public static ScaledUnit TeraNewtonMetre { get; private set; }
        public static ScaledUnit GigaNewtonMetre { get; private set; }
        public static ScaledUnit MegaNewtonMetre { get; private set; }
        public static ScaledUnit KiloNewtonMetre { get; private set; }
        public static ScaledUnit HectoNewtonMetre { get; private set; }
        public static ScaledUnit DecaNewtonMetre { get; private set; }
        public static ScaledUnit DeciNewtonMetre { get; private set; }
        public static ScaledUnit CentiNewtonMetre { get; private set; }
        public static ScaledUnit MilliNewtonMetre { get; private set; }
        public static ScaledUnit MicroNewtonMetre { get; private set; }
        public static ScaledUnit NanoNewtonMetre { get; private set; }
        public static ScaledUnit PicoNewtonMetre { get; private set; }
        public static ScaledUnit FemtoNewtonMetre { get; private set; }
        public static ScaledUnit AttoNewtonMetre { get; private set; }
        public static ScaledUnit ZeptoNewtonMetre { get; private set; }
        public static ScaledUnit YoctoNewtonMetre { get; private set; }

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
          NewtonMetre = new BaseUnit(@"NewtonMetre", @"N·m", PhysicalQuantities.Quantities.Torque, unitSystem);
          YottaNewtonMetre = new ScaledUnit(@"YottaNewtonMetre", @"YN·m", NewtonMetre, 1E+24, 0.0);
          ZettaNewtonMetre = new ScaledUnit(@"ZettaNewtonMetre", @"ZN·m", NewtonMetre, 1E+21, 0.0);
          ExaNewtonMetre = new ScaledUnit(@"ExaNewtonMetre", @"EN·m", NewtonMetre, 1E+18, 0.0);
          PetaNewtonMetre = new ScaledUnit(@"PetaNewtonMetre", @"PN·m", NewtonMetre, 1E+15, 0.0);
          TeraNewtonMetre = new ScaledUnit(@"TeraNewtonMetre", @"TN·m", NewtonMetre, 1000000000000, 0.0);
          GigaNewtonMetre = new ScaledUnit(@"GigaNewtonMetre", @"GN·m", NewtonMetre, 1000000000, 0.0);
          MegaNewtonMetre = new ScaledUnit(@"MegaNewtonMetre", @"MN·m", NewtonMetre, 1000000, 0.0);
          KiloNewtonMetre = new ScaledUnit(@"KiloNewtonMetre", @"kN·m", NewtonMetre, 1000, 0.0);
          HectoNewtonMetre = new ScaledUnit(@"HectoNewtonMetre", @"hN·m", NewtonMetre, 100, 0.0);
          DecaNewtonMetre = new ScaledUnit(@"DecaNewtonMetre", @"daN·m", NewtonMetre, 10, 0.0);
          DeciNewtonMetre = new ScaledUnit(@"DeciNewtonMetre", @"dN·m", NewtonMetre, 0.1, 0.0);
          CentiNewtonMetre = new ScaledUnit(@"CentiNewtonMetre", @"cN·m", NewtonMetre, 0.01, 0.0);
          MilliNewtonMetre = new ScaledUnit(@"MilliNewtonMetre", @"mN·m", NewtonMetre, 0.001, 0.0);
          MicroNewtonMetre = new ScaledUnit(@"MicroNewtonMetre", @"µN·m", NewtonMetre, 1E-06, 0.0);
          NanoNewtonMetre = new ScaledUnit(@"NanoNewtonMetre", @"nN·m", NewtonMetre, 1E-09, 0.0);
          PicoNewtonMetre = new ScaledUnit(@"PicoNewtonMetre", @"pN·m", NewtonMetre, 1E-12, 0.0);
          FemtoNewtonMetre = new ScaledUnit(@"FemtoNewtonMetre", @"fN·m", NewtonMetre, 1E-15, 0.0);
          AttoNewtonMetre = new ScaledUnit(@"AttoNewtonMetre", @"aN·m", NewtonMetre, 1E-18, 0.0);
          ZeptoNewtonMetre = new ScaledUnit(@"ZeptoNewtonMetre", @"zN·m", NewtonMetre, 1E-21, 0.0);
          YoctoNewtonMetre = new ScaledUnit(@"YoctoNewtonMetre", @"yN·m", NewtonMetre, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonMetre.Name, NewtonMetre },
            { YottaNewtonMetre.Name, YottaNewtonMetre },
            { ZettaNewtonMetre.Name, ZettaNewtonMetre },
            { ExaNewtonMetre.Name, ExaNewtonMetre },
            { PetaNewtonMetre.Name, PetaNewtonMetre },
            { TeraNewtonMetre.Name, TeraNewtonMetre },
            { GigaNewtonMetre.Name, GigaNewtonMetre },
            { MegaNewtonMetre.Name, MegaNewtonMetre },
            { KiloNewtonMetre.Name, KiloNewtonMetre },
            { HectoNewtonMetre.Name, HectoNewtonMetre },
            { DecaNewtonMetre.Name, DecaNewtonMetre },
            { DeciNewtonMetre.Name, DeciNewtonMetre },
            { CentiNewtonMetre.Name, CentiNewtonMetre },
            { MilliNewtonMetre.Name, MilliNewtonMetre },
            { MicroNewtonMetre.Name, MicroNewtonMetre },
            { NanoNewtonMetre.Name, NanoNewtonMetre },
            { PicoNewtonMetre.Name, PicoNewtonMetre },
            { FemtoNewtonMetre.Name, FemtoNewtonMetre },
            { AttoNewtonMetre.Name, AttoNewtonMetre },
            { ZeptoNewtonMetre.Name, ZeptoNewtonMetre },
            { YoctoNewtonMetre.Name, YoctoNewtonMetre },
          };
        }

        static Torque()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
