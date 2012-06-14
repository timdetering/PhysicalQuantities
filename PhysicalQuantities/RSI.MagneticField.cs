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
      public static partial class MagneticField
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tesla_(unit)
        /// </summary>
        public static BaseUnit Tesla { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tesla_(unit)
        /// </summary>
        public static ScaledUnit MilliTesla { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tesla_(unit)
        /// </summary>
        public static ScaledUnit MicroTesla { get; private set; }

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
          Tesla = new BaseUnit(@"Tesla", @"T", PhysicalQuantities.Quantities.MagneticField, unitSystem);
          MilliTesla = new ScaledUnit(@"MilliTesla", @"mT", Tesla, 0.001, 0);
          MicroTesla = new ScaledUnit(@"MicroTesla", @"µT", Tesla, 1E-06, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Tesla.Name, Tesla },
            { MilliTesla.Name, MilliTesla },
            { MicroTesla.Name, MicroTesla },
          };
        }

        static MagneticField()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
