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
      public static partial class SpecificVolume
      {
        public static BaseUnit CubicMetrePerKilogram { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit ZettaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit ExaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit PetaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit TeraCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit GigaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit MegaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit KiloCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit HectoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit DecaCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit DeciCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit CentiCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit MilliCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit MicroCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit NanoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit PicoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit FemtoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit AttoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit ZeptoCubicMetrePerKilogram { get; private set; }
        public static ScaledUnit YoctoCubicMetrePerKilogram { get; private set; }

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
          CubicMetrePerKilogram = new BaseUnit(@"CubicMetrePerKilogram", @"m³/kg", PhysicalQuantities.Quantities.SpecificVolume, unitSystem);
          YottaCubicMetrePerKilogram = new ScaledUnit(@"YottaCubicMetrePerKilogram", @"Ym³/kg", CubicMetrePerKilogram, 1E+24, 0.0);
          ZettaCubicMetrePerKilogram = new ScaledUnit(@"ZettaCubicMetrePerKilogram", @"Zm³/kg", CubicMetrePerKilogram, 1E+21, 0.0);
          ExaCubicMetrePerKilogram = new ScaledUnit(@"ExaCubicMetrePerKilogram", @"Em³/kg", CubicMetrePerKilogram, 1E+18, 0.0);
          PetaCubicMetrePerKilogram = new ScaledUnit(@"PetaCubicMetrePerKilogram", @"Pm³/kg", CubicMetrePerKilogram, 1E+15, 0.0);
          TeraCubicMetrePerKilogram = new ScaledUnit(@"TeraCubicMetrePerKilogram", @"Tm³/kg", CubicMetrePerKilogram, 1000000000000, 0.0);
          GigaCubicMetrePerKilogram = new ScaledUnit(@"GigaCubicMetrePerKilogram", @"Gm³/kg", CubicMetrePerKilogram, 1000000000, 0.0);
          MegaCubicMetrePerKilogram = new ScaledUnit(@"MegaCubicMetrePerKilogram", @"Mm³/kg", CubicMetrePerKilogram, 1000000, 0.0);
          KiloCubicMetrePerKilogram = new ScaledUnit(@"KiloCubicMetrePerKilogram", @"km³/kg", CubicMetrePerKilogram, 1000, 0.0);
          HectoCubicMetrePerKilogram = new ScaledUnit(@"HectoCubicMetrePerKilogram", @"hm³/kg", CubicMetrePerKilogram, 100, 0.0);
          DecaCubicMetrePerKilogram = new ScaledUnit(@"DecaCubicMetrePerKilogram", @"dam³/kg", CubicMetrePerKilogram, 10, 0.0);
          DeciCubicMetrePerKilogram = new ScaledUnit(@"DeciCubicMetrePerKilogram", @"dm³/kg", CubicMetrePerKilogram, 0.1, 0.0);
          CentiCubicMetrePerKilogram = new ScaledUnit(@"CentiCubicMetrePerKilogram", @"cm³/kg", CubicMetrePerKilogram, 0.01, 0.0);
          MilliCubicMetrePerKilogram = new ScaledUnit(@"MilliCubicMetrePerKilogram", @"mm³/kg", CubicMetrePerKilogram, 0.001, 0.0);
          MicroCubicMetrePerKilogram = new ScaledUnit(@"MicroCubicMetrePerKilogram", @"µm³/kg", CubicMetrePerKilogram, 1E-06, 0.0);
          NanoCubicMetrePerKilogram = new ScaledUnit(@"NanoCubicMetrePerKilogram", @"nm³/kg", CubicMetrePerKilogram, 1E-09, 0.0);
          PicoCubicMetrePerKilogram = new ScaledUnit(@"PicoCubicMetrePerKilogram", @"pm³/kg", CubicMetrePerKilogram, 1E-12, 0.0);
          FemtoCubicMetrePerKilogram = new ScaledUnit(@"FemtoCubicMetrePerKilogram", @"fm³/kg", CubicMetrePerKilogram, 1E-15, 0.0);
          AttoCubicMetrePerKilogram = new ScaledUnit(@"AttoCubicMetrePerKilogram", @"am³/kg", CubicMetrePerKilogram, 1E-18, 0.0);
          ZeptoCubicMetrePerKilogram = new ScaledUnit(@"ZeptoCubicMetrePerKilogram", @"zm³/kg", CubicMetrePerKilogram, 1E-21, 0.0);
          YoctoCubicMetrePerKilogram = new ScaledUnit(@"YoctoCubicMetrePerKilogram", @"ym³/kg", CubicMetrePerKilogram, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { CubicMetrePerKilogram.Name, CubicMetrePerKilogram },
            { YottaCubicMetrePerKilogram.Name, YottaCubicMetrePerKilogram },
            { ZettaCubicMetrePerKilogram.Name, ZettaCubicMetrePerKilogram },
            { ExaCubicMetrePerKilogram.Name, ExaCubicMetrePerKilogram },
            { PetaCubicMetrePerKilogram.Name, PetaCubicMetrePerKilogram },
            { TeraCubicMetrePerKilogram.Name, TeraCubicMetrePerKilogram },
            { GigaCubicMetrePerKilogram.Name, GigaCubicMetrePerKilogram },
            { MegaCubicMetrePerKilogram.Name, MegaCubicMetrePerKilogram },
            { KiloCubicMetrePerKilogram.Name, KiloCubicMetrePerKilogram },
            { HectoCubicMetrePerKilogram.Name, HectoCubicMetrePerKilogram },
            { DecaCubicMetrePerKilogram.Name, DecaCubicMetrePerKilogram },
            { DeciCubicMetrePerKilogram.Name, DeciCubicMetrePerKilogram },
            { CentiCubicMetrePerKilogram.Name, CentiCubicMetrePerKilogram },
            { MilliCubicMetrePerKilogram.Name, MilliCubicMetrePerKilogram },
            { MicroCubicMetrePerKilogram.Name, MicroCubicMetrePerKilogram },
            { NanoCubicMetrePerKilogram.Name, NanoCubicMetrePerKilogram },
            { PicoCubicMetrePerKilogram.Name, PicoCubicMetrePerKilogram },
            { FemtoCubicMetrePerKilogram.Name, FemtoCubicMetrePerKilogram },
            { AttoCubicMetrePerKilogram.Name, AttoCubicMetrePerKilogram },
            { ZeptoCubicMetrePerKilogram.Name, ZeptoCubicMetrePerKilogram },
            { YoctoCubicMetrePerKilogram.Name, YoctoCubicMetrePerKilogram },
          };
        }

        static SpecificVolume()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
