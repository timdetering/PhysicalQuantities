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
      public static partial class LuminousIntensity
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Candela
        /// </summary>
        public static BaseUnit Candela { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaCandela { get; private set; }
        public static ScaledUnit ZettaCandela { get; private set; }
        public static ScaledUnit ExaCandela { get; private set; }
        public static ScaledUnit PetaCandela { get; private set; }
        public static ScaledUnit TeraCandela { get; private set; }
        public static ScaledUnit GigaCandela { get; private set; }
        public static ScaledUnit MegaCandela { get; private set; }
        public static ScaledUnit KiloCandela { get; private set; }
        public static ScaledUnit HectoCandela { get; private set; }
        public static ScaledUnit DecaCandela { get; private set; }
        public static ScaledUnit DeciCandela { get; private set; }
        public static ScaledUnit CentiCandela { get; private set; }
        public static ScaledUnit MilliCandela { get; private set; }
        public static ScaledUnit MicroCandela { get; private set; }
        public static ScaledUnit NanoCandela { get; private set; }
        public static ScaledUnit PicoCandela { get; private set; }
        public static ScaledUnit FemtoCandela { get; private set; }
        public static ScaledUnit AttoCandela { get; private set; }
        public static ScaledUnit ZeptoCandela { get; private set; }
        public static ScaledUnit YoctoCandela { get; private set; }

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
          Candela = new BaseUnit(@"Candela", @"cd", PhysicalQuantities.Quantities.LuminousIntensity, unitSystem) { Caption = @"candela" };
          YottaCandela = new ScaledUnit(@"YottaCandela", @"Ycd", Candela, 1E+24, 0.0) { Caption = @"yottacandela" };
          ZettaCandela = new ScaledUnit(@"ZettaCandela", @"Zcd", Candela, 1E+21, 0.0) { Caption = @"zettacandela" };
          ExaCandela = new ScaledUnit(@"ExaCandela", @"Ecd", Candela, 1E+18, 0.0) { Caption = @"exacandela" };
          PetaCandela = new ScaledUnit(@"PetaCandela", @"Pcd", Candela, 1E+15, 0.0) { Caption = @"petacandela" };
          TeraCandela = new ScaledUnit(@"TeraCandela", @"Tcd", Candela, 1000000000000, 0.0) { Caption = @"teracandela" };
          GigaCandela = new ScaledUnit(@"GigaCandela", @"Gcd", Candela, 1000000000, 0.0) { Caption = @"gigacandela" };
          MegaCandela = new ScaledUnit(@"MegaCandela", @"Mcd", Candela, 1000000, 0.0) { Caption = @"megacandela" };
          KiloCandela = new ScaledUnit(@"KiloCandela", @"kcd", Candela, 1000, 0.0) { Caption = @"kilocandela" };
          HectoCandela = new ScaledUnit(@"HectoCandela", @"hcd", Candela, 100, 0.0) { Caption = @"hectocandela" };
          DecaCandela = new ScaledUnit(@"DecaCandela", @"dacd", Candela, 10, 0.0) { Caption = @"decacandela" };
          DeciCandela = new ScaledUnit(@"DeciCandela", @"dcd", Candela, 0.1, 0.0) { Caption = @"decicandela" };
          CentiCandela = new ScaledUnit(@"CentiCandela", @"ccd", Candela, 0.01, 0.0) { Caption = @"centicandela" };
          MilliCandela = new ScaledUnit(@"MilliCandela", @"mcd", Candela, 0.001, 0.0) { Caption = @"milicandela" };
          MicroCandela = new ScaledUnit(@"MicroCandela", @"μcd", Candela, 1E-06, 0.0) { Caption = @"microcandela" };
          NanoCandela = new ScaledUnit(@"NanoCandela", @"ncd", Candela, 1E-09, 0.0) { Caption = @"nanocandela" };
          PicoCandela = new ScaledUnit(@"PicoCandela", @"pcd", Candela, 1E-12, 0.0) { Caption = @"picocandela" };
          FemtoCandela = new ScaledUnit(@"FemtoCandela", @"fcd", Candela, 1E-15, 0.0) { Caption = @"femtocandela" };
          AttoCandela = new ScaledUnit(@"AttoCandela", @"acd", Candela, 1E-18, 0.0) { Caption = @"attocandela" };
          ZeptoCandela = new ScaledUnit(@"ZeptoCandela", @"zcd", Candela, 1E-21, 0.0) { Caption = @"zeptocandela" };
          YoctoCandela = new ScaledUnit(@"YoctoCandela", @"ycd", Candela, 1E-24, 0.0) { Caption = @"yoctocandela" };

          allUnits = new Dictionary<string, Unit>
          {
            { Candela.Name, Candela },
            { YottaCandela.Name, YottaCandela },
            { ZettaCandela.Name, ZettaCandela },
            { ExaCandela.Name, ExaCandela },
            { PetaCandela.Name, PetaCandela },
            { TeraCandela.Name, TeraCandela },
            { GigaCandela.Name, GigaCandela },
            { MegaCandela.Name, MegaCandela },
            { KiloCandela.Name, KiloCandela },
            { HectoCandela.Name, HectoCandela },
            { DecaCandela.Name, DecaCandela },
            { DeciCandela.Name, DeciCandela },
            { CentiCandela.Name, CentiCandela },
            { MilliCandela.Name, MilliCandela },
            { MicroCandela.Name, MicroCandela },
            { NanoCandela.Name, NanoCandela },
            { PicoCandela.Name, PicoCandela },
            { FemtoCandela.Name, FemtoCandela },
            { AttoCandela.Name, AttoCandela },
            { ZeptoCandela.Name, ZeptoCandela },
            { YoctoCandela.Name, YoctoCandela },
          };
        }

        static LuminousIntensity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
