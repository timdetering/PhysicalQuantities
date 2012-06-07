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
      public static partial class Mass
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pound_(mass)
        /// </summary>
        public static BaseUnit Pound { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Ounce
        /// </summary>
        public static ScaledUnit Ounce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Dram_(unit)
        /// </summary>
        public static ScaledUnit Drachm { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Grain_(mass)
        /// </summary>
        public static ScaledUnit Grain { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Stone_(Imperial_mass)
        /// </summary>
        public static ScaledUnit Stone { get; private set; }
        public static ScaledUnit Quarter { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hundredweight
        /// </summary>
        public static ScaledUnit Hundredweight { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Long_ton
        /// </summary>
        public static ScaledUnit Ton { get; private set; }

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
          Pound = new BaseUnit(@"Pound", @"lb", PhysicalQuantities.Quantities.Mass, unitSystem);
          Ounce = new ScaledUnit(@"Ounce", @"oz", Pound, 0.0625, 0);
          Drachm = new ScaledUnit(@"Drachm", @"drc", Ounce, 0.0625, 0);
          Grain = new ScaledUnit(@"Grain", @"gr", Pound, 0.000142857142857143, 0);
          Stone = new ScaledUnit(@"Stone", @"st", Pound, 14, 0);
          Quarter = new ScaledUnit(@"Quarter", @"qtr", Stone, 2, 0);
          Hundredweight = new ScaledUnit(@"Hundredweight", @"cwt", Quarter, 4, 0);
          Ton = new ScaledUnit(@"Ton", @"t", Hundredweight, 20, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Pound.Name, Pound },
            { Ounce.Name, Ounce },
            { Drachm.Name, Drachm },
            { Grain.Name, Grain },
            { Stone.Name, Stone },
            { Quarter.Name, Quarter },
            { Hundredweight.Name, Hundredweight },
            { Ton.Name, Ton },
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
