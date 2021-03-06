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
      public static partial class ElectricCharge
      {
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Coulomb
        /// </summary>
        public static BaseUnit Coulomb { get; private set; }
        // Prefix Table: ISUPrefixes
        public static ScaledUnit YottaCoulomb { get; private set; }
        public static ScaledUnit ZettaCoulomb { get; private set; }
        public static ScaledUnit ExaCoulomb { get; private set; }
        public static ScaledUnit PetaCoulomb { get; private set; }
        public static ScaledUnit TeraCoulomb { get; private set; }
        public static ScaledUnit GigaCoulomb { get; private set; }
        public static ScaledUnit MegaCoulomb { get; private set; }
        public static ScaledUnit KiloCoulomb { get; private set; }
        public static ScaledUnit HectoCoulomb { get; private set; }
        public static ScaledUnit DecaCoulomb { get; private set; }
        public static ScaledUnit DeciCoulomb { get; private set; }
        public static ScaledUnit CentiCoulomb { get; private set; }
        public static ScaledUnit MilliCoulomb { get; private set; }
        public static ScaledUnit MicroCoulomb { get; private set; }
        public static ScaledUnit NanoCoulomb { get; private set; }
        public static ScaledUnit PicoCoulomb { get; private set; }
        public static ScaledUnit FemtoCoulomb { get; private set; }
        public static ScaledUnit AttoCoulomb { get; private set; }
        public static ScaledUnit ZeptoCoulomb { get; private set; }
        public static ScaledUnit YoctoCoulomb { get; private set; }
        /// <summary>
        /// Reference: http://en.wikipedia.org/wiki/Elementary_charge
        /// </summary>
        public static ScaledUnit ElementaryCharge { get; private set; }

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
          Coulomb = new BaseUnit(@"Coulomb", @"C", PhysicalQuantities.Quantities.ElectricCharge, unitSystem) { Caption = @"culombio" };
          YottaCoulomb = new ScaledUnit(@"YottaCoulomb", @"YC", Coulomb, 1E+24, 0.0) { Caption = @"yottaculombio" };
          ZettaCoulomb = new ScaledUnit(@"ZettaCoulomb", @"ZC", Coulomb, 1E+21, 0.0) { Caption = @"zettaculombio" };
          ExaCoulomb = new ScaledUnit(@"ExaCoulomb", @"EC", Coulomb, 1E+18, 0.0) { Caption = @"exaculombio" };
          PetaCoulomb = new ScaledUnit(@"PetaCoulomb", @"PC", Coulomb, 1E+15, 0.0) { Caption = @"petaculombio" };
          TeraCoulomb = new ScaledUnit(@"TeraCoulomb", @"TC", Coulomb, 1000000000000, 0.0) { Caption = @"teraculombio" };
          GigaCoulomb = new ScaledUnit(@"GigaCoulomb", @"GC", Coulomb, 1000000000, 0.0) { Caption = @"gigaculombio" };
          MegaCoulomb = new ScaledUnit(@"MegaCoulomb", @"MC", Coulomb, 1000000, 0.0) { Caption = @"megaculombio" };
          KiloCoulomb = new ScaledUnit(@"KiloCoulomb", @"kC", Coulomb, 1000, 0.0) { Caption = @"kiloculombio" };
          HectoCoulomb = new ScaledUnit(@"HectoCoulomb", @"hC", Coulomb, 100, 0.0) { Caption = @"hectoculombio" };
          DecaCoulomb = new ScaledUnit(@"DecaCoulomb", @"daC", Coulomb, 10, 0.0) { Caption = @"decaculombio" };
          DeciCoulomb = new ScaledUnit(@"DeciCoulomb", @"dC", Coulomb, 0.1, 0.0) { Caption = @"deciculombio" };
          CentiCoulomb = new ScaledUnit(@"CentiCoulomb", @"cC", Coulomb, 0.01, 0.0) { Caption = @"centiculombio" };
          MilliCoulomb = new ScaledUnit(@"MilliCoulomb", @"mC", Coulomb, 0.001, 0.0) { Caption = @"miliculombio" };
          MicroCoulomb = new ScaledUnit(@"MicroCoulomb", @"μC", Coulomb, 1E-06, 0.0) { Caption = @"microculombio" };
          NanoCoulomb = new ScaledUnit(@"NanoCoulomb", @"nC", Coulomb, 1E-09, 0.0) { Caption = @"nanoculombio" };
          PicoCoulomb = new ScaledUnit(@"PicoCoulomb", @"pC", Coulomb, 1E-12, 0.0) { Caption = @"picoculombio" };
          FemtoCoulomb = new ScaledUnit(@"FemtoCoulomb", @"fC", Coulomb, 1E-15, 0.0) { Caption = @"femtoculombio" };
          AttoCoulomb = new ScaledUnit(@"AttoCoulomb", @"aC", Coulomb, 1E-18, 0.0) { Caption = @"attoculombio" };
          ZeptoCoulomb = new ScaledUnit(@"ZeptoCoulomb", @"zC", Coulomb, 1E-21, 0.0) { Caption = @"zeptoculombio" };
          YoctoCoulomb = new ScaledUnit(@"YoctoCoulomb", @"yC", Coulomb, 1E-24, 0.0) { Caption = @"yoctoculombio" };
          ElementaryCharge = new ScaledUnit(@"ElementaryCharge", @"e", Coulomb, 1.60217656535E-19, 0) { Caption = @"carga elemental" };

          allUnits = new Dictionary<string, Unit>
          {
            { Coulomb.Name, Coulomb },
            { YottaCoulomb.Name, YottaCoulomb },
            { ZettaCoulomb.Name, ZettaCoulomb },
            { ExaCoulomb.Name, ExaCoulomb },
            { PetaCoulomb.Name, PetaCoulomb },
            { TeraCoulomb.Name, TeraCoulomb },
            { GigaCoulomb.Name, GigaCoulomb },
            { MegaCoulomb.Name, MegaCoulomb },
            { KiloCoulomb.Name, KiloCoulomb },
            { HectoCoulomb.Name, HectoCoulomb },
            { DecaCoulomb.Name, DecaCoulomb },
            { DeciCoulomb.Name, DeciCoulomb },
            { CentiCoulomb.Name, CentiCoulomb },
            { MilliCoulomb.Name, MilliCoulomb },
            { MicroCoulomb.Name, MicroCoulomb },
            { NanoCoulomb.Name, NanoCoulomb },
            { PicoCoulomb.Name, PicoCoulomb },
            { FemtoCoulomb.Name, FemtoCoulomb },
            { AttoCoulomb.Name, AttoCoulomb },
            { ZeptoCoulomb.Name, ZeptoCoulomb },
            { YoctoCoulomb.Name, YoctoCoulomb },
            { ElementaryCharge.Name, ElementaryCharge },
          };
        }

        static ElectricCharge()
        {
          var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
        }
      }
    }
  }
}
