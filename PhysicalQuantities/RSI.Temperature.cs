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
      public static partial class Temperature
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kelvin
        /// </summary>
        public static BaseUnit Kelvin { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Celsius
        /// </summary>
        public static ScaledUnit Celsius { get; private set; }

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
          Kelvin = new BaseUnit(@"Kelvin", @"K", PhysicalQuantities.Quantities.Temperature, unitSystem);
          Celsius = new ScaledUnit(@"Celsius", @"°C", Kelvin, 1, -273.15);

          allUnits = new Dictionary<string, Unit>
          {
            { Kelvin.Name, Kelvin },
            { Celsius.Name, Celsius },
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
