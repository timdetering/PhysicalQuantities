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
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_yard
        /// </summary>
        public static ScaledUnit SquareYard { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_foot
        /// </summary>
        public static ScaledUnit SquareFootSurvey { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Chain_(unit)
        /// </summary>
        public static ScaledUnit SquareChain { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Acre
        /// </summary>
        public static ScaledUnit Acre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Section_(United_States_land_surveying)
        /// </summary>
        public static ScaledUnit Section { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_mile
        /// </summary>
        public static ScaledUnit SquareMileSurvey { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Survey_township
        /// </summary>
        public static ScaledUnit SurveyTownship { get; private set; }

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
          SquareFoot = new BaseUnit(@"SquareFoot", @"ft²", PhysicalQuantities.Quantities.Area, unitSystem) { Caption = @"pie cuadrado" };
          SquareInch = new ScaledUnit(@"SquareInch", @"in²", SquareFoot, 0.00694444444444444, 0) { Caption = @"pulgada cuadrada" };
          SquareYard = new ScaledUnit(@"SquareYard", @"yd²", SquareFoot, 9, 0) { Caption = @"yarda cuadrada" };
          SquareFootSurvey = new ScaledUnit(@"SquareFootSurvey", @"ft²", SquareFoot, 1.00000400262868, 0) { Caption = @"pie cuadrado (encuesta)" };
          SquareChain = new ScaledUnit(@"SquareChain", @"ch²", SquareFoot, 4356, 0) { Caption = @"cadena cuadrada" };
          Acre = new ScaledUnit(@"Acre", null, SquareChain, 10, 0) { Caption = @"acre" };
          Section = new ScaledUnit(@"Section", null, Acre, 640, 0) { Caption = @"sección" };
          SquareMileSurvey = new ScaledUnit(@"SquareMileSurvey", @"mi²", Section, 1, 0) { Caption = @"milla cuadrada (encuesta)" };
          SurveyTownship = new ScaledUnit(@"SurveyTownship", @"twp", Section, 36, 0) { Caption = @"municipio (encuesta)" };

          allUnits = new Dictionary<string, Unit>
          {
            { SquareFoot.Name, SquareFoot },
            { SquareInch.Name, SquareInch },
            { SquareYard.Name, SquareYard },
            { SquareFootSurvey.Name, SquareFootSurvey },
            { SquareChain.Name, SquareChain },
            { Acre.Name, Acre },
            { Section.Name, Section },
            { SquareMileSurvey.Name, SquareMileSurvey },
            { SurveyTownship.Name, SurveyTownship },
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
