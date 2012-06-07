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
        public static ScaledUnit Dram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Grain_(mass)
        /// </summary>
        public static ScaledUnit Grain { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hundredweight
        /// </summary>
        public static ScaledUnit Hundredweight { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hundredweight
        /// </summary>
        public static ScaledUnit LongHundredweight { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Short_ton
        /// </summary>
        public static ScaledUnit ShortTon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Long_ton
        /// </summary>
        public static ScaledUnit LongTon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pennyweight
        /// </summary>
        public static ScaledUnit Pennyweight { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Troy_ounce
        /// </summary>
        public static ScaledUnit TroyOunce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Troy_pound
        /// </summary>
        public static ScaledUnit TroyPound { get; private set; }

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
          Dram = new ScaledUnit(@"Dram", @"dr", Ounce, 0.0625, 0);
          Grain = new ScaledUnit(@"Grain", @"gr", Pound, 0.000142857142857143, 0);
          Hundredweight = new ScaledUnit(@"Hundredweight", @"cwt", Pound, 100, 0);
          LongHundredweight = new ScaledUnit(@"LongHundredweight", null, Pound, 112, 0);
          ShortTon = new ScaledUnit(@"ShortTon", @"ton", Hundredweight, 20, 0);
          LongTon = new ScaledUnit(@"LongTon", @"t", LongHundredweight, 20, 0);
          Pennyweight = new ScaledUnit(@"Pennyweight", @"dwt", Grain, 24, 0);
          TroyOunce = new ScaledUnit(@"TroyOunce", @"oz t", Pennyweight, 20, 0);
          TroyPound = new ScaledUnit(@"TroyPound", @"lb t", TroyOunce, 12, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Pound.Name, Pound },
            { Ounce.Name, Ounce },
            { Dram.Name, Dram },
            { Grain.Name, Grain },
            { Hundredweight.Name, Hundredweight },
            { LongHundredweight.Name, LongHundredweight },
            { ShortTon.Name, ShortTon },
            { LongTon.Name, LongTon },
            { Pennyweight.Name, Pennyweight },
            { TroyOunce.Name, TroyOunce },
            { TroyPound.Name, TroyPound },
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
