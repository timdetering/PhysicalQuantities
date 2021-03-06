using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class RSI
    {
      public static partial class Volume
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static BaseUnit CubicMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicKiloMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicHectoMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicDecaMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicDeciMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicCentiMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_metre
        /// </summary>
        public static ScaledUnit CubicMilliMetre { get; private set; }
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
          CubicMetre = new BaseUnit(@"CubicMetre", @"m³", PhysicalQuantities.Quantities.Volume, unitSystem) { Caption = @"metro cúbico" };
          CubicKiloMetre = new ScaledUnit(@"CubicKiloMetre", @"km³", CubicMetre, 1000000000, 0) { Caption = @"kilómetro cúbico" };
          CubicHectoMetre = new ScaledUnit(@"CubicHectoMetre", @"hm³", CubicMetre, 1000000, 0) { Caption = @"hectómetro cúbico" };
          CubicDecaMetre = new ScaledUnit(@"CubicDecaMetre", @"dam³", CubicMetre, 1000, 0) { Caption = @"decámetro cúbico" };
          CubicDeciMetre = new ScaledUnit(@"CubicDeciMetre", @"dm³", CubicMetre, 0.001, 0) { Caption = @"decímetro cúbico" };
          CubicCentiMetre = new ScaledUnit(@"CubicCentiMetre", @"cm³", CubicMetre, 1E-06, 0) { Caption = @"centímetro cúbico" };
          CubicMilliMetre = new ScaledUnit(@"CubicMilliMetre", @"mm³", CubicMetre, 1E-09, 0) { Caption = @"milímetro cúbico" };
          Litre = new ScaledUnit(@"Litre", @"L", CubicMetre, 0.001, 0) { Caption = @"litro" };
          MilliLitre = new ScaledUnit(@"MilliLitre", @"mL", Litre, 0.001, 0) { Caption = @"mililitro" };
          CentiLitre = new ScaledUnit(@"CentiLitre", @"cL", Litre, 0.01, 0) { Caption = @"centilitro" };
          DeciLitre = new ScaledUnit(@"DeciLitre", @"dL", Litre, 0.1, 0) { Caption = @"decilitro" };
          DecaLitre = new ScaledUnit(@"DecaLitre", @"daL", Litre, 10, 0) { Caption = @"decalitro" };
          HectoLitre = new ScaledUnit(@"HectoLitre", @"hL", Litre, 100, 0) { Caption = @"hectolitro" };
          KiloLitre = new ScaledUnit(@"KiloLitre", @"kL", Litre, 1000, 0) { Caption = @"kilolitro" };

          allUnits = new Dictionary<string, Unit>
          {
            { CubicMetre.Name, CubicMetre },
            { CubicKiloMetre.Name, CubicKiloMetre },
            { CubicHectoMetre.Name, CubicHectoMetre },
            { CubicDecaMetre.Name, CubicDecaMetre },
            { CubicDeciMetre.Name, CubicDeciMetre },
            { CubicCentiMetre.Name, CubicCentiMetre },
            { CubicMilliMetre.Name, CubicMilliMetre },
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
