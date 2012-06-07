using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class US
    {
      public static partial class Angle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Degree_(angle)
        /// </summary>
        public static BaseUnit Degree { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcminute
        /// </summary>
        public static ScaledUnit Arcminute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond
        /// </summary>
        public static ScaledUnit Arcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Milliarcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Microarcsecond { get; private set; }

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
          Degree = new BaseUnit(@"Degree", @"°", PhysicalQuantities.Quantities.Angle, unitSystem);
          Arcminute = new ScaledUnit(@"Arcminute", @"'", Degree, 0.0166666666666667, 0);
          Arcsecond = new ScaledUnit(@"Arcsecond", @"""", Arcminute, 0.0166666666666667, 0);
          Milliarcsecond = new ScaledUnit(@"Milliarcsecond", @"mas", Arcsecond, 0.001, 0);
          Microarcsecond = new ScaledUnit(@"Microarcsecond", @"µas", Milliarcsecond, 0.001, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Degree.Name, Degree },
            { Arcminute.Name, Arcminute },
            { Arcsecond.Name, Arcsecond },
            { Milliarcsecond.Name, Milliarcsecond },
            { Microarcsecond.Name, Microarcsecond },
          };
        }

        static Angle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
