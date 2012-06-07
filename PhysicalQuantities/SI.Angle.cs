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
      public static partial class Angle
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Radian
        /// </summary>
        public static BaseUnit Radian { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaRadian { get; private set; }
        public static ScaledUnit ZettaRadian { get; private set; }
        public static ScaledUnit ExaRadian { get; private set; }
        public static ScaledUnit PetaRadian { get; private set; }
        public static ScaledUnit TeraRadian { get; private set; }
        public static ScaledUnit GigaRadian { get; private set; }
        public static ScaledUnit MegaRadian { get; private set; }
        public static ScaledUnit KiloRadian { get; private set; }
        public static ScaledUnit HectoRadian { get; private set; }
        public static ScaledUnit DecaRadian { get; private set; }
        public static ScaledUnit DeciRadian { get; private set; }
        public static ScaledUnit CentiRadian { get; private set; }
        public static ScaledUnit MilliRadian { get; private set; }
        public static ScaledUnit MicroRadian { get; private set; }
        public static ScaledUnit NanoRadian { get; private set; }
        public static ScaledUnit PicoRadian { get; private set; }
        public static ScaledUnit FemtoRadian { get; private set; }
        public static ScaledUnit AttoRadian { get; private set; }
        public static ScaledUnit ZeptoRadian { get; private set; }
        public static ScaledUnit YoctoRadian { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Degree_(angle)
        /// </summary>
        public static ScaledUnit Degree { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcminute
        /// </summary>
        public static ScaledUnit Arcminute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond
        /// </summary>
        public static ScaledUnit Arcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Milliarcsecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Arcsecond#Symbols_and_abbreviations
        /// </summary>
        public static ScaledUnit Microarcsecond { get; private set; }

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
          Radian = new BaseUnit(@"Radian", @"rad", PhysicalQuantities.Quantities.Angle, unitSystem);
          YottaRadian = new ScaledUnit(@"YottaRadian", @"Yrad", Radian, 1E+24, 0.0);
          ZettaRadian = new ScaledUnit(@"ZettaRadian", @"Zrad", Radian, 1E+21, 0.0);
          ExaRadian = new ScaledUnit(@"ExaRadian", @"Erad", Radian, 1E+18, 0.0);
          PetaRadian = new ScaledUnit(@"PetaRadian", @"Prad", Radian, 1E+15, 0.0);
          TeraRadian = new ScaledUnit(@"TeraRadian", @"Trad", Radian, 1000000000000, 0.0);
          GigaRadian = new ScaledUnit(@"GigaRadian", @"Grad", Radian, 1000000000, 0.0);
          MegaRadian = new ScaledUnit(@"MegaRadian", @"Mrad", Radian, 1000000, 0.0);
          KiloRadian = new ScaledUnit(@"KiloRadian", @"krad", Radian, 1000, 0.0);
          HectoRadian = new ScaledUnit(@"HectoRadian", @"hrad", Radian, 100, 0.0);
          DecaRadian = new ScaledUnit(@"DecaRadian", @"darad", Radian, 10, 0.0);
          DeciRadian = new ScaledUnit(@"DeciRadian", @"drad", Radian, 0.1, 0.0);
          CentiRadian = new ScaledUnit(@"CentiRadian", @"crad", Radian, 0.01, 0.0);
          MilliRadian = new ScaledUnit(@"MilliRadian", @"mrad", Radian, 0.001, 0.0);
          MicroRadian = new ScaledUnit(@"MicroRadian", @"µrad", Radian, 1E-06, 0.0);
          NanoRadian = new ScaledUnit(@"NanoRadian", @"nrad", Radian, 1E-09, 0.0);
          PicoRadian = new ScaledUnit(@"PicoRadian", @"prad", Radian, 1E-12, 0.0);
          FemtoRadian = new ScaledUnit(@"FemtoRadian", @"frad", Radian, 1E-15, 0.0);
          AttoRadian = new ScaledUnit(@"AttoRadian", @"arad", Radian, 1E-18, 0.0);
          ZeptoRadian = new ScaledUnit(@"ZeptoRadian", @"zrad", Radian, 1E-21, 0.0);
          YoctoRadian = new ScaledUnit(@"YoctoRadian", @"yrad", Radian, 1E-24, 0.0);
          Degree = new ScaledUnit(@"Degree", @"°", Radian, 0.0174532925199433, 0);
          Arcminute = new ScaledUnit(@"Arcminute", @"'", Degree, 0.0166666666666667, 0);
          Arcsecond = new ScaledUnit(@"Arcsecond", @"""", Arcminute, 0.0166666666666667, 0);
          Milliarcsecond = new ScaledUnit(@"Milliarcsecond", @"mas", Arcsecond, 0.001, 0);
          Microarcsecond = new ScaledUnit(@"Microarcsecond", @"µas", Milliarcsecond, 0.001, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Radian.Name, Radian },
            { YottaRadian.Name, YottaRadian },
            { ZettaRadian.Name, ZettaRadian },
            { ExaRadian.Name, ExaRadian },
            { PetaRadian.Name, PetaRadian },
            { TeraRadian.Name, TeraRadian },
            { GigaRadian.Name, GigaRadian },
            { MegaRadian.Name, MegaRadian },
            { KiloRadian.Name, KiloRadian },
            { HectoRadian.Name, HectoRadian },
            { DecaRadian.Name, DecaRadian },
            { DeciRadian.Name, DeciRadian },
            { CentiRadian.Name, CentiRadian },
            { MilliRadian.Name, MilliRadian },
            { MicroRadian.Name, MicroRadian },
            { NanoRadian.Name, NanoRadian },
            { PicoRadian.Name, PicoRadian },
            { FemtoRadian.Name, FemtoRadian },
            { AttoRadian.Name, AttoRadian },
            { ZeptoRadian.Name, ZeptoRadian },
            { YoctoRadian.Name, YoctoRadian },
            { Degree.Name, Degree },
            { Arcminute.Name, Arcminute },
            { Arcsecond.Name, Arcsecond },
            { Milliarcsecond.Name, Milliarcsecond },
            { Microarcsecond.Name, Microarcsecond },
          };
        }

        static Angle()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
