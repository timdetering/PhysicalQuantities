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
      public static partial class Length
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot_(unit)
        /// </summary>
        public static BaseUnit Foot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Inch
        /// </summary>
        public static ScaledUnit Inch { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Thou_(length)
        /// </summary>
        public static ScaledUnit Thou { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Yard
        /// </summary>
        public static ScaledUnit Yard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Chain_(length)
        /// </summary>
        public static ScaledUnit Chain { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Furlong
        /// </summary>
        public static ScaledUnit Furlong { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Mile
        /// </summary>
        public static ScaledUnit Mile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/League_(unit)
        /// </summary>
        public static ScaledUnit League { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fathom
        /// </summary>
        public static ScaledUnit Fathom { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cable_length
        /// </summary>
        public static ScaledUnit Cable { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Nautical_mile
        /// </summary>
        public static ScaledUnit NauticalMile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Link_(unit)
        /// </summary>
        public static ScaledUnit Link { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Rod_(unit)
        /// </summary>
        public static ScaledUnit Rod { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Perch_(unit_of_measure)#Length
        /// </summary>
        public static ScaledUnit Perch { get; private set; }

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
          Foot = new BaseUnit(@"Foot", @"ft", PhysicalQuantities.Quantities.Length, unitSystem);
          Inch = new ScaledUnit(@"Inch", @"in", Foot, 0.0833333333333333, 0);
          Thou = new ScaledUnit(@"Thou", @"th", Inch, 0.001, 0);
          Yard = new ScaledUnit(@"Yard", @"yd", Foot, 3, 0);
          Chain = new ScaledUnit(@"Chain", @"ch", Yard, 22, 0);
          Furlong = new ScaledUnit(@"Furlong", @"fur", Chain, 10, 0);
          Mile = new ScaledUnit(@"Mile", @"mi", Furlong, 8, 0);
          League = new ScaledUnit(@"League", @"lea", Mile, 3, 0);
          Fathom = new ScaledUnit(@"Fathom", @"ftm", Foot, 6.08, 0);
          Cable = new ScaledUnit(@"Cable", null, Fathom, 100, 0);
          NauticalMile = new ScaledUnit(@"NauticalMile", @"nmi", Cable, 10, 0);
          Link = new ScaledUnit(@"Link", null, Inch, 7.92, 0);
          Rod = new ScaledUnit(@"Rod", null, Link, 25, 0);
          Perch = new ScaledUnit(@"Perch", null, Rod, 1, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Foot.Name, Foot },
            { Inch.Name, Inch },
            { Thou.Name, Thou },
            { Yard.Name, Yard },
            { Chain.Name, Chain },
            { Furlong.Name, Furlong },
            { Mile.Name, Mile },
            { League.Name, League },
            { Fathom.Name, Fathom },
            { Cable.Name, Cable },
            { NauticalMile.Name, NauticalMile },
            { Link.Name, Link },
            { Rod.Name, Rod },
            { Perch.Name, Perch },
          };
        }

        static Length()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
