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
      public static partial class Volume
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static BaseUnit CubicMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaCubicMetre { get; private set; }
        public static ScaledUnit ZettaCubicMetre { get; private set; }
        public static ScaledUnit ExaCubicMetre { get; private set; }
        public static ScaledUnit PetaCubicMetre { get; private set; }
        public static ScaledUnit TeraCubicMetre { get; private set; }
        public static ScaledUnit GigaCubicMetre { get; private set; }
        public static ScaledUnit MegaCubicMetre { get; private set; }
        public static ScaledUnit KiloCubicMetre { get; private set; }
        public static ScaledUnit HectoCubicMetre { get; private set; }
        public static ScaledUnit DecaCubicMetre { get; private set; }
        public static ScaledUnit DeciCubicMetre { get; private set; }
        public static ScaledUnit CentiCubicMetre { get; private set; }
        public static ScaledUnit MilliCubicMetre { get; private set; }
        public static ScaledUnit MicroCubicMetre { get; private set; }
        public static ScaledUnit NanoCubicMetre { get; private set; }
        public static ScaledUnit PicoCubicMetre { get; private set; }
        public static ScaledUnit FemtoCubicMetre { get; private set; }
        public static ScaledUnit AttoCubicMetre { get; private set; }
        public static ScaledUnit ZeptoCubicMetre { get; private set; }
        public static ScaledUnit YoctoCubicMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit Litre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit MilliLitre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit CentiLitre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit DeciLitre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit DecaLitre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit HectoLitre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Litre
        /// </summary>
        public static ScaledUnit KiloLitre { get; private set; }

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
          CubicMetre = new BaseUnit(@"CubicMetre", @"m³", PhysicalQuantities.Quantities.Volume, unitSystem);
          YottaCubicMetre = new ScaledUnit(@"YottaCubicMetre", @"Ym³", CubicMetre, 1E+24, 0.0);
          ZettaCubicMetre = new ScaledUnit(@"ZettaCubicMetre", @"Zm³", CubicMetre, 1E+21, 0.0);
          ExaCubicMetre = new ScaledUnit(@"ExaCubicMetre", @"Em³", CubicMetre, 1E+18, 0.0);
          PetaCubicMetre = new ScaledUnit(@"PetaCubicMetre", @"Pm³", CubicMetre, 1E+15, 0.0);
          TeraCubicMetre = new ScaledUnit(@"TeraCubicMetre", @"Tm³", CubicMetre, 1000000000000, 0.0);
          GigaCubicMetre = new ScaledUnit(@"GigaCubicMetre", @"Gm³", CubicMetre, 1000000000, 0.0);
          MegaCubicMetre = new ScaledUnit(@"MegaCubicMetre", @"Mm³", CubicMetre, 1000000, 0.0);
          KiloCubicMetre = new ScaledUnit(@"KiloCubicMetre", @"km³", CubicMetre, 1000, 0.0);
          HectoCubicMetre = new ScaledUnit(@"HectoCubicMetre", @"hm³", CubicMetre, 100, 0.0);
          DecaCubicMetre = new ScaledUnit(@"DecaCubicMetre", @"dam³", CubicMetre, 10, 0.0);
          DeciCubicMetre = new ScaledUnit(@"DeciCubicMetre", @"dm³", CubicMetre, 0.1, 0.0);
          CentiCubicMetre = new ScaledUnit(@"CentiCubicMetre", @"cm³", CubicMetre, 0.01, 0.0);
          MilliCubicMetre = new ScaledUnit(@"MilliCubicMetre", @"mm³", CubicMetre, 0.001, 0.0);
          MicroCubicMetre = new ScaledUnit(@"MicroCubicMetre", @"µm³", CubicMetre, 1E-06, 0.0);
          NanoCubicMetre = new ScaledUnit(@"NanoCubicMetre", @"nm³", CubicMetre, 1E-09, 0.0);
          PicoCubicMetre = new ScaledUnit(@"PicoCubicMetre", @"pm³", CubicMetre, 1E-12, 0.0);
          FemtoCubicMetre = new ScaledUnit(@"FemtoCubicMetre", @"fm³", CubicMetre, 1E-15, 0.0);
          AttoCubicMetre = new ScaledUnit(@"AttoCubicMetre", @"am³", CubicMetre, 1E-18, 0.0);
          ZeptoCubicMetre = new ScaledUnit(@"ZeptoCubicMetre", @"zm³", CubicMetre, 1E-21, 0.0);
          YoctoCubicMetre = new ScaledUnit(@"YoctoCubicMetre", @"ym³", CubicMetre, 1E-24, 0.0);
          Litre = new ScaledUnit(@"Litre", @"L", CubicMetre, 0.001, 0);
          MilliLitre = new ScaledUnit(@"MilliLitre", @"mL", Litre, 0.001, 0);
          CentiLitre = new ScaledUnit(@"CentiLitre", @"cL", Litre, 0.01, 0);
          DeciLitre = new ScaledUnit(@"DeciLitre", @"dL", Litre, 0.1, 0);
          DecaLitre = new ScaledUnit(@"DecaLitre", @"daL", Litre, 10, 0);
          HectoLitre = new ScaledUnit(@"HectoLitre", @"hL", Litre, 100, 0);
          KiloLitre = new ScaledUnit(@"KiloLitre", @"kL", Litre, 1000, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { CubicMetre.Name, CubicMetre },
            { YottaCubicMetre.Name, YottaCubicMetre },
            { ZettaCubicMetre.Name, ZettaCubicMetre },
            { ExaCubicMetre.Name, ExaCubicMetre },
            { PetaCubicMetre.Name, PetaCubicMetre },
            { TeraCubicMetre.Name, TeraCubicMetre },
            { GigaCubicMetre.Name, GigaCubicMetre },
            { MegaCubicMetre.Name, MegaCubicMetre },
            { KiloCubicMetre.Name, KiloCubicMetre },
            { HectoCubicMetre.Name, HectoCubicMetre },
            { DecaCubicMetre.Name, DecaCubicMetre },
            { DeciCubicMetre.Name, DeciCubicMetre },
            { CentiCubicMetre.Name, CentiCubicMetre },
            { MilliCubicMetre.Name, MilliCubicMetre },
            { MicroCubicMetre.Name, MicroCubicMetre },
            { NanoCubicMetre.Name, NanoCubicMetre },
            { PicoCubicMetre.Name, PicoCubicMetre },
            { FemtoCubicMetre.Name, FemtoCubicMetre },
            { AttoCubicMetre.Name, AttoCubicMetre },
            { ZeptoCubicMetre.Name, ZeptoCubicMetre },
            { YoctoCubicMetre.Name, YoctoCubicMetre },
            { Litre.Name, Litre },
            { MilliLitre.Name, MilliLitre },
            { CentiLitre.Name, CentiLitre },
            { DeciLitre.Name, DeciLitre },
            { DecaLitre.Name, DecaLitre },
            { HectoLitre.Name, HectoLitre },
            { KiloLitre.Name, KiloLitre },
          };
        }

        static Volume()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
