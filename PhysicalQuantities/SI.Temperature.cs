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
      public static partial class Temperature
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Kelvin
        /// </summary>
        public static BaseUnit Kelvin { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaKelvin { get; private set; }
        public static ScaledUnit ZettaKelvin { get; private set; }
        public static ScaledUnit ExaKelvin { get; private set; }
        public static ScaledUnit PetaKelvin { get; private set; }
        public static ScaledUnit TeraKelvin { get; private set; }
        public static ScaledUnit GigaKelvin { get; private set; }
        public static ScaledUnit MegaKelvin { get; private set; }
        public static ScaledUnit KiloKelvin { get; private set; }
        public static ScaledUnit HectoKelvin { get; private set; }
        public static ScaledUnit DecaKelvin { get; private set; }
        public static ScaledUnit DeciKelvin { get; private set; }
        public static ScaledUnit CentiKelvin { get; private set; }
        public static ScaledUnit MilliKelvin { get; private set; }
        public static ScaledUnit MicroKelvin { get; private set; }
        public static ScaledUnit NanoKelvin { get; private set; }
        public static ScaledUnit PicoKelvin { get; private set; }
        public static ScaledUnit FemtoKelvin { get; private set; }
        public static ScaledUnit AttoKelvin { get; private set; }
        public static ScaledUnit ZeptoKelvin { get; private set; }
        public static ScaledUnit YoctoKelvin { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Celsius
        /// </summary>
        public static ScaledUnit Celsius { get; private set; }

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
          Kelvin = new BaseUnit(@"Kelvin", @"K", PhysicalQuantities.Quantities.Temperature, unitSystem) { Caption = @"grado kelvin" };
          YottaKelvin = new ScaledUnit(@"YottaKelvin", @"YK", Kelvin, 1E+24, 0.0) { Caption = @"yottagrado kelvin" };
          ZettaKelvin = new ScaledUnit(@"ZettaKelvin", @"ZK", Kelvin, 1E+21, 0.0) { Caption = @"zettagrado kelvin" };
          ExaKelvin = new ScaledUnit(@"ExaKelvin", @"EK", Kelvin, 1E+18, 0.0) { Caption = @"exagrado kelvin" };
          PetaKelvin = new ScaledUnit(@"PetaKelvin", @"PK", Kelvin, 1E+15, 0.0) { Caption = @"petagrado kelvin" };
          TeraKelvin = new ScaledUnit(@"TeraKelvin", @"TK", Kelvin, 1000000000000, 0.0) { Caption = @"teragrado kelvin" };
          GigaKelvin = new ScaledUnit(@"GigaKelvin", @"GK", Kelvin, 1000000000, 0.0) { Caption = @"gigagrado kelvin" };
          MegaKelvin = new ScaledUnit(@"MegaKelvin", @"MK", Kelvin, 1000000, 0.0) { Caption = @"megagrado kelvin" };
          KiloKelvin = new ScaledUnit(@"KiloKelvin", @"kK", Kelvin, 1000, 0.0) { Caption = @"kilogrado kelvin" };
          HectoKelvin = new ScaledUnit(@"HectoKelvin", @"hK", Kelvin, 100, 0.0) { Caption = @"hectogrado kelvin" };
          DecaKelvin = new ScaledUnit(@"DecaKelvin", @"daK", Kelvin, 10, 0.0) { Caption = @"decagrado kelvin" };
          DeciKelvin = new ScaledUnit(@"DeciKelvin", @"dK", Kelvin, 0.1, 0.0) { Caption = @"decigrado kelvin" };
          CentiKelvin = new ScaledUnit(@"CentiKelvin", @"cK", Kelvin, 0.01, 0.0) { Caption = @"centigrado kelvin" };
          MilliKelvin = new ScaledUnit(@"MilliKelvin", @"mK", Kelvin, 0.001, 0.0) { Caption = @"miligrado kelvin" };
          MicroKelvin = new ScaledUnit(@"MicroKelvin", @"μK", Kelvin, 1E-06, 0.0) { Caption = @"microgrado kelvin" };
          NanoKelvin = new ScaledUnit(@"NanoKelvin", @"nK", Kelvin, 1E-09, 0.0) { Caption = @"nanogrado kelvin" };
          PicoKelvin = new ScaledUnit(@"PicoKelvin", @"pK", Kelvin, 1E-12, 0.0) { Caption = @"picogrado kelvin" };
          FemtoKelvin = new ScaledUnit(@"FemtoKelvin", @"fK", Kelvin, 1E-15, 0.0) { Caption = @"femtogrado kelvin" };
          AttoKelvin = new ScaledUnit(@"AttoKelvin", @"aK", Kelvin, 1E-18, 0.0) { Caption = @"attogrado kelvin" };
          ZeptoKelvin = new ScaledUnit(@"ZeptoKelvin", @"zK", Kelvin, 1E-21, 0.0) { Caption = @"zeptogrado kelvin" };
          YoctoKelvin = new ScaledUnit(@"YoctoKelvin", @"yK", Kelvin, 1E-24, 0.0) { Caption = @"yoctogrado kelvin" };
          Celsius = new ScaledUnit(@"Celsius", @"°C", Kelvin, 1, -273.15) { Caption = @"grado celsio" };

          allUnits = new Dictionary<string, Unit>
          {
            { Kelvin.Name, Kelvin },
            { YottaKelvin.Name, YottaKelvin },
            { ZettaKelvin.Name, ZettaKelvin },
            { ExaKelvin.Name, ExaKelvin },
            { PetaKelvin.Name, PetaKelvin },
            { TeraKelvin.Name, TeraKelvin },
            { GigaKelvin.Name, GigaKelvin },
            { MegaKelvin.Name, MegaKelvin },
            { KiloKelvin.Name, KiloKelvin },
            { HectoKelvin.Name, HectoKelvin },
            { DecaKelvin.Name, DecaKelvin },
            { DeciKelvin.Name, DeciKelvin },
            { CentiKelvin.Name, CentiKelvin },
            { MilliKelvin.Name, MilliKelvin },
            { MicroKelvin.Name, MicroKelvin },
            { NanoKelvin.Name, NanoKelvin },
            { PicoKelvin.Name, PicoKelvin },
            { FemtoKelvin.Name, FemtoKelvin },
            { AttoKelvin.Name, AttoKelvin },
            { ZeptoKelvin.Name, ZeptoKelvin },
            { YoctoKelvin.Name, YoctoKelvin },
            { Celsius.Name, Celsius },
          };
        }

        static Temperature()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
