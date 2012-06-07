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
      public static partial class Pressure
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pascal_(unit)
        /// </summary>
        public static BaseUnit Pascal { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaPascal { get; private set; }
        public static ScaledUnit ZettaPascal { get; private set; }
        public static ScaledUnit ExaPascal { get; private set; }
        public static ScaledUnit PetaPascal { get; private set; }
        public static ScaledUnit TeraPascal { get; private set; }
        public static ScaledUnit GigaPascal { get; private set; }
        public static ScaledUnit MegaPascal { get; private set; }
        public static ScaledUnit KiloPascal { get; private set; }
        public static ScaledUnit HectoPascal { get; private set; }
        public static ScaledUnit DecaPascal { get; private set; }
        public static ScaledUnit DeciPascal { get; private set; }
        public static ScaledUnit CentiPascal { get; private set; }
        public static ScaledUnit MilliPascal { get; private set; }
        public static ScaledUnit MicroPascal { get; private set; }
        public static ScaledUnit NanoPascal { get; private set; }
        public static ScaledUnit PicoPascal { get; private set; }
        public static ScaledUnit FemtoPascal { get; private set; }
        public static ScaledUnit AttoPascal { get; private set; }
        public static ScaledUnit ZeptoPascal { get; private set; }
        public static ScaledUnit YoctoPascal { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bar_(unit)
        /// </summary>
        public static ScaledUnit Bar { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bar_(unit)
        /// </summary>
        public static ScaledUnit MilliBar { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Barye
        /// </summary>
        public static ScaledUnit Barye { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Atmosphere_(unit)
        /// </summary>
        public static ScaledUnit Atmosphere { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Millimetre_of_mercury#Manometric_units_of_pressure
        /// </summary>
        public static ScaledUnit MillimetreOfMercury { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Torr
        /// </summary>
        public static ScaledUnit Torr { get; private set; }

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
          Pascal = new BaseUnit(@"Pascal", @"Pa", PhysicalQuantities.Quantities.Pressure, unitSystem);
          YottaPascal = new ScaledUnit(@"YottaPascal", @"YPa", Pascal, 1E+24, 0.0);
          ZettaPascal = new ScaledUnit(@"ZettaPascal", @"ZPa", Pascal, 1E+21, 0.0);
          ExaPascal = new ScaledUnit(@"ExaPascal", @"EPa", Pascal, 1E+18, 0.0);
          PetaPascal = new ScaledUnit(@"PetaPascal", @"PPa", Pascal, 1E+15, 0.0);
          TeraPascal = new ScaledUnit(@"TeraPascal", @"TPa", Pascal, 1000000000000, 0.0);
          GigaPascal = new ScaledUnit(@"GigaPascal", @"GPa", Pascal, 1000000000, 0.0);
          MegaPascal = new ScaledUnit(@"MegaPascal", @"MPa", Pascal, 1000000, 0.0);
          KiloPascal = new ScaledUnit(@"KiloPascal", @"kPa", Pascal, 1000, 0.0);
          HectoPascal = new ScaledUnit(@"HectoPascal", @"hPa", Pascal, 100, 0.0);
          DecaPascal = new ScaledUnit(@"DecaPascal", @"daPa", Pascal, 10, 0.0);
          DeciPascal = new ScaledUnit(@"DeciPascal", @"dPa", Pascal, 0.1, 0.0);
          CentiPascal = new ScaledUnit(@"CentiPascal", @"cPa", Pascal, 0.01, 0.0);
          MilliPascal = new ScaledUnit(@"MilliPascal", @"mPa", Pascal, 0.001, 0.0);
          MicroPascal = new ScaledUnit(@"MicroPascal", @"µPa", Pascal, 1E-06, 0.0);
          NanoPascal = new ScaledUnit(@"NanoPascal", @"nPa", Pascal, 1E-09, 0.0);
          PicoPascal = new ScaledUnit(@"PicoPascal", @"pPa", Pascal, 1E-12, 0.0);
          FemtoPascal = new ScaledUnit(@"FemtoPascal", @"fPa", Pascal, 1E-15, 0.0);
          AttoPascal = new ScaledUnit(@"AttoPascal", @"aPa", Pascal, 1E-18, 0.0);
          ZeptoPascal = new ScaledUnit(@"ZeptoPascal", @"zPa", Pascal, 1E-21, 0.0);
          YoctoPascal = new ScaledUnit(@"YoctoPascal", @"yPa", Pascal, 1E-24, 0.0);
          Bar = new ScaledUnit(@"Bar", @"bar", Pascal, 100000, 0);
          MilliBar = new ScaledUnit(@"MilliBar", @"mbar", Bar, 0.001, 0);
          Barye = new ScaledUnit(@"Barye", @"Ba", Pascal, 0.1, 0);
          Atmosphere = new ScaledUnit(@"Atmosphere", @"atm", Pascal, 101325, 0);
          MillimetreOfMercury = new ScaledUnit(@"MillimetreOfMercury", @"mmHg", Pascal, 133.322387415, 0);
          Torr = new ScaledUnit(@"Torr", @"Torr", Pascal, 133.322368421, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Pascal.Name, Pascal },
            { YottaPascal.Name, YottaPascal },
            { ZettaPascal.Name, ZettaPascal },
            { ExaPascal.Name, ExaPascal },
            { PetaPascal.Name, PetaPascal },
            { TeraPascal.Name, TeraPascal },
            { GigaPascal.Name, GigaPascal },
            { MegaPascal.Name, MegaPascal },
            { KiloPascal.Name, KiloPascal },
            { HectoPascal.Name, HectoPascal },
            { DecaPascal.Name, DecaPascal },
            { DeciPascal.Name, DeciPascal },
            { CentiPascal.Name, CentiPascal },
            { MilliPascal.Name, MilliPascal },
            { MicroPascal.Name, MicroPascal },
            { NanoPascal.Name, NanoPascal },
            { PicoPascal.Name, PicoPascal },
            { FemtoPascal.Name, FemtoPascal },
            { AttoPascal.Name, AttoPascal },
            { ZeptoPascal.Name, ZeptoPascal },
            { YoctoPascal.Name, YoctoPascal },
            { Bar.Name, Bar },
            { MilliBar.Name, MilliBar },
            { Barye.Name, Barye },
            { Atmosphere.Name, Atmosphere },
            { MillimetreOfMercury.Name, MillimetreOfMercury },
            { Torr.Name, Torr },
          };
        }

        static Pressure()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
