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
      public static partial class ElectricCapacitance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Farad
        /// </summary>
        public static BaseUnit Farad { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaFarad { get; private set; }
        public static ScaledUnit ZettaFarad { get; private set; }
        public static ScaledUnit ExaFarad { get; private set; }
        public static ScaledUnit PetaFarad { get; private set; }
        public static ScaledUnit TeraFarad { get; private set; }
        public static ScaledUnit GigaFarad { get; private set; }
        public static ScaledUnit MegaFarad { get; private set; }
        public static ScaledUnit KiloFarad { get; private set; }
        public static ScaledUnit HectoFarad { get; private set; }
        public static ScaledUnit DecaFarad { get; private set; }
        public static ScaledUnit DeciFarad { get; private set; }
        public static ScaledUnit CentiFarad { get; private set; }
        public static ScaledUnit MilliFarad { get; private set; }
        public static ScaledUnit MicroFarad { get; private set; }
        public static ScaledUnit NanoFarad { get; private set; }
        public static ScaledUnit PicoFarad { get; private set; }
        public static ScaledUnit FemtoFarad { get; private set; }
        public static ScaledUnit AttoFarad { get; private set; }
        public static ScaledUnit ZeptoFarad { get; private set; }
        public static ScaledUnit YoctoFarad { get; private set; }

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
          Farad = new BaseUnit(@"Farad", @"F", PhysicalQuantities.Quantities.ElectricCapacitance, unitSystem);
          YottaFarad = new ScaledUnit(@"YottaFarad", @"YF", Farad, 1E+24, 0.0);
          ZettaFarad = new ScaledUnit(@"ZettaFarad", @"ZF", Farad, 1E+21, 0.0);
          ExaFarad = new ScaledUnit(@"ExaFarad", @"EF", Farad, 1E+18, 0.0);
          PetaFarad = new ScaledUnit(@"PetaFarad", @"PF", Farad, 1E+15, 0.0);
          TeraFarad = new ScaledUnit(@"TeraFarad", @"TF", Farad, 1000000000000, 0.0);
          GigaFarad = new ScaledUnit(@"GigaFarad", @"GF", Farad, 1000000000, 0.0);
          MegaFarad = new ScaledUnit(@"MegaFarad", @"MF", Farad, 1000000, 0.0);
          KiloFarad = new ScaledUnit(@"KiloFarad", @"kF", Farad, 1000, 0.0);
          HectoFarad = new ScaledUnit(@"HectoFarad", @"hF", Farad, 100, 0.0);
          DecaFarad = new ScaledUnit(@"DecaFarad", @"daF", Farad, 10, 0.0);
          DeciFarad = new ScaledUnit(@"DeciFarad", @"dF", Farad, 0.1, 0.0);
          CentiFarad = new ScaledUnit(@"CentiFarad", @"cF", Farad, 0.01, 0.0);
          MilliFarad = new ScaledUnit(@"MilliFarad", @"mF", Farad, 0.001, 0.0);
          MicroFarad = new ScaledUnit(@"MicroFarad", @"µF", Farad, 1E-06, 0.0);
          NanoFarad = new ScaledUnit(@"NanoFarad", @"nF", Farad, 1E-09, 0.0);
          PicoFarad = new ScaledUnit(@"PicoFarad", @"pF", Farad, 1E-12, 0.0);
          FemtoFarad = new ScaledUnit(@"FemtoFarad", @"fF", Farad, 1E-15, 0.0);
          AttoFarad = new ScaledUnit(@"AttoFarad", @"aF", Farad, 1E-18, 0.0);
          ZeptoFarad = new ScaledUnit(@"ZeptoFarad", @"zF", Farad, 1E-21, 0.0);
          YoctoFarad = new ScaledUnit(@"YoctoFarad", @"yF", Farad, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Farad.Name, Farad },
            { YottaFarad.Name, YottaFarad },
            { ZettaFarad.Name, ZettaFarad },
            { ExaFarad.Name, ExaFarad },
            { PetaFarad.Name, PetaFarad },
            { TeraFarad.Name, TeraFarad },
            { GigaFarad.Name, GigaFarad },
            { MegaFarad.Name, MegaFarad },
            { KiloFarad.Name, KiloFarad },
            { HectoFarad.Name, HectoFarad },
            { DecaFarad.Name, DecaFarad },
            { DeciFarad.Name, DeciFarad },
            { CentiFarad.Name, CentiFarad },
            { MilliFarad.Name, MilliFarad },
            { MicroFarad.Name, MicroFarad },
            { NanoFarad.Name, NanoFarad },
            { PicoFarad.Name, PicoFarad },
            { FemtoFarad.Name, FemtoFarad },
            { AttoFarad.Name, AttoFarad },
            { ZeptoFarad.Name, ZeptoFarad },
            { YoctoFarad.Name, YoctoFarad },
          };
        }

        static ElectricCapacitance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
