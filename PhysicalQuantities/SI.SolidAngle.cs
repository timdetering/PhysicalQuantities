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
      public static partial class SolidAngle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Steradian
        /// </summary>
        public static BaseUnit Steradian { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSteradian { get; private set; }
        public static ScaledUnit ZettaSteradian { get; private set; }
        public static ScaledUnit ExaSteradian { get; private set; }
        public static ScaledUnit PetaSteradian { get; private set; }
        public static ScaledUnit TeraSteradian { get; private set; }
        public static ScaledUnit GigaSteradian { get; private set; }
        public static ScaledUnit MegaSteradian { get; private set; }
        public static ScaledUnit KiloSteradian { get; private set; }
        public static ScaledUnit HectoSteradian { get; private set; }
        public static ScaledUnit DecaSteradian { get; private set; }
        public static ScaledUnit DeciSteradian { get; private set; }
        public static ScaledUnit CentiSteradian { get; private set; }
        public static ScaledUnit MilliSteradian { get; private set; }
        public static ScaledUnit MicroSteradian { get; private set; }
        public static ScaledUnit NanoSteradian { get; private set; }
        public static ScaledUnit PicoSteradian { get; private set; }
        public static ScaledUnit FemtoSteradian { get; private set; }
        public static ScaledUnit AttoSteradian { get; private set; }
        public static ScaledUnit ZeptoSteradian { get; private set; }
        public static ScaledUnit YoctoSteradian { get; private set; }

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
          Steradian = new BaseUnit(@"Steradian", @"sr", PhysicalQuantities.Quantities.SolidAngle, unitSystem);
          YottaSteradian = new ScaledUnit(@"YottaSteradian", @"Ysr", Steradian, 1E+24, 0.0);
          ZettaSteradian = new ScaledUnit(@"ZettaSteradian", @"Zsr", Steradian, 1E+21, 0.0);
          ExaSteradian = new ScaledUnit(@"ExaSteradian", @"Esr", Steradian, 1E+18, 0.0);
          PetaSteradian = new ScaledUnit(@"PetaSteradian", @"Psr", Steradian, 1E+15, 0.0);
          TeraSteradian = new ScaledUnit(@"TeraSteradian", @"Tsr", Steradian, 1000000000000, 0.0);
          GigaSteradian = new ScaledUnit(@"GigaSteradian", @"Gsr", Steradian, 1000000000, 0.0);
          MegaSteradian = new ScaledUnit(@"MegaSteradian", @"Msr", Steradian, 1000000, 0.0);
          KiloSteradian = new ScaledUnit(@"KiloSteradian", @"ksr", Steradian, 1000, 0.0);
          HectoSteradian = new ScaledUnit(@"HectoSteradian", @"hsr", Steradian, 100, 0.0);
          DecaSteradian = new ScaledUnit(@"DecaSteradian", @"dasr", Steradian, 10, 0.0);
          DeciSteradian = new ScaledUnit(@"DeciSteradian", @"dsr", Steradian, 0.1, 0.0);
          CentiSteradian = new ScaledUnit(@"CentiSteradian", @"csr", Steradian, 0.01, 0.0);
          MilliSteradian = new ScaledUnit(@"MilliSteradian", @"msr", Steradian, 0.001, 0.0);
          MicroSteradian = new ScaledUnit(@"MicroSteradian", @"µsr", Steradian, 1E-06, 0.0);
          NanoSteradian = new ScaledUnit(@"NanoSteradian", @"nsr", Steradian, 1E-09, 0.0);
          PicoSteradian = new ScaledUnit(@"PicoSteradian", @"psr", Steradian, 1E-12, 0.0);
          FemtoSteradian = new ScaledUnit(@"FemtoSteradian", @"fsr", Steradian, 1E-15, 0.0);
          AttoSteradian = new ScaledUnit(@"AttoSteradian", @"asr", Steradian, 1E-18, 0.0);
          ZeptoSteradian = new ScaledUnit(@"ZeptoSteradian", @"zsr", Steradian, 1E-21, 0.0);
          YoctoSteradian = new ScaledUnit(@"YoctoSteradian", @"ysr", Steradian, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Steradian.Name, Steradian },
            { YottaSteradian.Name, YottaSteradian },
            { ZettaSteradian.Name, ZettaSteradian },
            { ExaSteradian.Name, ExaSteradian },
            { PetaSteradian.Name, PetaSteradian },
            { TeraSteradian.Name, TeraSteradian },
            { GigaSteradian.Name, GigaSteradian },
            { MegaSteradian.Name, MegaSteradian },
            { KiloSteradian.Name, KiloSteradian },
            { HectoSteradian.Name, HectoSteradian },
            { DecaSteradian.Name, DecaSteradian },
            { DeciSteradian.Name, DeciSteradian },
            { CentiSteradian.Name, CentiSteradian },
            { MilliSteradian.Name, MilliSteradian },
            { MicroSteradian.Name, MicroSteradian },
            { NanoSteradian.Name, NanoSteradian },
            { PicoSteradian.Name, PicoSteradian },
            { FemtoSteradian.Name, FemtoSteradian },
            { AttoSteradian.Name, AttoSteradian },
            { ZeptoSteradian.Name, ZeptoSteradian },
            { YoctoSteradian.Name, YoctoSteradian },
          };
        }

        static SolidAngle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
