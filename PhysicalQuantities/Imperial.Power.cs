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
      public static partial class Power
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Foot-pound_force
        /// </summary>
        public static BaseUnit FootPoundPerSecond { get; private set; }
        public static ScaledUnit FootPoundPerMinute { get; private set; }
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
        public static ScaledUnit MetricHorsepower { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit ElectricalHorsepower { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit BoilerHorsepower { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Horsepower
        /// </summary>
        public static ScaledUnit HidraulicHorsepower { get; private set; }

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
          Horsepower = new ScaledUnit(@"Horsepower", @"hp", FootPoundPerMinute, 33000, 0);
          MechanicalHorsepower = new ScaledUnit(@"MechanicalHorsepower", @"hp(I)", Horsepower, 1, 0);
          MetricHorsepower = new ScaledUnit(@"MetricHorsepower", @"hp(M)", FootPoundPerMinute, 32548.5623122113, 0);
          ElectricalHorsepower = new ScaledUnit(@"ElectricalHorsepower", @"hp(E)", FootPoundPerMinute, 33013.2817831569, 0);
          BoilerHorsepower = new ScaledUnit(@"BoilerHorsepower", @"hp(S)", FootPoundPerMinute, 434106.95395694, 0);
          HidraulicHorsepower = new ScaledUnit(@"HidraulicHorsepower", @"hp", Horsepower, 1, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { FootPoundPerSecond.Name, FootPoundPerSecond },
            { FootPoundPerMinute.Name, FootPoundPerMinute },
            { Horsepower.Name, Horsepower },
            { MechanicalHorsepower.Name, MechanicalHorsepower },
            { MetricHorsepower.Name, MetricHorsepower },
            { ElectricalHorsepower.Name, ElectricalHorsepower },
            { BoilerHorsepower.Name, BoilerHorsepower },
            { HidraulicHorsepower.Name, HidraulicHorsepower },
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
