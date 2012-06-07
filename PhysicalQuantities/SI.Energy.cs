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
      public static partial class Energy
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Joule
        /// </summary>
        public static BaseUnit Joule { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaJoule { get; private set; }
        public static ScaledUnit ZettaJoule { get; private set; }
        public static ScaledUnit ExaJoule { get; private set; }
        public static ScaledUnit PetaJoule { get; private set; }
        public static ScaledUnit TeraJoule { get; private set; }
        public static ScaledUnit GigaJoule { get; private set; }
        public static ScaledUnit MegaJoule { get; private set; }
        public static ScaledUnit KiloJoule { get; private set; }
        public static ScaledUnit HectoJoule { get; private set; }
        public static ScaledUnit DecaJoule { get; private set; }
        public static ScaledUnit DeciJoule { get; private set; }
        public static ScaledUnit CentiJoule { get; private set; }
        public static ScaledUnit MilliJoule { get; private set; }
        public static ScaledUnit MicroJoule { get; private set; }
        public static ScaledUnit NanoJoule { get; private set; }
        public static ScaledUnit PicoJoule { get; private set; }
        public static ScaledUnit FemtoJoule { get; private set; }
        public static ScaledUnit AttoJoule { get; private set; }
        public static ScaledUnit ZeptoJoule { get; private set; }
        public static ScaledUnit YoctoJoule { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit Electronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit MilliElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit KiloElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit MegaElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit GigaElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit TeraElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Electron-volt
        /// </summary>
        public static ScaledUnit PetaElectronvolt { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Bevatron
        /// </summary>
        public static ScaledUnit Bevatron { get; private set; }

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
          Joule = new BaseUnit(@"Joule", @"J", PhysicalQuantities.Quantities.Energy, unitSystem);
          YottaJoule = new ScaledUnit(@"YottaJoule", @"YJ", Joule, 1E+24, 0.0);
          ZettaJoule = new ScaledUnit(@"ZettaJoule", @"ZJ", Joule, 1E+21, 0.0);
          ExaJoule = new ScaledUnit(@"ExaJoule", @"EJ", Joule, 1E+18, 0.0);
          PetaJoule = new ScaledUnit(@"PetaJoule", @"PJ", Joule, 1E+15, 0.0);
          TeraJoule = new ScaledUnit(@"TeraJoule", @"TJ", Joule, 1000000000000, 0.0);
          GigaJoule = new ScaledUnit(@"GigaJoule", @"GJ", Joule, 1000000000, 0.0);
          MegaJoule = new ScaledUnit(@"MegaJoule", @"MJ", Joule, 1000000, 0.0);
          KiloJoule = new ScaledUnit(@"KiloJoule", @"kJ", Joule, 1000, 0.0);
          HectoJoule = new ScaledUnit(@"HectoJoule", @"hJ", Joule, 100, 0.0);
          DecaJoule = new ScaledUnit(@"DecaJoule", @"daJ", Joule, 10, 0.0);
          DeciJoule = new ScaledUnit(@"DeciJoule", @"dJ", Joule, 0.1, 0.0);
          CentiJoule = new ScaledUnit(@"CentiJoule", @"cJ", Joule, 0.01, 0.0);
          MilliJoule = new ScaledUnit(@"MilliJoule", @"mJ", Joule, 0.001, 0.0);
          MicroJoule = new ScaledUnit(@"MicroJoule", @"µJ", Joule, 1E-06, 0.0);
          NanoJoule = new ScaledUnit(@"NanoJoule", @"nJ", Joule, 1E-09, 0.0);
          PicoJoule = new ScaledUnit(@"PicoJoule", @"pJ", Joule, 1E-12, 0.0);
          FemtoJoule = new ScaledUnit(@"FemtoJoule", @"fJ", Joule, 1E-15, 0.0);
          AttoJoule = new ScaledUnit(@"AttoJoule", @"aJ", Joule, 1E-18, 0.0);
          ZeptoJoule = new ScaledUnit(@"ZeptoJoule", @"zJ", Joule, 1E-21, 0.0);
          YoctoJoule = new ScaledUnit(@"YoctoJoule", @"yJ", Joule, 1E-24, 0.0);
          Electronvolt = new ScaledUnit(@"Electronvolt", @"eV", Joule, 1.602176487E-19, 0);
          MilliElectronvolt = new ScaledUnit(@"MilliElectronvolt", @"meV", Electronvolt, 0.001, 0);
          KiloElectronvolt = new ScaledUnit(@"KiloElectronvolt", @"keV", Electronvolt, 1000, 0);
          MegaElectronvolt = new ScaledUnit(@"MegaElectronvolt", @"MeV", Electronvolt, 1000000, 0);
          GigaElectronvolt = new ScaledUnit(@"GigaElectronvolt", @"GeV", Electronvolt, 1000000000, 0);
          TeraElectronvolt = new ScaledUnit(@"TeraElectronvolt", @"TeV", Electronvolt, 1000, 0);
          PetaElectronvolt = new ScaledUnit(@"PetaElectronvolt", @"PeV", Electronvolt, 1000, 0);
          Bevatron = new ScaledUnit(@"Bevatron", @"BeV", GigaElectronvolt, 1, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Joule.Name, Joule },
            { YottaJoule.Name, YottaJoule },
            { ZettaJoule.Name, ZettaJoule },
            { ExaJoule.Name, ExaJoule },
            { PetaJoule.Name, PetaJoule },
            { TeraJoule.Name, TeraJoule },
            { GigaJoule.Name, GigaJoule },
            { MegaJoule.Name, MegaJoule },
            { KiloJoule.Name, KiloJoule },
            { HectoJoule.Name, HectoJoule },
            { DecaJoule.Name, DecaJoule },
            { DeciJoule.Name, DeciJoule },
            { CentiJoule.Name, CentiJoule },
            { MilliJoule.Name, MilliJoule },
            { MicroJoule.Name, MicroJoule },
            { NanoJoule.Name, NanoJoule },
            { PicoJoule.Name, PicoJoule },
            { FemtoJoule.Name, FemtoJoule },
            { AttoJoule.Name, AttoJoule },
            { ZeptoJoule.Name, ZeptoJoule },
            { YoctoJoule.Name, YoctoJoule },
            { Electronvolt.Name, Electronvolt },
            { MilliElectronvolt.Name, MilliElectronvolt },
            { KiloElectronvolt.Name, KiloElectronvolt },
            { MegaElectronvolt.Name, MegaElectronvolt },
            { GigaElectronvolt.Name, GigaElectronvolt },
            { TeraElectronvolt.Name, TeraElectronvolt },
            { PetaElectronvolt.Name, PetaElectronvolt },
            { Bevatron.Name, Bevatron },
          };
        }

        static Energy()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
