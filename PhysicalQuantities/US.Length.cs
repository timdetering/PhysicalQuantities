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
        /// Reference: http://en.wikipedia.org/wiki/Pica_(typography)
        /// </summary>
        public static ScaledUnit Pica { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Point_(typography)
        /// </summary>
        public static ScaledUnit Point { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Yard
        /// </summary>
        public static ScaledUnit Yard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Mile
        /// </summary>
        public static ScaledUnit Mile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Link_(unit)
        /// </summary>
        public static ScaledUnit Link { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot_(unit)
        /// </summary>
        public static ScaledUnit FootSurvey { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Rod_(unit)
        /// </summary>
        public static ScaledUnit Rod { get; private set; }
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
        public static ScaledUnit MileSurvey { get; private set; }
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
          Pica = new ScaledUnit(@"Pica", @"P?", Inch, 0.166666666666667, 0);
          Point = new ScaledUnit(@"Point", @"p", Pica, 0.0833333333333333, 0);
          Yard = new ScaledUnit(@"Yard", @"yd", Foot, 3, 0);
          Mile = new ScaledUnit(@"Mile", @"mi", Foot, 5280, 0);
          Link = new ScaledUnit(@"Link", @"li", Foot, 0.66, 0);
          FootSurvey = new ScaledUnit(@"FootSurvey", @"ft (survey)", Foot, 1.00000200131234, 0);
          Rod = new ScaledUnit(@"Rod", @"rd", Link, 25, 0);
          Chain = new ScaledUnit(@"Chain", @"ch", Rod, 4, 0);
          Furlong = new ScaledUnit(@"Furlong", @"fur", Chain, 10, 0);
          MileSurvey = new ScaledUnit(@"MileSurvey", @"mi (survey)", Furlong, 8, 0);
          League = new ScaledUnit(@"League", @"lea", MileSurvey, 3, 0);
          Fathom = new ScaledUnit(@"Fathom", @"ftm", Yard, 2, 0);
          Cable = new ScaledUnit(@"Cable", @"cb", Fathom, 120, 0);
          NauticalMile = new ScaledUnit(@"NauticalMile", @"nmi", Cable, 8.44, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Foot.Name, Foot },
            { Inch.Name, Inch },
            { Pica.Name, Pica },
            { Point.Name, Point },
            { Yard.Name, Yard },
            { Mile.Name, Mile },
            { Link.Name, Link },
            { FootSurvey.Name, FootSurvey },
            { Rod.Name, Rod },
            { Chain.Name, Chain },
            { Furlong.Name, Furlong },
            { MileSurvey.Name, MileSurvey },
            { League.Name, League },
            { Fathom.Name, Fathom },
            { Cable.Name, Cable },
            { NauticalMile.Name, NauticalMile },
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
