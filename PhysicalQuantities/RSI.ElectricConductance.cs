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
      public static partial class ElectricConductance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Siemens_(unit)
        /// </summary>
        public static BaseUnit Siemens { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Siemens_(unit)
        /// </summary>
        public static ScaledUnit MilliSiemens { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Siemens_(unit)
        /// </summary>
        public static ScaledUnit MicroSiemens { get; private set; }

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
          Siemens = new BaseUnit(@"Siemens", @"S", PhysicalQuantities.Quantities.ElectricConductance, unitSystem);
          MilliSiemens = new ScaledUnit(@"MilliSiemens", @"mS", Siemens, 0.001, 0);
          MicroSiemens = new ScaledUnit(@"MicroSiemens", @"µS", Siemens, 1E-06, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Siemens.Name, Siemens },
            { MilliSiemens.Name, MilliSiemens },
            { MicroSiemens.Name, MicroSiemens },
          };
        }

        static ElectricConductance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
