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
      public static partial class Mass
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kilogram
        /// </summary>
        public static BaseUnit Kilogram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gram
        /// </summary>
        public static ScaledUnit Gram { get; private set; }
        public static ScaledUnit Hectogram { get; private set; }
        public static ScaledUnit Decagram { get; private set; }
        public static ScaledUnit Decigram { get; private set; }
        public static ScaledUnit Centigram { get; private set; }
        public static ScaledUnit Milligram { get; private set; }
        public static ScaledUnit Microgram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit Tonne { get; private set; }

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
          Kilogram = new BaseUnit(@"Kilogram", @"kg", PhysicalQuantities.Quantities.Mass, unitSystem);
          Gram = new ScaledUnit(@"Gram", @"g", Kilogram, 0.001, 0);
          Hectogram = new ScaledUnit(@"Hectogram", @"hg", Gram, 100, 0);
          Decagram = new ScaledUnit(@"Decagram", @"dag", Gram, 10, 0);
          Decigram = new ScaledUnit(@"Decigram", @"dg", Gram, 0.1, 0);
          Centigram = new ScaledUnit(@"Centigram", @"cg", Gram, 0.01, 0);
          Milligram = new ScaledUnit(@"Milligram", @"mg", Gram, 0.001, 0);
          Microgram = new ScaledUnit(@"Microgram", @"µg", Gram, 1E-06, 0);
          Tonne = new ScaledUnit(@"Tonne", @"t", Kilogram, 1000, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Kilogram.Name, Kilogram },
            { Gram.Name, Gram },
            { Hectogram.Name, Hectogram },
            { Decagram.Name, Decagram },
            { Decigram.Name, Decigram },
            { Centigram.Name, Centigram },
            { Milligram.Name, Milligram },
            { Microgram.Name, Microgram },
            { Tonne.Name, Tonne },
          };
        }

        static Mass()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
