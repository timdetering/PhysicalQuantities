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
      public static partial class Wavenumber
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Reciprocal_metre
        /// </summary>
        public static BaseUnit ReciprocalMetre { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaReciprocalMetre { get; private set; }
        public static ScaledUnit ZettaReciprocalMetre { get; private set; }
        public static ScaledUnit ExaReciprocalMetre { get; private set; }
        public static ScaledUnit PetaReciprocalMetre { get; private set; }
        public static ScaledUnit TeraReciprocalMetre { get; private set; }
        public static ScaledUnit GigaReciprocalMetre { get; private set; }
        public static ScaledUnit MegaReciprocalMetre { get; private set; }
        public static ScaledUnit KiloReciprocalMetre { get; private set; }
        public static ScaledUnit HectoReciprocalMetre { get; private set; }
        public static ScaledUnit DecaReciprocalMetre { get; private set; }
        public static ScaledUnit DeciReciprocalMetre { get; private set; }
        public static ScaledUnit CentiReciprocalMetre { get; private set; }
        public static ScaledUnit MilliReciprocalMetre { get; private set; }
        public static ScaledUnit MicroReciprocalMetre { get; private set; }
        public static ScaledUnit NanoReciprocalMetre { get; private set; }
        public static ScaledUnit PicoReciprocalMetre { get; private set; }
        public static ScaledUnit FemtoReciprocalMetre { get; private set; }
        public static ScaledUnit AttoReciprocalMetre { get; private set; }
        public static ScaledUnit ZeptoReciprocalMetre { get; private set; }
        public static ScaledUnit YoctoReciprocalMetre { get; private set; }

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
          ReciprocalMetre = new BaseUnit(@"ReciprocalMetre", @"m-1", PhysicalQuantities.Quantities.Wavenumber, unitSystem);
          YottaReciprocalMetre = new ScaledUnit(@"YottaReciprocalMetre", @"Ym-1", ReciprocalMetre, 1E+24, 0.0);
          ZettaReciprocalMetre = new ScaledUnit(@"ZettaReciprocalMetre", @"Zm-1", ReciprocalMetre, 1E+21, 0.0);
          ExaReciprocalMetre = new ScaledUnit(@"ExaReciprocalMetre", @"Em-1", ReciprocalMetre, 1E+18, 0.0);
          PetaReciprocalMetre = new ScaledUnit(@"PetaReciprocalMetre", @"Pm-1", ReciprocalMetre, 1E+15, 0.0);
          TeraReciprocalMetre = new ScaledUnit(@"TeraReciprocalMetre", @"Tm-1", ReciprocalMetre, 1000000000000, 0.0);
          GigaReciprocalMetre = new ScaledUnit(@"GigaReciprocalMetre", @"Gm-1", ReciprocalMetre, 1000000000, 0.0);
          MegaReciprocalMetre = new ScaledUnit(@"MegaReciprocalMetre", @"Mm-1", ReciprocalMetre, 1000000, 0.0);
          KiloReciprocalMetre = new ScaledUnit(@"KiloReciprocalMetre", @"km-1", ReciprocalMetre, 1000, 0.0);
          HectoReciprocalMetre = new ScaledUnit(@"HectoReciprocalMetre", @"hm-1", ReciprocalMetre, 100, 0.0);
          DecaReciprocalMetre = new ScaledUnit(@"DecaReciprocalMetre", @"dam-1", ReciprocalMetre, 10, 0.0);
          DeciReciprocalMetre = new ScaledUnit(@"DeciReciprocalMetre", @"dm-1", ReciprocalMetre, 0.1, 0.0);
          CentiReciprocalMetre = new ScaledUnit(@"CentiReciprocalMetre", @"cm-1", ReciprocalMetre, 0.01, 0.0);
          MilliReciprocalMetre = new ScaledUnit(@"MilliReciprocalMetre", @"mm-1", ReciprocalMetre, 0.001, 0.0);
          MicroReciprocalMetre = new ScaledUnit(@"MicroReciprocalMetre", @"µm-1", ReciprocalMetre, 1E-06, 0.0);
          NanoReciprocalMetre = new ScaledUnit(@"NanoReciprocalMetre", @"nm-1", ReciprocalMetre, 1E-09, 0.0);
          PicoReciprocalMetre = new ScaledUnit(@"PicoReciprocalMetre", @"pm-1", ReciprocalMetre, 1E-12, 0.0);
          FemtoReciprocalMetre = new ScaledUnit(@"FemtoReciprocalMetre", @"fm-1", ReciprocalMetre, 1E-15, 0.0);
          AttoReciprocalMetre = new ScaledUnit(@"AttoReciprocalMetre", @"am-1", ReciprocalMetre, 1E-18, 0.0);
          ZeptoReciprocalMetre = new ScaledUnit(@"ZeptoReciprocalMetre", @"zm-1", ReciprocalMetre, 1E-21, 0.0);
          YoctoReciprocalMetre = new ScaledUnit(@"YoctoReciprocalMetre", @"ym-1", ReciprocalMetre, 1E-24, 0.0);

          allUnits = new Dictionary<string, Unit>
          {
            { ReciprocalMetre.Name, ReciprocalMetre },
            { YottaReciprocalMetre.Name, YottaReciprocalMetre },
            { ZettaReciprocalMetre.Name, ZettaReciprocalMetre },
            { ExaReciprocalMetre.Name, ExaReciprocalMetre },
            { PetaReciprocalMetre.Name, PetaReciprocalMetre },
            { TeraReciprocalMetre.Name, TeraReciprocalMetre },
            { GigaReciprocalMetre.Name, GigaReciprocalMetre },
            { MegaReciprocalMetre.Name, MegaReciprocalMetre },
            { KiloReciprocalMetre.Name, KiloReciprocalMetre },
            { HectoReciprocalMetre.Name, HectoReciprocalMetre },
            { DecaReciprocalMetre.Name, DecaReciprocalMetre },
            { DeciReciprocalMetre.Name, DeciReciprocalMetre },
            { CentiReciprocalMetre.Name, CentiReciprocalMetre },
            { MilliReciprocalMetre.Name, MilliReciprocalMetre },
            { MicroReciprocalMetre.Name, MicroReciprocalMetre },
            { NanoReciprocalMetre.Name, NanoReciprocalMetre },
            { PicoReciprocalMetre.Name, PicoReciprocalMetre },
            { FemtoReciprocalMetre.Name, FemtoReciprocalMetre },
            { AttoReciprocalMetre.Name, AttoReciprocalMetre },
            { ZeptoReciprocalMetre.Name, ZeptoReciprocalMetre },
            { YoctoReciprocalMetre.Name, YoctoReciprocalMetre },
          };
        }

        static Wavenumber()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
