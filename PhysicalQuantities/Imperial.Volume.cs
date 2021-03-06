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
      public static partial class Volume
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_foot
        /// </summary>
        public static BaseUnit CubicFoot { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_inch
        /// </summary>
        public static ScaledUnit CubicInch { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_yard
        /// </summary>
        public static ScaledUnit CubicYard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Cubic_mile
        /// </summary>
        public static ScaledUnit CubicMile { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fluid_ounce
        /// </summary>
        public static ScaledUnit FluidOunce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Fluid_dram
        /// </summary>
        public static ScaledUnit FluidDram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gill_(volume)
        /// </summary>
        public static ScaledUnit Gill { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Pint
        /// </summary>
        public static ScaledUnit Pint { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Quart
        /// </summary>
        public static ScaledUnit Quart { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gallon
        /// </summary>
        public static ScaledUnit Gallon { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Peck
        /// </summary>
        public static ScaledUnit Peck { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bushel
        /// </summary>
        public static ScaledUnit Bushel { get; private set; }

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
          CubicFoot = new BaseUnit(@"CubicFoot", @"ft³", PhysicalQuantities.Quantities.Volume, unitSystem) { Caption = @"pie cúbico" };
          CubicInch = new ScaledUnit(@"CubicInch", @"in³", CubicFoot, 0.000578703703703704, 0) { Caption = @"pulgada cúbica" };
          CubicYard = new ScaledUnit(@"CubicYard", @"yd³", CubicFoot, 27, 0) { Caption = @"yarda cúbica" };
          CubicMile = new ScaledUnit(@"CubicMile", @"mi³", CubicYard, 5451776000, 0) { Caption = @"milla cúbica" };
          FluidOunce = new ScaledUnit(@"FluidOunce", @"fl oz", CubicInch, 1.733871455, 0) { Caption = @"onza líquida" };
          FluidDram = new ScaledUnit(@"FluidDram", @"ℨ", FluidOunce, 0.125, 0) { Caption = @"dracma líquido" };
          Gill = new ScaledUnit(@"Gill", @"gi", FluidOunce, 5, 0) { Caption = @"cuarto de pinta" };
          Pint = new ScaledUnit(@"Pint", @"pt", Gill, 4, 0) { Caption = @"pinta" };
          Quart = new ScaledUnit(@"Quart", @"qt", Pint, 2, 0) { Caption = @"cuarto de galón" };
          Gallon = new ScaledUnit(@"Gallon", @"gal", Quart, 4, 0) { Caption = @"galón" };
          Peck = new ScaledUnit(@"Peck", null, Gallon, 2, 0) { Caption = @"peck" };
          Bushel = new ScaledUnit(@"Bushel", null, Peck, 4, 0) { Caption = @"bushel" };

          allUnits = new Dictionary<string, Unit>
          {
            { CubicFoot.Name, CubicFoot },
            { CubicInch.Name, CubicInch },
            { CubicYard.Name, CubicYard },
            { CubicMile.Name, CubicMile },
            { FluidOunce.Name, FluidOunce },
            { FluidDram.Name, FluidDram },
            { Gill.Name, Gill },
            { Pint.Name, Pint },
            { Quart.Name, Quart },
            { Gallon.Name, Gallon },
            { Peck.Name, Peck },
            { Bushel.Name, Bushel },
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
