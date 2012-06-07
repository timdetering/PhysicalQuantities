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
      public static partial class Area
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_metre
        /// </summary>
        public static BaseUnit SquareMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSquareMetre { get; private set; }
        public static ScaledUnit ZettaSquareMetre { get; private set; }
        public static ScaledUnit ExaSquareMetre { get; private set; }
        public static ScaledUnit PetaSquareMetre { get; private set; }
        public static ScaledUnit TeraSquareMetre { get; private set; }
        public static ScaledUnit GigaSquareMetre { get; private set; }
        public static ScaledUnit MegaSquareMetre { get; private set; }
        public static ScaledUnit KiloSquareMetre { get; private set; }
        public static ScaledUnit HectoSquareMetre { get; private set; }
        public static ScaledUnit DecaSquareMetre { get; private set; }
        public static ScaledUnit DeciSquareMetre { get; private set; }
        public static ScaledUnit CentiSquareMetre { get; private set; }
        public static ScaledUnit MilliSquareMetre { get; private set; }
        public static ScaledUnit MicroSquareMetre { get; private set; }
        public static ScaledUnit NanoSquareMetre { get; private set; }
        public static ScaledUnit PicoSquareMetre { get; private set; }
        public static ScaledUnit FemtoSquareMetre { get; private set; }
        public static ScaledUnit AttoSquareMetre { get; private set; }
        public static ScaledUnit ZeptoSquareMetre { get; private set; }
        public static ScaledUnit YoctoSquareMetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Are
        /// </summary>
        public static ScaledUnit Are { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Centiare
        /// </summary>
        public static ScaledUnit Centiare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare#Decare
        /// </summary>
        public static ScaledUnit Decare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hectare
        /// </summary>
        public static ScaledUnit Hectare { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_kilometer
        /// </summary>
        public static ScaledUnit SquareKilometre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_centimetre
        /// </summary>
        public static ScaledUnit SquareCentimetre { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Square_millimetre
        /// </summary>
        public static ScaledUnit SquareMillimetre { get; private set; }

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
          SquareMetre = new BaseUnit(@"SquareMetre", @"m²", PhysicalQuantities.Quantities.Area, unitSystem);
          YottaSquareMetre = new ScaledUnit(@"YottaSquareMetre", @"Ym²", SquareMetre, 1E+24, 0.0);
          ZettaSquareMetre = new ScaledUnit(@"ZettaSquareMetre", @"Zm²", SquareMetre, 1E+21, 0.0);
          ExaSquareMetre = new ScaledUnit(@"ExaSquareMetre", @"Em²", SquareMetre, 1E+18, 0.0);
          PetaSquareMetre = new ScaledUnit(@"PetaSquareMetre", @"Pm²", SquareMetre, 1E+15, 0.0);
          TeraSquareMetre = new ScaledUnit(@"TeraSquareMetre", @"Tm²", SquareMetre, 1000000000000, 0.0);
          GigaSquareMetre = new ScaledUnit(@"GigaSquareMetre", @"Gm²", SquareMetre, 1000000000, 0.0);
          MegaSquareMetre = new ScaledUnit(@"MegaSquareMetre", @"Mm²", SquareMetre, 1000000, 0.0);
          KiloSquareMetre = new ScaledUnit(@"KiloSquareMetre", @"km²", SquareMetre, 1000, 0.0);
          HectoSquareMetre = new ScaledUnit(@"HectoSquareMetre", @"hm²", SquareMetre, 100, 0.0);
          DecaSquareMetre = new ScaledUnit(@"DecaSquareMetre", @"dam²", SquareMetre, 10, 0.0);
          DeciSquareMetre = new ScaledUnit(@"DeciSquareMetre", @"dm²", SquareMetre, 0.1, 0.0);
          CentiSquareMetre = new ScaledUnit(@"CentiSquareMetre", @"cm²", SquareMetre, 0.01, 0.0);
          MilliSquareMetre = new ScaledUnit(@"MilliSquareMetre", @"mm²", SquareMetre, 0.001, 0.0);
          MicroSquareMetre = new ScaledUnit(@"MicroSquareMetre", @"µm²", SquareMetre, 1E-06, 0.0);
          NanoSquareMetre = new ScaledUnit(@"NanoSquareMetre", @"nm²", SquareMetre, 1E-09, 0.0);
          PicoSquareMetre = new ScaledUnit(@"PicoSquareMetre", @"pm²", SquareMetre, 1E-12, 0.0);
          FemtoSquareMetre = new ScaledUnit(@"FemtoSquareMetre", @"fm²", SquareMetre, 1E-15, 0.0);
          AttoSquareMetre = new ScaledUnit(@"AttoSquareMetre", @"am²", SquareMetre, 1E-18, 0.0);
          ZeptoSquareMetre = new ScaledUnit(@"ZeptoSquareMetre", @"zm²", SquareMetre, 1E-21, 0.0);
          YoctoSquareMetre = new ScaledUnit(@"YoctoSquareMetre", @"ym²", SquareMetre, 1E-24, 0.0);
          Are = new ScaledUnit(@"Are", @"a", SquareMetre, 100, 0);
          Centiare = new ScaledUnit(@"Centiare", @"ca", SquareMetre, 1, 0);
          Decare = new ScaledUnit(@"Decare", @"daa", Are, 10, 0);
          Hectare = new ScaledUnit(@"Hectare", @"ha", Are, 100, 0);
          SquareKilometre = new ScaledUnit(@"SquareKilometre", @"km²", SquareMetre, 1000000, 0);
          SquareCentimetre = new ScaledUnit(@"SquareCentimetre", @"cm²", SquareMetre, 0.0001, 0);
          SquareMillimetre = new ScaledUnit(@"SquareMillimetre", @"mm²", SquareMetre, 1E-06, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { SquareMetre.Name, SquareMetre },
            { YottaSquareMetre.Name, YottaSquareMetre },
            { ZettaSquareMetre.Name, ZettaSquareMetre },
            { ExaSquareMetre.Name, ExaSquareMetre },
            { PetaSquareMetre.Name, PetaSquareMetre },
            { TeraSquareMetre.Name, TeraSquareMetre },
            { GigaSquareMetre.Name, GigaSquareMetre },
            { MegaSquareMetre.Name, MegaSquareMetre },
            { KiloSquareMetre.Name, KiloSquareMetre },
            { HectoSquareMetre.Name, HectoSquareMetre },
            { DecaSquareMetre.Name, DecaSquareMetre },
            { DeciSquareMetre.Name, DeciSquareMetre },
            { CentiSquareMetre.Name, CentiSquareMetre },
            { MilliSquareMetre.Name, MilliSquareMetre },
            { MicroSquareMetre.Name, MicroSquareMetre },
            { NanoSquareMetre.Name, NanoSquareMetre },
            { PicoSquareMetre.Name, PicoSquareMetre },
            { FemtoSquareMetre.Name, FemtoSquareMetre },
            { AttoSquareMetre.Name, AttoSquareMetre },
            { ZeptoSquareMetre.Name, ZeptoSquareMetre },
            { YoctoSquareMetre.Name, YoctoSquareMetre },
            { Are.Name, Are },
            { Centiare.Name, Centiare },
            { Decare.Name, Decare },
            { Hectare.Name, Hectare },
            { SquareKilometre.Name, SquareKilometre },
            { SquareCentimetre.Name, SquareCentimetre },
            { SquareMillimetre.Name, SquareMillimetre },
          };
        }

        static Area()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
