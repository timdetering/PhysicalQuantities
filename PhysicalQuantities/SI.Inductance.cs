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
      public static partial class Inductance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Henry_(unit)
        /// </summary>
        public static BaseUnit Henry { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaHenry { get; private set; }
        public static ScaledUnit ZettaHenry { get; private set; }
        public static ScaledUnit ExaHenry { get; private set; }
        public static ScaledUnit PetaHenry { get; private set; }
        public static ScaledUnit TeraHenry { get; private set; }
        public static ScaledUnit GigaHenry { get; private set; }
        public static ScaledUnit MegaHenry { get; private set; }
        public static ScaledUnit KiloHenry { get; private set; }
        public static ScaledUnit HectoHenry { get; private set; }
        public static ScaledUnit DecaHenry { get; private set; }
        public static ScaledUnit DeciHenry { get; private set; }
        public static ScaledUnit CentiHenry { get; private set; }
        public static ScaledUnit MilliHenry { get; private set; }
        public static ScaledUnit MicroHenry { get; private set; }
        public static ScaledUnit NanoHenry { get; private set; }
        public static ScaledUnit PicoHenry { get; private set; }
        public static ScaledUnit FemtoHenry { get; private set; }
        public static ScaledUnit AttoHenry { get; private set; }
        public static ScaledUnit ZeptoHenry { get; private set; }
        public static ScaledUnit YoctoHenry { get; private set; }

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
          Henry = new BaseUnit(@"Henry", @"H", PhysicalQuantities.Quantities.Inductance, unitSystem);
          YottaHenry = new ScaledUnit(@"YottaHenry", @"YH", Henry, 1E+24, 0.0);
          ZettaHenry = new ScaledUnit(@"ZettaHenry", @"ZH", Henry, 1E+21, 0.0);
          ExaHenry = new ScaledUnit(@"ExaHenry", @"EH", Henry, 1E+18, 0.0);
          PetaHenry = new ScaledUnit(@"PetaHenry", @"PH", Henry, 1E+15, 0.0);
          TeraHenry = new ScaledUnit(@"TeraHenry", @"TH", Henry, 1000000000000, 0.0);
          GigaHenry = new ScaledUnit(@"GigaHenry", @"GH", Henry, 1000000000, 0.0);
          MegaHenry = new ScaledUnit(@"MegaHenry", @"MH", Henry, 1000000, 0.0);
          KiloHenry = new ScaledUnit(@"KiloHenry", @"kH", Henry, 1000, 0.0);
          HectoHenry = new ScaledUnit(@"HectoHenry", @"hH", Henry, 100, 0.0);
          DecaHenry = new ScaledUnit(@"DecaHenry", @"daH", Henry, 10, 0.0);
          DeciHenry = new ScaledUnit(@"DeciHenry", @"dH", Henry, 0.1, 0.0);
          CentiHenry = new ScaledUnit(@"CentiHenry", @"cH", Henry, 0.01, 0.0);
          MilliHenry = new ScaledUnit(@"MilliHenry", @"mH", Henry, 0.001, 0.0);
          MicroHenry = new ScaledUnit(@"MicroHenry", @"µH", Henry, 1E-06, 0.0);
          NanoHenry = new ScaledUnit(@"NanoHenry", @"nH", Henry, 1E-09, 0.0);
          PicoHenry = new ScaledUnit(@"PicoHenry", @"pH", Henry, 1E-12, 0.0);
          FemtoHenry = new ScaledUnit(@"FemtoHenry", @"fH", Henry, 1E-15, 0.0);
          AttoHenry = new ScaledUnit(@"AttoHenry", @"aH", Henry, 1E-18, 0.0);
          ZeptoHenry = new ScaledUnit(@"ZeptoHenry", @"zH", Henry, 1E-21, 0.0);
          YoctoHenry = new ScaledUnit(@"YoctoHenry", @"yH", Henry, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Henry.Name, Henry },
            { YottaHenry.Name, YottaHenry },
            { ZettaHenry.Name, ZettaHenry },
            { ExaHenry.Name, ExaHenry },
            { PetaHenry.Name, PetaHenry },
            { TeraHenry.Name, TeraHenry },
            { GigaHenry.Name, GigaHenry },
            { MegaHenry.Name, MegaHenry },
            { KiloHenry.Name, KiloHenry },
            { HectoHenry.Name, HectoHenry },
            { DecaHenry.Name, DecaHenry },
            { DeciHenry.Name, DeciHenry },
            { CentiHenry.Name, CentiHenry },
            { MilliHenry.Name, MilliHenry },
            { MicroHenry.Name, MicroHenry },
            { NanoHenry.Name, NanoHenry },
            { PicoHenry.Name, PicoHenry },
            { FemtoHenry.Name, FemtoHenry },
            { AttoHenry.Name, AttoHenry },
            { ZeptoHenry.Name, ZeptoHenry },
            { YoctoHenry.Name, YoctoHenry },
          };
        }

        static Inductance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
