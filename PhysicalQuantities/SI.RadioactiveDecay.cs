using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class SI
    {
      public static partial class RadioactiveDecay
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Becquerel
        /// </summary>
        public static BaseUnit Becquerel { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaBecquerel { get; private set; }
        public static ScaledUnit ZettaBecquerel { get; private set; }
        public static ScaledUnit ExaBecquerel { get; private set; }
        public static ScaledUnit PetaBecquerel { get; private set; }
        public static ScaledUnit TeraBecquerel { get; private set; }
        public static ScaledUnit GigaBecquerel { get; private set; }
        public static ScaledUnit MegaBecquerel { get; private set; }
        public static ScaledUnit KiloBecquerel { get; private set; }
        public static ScaledUnit HectoBecquerel { get; private set; }
        public static ScaledUnit DecaBecquerel { get; private set; }
        public static ScaledUnit DeciBecquerel { get; private set; }
        public static ScaledUnit CentiBecquerel { get; private set; }
        public static ScaledUnit MilliBecquerel { get; private set; }
        public static ScaledUnit MicroBecquerel { get; private set; }
        public static ScaledUnit NanoBecquerel { get; private set; }
        public static ScaledUnit PicoBecquerel { get; private set; }
        public static ScaledUnit FemtoBecquerel { get; private set; }
        public static ScaledUnit AttoBecquerel { get; private set; }
        public static ScaledUnit ZeptoBecquerel { get; private set; }
        public static ScaledUnit YoctoBecquerel { get; private set; }

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
          Becquerel = new BaseUnit(@"Becquerel", @"Bq", PhysicalQuantities.Quantities.RadioactiveDecay, unitSystem);
          YottaBecquerel = new ScaledUnit(@"YottaBecquerel", @"YBq", Becquerel, 1E+24, 0.0);
          ZettaBecquerel = new ScaledUnit(@"ZettaBecquerel", @"ZBq", Becquerel, 1E+21, 0.0);
          ExaBecquerel = new ScaledUnit(@"ExaBecquerel", @"EBq", Becquerel, 1E+18, 0.0);
          PetaBecquerel = new ScaledUnit(@"PetaBecquerel", @"PBq", Becquerel, 1E+15, 0.0);
          TeraBecquerel = new ScaledUnit(@"TeraBecquerel", @"TBq", Becquerel, 1000000000000, 0.0);
          GigaBecquerel = new ScaledUnit(@"GigaBecquerel", @"GBq", Becquerel, 1000000000, 0.0);
          MegaBecquerel = new ScaledUnit(@"MegaBecquerel", @"MBq", Becquerel, 1000000, 0.0);
          KiloBecquerel = new ScaledUnit(@"KiloBecquerel", @"kBq", Becquerel, 1000, 0.0);
          HectoBecquerel = new ScaledUnit(@"HectoBecquerel", @"hBq", Becquerel, 100, 0.0);
          DecaBecquerel = new ScaledUnit(@"DecaBecquerel", @"daBq", Becquerel, 10, 0.0);
          DeciBecquerel = new ScaledUnit(@"DeciBecquerel", @"dBq", Becquerel, 0.1, 0.0);
          CentiBecquerel = new ScaledUnit(@"CentiBecquerel", @"cBq", Becquerel, 0.01, 0.0);
          MilliBecquerel = new ScaledUnit(@"MilliBecquerel", @"mBq", Becquerel, 0.001, 0.0);
          MicroBecquerel = new ScaledUnit(@"MicroBecquerel", @"µBq", Becquerel, 1E-06, 0.0);
          NanoBecquerel = new ScaledUnit(@"NanoBecquerel", @"nBq", Becquerel, 1E-09, 0.0);
          PicoBecquerel = new ScaledUnit(@"PicoBecquerel", @"pBq", Becquerel, 1E-12, 0.0);
          FemtoBecquerel = new ScaledUnit(@"FemtoBecquerel", @"fBq", Becquerel, 1E-15, 0.0);
          AttoBecquerel = new ScaledUnit(@"AttoBecquerel", @"aBq", Becquerel, 1E-18, 0.0);
          ZeptoBecquerel = new ScaledUnit(@"ZeptoBecquerel", @"zBq", Becquerel, 1E-21, 0.0);
          YoctoBecquerel = new ScaledUnit(@"YoctoBecquerel", @"yBq", Becquerel, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Becquerel.Name, Becquerel },
            { YottaBecquerel.Name, YottaBecquerel },
            { ZettaBecquerel.Name, ZettaBecquerel },
            { ExaBecquerel.Name, ExaBecquerel },
            { PetaBecquerel.Name, PetaBecquerel },
            { TeraBecquerel.Name, TeraBecquerel },
            { GigaBecquerel.Name, GigaBecquerel },
            { MegaBecquerel.Name, MegaBecquerel },
            { KiloBecquerel.Name, KiloBecquerel },
            { HectoBecquerel.Name, HectoBecquerel },
            { DecaBecquerel.Name, DecaBecquerel },
            { DeciBecquerel.Name, DeciBecquerel },
            { CentiBecquerel.Name, CentiBecquerel },
            { MilliBecquerel.Name, MilliBecquerel },
            { MicroBecquerel.Name, MicroBecquerel },
            { NanoBecquerel.Name, NanoBecquerel },
            { PicoBecquerel.Name, PicoBecquerel },
            { FemtoBecquerel.Name, FemtoBecquerel },
            { AttoBecquerel.Name, AttoBecquerel },
            { ZeptoBecquerel.Name, ZeptoBecquerel },
            { YoctoBecquerel.Name, YoctoBecquerel },
          };
        }

        static RadioactiveDecay()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
