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
      public static partial class VolumetricFlow
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Volumetric_flow
        /// </summary>
        public static BaseUnit CubicFootPerSecond { get; private set; }

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
          CubicFootPerSecond = new BaseUnit(@"CubicFootPerSecond", @"ft³/s", PhysicalQuantities.Quantities.VolumetricFlow, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { CubicFootPerSecond.Name, CubicFootPerSecond },
          };
        }

        static VolumetricFlow()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
