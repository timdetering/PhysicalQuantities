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
      public static partial class Energy
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot-pound_force
        /// </summary>
        public static BaseUnit FootPoundForce { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot-poundal
        /// </summary>
        public static ScaledUnit FootPoundal { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/British_thermal_unit
        /// </summary>
        public static ScaledUnit BritishThermalUnit { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/British_thermal_unit
        /// </summary>
        public static ScaledUnit BritishThermalUnitThermochemical { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/British_thermal_unit
        /// </summary>
        public static ScaledUnit BritishThermalUnitMean { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Therm
        /// </summary>
        public static ScaledUnit Therm { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Watt_hour
        /// </summary>
        public static ScaledUnit WattHour { get; private set; }

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
          FootPoundal = new ScaledUnit(@"FootPoundal", @"ft pdl", FootPoundForce, 0.0310812804248414, 0);
          BritishThermalUnit = new ScaledUnit(@"BritishThermalUnit", @"Btu", FootPoundForce, 780, 0);
          BritishThermalUnitThermochemical = new ScaledUnit(@"BritishThermalUnitThermochemical", @"Btu", BritishThermalUnit, 0.999330841206533, 0);
          BritishThermalUnitMean = new ScaledUnit(@"BritishThermalUnitMean", @"Btu", BritishThermalUnit, 1.00077152302816, 0);
          Therm = new ScaledUnit(@"Therm", @"thm", BritishThermalUnit, 100000, 0);
          WattHour = new ScaledUnit(@"WattHour", @"Wh", BritishThermalUnit, 3.41214115648838, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { FootPoundForce.Name, FootPoundForce },
            { FootPoundal.Name, FootPoundal },
            { BritishThermalUnit.Name, BritishThermalUnit },
            { BritishThermalUnitThermochemical.Name, BritishThermalUnitThermochemical },
            { BritishThermalUnitMean.Name, BritishThermalUnitMean },
            { Therm.Name, Therm },
            { WattHour.Name, WattHour },
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
