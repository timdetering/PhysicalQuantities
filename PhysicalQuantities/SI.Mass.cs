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
      public static partial class Mass
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kilogram
        /// </summary>
        public static BaseUnit Kilogram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Gram
        /// </summary>
        public static ScaledUnit Gram { get; private set; }
        public static ScaledUnit Yottagram { get; private set; }
        public static ScaledUnit Zettagram { get; private set; }
        public static ScaledUnit Exagram { get; private set; }
        public static ScaledUnit Petagram { get; private set; }
        public static ScaledUnit Teragram { get; private set; }
        public static ScaledUnit Gigagram { get; private set; }
        public static ScaledUnit Megagram { get; private set; }
        public static ScaledUnit Hectogram { get; private set; }
        public static ScaledUnit Decagram { get; private set; }
        public static ScaledUnit Decigram { get; private set; }
        public static ScaledUnit Centigram { get; private set; }
        public static ScaledUnit Milligram { get; private set; }
        public static ScaledUnit Microgram { get; private set; }
        public static ScaledUnit Nanogram { get; private set; }
        public static ScaledUnit Picogram { get; private set; }
        public static ScaledUnit Femtogram { get; private set; }
        public static ScaledUnit Attogram { get; private set; }
        public static ScaledUnit Zeptogram { get; private set; }
        public static ScaledUnit Yoctogram { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit Tonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit KiloTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit MegaTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit GigaTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit TeraTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit PetaTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tonne
        /// </summary>
        public static ScaledUnit ExaTonne { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Atomic_mass_unit
        /// </summary>
        public static ScaledUnit AtomicMassUnit { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Dalton_(unit)
        /// </summary>
        public static ScaledUnit Dalton { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron_rest_mass
        /// </summary>
        public static ScaledUnit ElectronRestMass { get; private set; }

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
          Kilogram = new BaseUnit(@"Kilogram", @"kg", PhysicalQuantities.Quantities.Mass, unitSystem);
          Gram = new ScaledUnit(@"Gram", @"g", Kilogram, 0.001, 0);
          Yottagram = new ScaledUnit(@"Yottagram", @"Yg", Gram, 1E+24, 0);
          Zettagram = new ScaledUnit(@"Zettagram", @"Zg", Gram, 1E+21, 0);
          Exagram = new ScaledUnit(@"Exagram", @"Eg", Gram, 1E+18, 0);
          Petagram = new ScaledUnit(@"Petagram", @"Pg", Gram, 1E+15, 0);
          Teragram = new ScaledUnit(@"Teragram", @"Tg", Gram, 1000000000000, 0);
          Gigagram = new ScaledUnit(@"Gigagram", @"Gg", Gram, 1000000000, 0);
          Megagram = new ScaledUnit(@"Megagram", @"Mg", Gram, 1000000, 0);
          Hectogram = new ScaledUnit(@"Hectogram", @"hg", Gram, 100, 0);
          Decagram = new ScaledUnit(@"Decagram", @"dag", Gram, 10, 0);
          Decigram = new ScaledUnit(@"Decigram", @"dg", Gram, 0.1, 0);
          Centigram = new ScaledUnit(@"Centigram", @"cg", Gram, 0.01, 0);
          Milligram = new ScaledUnit(@"Milligram", @"mg", Gram, 0.001, 0);
          Microgram = new ScaledUnit(@"Microgram", @"µg", Gram, 1E-06, 0);
          Nanogram = new ScaledUnit(@"Nanogram", @"ng", Gram, 1E-09, 0);
          Picogram = new ScaledUnit(@"Picogram", @"pg", Gram, 1E-12, 0);
          Femtogram = new ScaledUnit(@"Femtogram", @"fg", Gram, 1E-15, 0);
          Attogram = new ScaledUnit(@"Attogram", @"ag", Gram, 1E-18, 0);
          Zeptogram = new ScaledUnit(@"Zeptogram", @"zg", Gram, 1E-21, 0);
          Yoctogram = new ScaledUnit(@"Yoctogram", @"yg", Gram, 1E-24, 0);
          Tonne = new ScaledUnit(@"Tonne", @"t", Kilogram, 1000, 0);
          KiloTonne = new ScaledUnit(@"KiloTonne", @"kt", Tonne, 1000, 0);
          MegaTonne = new ScaledUnit(@"MegaTonne", @"Mt", Tonne, 1000000, 0);
          GigaTonne = new ScaledUnit(@"GigaTonne", @"Gt", Tonne, 1000000000000, 0);
          TeraTonne = new ScaledUnit(@"TeraTonne", @"Tt", Tonne, 1E+15, 0);
          PetaTonne = new ScaledUnit(@"PetaTonne", @"Pt", Tonne, 1E+18, 0);
          ExaTonne = new ScaledUnit(@"ExaTonne", @"Et", Tonne, 1E+21, 0);
          AtomicMassUnit = new ScaledUnit(@"AtomicMassUnit", @"u", Kilogram, 1.66053892173E-27, 0);
          Dalton = new ScaledUnit(@"Dalton", @"Da", AtomicMassUnit, 1, 0);
          ElectronRestMass = new ScaledUnit(@"ElectronRestMass", @"me", Kilogram, 9.109382616E-31, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Kilogram.Name, Kilogram },
            { Gram.Name, Gram },
            { Yottagram.Name, Yottagram },
            { Zettagram.Name, Zettagram },
            { Exagram.Name, Exagram },
            { Petagram.Name, Petagram },
            { Teragram.Name, Teragram },
            { Gigagram.Name, Gigagram },
            { Megagram.Name, Megagram },
            { Hectogram.Name, Hectogram },
            { Decagram.Name, Decagram },
            { Decigram.Name, Decigram },
            { Centigram.Name, Centigram },
            { Milligram.Name, Milligram },
            { Microgram.Name, Microgram },
            { Nanogram.Name, Nanogram },
            { Picogram.Name, Picogram },
            { Femtogram.Name, Femtogram },
            { Attogram.Name, Attogram },
            { Zeptogram.Name, Zeptogram },
            { Yoctogram.Name, Yoctogram },
            { Tonne.Name, Tonne },
            { KiloTonne.Name, KiloTonne },
            { MegaTonne.Name, MegaTonne },
            { GigaTonne.Name, GigaTonne },
            { TeraTonne.Name, TeraTonne },
            { PetaTonne.Name, PetaTonne },
            { ExaTonne.Name, ExaTonne },
            { AtomicMassUnit.Name, AtomicMassUnit },
            { Dalton.Name, Dalton },
            { ElectronRestMass.Name, ElectronRestMass },
          };
        }

        static Mass()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
