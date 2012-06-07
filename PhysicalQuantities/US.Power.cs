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
      public static partial class Power
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot-pound_force
        /// </summary>
        public static BaseUnit FootPoundPerSecond { get; private set; }
        public static ScaledUnit FootPoundPerMinute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/British_thermal_unit
        /// </summary>
        public static ScaledUnit BritishThermalUnitPerHour { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit Horsepower { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit MechanicalHorsepower { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit BoilerHorsepower { get; private set; }

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
          FootPoundPerSecond = new BaseUnit(@"FootPoundPerSecond", @"ft lbf/s", PhysicalQuantities.Quantities.Power, unitSystem);
          FootPoundPerMinute = new ScaledUnit(@"FootPoundPerMinute", @"ft lbf/min", FootPoundPerSecond, 0.0166666666666667, 0);
          BritishThermalUnitPerHour = new ScaledUnit(@"BritishThermalUnitPerHour", @"Btu/h", FootPoundPerSecond, 2.1616020061956, 0);
          Horsepower = new ScaledUnit(@"Horsepower", @"hp", FootPoundPerSecond, 550, 0);
          MechanicalHorsepower = new ScaledUnit(@"MechanicalHorsepower", @"hp(I)", Horsepower, 1, 0);
          BoilerHorsepower = new ScaledUnit(@"BoilerHorsepower", @"hp(S)", MechanicalHorsepower, 13.1547556865704, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { FootPoundPerSecond.Name, FootPoundPerSecond },
            { FootPoundPerMinute.Name, FootPoundPerMinute },
            { BritishThermalUnitPerHour.Name, BritishThermalUnitPerHour },
            { Horsepower.Name, Horsepower },
            { MechanicalHorsepower.Name, MechanicalHorsepower },
            { BoilerHorsepower.Name, BoilerHorsepower },
          };
        }

        static Power()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
