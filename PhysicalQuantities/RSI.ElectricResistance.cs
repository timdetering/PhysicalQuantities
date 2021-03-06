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
          Ohm = new BaseUnit(@"Ohm", @"Ω", PhysicalQuantities.Quantities.ElectricResistance, unitSystem) { Caption = @"ohmio" };
          GigaOhm = new ScaledUnit(@"GigaOhm", @"GΩ", Ohm, 1000000000, 0.0) { Caption = @"gigaohmio" };
          MegaOhm = new ScaledUnit(@"MegaOhm", @"MΩ", Ohm, 1000000, 0.0) { Caption = @"megaohmio" };
          KiloOhm = new ScaledUnit(@"KiloOhm", @"kΩ", Ohm, 1000, 0.0) { Caption = @"kiloohmio" };
          HectoOhm = new ScaledUnit(@"HectoOhm", @"hΩ", Ohm, 100, 0.0) { Caption = @"hectoohmio" };
          DecaOhm = new ScaledUnit(@"DecaOhm", @"daΩ", Ohm, 10, 0.0) { Caption = @"decaohmio" };
          DeciOhm = new ScaledUnit(@"DeciOhm", @"dΩ", Ohm, 0.1, 0.0) { Caption = @"deciohmio" };
          CentiOhm = new ScaledUnit(@"CentiOhm", @"cΩ", Ohm, 0.01, 0.0) { Caption = @"centiohmio" };
          MilliOhm = new ScaledUnit(@"MilliOhm", @"mΩ", Ohm, 0.001, 0.0) { Caption = @"miliohmio" };
          MicroOhm = new ScaledUnit(@"MicroOhm", @"μΩ", Ohm, 1E-06, 0.0) { Caption = @"microohmio" };

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
