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
      public static partial class LuminousFlux
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Lumen_(unit)
        /// </summary>
        public static BaseUnit Lumen { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaLumen { get; private set; }
        public static ScaledUnit ZettaLumen { get; private set; }
        public static ScaledUnit ExaLumen { get; private set; }
        public static ScaledUnit PetaLumen { get; private set; }
        public static ScaledUnit TeraLumen { get; private set; }
        public static ScaledUnit GigaLumen { get; private set; }
        public static ScaledUnit MegaLumen { get; private set; }
        public static ScaledUnit KiloLumen { get; private set; }
        public static ScaledUnit HectoLumen { get; private set; }
        public static ScaledUnit DecaLumen { get; private set; }
        public static ScaledUnit DeciLumen { get; private set; }
        public static ScaledUnit CentiLumen { get; private set; }
        public static ScaledUnit MilliLumen { get; private set; }
        public static ScaledUnit MicroLumen { get; private set; }
        public static ScaledUnit NanoLumen { get; private set; }
        public static ScaledUnit PicoLumen { get; private set; }
        public static ScaledUnit FemtoLumen { get; private set; }
        public static ScaledUnit AttoLumen { get; private set; }
        public static ScaledUnit ZeptoLumen { get; private set; }
        public static ScaledUnit YoctoLumen { get; private set; }

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
          Lumen = new BaseUnit(@"Lumen", @"lm", PhysicalQuantities.Quantities.LuminousFlux, unitSystem);
          YottaLumen = new ScaledUnit(@"YottaLumen", @"Ylm", Lumen, 1E+24, 0.0);
          ZettaLumen = new ScaledUnit(@"ZettaLumen", @"Zlm", Lumen, 1E+21, 0.0);
          ExaLumen = new ScaledUnit(@"ExaLumen", @"Elm", Lumen, 1E+18, 0.0);
          PetaLumen = new ScaledUnit(@"PetaLumen", @"Plm", Lumen, 1E+15, 0.0);
          TeraLumen = new ScaledUnit(@"TeraLumen", @"Tlm", Lumen, 1000000000000, 0.0);
          GigaLumen = new ScaledUnit(@"GigaLumen", @"Glm", Lumen, 1000000000, 0.0);
          MegaLumen = new ScaledUnit(@"MegaLumen", @"Mlm", Lumen, 1000000, 0.0);
          KiloLumen = new ScaledUnit(@"KiloLumen", @"klm", Lumen, 1000, 0.0);
          HectoLumen = new ScaledUnit(@"HectoLumen", @"hlm", Lumen, 100, 0.0);
          DecaLumen = new ScaledUnit(@"DecaLumen", @"dalm", Lumen, 10, 0.0);
          DeciLumen = new ScaledUnit(@"DeciLumen", @"dlm", Lumen, 0.1, 0.0);
          CentiLumen = new ScaledUnit(@"CentiLumen", @"clm", Lumen, 0.01, 0.0);
          MilliLumen = new ScaledUnit(@"MilliLumen", @"mlm", Lumen, 0.001, 0.0);
          MicroLumen = new ScaledUnit(@"MicroLumen", @"µlm", Lumen, 1E-06, 0.0);
          NanoLumen = new ScaledUnit(@"NanoLumen", @"nlm", Lumen, 1E-09, 0.0);
          PicoLumen = new ScaledUnit(@"PicoLumen", @"plm", Lumen, 1E-12, 0.0);
          FemtoLumen = new ScaledUnit(@"FemtoLumen", @"flm", Lumen, 1E-15, 0.0);
          AttoLumen = new ScaledUnit(@"AttoLumen", @"alm", Lumen, 1E-18, 0.0);
          ZeptoLumen = new ScaledUnit(@"ZeptoLumen", @"zlm", Lumen, 1E-21, 0.0);
          YoctoLumen = new ScaledUnit(@"YoctoLumen", @"ylm", Lumen, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Lumen.Name, Lumen },
            { YottaLumen.Name, YottaLumen },
            { ZettaLumen.Name, ZettaLumen },
            { ExaLumen.Name, ExaLumen },
            { PetaLumen.Name, PetaLumen },
            { TeraLumen.Name, TeraLumen },
            { GigaLumen.Name, GigaLumen },
            { MegaLumen.Name, MegaLumen },
            { KiloLumen.Name, KiloLumen },
            { HectoLumen.Name, HectoLumen },
            { DecaLumen.Name, DecaLumen },
            { DeciLumen.Name, DeciLumen },
            { CentiLumen.Name, CentiLumen },
            { MilliLumen.Name, MilliLumen },
            { MicroLumen.Name, MicroLumen },
            { NanoLumen.Name, NanoLumen },
            { PicoLumen.Name, PicoLumen },
            { FemtoLumen.Name, FemtoLumen },
            { AttoLumen.Name, AttoLumen },
            { ZeptoLumen.Name, ZeptoLumen },
            { YoctoLumen.Name, YoctoLumen },
          };
        }

        static LuminousFlux()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
