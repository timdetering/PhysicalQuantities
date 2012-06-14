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
      public static partial class ElectricResistance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Ohm_(unit)
        /// </summary>
        public static BaseUnit Ohm { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaOhm { get; private set; }
        public static ScaledUnit MegaOhm { get; private set; }
        public static ScaledUnit KiloOhm { get; private set; }
        public static ScaledUnit HectoOhm { get; private set; }
        public static ScaledUnit DecaOhm { get; private set; }
        public static ScaledUnit DeciOhm { get; private set; }
        public static ScaledUnit CentiOhm { get; private set; }
        public static ScaledUnit MilliOhm { get; private set; }
        public static ScaledUnit MicroOhm { get; private set; }

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
          GigaOhm = new ScaledUnit(@"GigaOhm", @"GO", Ohm, 1000000000, 0.0);
          MegaOhm = new ScaledUnit(@"MegaOhm", @"MO", Ohm, 1000000, 0.0);
          KiloOhm = new ScaledUnit(@"KiloOhm", @"kO", Ohm, 1000, 0.0);
          HectoOhm = new ScaledUnit(@"HectoOhm", @"hO", Ohm, 100, 0.0);
          DecaOhm = new ScaledUnit(@"DecaOhm", @"daO", Ohm, 10, 0.0);
          DeciOhm = new ScaledUnit(@"DeciOhm", @"dO", Ohm, 0.1, 0.0);
          CentiOhm = new ScaledUnit(@"CentiOhm", @"cO", Ohm, 0.01, 0.0);
          MilliOhm = new ScaledUnit(@"MilliOhm", @"mO", Ohm, 0.001, 0.0);
          MicroOhm = new ScaledUnit(@"MicroOhm", @"µO", Ohm, 1E-06, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Ohm.Name, Ohm },
            { GigaOhm.Name, GigaOhm },
            { MegaOhm.Name, MegaOhm },
            { KiloOhm.Name, KiloOhm },
            { HectoOhm.Name, HectoOhm },
            { DecaOhm.Name, DecaOhm },
            { DeciOhm.Name, DeciOhm },
            { CentiOhm.Name, CentiOhm },
            { MilliOhm.Name, MilliOhm },
            { MicroOhm.Name, MicroOhm },
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
