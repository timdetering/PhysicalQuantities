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
      public static partial class ElectricConductance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Siemens_(unit)
        /// </summary>
        public static BaseUnit Siemens { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSiemens { get; private set; }
        public static ScaledUnit ZettaSiemens { get; private set; }
        public static ScaledUnit ExaSiemens { get; private set; }
        public static ScaledUnit PetaSiemens { get; private set; }
        public static ScaledUnit TeraSiemens { get; private set; }
        public static ScaledUnit GigaSiemens { get; private set; }
        public static ScaledUnit MegaSiemens { get; private set; }
        public static ScaledUnit KiloSiemens { get; private set; }
        public static ScaledUnit HectoSiemens { get; private set; }
        public static ScaledUnit DecaSiemens { get; private set; }
        public static ScaledUnit DeciSiemens { get; private set; }
        public static ScaledUnit CentiSiemens { get; private set; }
        public static ScaledUnit MilliSiemens { get; private set; }
        public static ScaledUnit MicroSiemens { get; private set; }
        public static ScaledUnit NanoSiemens { get; private set; }
        public static ScaledUnit PicoSiemens { get; private set; }
        public static ScaledUnit FemtoSiemens { get; private set; }
        public static ScaledUnit AttoSiemens { get; private set; }
        public static ScaledUnit ZeptoSiemens { get; private set; }
        public static ScaledUnit YoctoSiemens { get; private set; }

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
          Siemens = new BaseUnit(@"Siemens", @"S", PhysicalQuantities.Quantities.ElectricConductance, unitSystem) { Caption = @"siemens" };
          YottaSiemens = new ScaledUnit(@"YottaSiemens", @"YS", Siemens, 1E+24, 0.0) { Caption = @"yottasiemens" };
          ZettaSiemens = new ScaledUnit(@"ZettaSiemens", @"ZS", Siemens, 1E+21, 0.0) { Caption = @"zettasiemens" };
          ExaSiemens = new ScaledUnit(@"ExaSiemens", @"ES", Siemens, 1E+18, 0.0) { Caption = @"exasiemens" };
          PetaSiemens = new ScaledUnit(@"PetaSiemens", @"PS", Siemens, 1E+15, 0.0) { Caption = @"petasiemens" };
          TeraSiemens = new ScaledUnit(@"TeraSiemens", @"TS", Siemens, 1000000000000, 0.0) { Caption = @"terasiemens" };
          GigaSiemens = new ScaledUnit(@"GigaSiemens", @"GS", Siemens, 1000000000, 0.0) { Caption = @"gigasiemens" };
          MegaSiemens = new ScaledUnit(@"MegaSiemens", @"MS", Siemens, 1000000, 0.0) { Caption = @"megasiemens" };
          KiloSiemens = new ScaledUnit(@"KiloSiemens", @"kS", Siemens, 1000, 0.0) { Caption = @"kilosiemens" };
          HectoSiemens = new ScaledUnit(@"HectoSiemens", @"hS", Siemens, 100, 0.0) { Caption = @"hectosiemens" };
          DecaSiemens = new ScaledUnit(@"DecaSiemens", @"daS", Siemens, 10, 0.0) { Caption = @"decasiemens" };
          DeciSiemens = new ScaledUnit(@"DeciSiemens", @"dS", Siemens, 0.1, 0.0) { Caption = @"decisiemens" };
          CentiSiemens = new ScaledUnit(@"CentiSiemens", @"cS", Siemens, 0.01, 0.0) { Caption = @"centisiemens" };
          MilliSiemens = new ScaledUnit(@"MilliSiemens", @"mS", Siemens, 0.001, 0.0) { Caption = @"milisiemens" };
          MicroSiemens = new ScaledUnit(@"MicroSiemens", @"μS", Siemens, 1E-06, 0.0) { Caption = @"microsiemens" };
          NanoSiemens = new ScaledUnit(@"NanoSiemens", @"nS", Siemens, 1E-09, 0.0) { Caption = @"nanosiemens" };
          PicoSiemens = new ScaledUnit(@"PicoSiemens", @"pS", Siemens, 1E-12, 0.0) { Caption = @"picosiemens" };
          FemtoSiemens = new ScaledUnit(@"FemtoSiemens", @"fS", Siemens, 1E-15, 0.0) { Caption = @"femtosiemens" };
          AttoSiemens = new ScaledUnit(@"AttoSiemens", @"aS", Siemens, 1E-18, 0.0) { Caption = @"attosiemens" };
          ZeptoSiemens = new ScaledUnit(@"ZeptoSiemens", @"zS", Siemens, 1E-21, 0.0) { Caption = @"zeptosiemens" };
          YoctoSiemens = new ScaledUnit(@"YoctoSiemens", @"yS", Siemens, 1E-24, 0.0) { Caption = @"yoctosiemens" };

          allUnits = new Dictionary<string, Unit>
          {
            { Siemens.Name, Siemens },
            { YottaSiemens.Name, YottaSiemens },
            { ZettaSiemens.Name, ZettaSiemens },
            { ExaSiemens.Name, ExaSiemens },
            { PetaSiemens.Name, PetaSiemens },
            { TeraSiemens.Name, TeraSiemens },
            { GigaSiemens.Name, GigaSiemens },
            { MegaSiemens.Name, MegaSiemens },
            { KiloSiemens.Name, KiloSiemens },
            { HectoSiemens.Name, HectoSiemens },
            { DecaSiemens.Name, DecaSiemens },
            { DeciSiemens.Name, DeciSiemens },
            { CentiSiemens.Name, CentiSiemens },
            { MilliSiemens.Name, MilliSiemens },
            { MicroSiemens.Name, MicroSiemens },
            { NanoSiemens.Name, NanoSiemens },
            { PicoSiemens.Name, PicoSiemens },
            { FemtoSiemens.Name, FemtoSiemens },
            { AttoSiemens.Name, AttoSiemens },
            { ZeptoSiemens.Name, ZeptoSiemens },
            { YoctoSiemens.Name, YoctoSiemens },
          };
        }

        static ElectricConductance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
