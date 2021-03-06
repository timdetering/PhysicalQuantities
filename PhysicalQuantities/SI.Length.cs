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
      public static partial class Length
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Metre
        /// </summary>
        public static BaseUnit Metre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaMetre { get; private set; }
        public static ScaledUnit ZettaMetre { get; private set; }
        public static ScaledUnit ExaMetre { get; private set; }
        public static ScaledUnit PetaMetre { get; private set; }
        public static ScaledUnit TeraMetre { get; private set; }
        public static ScaledUnit GigaMetre { get; private set; }
        public static ScaledUnit MegaMetre { get; private set; }
        public static ScaledUnit KiloMetre { get; private set; }
        public static ScaledUnit HectoMetre { get; private set; }
        public static ScaledUnit DecaMetre { get; private set; }
        public static ScaledUnit DeciMetre { get; private set; }
        public static ScaledUnit CentiMetre { get; private set; }
        public static ScaledUnit MilliMetre { get; private set; }
        public static ScaledUnit MicroMetre { get; private set; }
        public static ScaledUnit NanoMetre { get; private set; }
        public static ScaledUnit PicoMetre { get; private set; }
        public static ScaledUnit FemtoMetre { get; private set; }
        public static ScaledUnit AttoMetre { get; private set; }
        public static ScaledUnit ZeptoMetre { get; private set; }
        public static ScaledUnit YoctoMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Astronomical_unit
        /// </summary>
        public static ScaledUnit AstronomicalUnit { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bohr_radius
        /// </summary>
        public static ScaledUnit BohrRadius { get; private set; }

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
          Metre = new BaseUnit(@"Metre", @"m", PhysicalQuantities.Quantities.Length, unitSystem) { Caption = @"metro" };
          YottaMetre = new ScaledUnit(@"YottaMetre", @"Ym", Metre, 1E+24, 0.0) { Caption = @"yottametro" };
          ZettaMetre = new ScaledUnit(@"ZettaMetre", @"Zm", Metre, 1E+21, 0.0) { Caption = @"zettametro" };
          ExaMetre = new ScaledUnit(@"ExaMetre", @"Em", Metre, 1E+18, 0.0) { Caption = @"exametro" };
          PetaMetre = new ScaledUnit(@"PetaMetre", @"Pm", Metre, 1E+15, 0.0) { Caption = @"petametro" };
          TeraMetre = new ScaledUnit(@"TeraMetre", @"Tm", Metre, 1000000000000, 0.0) { Caption = @"terametro" };
          GigaMetre = new ScaledUnit(@"GigaMetre", @"Gm", Metre, 1000000000, 0.0) { Caption = @"gigametro" };
          MegaMetre = new ScaledUnit(@"MegaMetre", @"Mm", Metre, 1000000, 0.0) { Caption = @"megametro" };
          KiloMetre = new ScaledUnit(@"KiloMetre", @"km", Metre, 1000, 0.0) { Caption = @"kilometro" };
          HectoMetre = new ScaledUnit(@"HectoMetre", @"hm", Metre, 100, 0.0) { Caption = @"hectometro" };
          DecaMetre = new ScaledUnit(@"DecaMetre", @"dam", Metre, 10, 0.0) { Caption = @"decametro" };
          DeciMetre = new ScaledUnit(@"DeciMetre", @"dm", Metre, 0.1, 0.0) { Caption = @"decimetro" };
          CentiMetre = new ScaledUnit(@"CentiMetre", @"cm", Metre, 0.01, 0.0) { Caption = @"centimetro" };
          MilliMetre = new ScaledUnit(@"MilliMetre", @"mm", Metre, 0.001, 0.0) { Caption = @"milimetro" };
          MicroMetre = new ScaledUnit(@"MicroMetre", @"μm", Metre, 1E-06, 0.0) { Caption = @"micrometro" };
          NanoMetre = new ScaledUnit(@"NanoMetre", @"nm", Metre, 1E-09, 0.0) { Caption = @"nanometro" };
          PicoMetre = new ScaledUnit(@"PicoMetre", @"pm", Metre, 1E-12, 0.0) { Caption = @"picometro" };
          FemtoMetre = new ScaledUnit(@"FemtoMetre", @"fm", Metre, 1E-15, 0.0) { Caption = @"femtometro" };
          AttoMetre = new ScaledUnit(@"AttoMetre", @"am", Metre, 1E-18, 0.0) { Caption = @"attometro" };
          ZeptoMetre = new ScaledUnit(@"ZeptoMetre", @"zm", Metre, 1E-21, 0.0) { Caption = @"zeptometro" };
          YoctoMetre = new ScaledUnit(@"YoctoMetre", @"ym", Metre, 1E-24, 0.0) { Caption = @"yoctometro" };
          AstronomicalUnit = new ScaledUnit(@"AstronomicalUnit", @"au", Metre, 149597870700, 0) { Caption = @"unidad astronómica" };
          BohrRadius = new ScaledUnit(@"BohrRadius", @"a0", Metre, 5.29177210818E-11, 0) { Caption = @"radio de Bohr" };

          allUnits = new Dictionary<string, Unit>
          {
            { Metre.Name, Metre },
            { YottaMetre.Name, YottaMetre },
            { ZettaMetre.Name, ZettaMetre },
            { ExaMetre.Name, ExaMetre },
            { PetaMetre.Name, PetaMetre },
            { TeraMetre.Name, TeraMetre },
            { GigaMetre.Name, GigaMetre },
            { MegaMetre.Name, MegaMetre },
            { KiloMetre.Name, KiloMetre },
            { HectoMetre.Name, HectoMetre },
            { DecaMetre.Name, DecaMetre },
            { DeciMetre.Name, DeciMetre },
            { CentiMetre.Name, CentiMetre },
            { MilliMetre.Name, MilliMetre },
            { MicroMetre.Name, MicroMetre },
            { NanoMetre.Name, NanoMetre },
            { PicoMetre.Name, PicoMetre },
            { FemtoMetre.Name, FemtoMetre },
            { AttoMetre.Name, AttoMetre },
            { ZeptoMetre.Name, ZeptoMetre },
            { YoctoMetre.Name, YoctoMetre },
            { AstronomicalUnit.Name, AstronomicalUnit },
            { BohrRadius.Name, BohrRadius },
          };
        }

        static Length()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
