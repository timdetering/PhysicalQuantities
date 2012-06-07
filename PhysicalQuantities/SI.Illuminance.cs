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
      public static partial class Illuminance
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Lux
        /// </summary>
        public static BaseUnit Lux { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaLux { get; private set; }
        public static ScaledUnit ZettaLux { get; private set; }
        public static ScaledUnit ExaLux { get; private set; }
        public static ScaledUnit PetaLux { get; private set; }
        public static ScaledUnit TeraLux { get; private set; }
        public static ScaledUnit GigaLux { get; private set; }
        public static ScaledUnit MegaLux { get; private set; }
        public static ScaledUnit KiloLux { get; private set; }
        public static ScaledUnit HectoLux { get; private set; }
        public static ScaledUnit DecaLux { get; private set; }
        public static ScaledUnit DeciLux { get; private set; }
        public static ScaledUnit CentiLux { get; private set; }
        public static ScaledUnit MilliLux { get; private set; }
        public static ScaledUnit MicroLux { get; private set; }
        public static ScaledUnit NanoLux { get; private set; }
        public static ScaledUnit PicoLux { get; private set; }
        public static ScaledUnit FemtoLux { get; private set; }
        public static ScaledUnit AttoLux { get; private set; }
        public static ScaledUnit ZeptoLux { get; private set; }
        public static ScaledUnit YoctoLux { get; private set; }

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
          Lux = new BaseUnit(@"Lux", @"lx", PhysicalQuantities.Quantities.Illuminance, unitSystem);
          YottaLux = new ScaledUnit(@"YottaLux", @"Ylx", Lux, 1E+24, 0.0);
          ZettaLux = new ScaledUnit(@"ZettaLux", @"Zlx", Lux, 1E+21, 0.0);
          ExaLux = new ScaledUnit(@"ExaLux", @"Elx", Lux, 1E+18, 0.0);
          PetaLux = new ScaledUnit(@"PetaLux", @"Plx", Lux, 1E+15, 0.0);
          TeraLux = new ScaledUnit(@"TeraLux", @"Tlx", Lux, 1000000000000, 0.0);
          GigaLux = new ScaledUnit(@"GigaLux", @"Glx", Lux, 1000000000, 0.0);
          MegaLux = new ScaledUnit(@"MegaLux", @"Mlx", Lux, 1000000, 0.0);
          KiloLux = new ScaledUnit(@"KiloLux", @"klx", Lux, 1000, 0.0);
          HectoLux = new ScaledUnit(@"HectoLux", @"hlx", Lux, 100, 0.0);
          DecaLux = new ScaledUnit(@"DecaLux", @"dalx", Lux, 10, 0.0);
          DeciLux = new ScaledUnit(@"DeciLux", @"dlx", Lux, 0.1, 0.0);
          CentiLux = new ScaledUnit(@"CentiLux", @"clx", Lux, 0.01, 0.0);
          MilliLux = new ScaledUnit(@"MilliLux", @"mlx", Lux, 0.001, 0.0);
          MicroLux = new ScaledUnit(@"MicroLux", @"µlx", Lux, 1E-06, 0.0);
          NanoLux = new ScaledUnit(@"NanoLux", @"nlx", Lux, 1E-09, 0.0);
          PicoLux = new ScaledUnit(@"PicoLux", @"plx", Lux, 1E-12, 0.0);
          FemtoLux = new ScaledUnit(@"FemtoLux", @"flx", Lux, 1E-15, 0.0);
          AttoLux = new ScaledUnit(@"AttoLux", @"alx", Lux, 1E-18, 0.0);
          ZeptoLux = new ScaledUnit(@"ZeptoLux", @"zlx", Lux, 1E-21, 0.0);
          YoctoLux = new ScaledUnit(@"YoctoLux", @"ylx", Lux, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { Lux.Name, Lux },
            { YottaLux.Name, YottaLux },
            { ZettaLux.Name, ZettaLux },
            { ExaLux.Name, ExaLux },
            { PetaLux.Name, PetaLux },
            { TeraLux.Name, TeraLux },
            { GigaLux.Name, GigaLux },
            { MegaLux.Name, MegaLux },
            { KiloLux.Name, KiloLux },
            { HectoLux.Name, HectoLux },
            { DecaLux.Name, DecaLux },
            { DeciLux.Name, DeciLux },
            { CentiLux.Name, CentiLux },
            { MilliLux.Name, MilliLux },
            { MicroLux.Name, MicroLux },
            { NanoLux.Name, NanoLux },
            { PicoLux.Name, PicoLux },
            { FemtoLux.Name, FemtoLux },
            { AttoLux.Name, AttoLux },
            { ZeptoLux.Name, ZeptoLux },
            { YoctoLux.Name, YoctoLux },
          };
        }

        static Illuminance()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
