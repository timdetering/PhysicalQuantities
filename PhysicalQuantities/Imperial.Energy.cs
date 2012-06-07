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
      public static partial class Energy
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot-pound_force
        /// </summary>
        public static BaseUnit FootPoundForce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/British_thermal_unit
        /// </summary>
        public static ScaledUnit BritishThermalUnit { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit HorsePowerHour { get; private set; }

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
          FootPoundForce = new BaseUnit(@"FootPoundForce", @"ft lbf", PhysicalQuantities.Quantities.Energy, unitSystem);
          BritishThermalUnit = new ScaledUnit(@"BritishThermalUnit", @"Btu", FootPoundForce, 780, 0);
          HorsePowerHour = new ScaledUnit(@"HorsePowerHour", @"hph", FootPoundForce, 1980333.14153351, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { FootPoundForce.Name, FootPoundForce },
            { BritishThermalUnit.Name, BritishThermalUnit },
            { HorsePowerHour.Name, HorsePowerHour },
          };
        }

        static Energy()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
