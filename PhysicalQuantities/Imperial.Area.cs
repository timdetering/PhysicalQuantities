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
      public static partial class Area
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_foot
        /// </summary>
        public static BaseUnit SquareFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_inch
        /// </summary>
        public static ScaledUnit SquareInch { get; private set; }
        public static ScaledUnit SquareThou { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_yard
        /// </summary>
        public static ScaledUnit SquareYard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Chain_(unit)
        /// </summary>
        public static ScaledUnit SquareChain { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Furlong
        /// </summary>
        public static ScaledUnit SquareFurlong { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_mile
        /// </summary>
        public static ScaledUnit SquareMile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/League_(unit)
        /// </summary>
        public static ScaledUnit SquareLeague { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fathom
        /// </summary>
        public static ScaledUnit SquareFathom { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cable_length
        /// </summary>
        public static ScaledUnit SquareCable { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Nautical_mile
        /// </summary>
        public static ScaledUnit SquareNauticalMile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Link_(unit)
        /// </summary>
        public static ScaledUnit SquareLink { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Rod_(unit)
        /// </summary>
        public static ScaledUnit SquareRod { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Perch_(unit_of_measure)#Area
        /// </summary>
        public static ScaledUnit Perch { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Rood_(unit)
        /// </summary>
        public static ScaledUnit Rood { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Acre
        /// </summary>
        public static ScaledUnit Acre { get; private set; }
        /// <summary>
        /// Reference: http://www.simetric.co.uk/si_imperial.htm
        /// </summary>
        public static ScaledUnit Pole { get; private set; }

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
          SquareFoot = new BaseUnit(@"SquareFoot", @"ft²", PhysicalQuantities.Quantities.Area, unitSystem);
          SquareInch = new ScaledUnit(@"SquareInch", @"in²", SquareFoot, 0.00694444444444444, 0);
          SquareThou = new ScaledUnit(@"SquareThou", @"th²", SquareInch, 1E-06, 0);
          SquareYard = new ScaledUnit(@"SquareYard", @"yd²", SquareFoot, 9, 0);
          SquareChain = new ScaledUnit(@"SquareChain", @"ch²", SquareYard, 484, 0);
          SquareFurlong = new ScaledUnit(@"SquareFurlong", @"fur²", SquareChain, 100, 0);
          SquareMile = new ScaledUnit(@"SquareMile", @"mi²", SquareFurlong, 64, 0);
          SquareLeague = new ScaledUnit(@"SquareLeague", @"lea²", SquareMile, 9, 0);
          SquareFathom = new ScaledUnit(@"SquareFathom", @"ftm²", SquareFoot, 36.9664, 0);
          SquareCable = new ScaledUnit(@"SquareCable", null, SquareFathom, 10000, 0);
          SquareNauticalMile = new ScaledUnit(@"SquareNauticalMile", @"nmi²", SquareCable, 100, 0);
          SquareLink = new ScaledUnit(@"SquareLink", null, SquareInch, 62.7264, 0);
          SquareRod = new ScaledUnit(@"SquareRod", null, SquareLink, 625, 0);
          Perch = new ScaledUnit(@"Perch", null, SquareRod, 1, 0);
          Rood = new ScaledUnit(@"Rood", null, Perch, 40, 0);
          Acre = new ScaledUnit(@"Acre", null, Rood, 4, 0);
          Pole = new ScaledUnit(@"Pole", null, SquareYard, 30.25, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { SquareFoot.Name, SquareFoot },
            { SquareInch.Name, SquareInch },
            { SquareThou.Name, SquareThou },
            { SquareYard.Name, SquareYard },
            { SquareChain.Name, SquareChain },
            { SquareFurlong.Name, SquareFurlong },
            { SquareMile.Name, SquareMile },
            { SquareLeague.Name, SquareLeague },
            { SquareFathom.Name, SquareFathom },
            { SquareCable.Name, SquareCable },
            { SquareNauticalMile.Name, SquareNauticalMile },
            { SquareLink.Name, SquareLink },
            { SquareRod.Name, SquareRod },
            { Perch.Name, Perch },
            { Rood.Name, Rood },
            { Acre.Name, Acre },
            { Pole.Name, Pole },
          };
        }

        static Area()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
