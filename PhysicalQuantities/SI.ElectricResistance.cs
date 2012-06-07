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
      public static partial class ElectricResistance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Ohm_(unit)
        /// </summary>
        public static BaseUnit Ohm { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaOhm { get; private set; }
        public static ScaledUnit ZettaOhm { get; private set; }
        public static ScaledUnit ExaOhm { get; private set; }
        public static ScaledUnit PetaOhm { get; private set; }
        public static ScaledUnit TeraOhm { get; private set; }
        public static ScaledUnit GigaOhm { get; private set; }
        public static ScaledUnit MegaOhm { get; private set; }
        public static ScaledUnit KiloOhm { get; private set; }
        public static ScaledUnit HectoOhm { get; private set; }
        public static ScaledUnit DecaOhm { get; private set; }
        public static ScaledUnit DeciOhm { get; private set; }
        public static ScaledUnit CentiOhm { get; private set; }
        public static ScaledUnit MilliOhm { get; private set; }
        public static ScaledUnit MicroOhm { get; private set; }
        public static ScaledUnit NanoOhm { get; private set; }
        public static ScaledUnit PicoOhm { get; private set; }
        public static ScaledUnit FemtoOhm { get; private set; }
        public static ScaledUnit AttoOhm { get; private set; }
        public static ScaledUnit ZeptoOhm { get; private set; }
        public static ScaledUnit YoctoOhm { get; private set; }

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
          Ohm = new BaseUnit(@"Ohm", @"O", PhysicalQuantities.Quantities.ElectricResistance, unitSystem);
          YottaOhm = new ScaledUnit(@"YottaOhm", @"YO", Ohm, 1E+24, 0.0);
          ZettaOhm = new ScaledUnit(@"ZettaOhm", @"ZO", Ohm, 1E+21, 0.0);
          ExaOhm = new ScaledUnit(@"ExaOhm", @"EO", Ohm, 1E+18, 0.0);
          PetaOhm = new ScaledUnit(@"PetaOhm", @"PO", Ohm, 1E+15, 0.0);
          TeraOhm = new ScaledUnit(@"TeraOhm", @"TO", Ohm, 1000000000000, 0.0);
          GigaOhm = new ScaledUnit(@"GigaOhm", @"GO", Ohm, 1000000000, 0.0);
          MegaOhm = new ScaledUnit(@"MegaOhm", @"MO", Ohm, 1000000, 0.0);
          KiloOhm = new ScaledUnit(@"KiloOhm", @"kO", Ohm, 1000, 0.0);
          HectoOhm = new ScaledUnit(@"HectoOhm", @"hO", Ohm, 100, 0.0);
          DecaOhm = new ScaledUnit(@"DecaOhm", @"daO", Ohm, 10, 0.0);
          DeciOhm = new ScaledUnit(@"DeciOhm", @"dO", Ohm, 0.1, 0.0);
          CentiOhm = new ScaledUnit(@"CentiOhm", @"cO", Ohm, 0.01, 0.0);
          MilliOhm = new ScaledUnit(@"MilliOhm", @"mO", Ohm, 0.001, 0.0);
          MicroOhm = new ScaledUnit(@"MicroOhm", @"µO", Ohm, 1E-06, 0.0);
          NanoOhm = new ScaledUnit(@"NanoOhm", @"nO", Ohm, 1E-09, 0.0);
          PicoOhm = new ScaledUnit(@"PicoOhm", @"pO", Ohm, 1E-12, 0.0);
          FemtoOhm = new ScaledUnit(@"FemtoOhm", @"fO", Ohm, 1E-15, 0.0);
          AttoOhm = new ScaledUnit(@"AttoOhm", @"aO", Ohm, 1E-18, 0.0);
          ZeptoOhm = new ScaledUnit(@"ZeptoOhm", @"zO", Ohm, 1E-21, 0.0);
          YoctoOhm = new ScaledUnit(@"YoctoOhm", @"yO", Ohm, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Ohm.Name, Ohm },
            { YottaOhm.Name, YottaOhm },
            { ZettaOhm.Name, ZettaOhm },
            { ExaOhm.Name, ExaOhm },
            { PetaOhm.Name, PetaOhm },
            { TeraOhm.Name, TeraOhm },
            { GigaOhm.Name, GigaOhm },
            { MegaOhm.Name, MegaOhm },
            { KiloOhm.Name, KiloOhm },
            { HectoOhm.Name, HectoOhm },
            { DecaOhm.Name, DecaOhm },
            { DeciOhm.Name, DeciOhm },
            { CentiOhm.Name, CentiOhm },
            { MilliOhm.Name, MilliOhm },
            { MicroOhm.Name, MicroOhm },
            { NanoOhm.Name, NanoOhm },
            { PicoOhm.Name, PicoOhm },
            { FemtoOhm.Name, FemtoOhm },
            { AttoOhm.Name, AttoOhm },
            { ZeptoOhm.Name, ZeptoOhm },
            { YoctoOhm.Name, YoctoOhm },
          };
        }

        static ElectricResistance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
