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
      public static partial class HeatCapacity
      {
        public static BaseUnit JoulePerKelvin { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaJoulePerKelvin { get; private set; }
        public static ScaledUnit ZettaJoulePerKelvin { get; private set; }
        public static ScaledUnit ExaJoulePerKelvin { get; private set; }
        public static ScaledUnit PetaJoulePerKelvin { get; private set; }
        public static ScaledUnit TeraJoulePerKelvin { get; private set; }
        public static ScaledUnit GigaJoulePerKelvin { get; private set; }
        public static ScaledUnit MegaJoulePerKelvin { get; private set; }
        public static ScaledUnit KiloJoulePerKelvin { get; private set; }
        public static ScaledUnit HectoJoulePerKelvin { get; private set; }
        public static ScaledUnit DecaJoulePerKelvin { get; private set; }
        public static ScaledUnit DeciJoulePerKelvin { get; private set; }
        public static ScaledUnit CentiJoulePerKelvin { get; private set; }
        public static ScaledUnit MilliJoulePerKelvin { get; private set; }
        public static ScaledUnit MicroJoulePerKelvin { get; private set; }
        public static ScaledUnit NanoJoulePerKelvin { get; private set; }
        public static ScaledUnit PicoJoulePerKelvin { get; private set; }
        public static ScaledUnit FemtoJoulePerKelvin { get; private set; }
        public static ScaledUnit AttoJoulePerKelvin { get; private set; }
        public static ScaledUnit ZeptoJoulePerKelvin { get; private set; }
        public static ScaledUnit YoctoJoulePerKelvin { get; private set; }

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
          JoulePerKelvin = new BaseUnit(@"JoulePerKelvin", @"J/K", PhysicalQuantities.Quantities.HeatCapacity, unitSystem) { Caption = @"joule por segundo" };
          YottaJoulePerKelvin = new ScaledUnit(@"YottaJoulePerKelvin", @"YJ/K", JoulePerKelvin, 1E+24, 0.0) { Caption = @"yottajoule por segundo" };
          ZettaJoulePerKelvin = new ScaledUnit(@"ZettaJoulePerKelvin", @"ZJ/K", JoulePerKelvin, 1E+21, 0.0) { Caption = @"zettajoule por segundo" };
          ExaJoulePerKelvin = new ScaledUnit(@"ExaJoulePerKelvin", @"EJ/K", JoulePerKelvin, 1E+18, 0.0) { Caption = @"exajoule por segundo" };
          PetaJoulePerKelvin = new ScaledUnit(@"PetaJoulePerKelvin", @"PJ/K", JoulePerKelvin, 1E+15, 0.0) { Caption = @"petajoule por segundo" };
          TeraJoulePerKelvin = new ScaledUnit(@"TeraJoulePerKelvin", @"TJ/K", JoulePerKelvin, 1000000000000, 0.0) { Caption = @"terajoule por segundo" };
          GigaJoulePerKelvin = new ScaledUnit(@"GigaJoulePerKelvin", @"GJ/K", JoulePerKelvin, 1000000000, 0.0) { Caption = @"gigajoule por segundo" };
          MegaJoulePerKelvin = new ScaledUnit(@"MegaJoulePerKelvin", @"MJ/K", JoulePerKelvin, 1000000, 0.0) { Caption = @"megajoule por segundo" };
          KiloJoulePerKelvin = new ScaledUnit(@"KiloJoulePerKelvin", @"kJ/K", JoulePerKelvin, 1000, 0.0) { Caption = @"kilojoule por segundo" };
          HectoJoulePerKelvin = new ScaledUnit(@"HectoJoulePerKelvin", @"hJ/K", JoulePerKelvin, 100, 0.0) { Caption = @"hectojoule por segundo" };
          DecaJoulePerKelvin = new ScaledUnit(@"DecaJoulePerKelvin", @"daJ/K", JoulePerKelvin, 10, 0.0) { Caption = @"decajoule por segundo" };
          DeciJoulePerKelvin = new ScaledUnit(@"DeciJoulePerKelvin", @"dJ/K", JoulePerKelvin, 0.1, 0.0) { Caption = @"decijoule por segundo" };
          CentiJoulePerKelvin = new ScaledUnit(@"CentiJoulePerKelvin", @"cJ/K", JoulePerKelvin, 0.01, 0.0) { Caption = @"centijoule por segundo" };
          MilliJoulePerKelvin = new ScaledUnit(@"MilliJoulePerKelvin", @"mJ/K", JoulePerKelvin, 0.001, 0.0) { Caption = @"milijoule por segundo" };
          MicroJoulePerKelvin = new ScaledUnit(@"MicroJoulePerKelvin", @"μJ/K", JoulePerKelvin, 1E-06, 0.0) { Caption = @"microjoule por segundo" };
          NanoJoulePerKelvin = new ScaledUnit(@"NanoJoulePerKelvin", @"nJ/K", JoulePerKelvin, 1E-09, 0.0) { Caption = @"nanojoule por segundo" };
          PicoJoulePerKelvin = new ScaledUnit(@"PicoJoulePerKelvin", @"pJ/K", JoulePerKelvin, 1E-12, 0.0) { Caption = @"picojoule por segundo" };
          FemtoJoulePerKelvin = new ScaledUnit(@"FemtoJoulePerKelvin", @"fJ/K", JoulePerKelvin, 1E-15, 0.0) { Caption = @"femtojoule por segundo" };
          AttoJoulePerKelvin = new ScaledUnit(@"AttoJoulePerKelvin", @"aJ/K", JoulePerKelvin, 1E-18, 0.0) { Caption = @"attojoule por segundo" };
          ZeptoJoulePerKelvin = new ScaledUnit(@"ZeptoJoulePerKelvin", @"zJ/K", JoulePerKelvin, 1E-21, 0.0) { Caption = @"zeptojoule por segundo" };
          YoctoJoulePerKelvin = new ScaledUnit(@"YoctoJoulePerKelvin", @"yJ/K", JoulePerKelvin, 1E-24, 0.0) { Caption = @"yoctojoule por segundo" };

          allUnits = new Dictionary<string, Unit>
          {
            { JoulePerKelvin.Name, JoulePerKelvin },
            { YottaJoulePerKelvin.Name, YottaJoulePerKelvin },
            { ZettaJoulePerKelvin.Name, ZettaJoulePerKelvin },
            { ExaJoulePerKelvin.Name, ExaJoulePerKelvin },
            { PetaJoulePerKelvin.Name, PetaJoulePerKelvin },
            { TeraJoulePerKelvin.Name, TeraJoulePerKelvin },
            { GigaJoulePerKelvin.Name, GigaJoulePerKelvin },
            { MegaJoulePerKelvin.Name, MegaJoulePerKelvin },
            { KiloJoulePerKelvin.Name, KiloJoulePerKelvin },
            { HectoJoulePerKelvin.Name, HectoJoulePerKelvin },
            { DecaJoulePerKelvin.Name, DecaJoulePerKelvin },
            { DeciJoulePerKelvin.Name, DeciJoulePerKelvin },
            { CentiJoulePerKelvin.Name, CentiJoulePerKelvin },
            { MilliJoulePerKelvin.Name, MilliJoulePerKelvin },
            { MicroJoulePerKelvin.Name, MicroJoulePerKelvin },
            { NanoJoulePerKelvin.Name, NanoJoulePerKelvin },
            { PicoJoulePerKelvin.Name, PicoJoulePerKelvin },
            { FemtoJoulePerKelvin.Name, FemtoJoulePerKelvin },
            { AttoJoulePerKelvin.Name, AttoJoulePerKelvin },
            { ZeptoJoulePerKelvin.Name, ZeptoJoulePerKelvin },
            { YoctoJoulePerKelvin.Name, YoctoJoulePerKelvin },
          };
        }

        static HeatCapacity()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
