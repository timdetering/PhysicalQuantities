using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class Imperial
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
          Degree = new BaseUnit(@"Degree", @"°", PhysicalQuantities.Quantities.Angle, unitSystem) { Caption = @"grado" };
          Arcminute = new ScaledUnit(@"Arcminute", @"'", Degree, 0.0166666666666667, 0) { Caption = @"minuto de arco" };
          Arcsecond = new ScaledUnit(@"Arcsecond", @"""", Arcminute, 0.0166666666666667, 0) { Caption = @"segundo de arco" };
          Milliarcsecond = new ScaledUnit(@"Milliarcsecond", @"mas", Arcsecond, 0.001, 0) { Caption = @"milisegundo de arco" };
          Microarcsecond = new ScaledUnit(@"Microarcsecond", @"μas", Milliarcsecond, 0.001, 0) { Caption = @"microsegundo de arco" };

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
