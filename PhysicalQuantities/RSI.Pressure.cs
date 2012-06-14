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
      public static partial class Pressure
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pascal_(unit)
        /// </summary>
        public static BaseUnit Pascal { get; private set; }
        // Prefix Table: RISUPrefixes
        public static ScaledUnit GigaPascal { get; private set; }
        public static ScaledUnit MegaPascal { get; private set; }
        public static ScaledUnit KiloPascal { get; private set; }
        public static ScaledUnit HectoPascal { get; private set; }
        public static ScaledUnit DecaPascal { get; private set; }
        public static ScaledUnit DeciPascal { get; private set; }
        public static ScaledUnit CentiPascal { get; private set; }
        public static ScaledUnit MilliPascal { get; private set; }
        public static ScaledUnit MicroPascal { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bar_(unit)
        /// </summary>
        public static ScaledUnit Bar { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bar_(unit)
        /// </summary>
        public static ScaledUnit MilliBar { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Atmosphere_(unit)
        /// </summary>
        public static ScaledUnit Atmosphere { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Millimetre_of_mercury#Manometric_units_of_pressure
        /// </summary>
        public static ScaledUnit MillimetreOfMercury { get; private set; }

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
          Pascal = new BaseUnit(@"Pascal", @"Pa", PhysicalQuantities.Quantities.Pressure, unitSystem);
          GigaPascal = new ScaledUnit(@"GigaPascal", @"GPa", Pascal, 1000000000, 0.0);
          MegaPascal = new ScaledUnit(@"MegaPascal", @"MPa", Pascal, 1000000, 0.0);
          KiloPascal = new ScaledUnit(@"KiloPascal", @"kPa", Pascal, 1000, 0.0);
          HectoPascal = new ScaledUnit(@"HectoPascal", @"hPa", Pascal, 100, 0.0);
          DecaPascal = new ScaledUnit(@"DecaPascal", @"daPa", Pascal, 10, 0.0);
          DeciPascal = new ScaledUnit(@"DeciPascal", @"dPa", Pascal, 0.1, 0.0);
          CentiPascal = new ScaledUnit(@"CentiPascal", @"cPa", Pascal, 0.01, 0.0);
          MilliPascal = new ScaledUnit(@"MilliPascal", @"mPa", Pascal, 0.001, 0.0);
          MicroPascal = new ScaledUnit(@"MicroPascal", @"µPa", Pascal, 1E-06, 0.0);
          Bar = new ScaledUnit(@"Bar", @"bar", Pascal, 100000, 0);
          MilliBar = new ScaledUnit(@"MilliBar", @"mbar", Bar, 0.001, 0);
          Atmosphere = new ScaledUnit(@"Atmosphere", @"atm", Pascal, 101325, 0);
          MillimetreOfMercury = new ScaledUnit(@"MillimetreOfMercury", @"mmHg", Pascal, 133.322387415, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Pascal.Name, Pascal },
            { GigaPascal.Name, GigaPascal },
            { MegaPascal.Name, MegaPascal },
            { KiloPascal.Name, KiloPascal },
            { HectoPascal.Name, HectoPascal },
            { DecaPascal.Name, DecaPascal },
            { DeciPascal.Name, DeciPascal },
            { CentiPascal.Name, CentiPascal },
            { MilliPascal.Name, MilliPascal },
            { MicroPascal.Name, MicroPascal },
            { Bar.Name, Bar },
            { MilliBar.Name, MilliBar },
            { Atmosphere.Name, Atmosphere },
            { MillimetreOfMercury.Name, MillimetreOfMercury },
          };
        }

        static Pressure()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
