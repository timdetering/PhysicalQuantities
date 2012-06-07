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
      public static partial class Voltage
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Volt
        /// </summary>
        public static BaseUnit Volt { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaVolt { get; private set; }
        public static ScaledUnit ZettaVolt { get; private set; }
        public static ScaledUnit ExaVolt { get; private set; }
        public static ScaledUnit PetaVolt { get; private set; }
        public static ScaledUnit TeraVolt { get; private set; }
        public static ScaledUnit GigaVolt { get; private set; }
        public static ScaledUnit MegaVolt { get; private set; }
        public static ScaledUnit KiloVolt { get; private set; }
        public static ScaledUnit HectoVolt { get; private set; }
        public static ScaledUnit DecaVolt { get; private set; }
        public static ScaledUnit DeciVolt { get; private set; }
        public static ScaledUnit CentiVolt { get; private set; }
        public static ScaledUnit MilliVolt { get; private set; }
        public static ScaledUnit MicroVolt { get; private set; }
        public static ScaledUnit NanoVolt { get; private set; }
        public static ScaledUnit PicoVolt { get; private set; }
        public static ScaledUnit FemtoVolt { get; private set; }
        public static ScaledUnit AttoVolt { get; private set; }
        public static ScaledUnit ZeptoVolt { get; private set; }
        public static ScaledUnit YoctoVolt { get; private set; }

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
          Volt = new BaseUnit(@"Volt", @"V", PhysicalQuantities.Quantities.Voltage, unitSystem);
          YottaVolt = new ScaledUnit(@"YottaVolt", @"YV", Volt, 1E+24, 0.0);
          ZettaVolt = new ScaledUnit(@"ZettaVolt", @"ZV", Volt, 1E+21, 0.0);
          ExaVolt = new ScaledUnit(@"ExaVolt", @"EV", Volt, 1E+18, 0.0);
          PetaVolt = new ScaledUnit(@"PetaVolt", @"PV", Volt, 1E+15, 0.0);
          TeraVolt = new ScaledUnit(@"TeraVolt", @"TV", Volt, 1000000000000, 0.0);
          GigaVolt = new ScaledUnit(@"GigaVolt", @"GV", Volt, 1000000000, 0.0);
          MegaVolt = new ScaledUnit(@"MegaVolt", @"MV", Volt, 1000000, 0.0);
          KiloVolt = new ScaledUnit(@"KiloVolt", @"kV", Volt, 1000, 0.0);
          HectoVolt = new ScaledUnit(@"HectoVolt", @"hV", Volt, 100, 0.0);
          DecaVolt = new ScaledUnit(@"DecaVolt", @"daV", Volt, 10, 0.0);
          DeciVolt = new ScaledUnit(@"DeciVolt", @"dV", Volt, 0.1, 0.0);
          CentiVolt = new ScaledUnit(@"CentiVolt", @"cV", Volt, 0.01, 0.0);
          MilliVolt = new ScaledUnit(@"MilliVolt", @"mV", Volt, 0.001, 0.0);
          MicroVolt = new ScaledUnit(@"MicroVolt", @"µV", Volt, 1E-06, 0.0);
          NanoVolt = new ScaledUnit(@"NanoVolt", @"nV", Volt, 1E-09, 0.0);
          PicoVolt = new ScaledUnit(@"PicoVolt", @"pV", Volt, 1E-12, 0.0);
          FemtoVolt = new ScaledUnit(@"FemtoVolt", @"fV", Volt, 1E-15, 0.0);
          AttoVolt = new ScaledUnit(@"AttoVolt", @"aV", Volt, 1E-18, 0.0);
          ZeptoVolt = new ScaledUnit(@"ZeptoVolt", @"zV", Volt, 1E-21, 0.0);
          YoctoVolt = new ScaledUnit(@"YoctoVolt", @"yV", Volt, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Volt.Name, Volt },
            { YottaVolt.Name, YottaVolt },
            { ZettaVolt.Name, ZettaVolt },
            { ExaVolt.Name, ExaVolt },
            { PetaVolt.Name, PetaVolt },
            { TeraVolt.Name, TeraVolt },
            { GigaVolt.Name, GigaVolt },
            { MegaVolt.Name, MegaVolt },
            { KiloVolt.Name, KiloVolt },
            { HectoVolt.Name, HectoVolt },
            { DecaVolt.Name, DecaVolt },
            { DeciVolt.Name, DeciVolt },
            { CentiVolt.Name, CentiVolt },
            { MilliVolt.Name, MilliVolt },
            { MicroVolt.Name, MicroVolt },
            { NanoVolt.Name, NanoVolt },
            { PicoVolt.Name, PicoVolt },
            { FemtoVolt.Name, FemtoVolt },
            { AttoVolt.Name, AttoVolt },
            { ZeptoVolt.Name, ZeptoVolt },
            { YoctoVolt.Name, YoctoVolt },
          };
        }

        static Voltage()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
