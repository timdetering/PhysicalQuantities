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
      public static partial class Substance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Mole_(unit)
        /// </summary>
        public static BaseUnit Mole { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMole { get; private set; }
        public static ScaledUnit ZettaMole { get; private set; }
        public static ScaledUnit ExaMole { get; private set; }
        public static ScaledUnit PetaMole { get; private set; }
        public static ScaledUnit TeraMole { get; private set; }
        public static ScaledUnit GigaMole { get; private set; }
        public static ScaledUnit MegaMole { get; private set; }
        public static ScaledUnit KiloMole { get; private set; }
        public static ScaledUnit HectoMole { get; private set; }
        public static ScaledUnit DecaMole { get; private set; }
        public static ScaledUnit DeciMole { get; private set; }
        public static ScaledUnit CentiMole { get; private set; }
        public static ScaledUnit MilliMole { get; private set; }
        public static ScaledUnit MicroMole { get; private set; }
        public static ScaledUnit NanoMole { get; private set; }
        public static ScaledUnit PicoMole { get; private set; }
        public static ScaledUnit FemtoMole { get; private set; }
        public static ScaledUnit AttoMole { get; private set; }
        public static ScaledUnit ZeptoMole { get; private set; }
        public static ScaledUnit YoctoMole { get; private set; }

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
          Mole = new BaseUnit(@"Mole", @"mol", PhysicalQuantities.Quantities.Substance, unitSystem) { Caption = @"mol" };
          YottaMole = new ScaledUnit(@"YottaMole", @"Ymol", Mole, 1E+24, 0.0) { Caption = @"yottamol" };
          ZettaMole = new ScaledUnit(@"ZettaMole", @"Zmol", Mole, 1E+21, 0.0) { Caption = @"zettamol" };
          ExaMole = new ScaledUnit(@"ExaMole", @"Emol", Mole, 1E+18, 0.0) { Caption = @"examol" };
          PetaMole = new ScaledUnit(@"PetaMole", @"Pmol", Mole, 1E+15, 0.0) { Caption = @"petamol" };
          TeraMole = new ScaledUnit(@"TeraMole", @"Tmol", Mole, 1000000000000, 0.0) { Caption = @"teramol" };
          GigaMole = new ScaledUnit(@"GigaMole", @"Gmol", Mole, 1000000000, 0.0) { Caption = @"gigamol" };
          MegaMole = new ScaledUnit(@"MegaMole", @"Mmol", Mole, 1000000, 0.0) { Caption = @"megamol" };
          KiloMole = new ScaledUnit(@"KiloMole", @"kmol", Mole, 1000, 0.0) { Caption = @"kilomol" };
          HectoMole = new ScaledUnit(@"HectoMole", @"hmol", Mole, 100, 0.0) { Caption = @"hectomol" };
          DecaMole = new ScaledUnit(@"DecaMole", @"damol", Mole, 10, 0.0) { Caption = @"decamol" };
          DeciMole = new ScaledUnit(@"DeciMole", @"dmol", Mole, 0.1, 0.0) { Caption = @"decimol" };
          CentiMole = new ScaledUnit(@"CentiMole", @"cmol", Mole, 0.01, 0.0) { Caption = @"centimol" };
          MilliMole = new ScaledUnit(@"MilliMole", @"mmol", Mole, 0.001, 0.0) { Caption = @"milimol" };
          MicroMole = new ScaledUnit(@"MicroMole", @"μmol", Mole, 1E-06, 0.0) { Caption = @"micromol" };
          NanoMole = new ScaledUnit(@"NanoMole", @"nmol", Mole, 1E-09, 0.0) { Caption = @"nanomol" };
          PicoMole = new ScaledUnit(@"PicoMole", @"pmol", Mole, 1E-12, 0.0) { Caption = @"picomol" };
          FemtoMole = new ScaledUnit(@"FemtoMole", @"fmol", Mole, 1E-15, 0.0) { Caption = @"femtomol" };
          AttoMole = new ScaledUnit(@"AttoMole", @"amol", Mole, 1E-18, 0.0) { Caption = @"attomol" };
          ZeptoMole = new ScaledUnit(@"ZeptoMole", @"zmol", Mole, 1E-21, 0.0) { Caption = @"zeptomol" };
          YoctoMole = new ScaledUnit(@"YoctoMole", @"ymol", Mole, 1E-24, 0.0) { Caption = @"yoctomol" };

          allUnits = new Dictionary<string, Unit>
          {
            { Mole.Name, Mole },
            { YottaMole.Name, YottaMole },
            { ZettaMole.Name, ZettaMole },
            { ExaMole.Name, ExaMole },
            { PetaMole.Name, PetaMole },
            { TeraMole.Name, TeraMole },
            { GigaMole.Name, GigaMole },
            { MegaMole.Name, MegaMole },
            { KiloMole.Name, KiloMole },
            { HectoMole.Name, HectoMole },
            { DecaMole.Name, DecaMole },
            { DeciMole.Name, DeciMole },
            { CentiMole.Name, CentiMole },
            { MilliMole.Name, MilliMole },
            { MicroMole.Name, MicroMole },
            { NanoMole.Name, NanoMole },
            { PicoMole.Name, PicoMole },
            { FemtoMole.Name, FemtoMole },
            { AttoMole.Name, AttoMole },
            { ZeptoMole.Name, ZeptoMole },
            { YoctoMole.Name, YoctoMole },
          };
        }

        static Substance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
