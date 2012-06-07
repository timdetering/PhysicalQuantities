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
      public static partial class Power
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Watt
        /// </summary>
        public static BaseUnit Watt { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaWatt { get; private set; }
        public static ScaledUnit ZettaWatt { get; private set; }
        public static ScaledUnit ExaWatt { get; private set; }
        public static ScaledUnit PetaWatt { get; private set; }
        public static ScaledUnit TeraWatt { get; private set; }
        public static ScaledUnit GigaWatt { get; private set; }
        public static ScaledUnit MegaWatt { get; private set; }
        public static ScaledUnit KiloWatt { get; private set; }
        public static ScaledUnit HectoWatt { get; private set; }
        public static ScaledUnit DecaWatt { get; private set; }
        public static ScaledUnit DeciWatt { get; private set; }
        public static ScaledUnit CentiWatt { get; private set; }
        public static ScaledUnit MilliWatt { get; private set; }
        public static ScaledUnit MicroWatt { get; private set; }
        public static ScaledUnit NanoWatt { get; private set; }
        public static ScaledUnit PicoWatt { get; private set; }
        public static ScaledUnit FemtoWatt { get; private set; }
        public static ScaledUnit AttoWatt { get; private set; }
        public static ScaledUnit ZeptoWatt { get; private set; }
        public static ScaledUnit YoctoWatt { get; private set; }

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
          Watt = new BaseUnit(@"Watt", @"W", PhysicalQuantities.Quantities.Power, unitSystem);
          YottaWatt = new ScaledUnit(@"YottaWatt", @"YW", Watt, 1E+24, 0.0);
          ZettaWatt = new ScaledUnit(@"ZettaWatt", @"ZW", Watt, 1E+21, 0.0);
          ExaWatt = new ScaledUnit(@"ExaWatt", @"EW", Watt, 1E+18, 0.0);
          PetaWatt = new ScaledUnit(@"PetaWatt", @"PW", Watt, 1E+15, 0.0);
          TeraWatt = new ScaledUnit(@"TeraWatt", @"TW", Watt, 1000000000000, 0.0);
          GigaWatt = new ScaledUnit(@"GigaWatt", @"GW", Watt, 1000000000, 0.0);
          MegaWatt = new ScaledUnit(@"MegaWatt", @"MW", Watt, 1000000, 0.0);
          KiloWatt = new ScaledUnit(@"KiloWatt", @"kW", Watt, 1000, 0.0);
          HectoWatt = new ScaledUnit(@"HectoWatt", @"hW", Watt, 100, 0.0);
          DecaWatt = new ScaledUnit(@"DecaWatt", @"daW", Watt, 10, 0.0);
          DeciWatt = new ScaledUnit(@"DeciWatt", @"dW", Watt, 0.1, 0.0);
          CentiWatt = new ScaledUnit(@"CentiWatt", @"cW", Watt, 0.01, 0.0);
          MilliWatt = new ScaledUnit(@"MilliWatt", @"mW", Watt, 0.001, 0.0);
          MicroWatt = new ScaledUnit(@"MicroWatt", @"µW", Watt, 1E-06, 0.0);
          NanoWatt = new ScaledUnit(@"NanoWatt", @"nW", Watt, 1E-09, 0.0);
          PicoWatt = new ScaledUnit(@"PicoWatt", @"pW", Watt, 1E-12, 0.0);
          FemtoWatt = new ScaledUnit(@"FemtoWatt", @"fW", Watt, 1E-15, 0.0);
          AttoWatt = new ScaledUnit(@"AttoWatt", @"aW", Watt, 1E-18, 0.0);
          ZeptoWatt = new ScaledUnit(@"ZeptoWatt", @"zW", Watt, 1E-21, 0.0);
          YoctoWatt = new ScaledUnit(@"YoctoWatt", @"yW", Watt, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Watt.Name, Watt },
            { YottaWatt.Name, YottaWatt },
            { ZettaWatt.Name, ZettaWatt },
            { ExaWatt.Name, ExaWatt },
            { PetaWatt.Name, PetaWatt },
            { TeraWatt.Name, TeraWatt },
            { GigaWatt.Name, GigaWatt },
            { MegaWatt.Name, MegaWatt },
            { KiloWatt.Name, KiloWatt },
            { HectoWatt.Name, HectoWatt },
            { DecaWatt.Name, DecaWatt },
            { DeciWatt.Name, DeciWatt },
            { CentiWatt.Name, CentiWatt },
            { MilliWatt.Name, MilliWatt },
            { MicroWatt.Name, MicroWatt },
            { NanoWatt.Name, NanoWatt },
            { PicoWatt.Name, PicoWatt },
            { FemtoWatt.Name, FemtoWatt },
            { AttoWatt.Name, AttoWatt },
            { ZeptoWatt.Name, ZeptoWatt },
            { YoctoWatt.Name, YoctoWatt },
          };
        }

        static Power()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
