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
      public static partial class AngularVelocity
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Radian_per_second
        /// </summary>
        public static BaseUnit RadianPerSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaRadianPerSecond { get; private set; }
        public static ScaledUnit ZettaRadianPerSecond { get; private set; }
        public static ScaledUnit ExaRadianPerSecond { get; private set; }
        public static ScaledUnit PetaRadianPerSecond { get; private set; }
        public static ScaledUnit TeraRadianPerSecond { get; private set; }
        public static ScaledUnit GigaRadianPerSecond { get; private set; }
        public static ScaledUnit MegaRadianPerSecond { get; private set; }
        public static ScaledUnit KiloRadianPerSecond { get; private set; }
        public static ScaledUnit HectoRadianPerSecond { get; private set; }
        public static ScaledUnit DecaRadianPerSecond { get; private set; }
        public static ScaledUnit DeciRadianPerSecond { get; private set; }
        public static ScaledUnit CentiRadianPerSecond { get; private set; }
        public static ScaledUnit MilliRadianPerSecond { get; private set; }
        public static ScaledUnit MicroRadianPerSecond { get; private set; }
        public static ScaledUnit NanoRadianPerSecond { get; private set; }
        public static ScaledUnit PicoRadianPerSecond { get; private set; }
        public static ScaledUnit FemtoRadianPerSecond { get; private set; }
        public static ScaledUnit AttoRadianPerSecond { get; private set; }
        public static ScaledUnit ZeptoRadianPerSecond { get; private set; }
        public static ScaledUnit YoctoRadianPerSecond { get; private set; }

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
          RadianPerSecond = new BaseUnit(@"RadianPerSecond", @"rad/s", PhysicalQuantities.Quantities.AngularVelocity, unitSystem) { Caption = @"radian por segundo" };
          YottaRadianPerSecond = new ScaledUnit(@"YottaRadianPerSecond", @"Yrad/s", RadianPerSecond, 1E+24, 0.0) { Caption = @"yottaradian por segundo" };
          ZettaRadianPerSecond = new ScaledUnit(@"ZettaRadianPerSecond", @"Zrad/s", RadianPerSecond, 1E+21, 0.0) { Caption = @"zettaradian por segundo" };
          ExaRadianPerSecond = new ScaledUnit(@"ExaRadianPerSecond", @"Erad/s", RadianPerSecond, 1E+18, 0.0) { Caption = @"exaradian por segundo" };
          PetaRadianPerSecond = new ScaledUnit(@"PetaRadianPerSecond", @"Prad/s", RadianPerSecond, 1E+15, 0.0) { Caption = @"petaradian por segundo" };
          TeraRadianPerSecond = new ScaledUnit(@"TeraRadianPerSecond", @"Trad/s", RadianPerSecond, 1000000000000, 0.0) { Caption = @"teraradian por segundo" };
          GigaRadianPerSecond = new ScaledUnit(@"GigaRadianPerSecond", @"Grad/s", RadianPerSecond, 1000000000, 0.0) { Caption = @"gigaradian por segundo" };
          MegaRadianPerSecond = new ScaledUnit(@"MegaRadianPerSecond", @"Mrad/s", RadianPerSecond, 1000000, 0.0) { Caption = @"megaradian por segundo" };
          KiloRadianPerSecond = new ScaledUnit(@"KiloRadianPerSecond", @"krad/s", RadianPerSecond, 1000, 0.0) { Caption = @"kiloradian por segundo" };
          HectoRadianPerSecond = new ScaledUnit(@"HectoRadianPerSecond", @"hrad/s", RadianPerSecond, 100, 0.0) { Caption = @"hectoradian por segundo" };
          DecaRadianPerSecond = new ScaledUnit(@"DecaRadianPerSecond", @"darad/s", RadianPerSecond, 10, 0.0) { Caption = @"decaradian por segundo" };
          DeciRadianPerSecond = new ScaledUnit(@"DeciRadianPerSecond", @"drad/s", RadianPerSecond, 0.1, 0.0) { Caption = @"deciradian por segundo" };
          CentiRadianPerSecond = new ScaledUnit(@"CentiRadianPerSecond", @"crad/s", RadianPerSecond, 0.01, 0.0) { Caption = @"centiradian por segundo" };
          MilliRadianPerSecond = new ScaledUnit(@"MilliRadianPerSecond", @"mrad/s", RadianPerSecond, 0.001, 0.0) { Caption = @"miliradian por segundo" };
          MicroRadianPerSecond = new ScaledUnit(@"MicroRadianPerSecond", @"μrad/s", RadianPerSecond, 1E-06, 0.0) { Caption = @"microradian por segundo" };
          NanoRadianPerSecond = new ScaledUnit(@"NanoRadianPerSecond", @"nrad/s", RadianPerSecond, 1E-09, 0.0) { Caption = @"nanoradian por segundo" };
          PicoRadianPerSecond = new ScaledUnit(@"PicoRadianPerSecond", @"prad/s", RadianPerSecond, 1E-12, 0.0) { Caption = @"picoradian por segundo" };
          FemtoRadianPerSecond = new ScaledUnit(@"FemtoRadianPerSecond", @"frad/s", RadianPerSecond, 1E-15, 0.0) { Caption = @"femtoradian por segundo" };
          AttoRadianPerSecond = new ScaledUnit(@"AttoRadianPerSecond", @"arad/s", RadianPerSecond, 1E-18, 0.0) { Caption = @"attoradian por segundo" };
          ZeptoRadianPerSecond = new ScaledUnit(@"ZeptoRadianPerSecond", @"zrad/s", RadianPerSecond, 1E-21, 0.0) { Caption = @"zeptoradian por segundo" };
          YoctoRadianPerSecond = new ScaledUnit(@"YoctoRadianPerSecond", @"yrad/s", RadianPerSecond, 1E-24, 0.0) { Caption = @"yoctoradian por segundo" };

          allUnits = new Dictionary<string, Unit>
          {
            { RadianPerSecond.Name, RadianPerSecond },
            { YottaRadianPerSecond.Name, YottaRadianPerSecond },
            { ZettaRadianPerSecond.Name, ZettaRadianPerSecond },
            { ExaRadianPerSecond.Name, ExaRadianPerSecond },
            { PetaRadianPerSecond.Name, PetaRadianPerSecond },
            { TeraRadianPerSecond.Name, TeraRadianPerSecond },
            { GigaRadianPerSecond.Name, GigaRadianPerSecond },
            { MegaRadianPerSecond.Name, MegaRadianPerSecond },
            { KiloRadianPerSecond.Name, KiloRadianPerSecond },
            { HectoRadianPerSecond.Name, HectoRadianPerSecond },
            { DecaRadianPerSecond.Name, DecaRadianPerSecond },
            { DeciRadianPerSecond.Name, DeciRadianPerSecond },
            { CentiRadianPerSecond.Name, CentiRadianPerSecond },
            { MilliRadianPerSecond.Name, MilliRadianPerSecond },
            { MicroRadianPerSecond.Name, MicroRadianPerSecond },
            { NanoRadianPerSecond.Name, NanoRadianPerSecond },
            { PicoRadianPerSecond.Name, PicoRadianPerSecond },
            { FemtoRadianPerSecond.Name, FemtoRadianPerSecond },
            { AttoRadianPerSecond.Name, AttoRadianPerSecond },
            { ZeptoRadianPerSecond.Name, ZeptoRadianPerSecond },
            { YoctoRadianPerSecond.Name, YoctoRadianPerSecond },
          };
        }

        static AngularVelocity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
