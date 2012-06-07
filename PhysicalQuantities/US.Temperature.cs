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
      public static partial class Temperature
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Farenheit
        /// </summary>
        public static BaseUnit Farenheit { get; private set; }

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
          Farenheit = new BaseUnit(@"Farenheit", @"°F", PhysicalQuantities.Quantities.Temperature, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { Farenheit.Name, Farenheit },
          };
        }

        static Temperature()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
