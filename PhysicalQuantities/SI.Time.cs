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
      public static partial class Time
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Second
        /// </summary>
        public static BaseUnit Second { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaSecond { get; private set; }
        public static ScaledUnit ZettaSecond { get; private set; }
        public static ScaledUnit ExaSecond { get; private set; }
        public static ScaledUnit PetaSecond { get; private set; }
        public static ScaledUnit TeraSecond { get; private set; }
        public static ScaledUnit GigaSecond { get; private set; }
        public static ScaledUnit MegaSecond { get; private set; }
        public static ScaledUnit KiloSecond { get; private set; }
        public static ScaledUnit HectoSecond { get; private set; }
        public static ScaledUnit DecaSecond { get; private set; }
        public static ScaledUnit DeciSecond { get; private set; }
        public static ScaledUnit CentiSecond { get; private set; }
        public static ScaledUnit MilliSecond { get; private set; }
        public static ScaledUnit MicroSecond { get; private set; }
        public static ScaledUnit NanoSecond { get; private set; }
        public static ScaledUnit PicoSecond { get; private set; }
        public static ScaledUnit FemtoSecond { get; private set; }
        public static ScaledUnit AttoSecond { get; private set; }
        public static ScaledUnit ZeptoSecond { get; private set; }
        public static ScaledUnit YoctoSecond { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Minute
        /// </summary>
        public static ScaledUnit Minute { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Hour
        /// </summary>
        public static ScaledUnit Hour { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Day
        /// </summary>
        public static ScaledUnit Day { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Unit_of_time
        /// </summary>
        public static ScaledUnit NaturalUnitOfTime { get; private set; }

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
          Second = new BaseUnit(@"Second", @"s", PhysicalQuantities.Quantities.Time, unitSystem);
          YottaSecond = new ScaledUnit(@"YottaSecond", @"Ys", Second, 1E+24, 0.0);
          ZettaSecond = new ScaledUnit(@"ZettaSecond", @"Zs", Second, 1E+21, 0.0);
          ExaSecond = new ScaledUnit(@"ExaSecond", @"Es", Second, 1E+18, 0.0);
          PetaSecond = new ScaledUnit(@"PetaSecond", @"Ps", Second, 1E+15, 0.0);
          TeraSecond = new ScaledUnit(@"TeraSecond", @"Ts", Second, 1000000000000, 0.0);
          GigaSecond = new ScaledUnit(@"GigaSecond", @"Gs", Second, 1000000000, 0.0);
          MegaSecond = new ScaledUnit(@"MegaSecond", @"Ms", Second, 1000000, 0.0);
          KiloSecond = new ScaledUnit(@"KiloSecond", @"ks", Second, 1000, 0.0);
          HectoSecond = new ScaledUnit(@"HectoSecond", @"hs", Second, 100, 0.0);
          DecaSecond = new ScaledUnit(@"DecaSecond", @"das", Second, 10, 0.0);
          DeciSecond = new ScaledUnit(@"DeciSecond", @"ds", Second, 0.1, 0.0);
          CentiSecond = new ScaledUnit(@"CentiSecond", @"cs", Second, 0.01, 0.0);
          MilliSecond = new ScaledUnit(@"MilliSecond", @"ms", Second, 0.001, 0.0);
          MicroSecond = new ScaledUnit(@"MicroSecond", @"µs", Second, 1E-06, 0.0);
          NanoSecond = new ScaledUnit(@"NanoSecond", @"ns", Second, 1E-09, 0.0);
          PicoSecond = new ScaledUnit(@"PicoSecond", @"ps", Second, 1E-12, 0.0);
          FemtoSecond = new ScaledUnit(@"FemtoSecond", @"fs", Second, 1E-15, 0.0);
          AttoSecond = new ScaledUnit(@"AttoSecond", @"as", Second, 1E-18, 0.0);
          ZeptoSecond = new ScaledUnit(@"ZeptoSecond", @"zs", Second, 1E-21, 0.0);
          YoctoSecond = new ScaledUnit(@"YoctoSecond", @"ys", Second, 1E-24, 0.0);
          Minute = new ScaledUnit(@"Minute", @"min", Second, 60, 0);
          Hour = new ScaledUnit(@"Hour", @"hr", Minute, 60, 0);
          Day = new ScaledUnit(@"Day", @"d", Hour, 24, 0);
          NaturalUnitOfTime = new ScaledUnit(@"NaturalUnitOfTime", null, Second, 1.288088667786E-21, 0);

          allUnits = new Dictionary<string, Unit>
          {
            { Second.Name, Second },
            { YottaSecond.Name, YottaSecond },
            { ZettaSecond.Name, ZettaSecond },
            { ExaSecond.Name, ExaSecond },
            { PetaSecond.Name, PetaSecond },
            { TeraSecond.Name, TeraSecond },
            { GigaSecond.Name, GigaSecond },
            { MegaSecond.Name, MegaSecond },
            { KiloSecond.Name, KiloSecond },
            { HectoSecond.Name, HectoSecond },
            { DecaSecond.Name, DecaSecond },
            { DeciSecond.Name, DeciSecond },
            { CentiSecond.Name, CentiSecond },
            { MilliSecond.Name, MilliSecond },
            { MicroSecond.Name, MicroSecond },
            { NanoSecond.Name, NanoSecond },
            { PicoSecond.Name, PicoSecond },
            { FemtoSecond.Name, FemtoSecond },
            { AttoSecond.Name, AttoSecond },
            { ZeptoSecond.Name, ZeptoSecond },
            { YoctoSecond.Name, YoctoSecond },
            { Minute.Name, Minute },
            { Hour.Name, Hour },
            { Day.Name, Day },
            { NaturalUnitOfTime.Name, NaturalUnitOfTime },
          };
        }

        static Time()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
