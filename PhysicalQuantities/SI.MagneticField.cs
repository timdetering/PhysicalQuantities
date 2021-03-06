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
      public static partial class MagneticField
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Tesla_(unit)
        /// </summary>
        public static BaseUnit Tesla { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaTesla { get; private set; }
        public static ScaledUnit ZettaTesla { get; private set; }
        public static ScaledUnit ExaTesla { get; private set; }
        public static ScaledUnit PetaTesla { get; private set; }
        public static ScaledUnit TeraTesla { get; private set; }
        public static ScaledUnit GigaTesla { get; private set; }
        public static ScaledUnit MegaTesla { get; private set; }
        public static ScaledUnit KiloTesla { get; private set; }
        public static ScaledUnit HectoTesla { get; private set; }
        public static ScaledUnit DecaTesla { get; private set; }
        public static ScaledUnit DeciTesla { get; private set; }
        public static ScaledUnit CentiTesla { get; private set; }
        public static ScaledUnit MilliTesla { get; private set; }
        public static ScaledUnit MicroTesla { get; private set; }
        public static ScaledUnit NanoTesla { get; private set; }
        public static ScaledUnit PicoTesla { get; private set; }
        public static ScaledUnit FemtoTesla { get; private set; }
        public static ScaledUnit AttoTesla { get; private set; }
        public static ScaledUnit ZeptoTesla { get; private set; }
        public static ScaledUnit YoctoTesla { get; private set; }

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
          Tesla = new BaseUnit(@"Tesla", @"T", PhysicalQuantities.Quantities.MagneticField, unitSystem) { Caption = @"tesla" };
          YottaTesla = new ScaledUnit(@"YottaTesla", @"YT", Tesla, 1E+24, 0.0) { Caption = @"yottatesla" };
          ZettaTesla = new ScaledUnit(@"ZettaTesla", @"ZT", Tesla, 1E+21, 0.0) { Caption = @"zettatesla" };
          ExaTesla = new ScaledUnit(@"ExaTesla", @"ET", Tesla, 1E+18, 0.0) { Caption = @"exatesla" };
          PetaTesla = new ScaledUnit(@"PetaTesla", @"PT", Tesla, 1E+15, 0.0) { Caption = @"petatesla" };
          TeraTesla = new ScaledUnit(@"TeraTesla", @"TT", Tesla, 1000000000000, 0.0) { Caption = @"teratesla" };
          GigaTesla = new ScaledUnit(@"GigaTesla", @"GT", Tesla, 1000000000, 0.0) { Caption = @"gigatesla" };
          MegaTesla = new ScaledUnit(@"MegaTesla", @"MT", Tesla, 1000000, 0.0) { Caption = @"megatesla" };
          KiloTesla = new ScaledUnit(@"KiloTesla", @"kT", Tesla, 1000, 0.0) { Caption = @"kilotesla" };
          HectoTesla = new ScaledUnit(@"HectoTesla", @"hT", Tesla, 100, 0.0) { Caption = @"hectotesla" };
          DecaTesla = new ScaledUnit(@"DecaTesla", @"daT", Tesla, 10, 0.0) { Caption = @"decatesla" };
          DeciTesla = new ScaledUnit(@"DeciTesla", @"dT", Tesla, 0.1, 0.0) { Caption = @"decitesla" };
          CentiTesla = new ScaledUnit(@"CentiTesla", @"cT", Tesla, 0.01, 0.0) { Caption = @"centitesla" };
          MilliTesla = new ScaledUnit(@"MilliTesla", @"mT", Tesla, 0.001, 0.0) { Caption = @"militesla" };
          MicroTesla = new ScaledUnit(@"MicroTesla", @"μT", Tesla, 1E-06, 0.0) { Caption = @"microtesla" };
          NanoTesla = new ScaledUnit(@"NanoTesla", @"nT", Tesla, 1E-09, 0.0) { Caption = @"nanotesla" };
          PicoTesla = new ScaledUnit(@"PicoTesla", @"pT", Tesla, 1E-12, 0.0) { Caption = @"picotesla" };
          FemtoTesla = new ScaledUnit(@"FemtoTesla", @"fT", Tesla, 1E-15, 0.0) { Caption = @"femtotesla" };
          AttoTesla = new ScaledUnit(@"AttoTesla", @"aT", Tesla, 1E-18, 0.0) { Caption = @"attotesla" };
          ZeptoTesla = new ScaledUnit(@"ZeptoTesla", @"zT", Tesla, 1E-21, 0.0) { Caption = @"zeptotesla" };
          YoctoTesla = new ScaledUnit(@"YoctoTesla", @"yT", Tesla, 1E-24, 0.0) { Caption = @"yoctotesla" };

          allUnits = new Dictionary<string, Unit>
          {
            { Tesla.Name, Tesla },
            { YottaTesla.Name, YottaTesla },
            { ZettaTesla.Name, ZettaTesla },
            { ExaTesla.Name, ExaTesla },
            { PetaTesla.Name, PetaTesla },
            { TeraTesla.Name, TeraTesla },
            { GigaTesla.Name, GigaTesla },
            { MegaTesla.Name, MegaTesla },
            { KiloTesla.Name, KiloTesla },
            { HectoTesla.Name, HectoTesla },
            { DecaTesla.Name, DecaTesla },
            { DeciTesla.Name, DeciTesla },
            { CentiTesla.Name, CentiTesla },
            { MilliTesla.Name, MilliTesla },
            { MicroTesla.Name, MicroTesla },
            { NanoTesla.Name, NanoTesla },
            { PicoTesla.Name, PicoTesla },
            { FemtoTesla.Name, FemtoTesla },
            { AttoTesla.Name, AttoTesla },
            { ZeptoTesla.Name, ZeptoTesla },
            { YoctoTesla.Name, YoctoTesla },
          };
        }

        static MagneticField()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
