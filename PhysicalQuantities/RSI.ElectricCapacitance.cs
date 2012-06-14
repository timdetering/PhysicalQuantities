using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class RSI
    {
      public static partial class ElectricCapacitance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Farad
        /// </summary>
        public static BaseUnit Farad { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaFarad { get; private set; }
        public static ScaledUnit MegaFarad { get; private set; }
        public static ScaledUnit KiloFarad { get; private set; }
        public static ScaledUnit HectoFarad { get; private set; }
        public static ScaledUnit DecaFarad { get; private set; }
        public static ScaledUnit DeciFarad { get; private set; }
        public static ScaledUnit CentiFarad { get; private set; }
        public static ScaledUnit MilliFarad { get; private set; }
        public static ScaledUnit MicroFarad { get; private set; }

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
          GigaFarad = new ScaledUnit(@"GigaFarad", @"GF", Farad, 1000000000, 0.0);
          MegaFarad = new ScaledUnit(@"MegaFarad", @"MF", Farad, 1000000, 0.0);
          KiloFarad = new ScaledUnit(@"KiloFarad", @"kF", Farad, 1000, 0.0);
          HectoFarad = new ScaledUnit(@"HectoFarad", @"hF", Farad, 100, 0.0);
          DecaFarad = new ScaledUnit(@"DecaFarad", @"daF", Farad, 10, 0.0);
          DeciFarad = new ScaledUnit(@"DeciFarad", @"dF", Farad, 0.1, 0.0);
          CentiFarad = new ScaledUnit(@"CentiFarad", @"cF", Farad, 0.01, 0.0);
          MilliFarad = new ScaledUnit(@"MilliFarad", @"mF", Farad, 0.001, 0.0);
          MicroFarad = new ScaledUnit(@"MicroFarad", @"µF", Farad, 1E-06, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Farad.Name, Farad },
            { GigaFarad.Name, GigaFarad },
            { MegaFarad.Name, MegaFarad },
            { KiloFarad.Name, KiloFarad },
            { HectoFarad.Name, HectoFarad },
            { DecaFarad.Name, DecaFarad },
            { DeciFarad.Name, DeciFarad },
            { CentiFarad.Name, CentiFarad },
            { MilliFarad.Name, MilliFarad },
            { MicroFarad.Name, MicroFarad },
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
