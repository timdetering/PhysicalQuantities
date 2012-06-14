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
      public static partial class ElectricCurrent
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Ampere
        /// </summary>
        public static BaseUnit Ampere { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaAmpere { get; private set; }
        public static ScaledUnit MegaAmpere { get; private set; }
        public static ScaledUnit KiloAmpere { get; private set; }
        public static ScaledUnit HectoAmpere { get; private set; }
        public static ScaledUnit DecaAmpere { get; private set; }
        public static ScaledUnit DeciAmpere { get; private set; }
        public static ScaledUnit CentiAmpere { get; private set; }
        public static ScaledUnit MilliAmpere { get; private set; }
        public static ScaledUnit MicroAmpere { get; private set; }

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
          Ampere = new BaseUnit(@"Ampere", @"A", PhysicalQuantities.Quantities.ElectricCurrent, unitSystem);
          GigaAmpere = new ScaledUnit(@"GigaAmpere", @"GA", Ampere, 1000000000, 0.0);
          MegaAmpere = new ScaledUnit(@"MegaAmpere", @"MA", Ampere, 1000000, 0.0);
          KiloAmpere = new ScaledUnit(@"KiloAmpere", @"kA", Ampere, 1000, 0.0);
          HectoAmpere = new ScaledUnit(@"HectoAmpere", @"hA", Ampere, 100, 0.0);
          DecaAmpere = new ScaledUnit(@"DecaAmpere", @"daA", Ampere, 10, 0.0);
          DeciAmpere = new ScaledUnit(@"DeciAmpere", @"dA", Ampere, 0.1, 0.0);
          CentiAmpere = new ScaledUnit(@"CentiAmpere", @"cA", Ampere, 0.01, 0.0);
          MilliAmpere = new ScaledUnit(@"MilliAmpere", @"mA", Ampere, 0.001, 0.0);
          MicroAmpere = new ScaledUnit(@"MicroAmpere", @"µA", Ampere, 1E-06, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Ampere.Name, Ampere },
            { GigaAmpere.Name, GigaAmpere },
            { MegaAmpere.Name, MegaAmpere },
            { KiloAmpere.Name, KiloAmpere },
            { HectoAmpere.Name, HectoAmpere },
            { DecaAmpere.Name, DecaAmpere },
            { DeciAmpere.Name, DeciAmpere },
            { CentiAmpere.Name, CentiAmpere },
            { MilliAmpere.Name, MilliAmpere },
            { MicroAmpere.Name, MicroAmpere },
          };
        }

        static ElectricCurrent()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
