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
      public static partial class VolumetricFlow
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre_per_second
        /// </summary>
        public static BaseUnit CubicMetrePerSecond { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit ZettaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit ExaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit PetaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit TeraCubicMetrePerSecond { get; private set; }
        public static ScaledUnit GigaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit MegaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit KiloCubicMetrePerSecond { get; private set; }
        public static ScaledUnit HectoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit DecaCubicMetrePerSecond { get; private set; }
        public static ScaledUnit DeciCubicMetrePerSecond { get; private set; }
        public static ScaledUnit CentiCubicMetrePerSecond { get; private set; }
        public static ScaledUnit MilliCubicMetrePerSecond { get; private set; }
        public static ScaledUnit MicroCubicMetrePerSecond { get; private set; }
        public static ScaledUnit NanoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit PicoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit FemtoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit AttoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit ZeptoCubicMetrePerSecond { get; private set; }
        public static ScaledUnit YoctoCubicMetrePerSecond { get; private set; }

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
          CubicMetrePerSecond = new BaseUnit(@"CubicMetrePerSecond", @"m³/s", PhysicalQuantities.Quantities.VolumetricFlow, unitSystem) { Caption = @"metro cúbico por segundo" };
          YottaCubicMetrePerSecond = new ScaledUnit(@"YottaCubicMetrePerSecond", @"Ym³/s", CubicMetrePerSecond, 1E+24, 0.0) { Caption = @"yottametro cúbico por segundo" };
          ZettaCubicMetrePerSecond = new ScaledUnit(@"ZettaCubicMetrePerSecond", @"Zm³/s", CubicMetrePerSecond, 1E+21, 0.0) { Caption = @"zettametro cúbico por segundo" };
          ExaCubicMetrePerSecond = new ScaledUnit(@"ExaCubicMetrePerSecond", @"Em³/s", CubicMetrePerSecond, 1E+18, 0.0) { Caption = @"exametro cúbico por segundo" };
          PetaCubicMetrePerSecond = new ScaledUnit(@"PetaCubicMetrePerSecond", @"Pm³/s", CubicMetrePerSecond, 1E+15, 0.0) { Caption = @"petametro cúbico por segundo" };
          TeraCubicMetrePerSecond = new ScaledUnit(@"TeraCubicMetrePerSecond", @"Tm³/s", CubicMetrePerSecond, 1000000000000, 0.0) { Caption = @"terametro cúbico por segundo" };
          GigaCubicMetrePerSecond = new ScaledUnit(@"GigaCubicMetrePerSecond", @"Gm³/s", CubicMetrePerSecond, 1000000000, 0.0) { Caption = @"gigametro cúbico por segundo" };
          MegaCubicMetrePerSecond = new ScaledUnit(@"MegaCubicMetrePerSecond", @"Mm³/s", CubicMetrePerSecond, 1000000, 0.0) { Caption = @"megametro cúbico por segundo" };
          KiloCubicMetrePerSecond = new ScaledUnit(@"KiloCubicMetrePerSecond", @"km³/s", CubicMetrePerSecond, 1000, 0.0) { Caption = @"kilometro cúbico por segundo" };
          HectoCubicMetrePerSecond = new ScaledUnit(@"HectoCubicMetrePerSecond", @"hm³/s", CubicMetrePerSecond, 100, 0.0) { Caption = @"hectometro cúbico por segundo" };
          DecaCubicMetrePerSecond = new ScaledUnit(@"DecaCubicMetrePerSecond", @"dam³/s", CubicMetrePerSecond, 10, 0.0) { Caption = @"decametro cúbico por segundo" };
          DeciCubicMetrePerSecond = new ScaledUnit(@"DeciCubicMetrePerSecond", @"dm³/s", CubicMetrePerSecond, 0.1, 0.0) { Caption = @"decimetro cúbico por segundo" };
          CentiCubicMetrePerSecond = new ScaledUnit(@"CentiCubicMetrePerSecond", @"cm³/s", CubicMetrePerSecond, 0.01, 0.0) { Caption = @"centimetro cúbico por segundo" };
          MilliCubicMetrePerSecond = new ScaledUnit(@"MilliCubicMetrePerSecond", @"mm³/s", CubicMetrePerSecond, 0.001, 0.0) { Caption = @"milimetro cúbico por segundo" };
          MicroCubicMetrePerSecond = new ScaledUnit(@"MicroCubicMetrePerSecond", @"μm³/s", CubicMetrePerSecond, 1E-06, 0.0) { Caption = @"micrometro cúbico por segundo" };
          NanoCubicMetrePerSecond = new ScaledUnit(@"NanoCubicMetrePerSecond", @"nm³/s", CubicMetrePerSecond, 1E-09, 0.0) { Caption = @"nanometro cúbico por segundo" };
          PicoCubicMetrePerSecond = new ScaledUnit(@"PicoCubicMetrePerSecond", @"pm³/s", CubicMetrePerSecond, 1E-12, 0.0) { Caption = @"picometro cúbico por segundo" };
          FemtoCubicMetrePerSecond = new ScaledUnit(@"FemtoCubicMetrePerSecond", @"fm³/s", CubicMetrePerSecond, 1E-15, 0.0) { Caption = @"femtometro cúbico por segundo" };
          AttoCubicMetrePerSecond = new ScaledUnit(@"AttoCubicMetrePerSecond", @"am³/s", CubicMetrePerSecond, 1E-18, 0.0) { Caption = @"attometro cúbico por segundo" };
          ZeptoCubicMetrePerSecond = new ScaledUnit(@"ZeptoCubicMetrePerSecond", @"zm³/s", CubicMetrePerSecond, 1E-21, 0.0) { Caption = @"zeptometro cúbico por segundo" };
          YoctoCubicMetrePerSecond = new ScaledUnit(@"YoctoCubicMetrePerSecond", @"ym³/s", CubicMetrePerSecond, 1E-24, 0.0) { Caption = @"yoctometro cúbico por segundo" };

          allUnits = new Dictionary<string, Unit>
          {
            { CubicMetrePerSecond.Name, CubicMetrePerSecond },
            { YottaCubicMetrePerSecond.Name, YottaCubicMetrePerSecond },
            { ZettaCubicMetrePerSecond.Name, ZettaCubicMetrePerSecond },
            { ExaCubicMetrePerSecond.Name, ExaCubicMetrePerSecond },
            { PetaCubicMetrePerSecond.Name, PetaCubicMetrePerSecond },
            { TeraCubicMetrePerSecond.Name, TeraCubicMetrePerSecond },
            { GigaCubicMetrePerSecond.Name, GigaCubicMetrePerSecond },
            { MegaCubicMetrePerSecond.Name, MegaCubicMetrePerSecond },
            { KiloCubicMetrePerSecond.Name, KiloCubicMetrePerSecond },
            { HectoCubicMetrePerSecond.Name, HectoCubicMetrePerSecond },
            { DecaCubicMetrePerSecond.Name, DecaCubicMetrePerSecond },
            { DeciCubicMetrePerSecond.Name, DeciCubicMetrePerSecond },
            { CentiCubicMetrePerSecond.Name, CentiCubicMetrePerSecond },
            { MilliCubicMetrePerSecond.Name, MilliCubicMetrePerSecond },
            { MicroCubicMetrePerSecond.Name, MicroCubicMetrePerSecond },
            { NanoCubicMetrePerSecond.Name, NanoCubicMetrePerSecond },
            { PicoCubicMetrePerSecond.Name, PicoCubicMetrePerSecond },
            { FemtoCubicMetrePerSecond.Name, FemtoCubicMetrePerSecond },
            { AttoCubicMetrePerSecond.Name, AttoCubicMetrePerSecond },
            { ZeptoCubicMetrePerSecond.Name, ZeptoCubicMetrePerSecond },
            { YoctoCubicMetrePerSecond.Name, YoctoCubicMetrePerSecond },
          };
        }

        static VolumetricFlow()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
