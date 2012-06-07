using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    public static partial class SI
    {
      public static partial class NewtonianConstantOfGravitationQuantity
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gravitational_constant
        /// </summary>
        public static BaseUnit NewtonianConstantOfGravitationUnit { get; private set; }

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
          NewtonianConstantOfGravitationUnit = new BaseUnit(@"NewtonianConstantOfGravitationUnit", @"G", PhysicalQuantities.Quantities.NewtonianConstantOfGravitationQuantity, unitSystem);

          allUnits = new Dictionary<string, Unit>
          {
            { NewtonianConstantOfGravitationUnit.Name, NewtonianConstantOfGravitationUnit },
          };
        }

        static NewtonianConstantOfGravitationQuantity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
