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
      public static partial class MagneticFlux
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Weber_(Wb)
        /// </summary>
        public static BaseUnit Weber { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaWeber { get; private set; }
        public static ScaledUnit ZettaWeber { get; private set; }
        public static ScaledUnit ExaWeber { get; private set; }
        public static ScaledUnit PetaWeber { get; private set; }
        public static ScaledUnit TeraWeber { get; private set; }
        public static ScaledUnit GigaWeber { get; private set; }
        public static ScaledUnit MegaWeber { get; private set; }
        public static ScaledUnit KiloWeber { get; private set; }
        public static ScaledUnit HectoWeber { get; private set; }
        public static ScaledUnit DecaWeber { get; private set; }
        public static ScaledUnit DeciWeber { get; private set; }
        public static ScaledUnit CentiWeber { get; private set; }
        public static ScaledUnit MilliWeber { get; private set; }
        public static ScaledUnit MicroWeber { get; private set; }
        public static ScaledUnit NanoWeber { get; private set; }
        public static ScaledUnit PicoWeber { get; private set; }
        public static ScaledUnit FemtoWeber { get; private set; }
        public static ScaledUnit AttoWeber { get; private set; }
        public static ScaledUnit ZeptoWeber { get; private set; }
        public static ScaledUnit YoctoWeber { get; private set; }

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
          Weber = new BaseUnit(@"Weber", @"Wb", PhysicalQuantities.Quantities.MagneticFlux, unitSystem);
          YottaWeber = new ScaledUnit(@"YottaWeber", @"YWb", Weber, 1E+24, 0.0);
          ZettaWeber = new ScaledUnit(@"ZettaWeber", @"ZWb", Weber, 1E+21, 0.0);
          ExaWeber = new ScaledUnit(@"ExaWeber", @"EWb", Weber, 1E+18, 0.0);
          PetaWeber = new ScaledUnit(@"PetaWeber", @"PWb", Weber, 1E+15, 0.0);
          TeraWeber = new ScaledUnit(@"TeraWeber", @"TWb", Weber, 1000000000000, 0.0);
          GigaWeber = new ScaledUnit(@"GigaWeber", @"GWb", Weber, 1000000000, 0.0);
          MegaWeber = new ScaledUnit(@"MegaWeber", @"MWb", Weber, 1000000, 0.0);
          KiloWeber = new ScaledUnit(@"KiloWeber", @"kWb", Weber, 1000, 0.0);
          HectoWeber = new ScaledUnit(@"HectoWeber", @"hWb", Weber, 100, 0.0);
          DecaWeber = new ScaledUnit(@"DecaWeber", @"daWb", Weber, 10, 0.0);
          DeciWeber = new ScaledUnit(@"DeciWeber", @"dWb", Weber, 0.1, 0.0);
          CentiWeber = new ScaledUnit(@"CentiWeber", @"cWb", Weber, 0.01, 0.0);
          MilliWeber = new ScaledUnit(@"MilliWeber", @"mWb", Weber, 0.001, 0.0);
          MicroWeber = new ScaledUnit(@"MicroWeber", @"µWb", Weber, 1E-06, 0.0);
          NanoWeber = new ScaledUnit(@"NanoWeber", @"nWb", Weber, 1E-09, 0.0);
          PicoWeber = new ScaledUnit(@"PicoWeber", @"pWb", Weber, 1E-12, 0.0);
          FemtoWeber = new ScaledUnit(@"FemtoWeber", @"fWb", Weber, 1E-15, 0.0);
          AttoWeber = new ScaledUnit(@"AttoWeber", @"aWb", Weber, 1E-18, 0.0);
          ZeptoWeber = new ScaledUnit(@"ZeptoWeber", @"zWb", Weber, 1E-21, 0.0);
          YoctoWeber = new ScaledUnit(@"YoctoWeber", @"yWb", Weber, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Weber.Name, Weber },
            { YottaWeber.Name, YottaWeber },
            { ZettaWeber.Name, ZettaWeber },
            { ExaWeber.Name, ExaWeber },
            { PetaWeber.Name, PetaWeber },
            { TeraWeber.Name, TeraWeber },
            { GigaWeber.Name, GigaWeber },
            { MegaWeber.Name, MegaWeber },
            { KiloWeber.Name, KiloWeber },
            { HectoWeber.Name, HectoWeber },
            { DecaWeber.Name, DecaWeber },
            { DeciWeber.Name, DeciWeber },
            { CentiWeber.Name, CentiWeber },
            { MilliWeber.Name, MilliWeber },
            { MicroWeber.Name, MicroWeber },
            { NanoWeber.Name, NanoWeber },
            { PicoWeber.Name, PicoWeber },
            { FemtoWeber.Name, FemtoWeber },
            { AttoWeber.Name, AttoWeber },
            { ZeptoWeber.Name, ZeptoWeber },
            { YoctoWeber.Name, YoctoWeber },
          };
        }

        static MagneticFlux()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
