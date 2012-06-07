using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  public static partial class UnitSystems
  {
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/International_System_of_Units
    /// </summary>
    public static partial class SI
    {
      public static UnitSystem UnitSystem { get; internal set; }


      #region [ Lookup ]
      private static Dictionary<string, Quantity> allQuantities;
      private static Dictionary<Quantity, Dictionary<string, Unit>> allUnits;
      public static Quantity GetQuantity(string quantityName)
      {
        Quantity result;
        if (allQuantities.TryGetValue(quantityName, out result))
          return result;
        return null;
      }
      public static Unit GetUnit(Quantity quantity, string unitName)
      {
        Dictionary<string, Unit> dict;
        Unit result;
        if (allUnits.TryGetValue(quantity, out dict))
          if (dict.TryGetValue(unitName, out result))
            return result;
        return null;
      }
      public static IEnumerable<Unit> AllQuantityUnits(Quantity quantity)
      {
        Dictionary<string, Unit> dict;
        if (allUnits.TryGetValue(quantity, out dict))
          return dict.Values;
        return Enumerable.Empty<Unit>();
      }
      public static IEnumerable<Unit> AllUnits
      {
        get
        {
          return allUnits.Values.SelectMany(d => d.Values);
        }
      }
      #endregion [ Lookup ]
	  
      internal static UnitSystem Create(UnitConversionTable ConversionTable)
      {
        var unitSystem = new UnitSystem(@"SI", ConversionTable);

        Dimensionless.Initialize(unitSystem);
        Length.Initialize(unitSystem);
        Mass.Initialize(unitSystem);
        Time.Initialize(unitSystem);
        Temperature.Initialize(unitSystem);
        Substance.Initialize(unitSystem);
        ElectricCurrent.Initialize(unitSystem);
        LuminousIntensity.Initialize(unitSystem);
        Frequency.Initialize(unitSystem);
        Angle.Initialize(unitSystem);
        SolidAngle.Initialize(unitSystem);
        Force.Initialize(unitSystem);
        Pressure.Initialize(unitSystem);
        Energy.Initialize(unitSystem);
        Power.Initialize(unitSystem);
        ElectricCharge.Initialize(unitSystem);
        Voltage.Initialize(unitSystem);
        ElectricCapacitance.Initialize(unitSystem);
        ElectricResistance.Initialize(unitSystem);
        ElectricConductance.Initialize(unitSystem);
        MagneticFlux.Initialize(unitSystem);
        MagneticField.Initialize(unitSystem);
        Inductance.Initialize(unitSystem);
        LuminousFlux.Initialize(unitSystem);
        Illuminance.Initialize(unitSystem);
        RadioactiveDecay.Initialize(unitSystem);
        AbsorbedDose.Initialize(unitSystem);
        EquivalentDose.Initialize(unitSystem);
        CatalyticActivity.Initialize(unitSystem);
        Area.Initialize(unitSystem);
        Volume.Initialize(unitSystem);
        Speed.Initialize(unitSystem);
        Acceleration.Initialize(unitSystem);
        VolumetricFlow.Initialize(unitSystem);
        Jerk.Initialize(unitSystem);
        Jounce.Initialize(unitSystem);
        AngularVelocity.Initialize(unitSystem);
        Momentum.Initialize(unitSystem);
        AngularMomentum.Initialize(unitSystem);
        Torque.Initialize(unitSystem);
        Yank.Initialize(unitSystem);
        Wavenumber.Initialize(unitSystem);
        AreaDensity.Initialize(unitSystem);
        Density.Initialize(unitSystem);
        SpecificVolume.Initialize(unitSystem);
        Action.Initialize(unitSystem);
        HeatCapacity.Initialize(unitSystem);
        NewtonianConstantOfGravitationQuantity.Initialize(unitSystem);

        allQuantities = new Dictionary<string, Quantity>
        {
          { @"Dimensionless", PhysicalQuantities.Quantities.Dimensionless },
          { @"Length", PhysicalQuantities.Quantities.Length },
          { @"Mass", PhysicalQuantities.Quantities.Mass },
          { @"Time", PhysicalQuantities.Quantities.Time },
          { @"Temperature", PhysicalQuantities.Quantities.Temperature },
          { @"Substance", PhysicalQuantities.Quantities.Substance },
          { @"ElectricCurrent", PhysicalQuantities.Quantities.ElectricCurrent },
          { @"LuminousIntensity", PhysicalQuantities.Quantities.LuminousIntensity },
          { @"Frequency", PhysicalQuantities.Quantities.Frequency },
          { @"Angle", PhysicalQuantities.Quantities.Angle },
          { @"SolidAngle", PhysicalQuantities.Quantities.SolidAngle },
          { @"Force", PhysicalQuantities.Quantities.Force },
          { @"Pressure", PhysicalQuantities.Quantities.Pressure },
          { @"Energy", PhysicalQuantities.Quantities.Energy },
          { @"Power", PhysicalQuantities.Quantities.Power },
          { @"ElectricCharge", PhysicalQuantities.Quantities.ElectricCharge },
          { @"Voltage", PhysicalQuantities.Quantities.Voltage },
          { @"ElectricCapacitance", PhysicalQuantities.Quantities.ElectricCapacitance },
          { @"ElectricResistance", PhysicalQuantities.Quantities.ElectricResistance },
          { @"ElectricConductance", PhysicalQuantities.Quantities.ElectricConductance },
          { @"MagneticFlux", PhysicalQuantities.Quantities.MagneticFlux },
          { @"MagneticField", PhysicalQuantities.Quantities.MagneticField },
          { @"Inductance", PhysicalQuantities.Quantities.Inductance },
          { @"LuminousFlux", PhysicalQuantities.Quantities.LuminousFlux },
          { @"Illuminance", PhysicalQuantities.Quantities.Illuminance },
          { @"RadioactiveDecay", PhysicalQuantities.Quantities.RadioactiveDecay },
          { @"AbsorbedDose", PhysicalQuantities.Quantities.AbsorbedDose },
          { @"EquivalentDose", PhysicalQuantities.Quantities.EquivalentDose },
          { @"CatalyticActivity", PhysicalQuantities.Quantities.CatalyticActivity },
          { @"Area", PhysicalQuantities.Quantities.Area },
          { @"Volume", PhysicalQuantities.Quantities.Volume },
          { @"Speed", PhysicalQuantities.Quantities.Speed },
          { @"Acceleration", PhysicalQuantities.Quantities.Acceleration },
          { @"VolumetricFlow", PhysicalQuantities.Quantities.VolumetricFlow },
          { @"Jerk", PhysicalQuantities.Quantities.Jerk },
          { @"Jounce", PhysicalQuantities.Quantities.Jounce },
          { @"AngularVelocity", PhysicalQuantities.Quantities.AngularVelocity },
          { @"Momentum", PhysicalQuantities.Quantities.Momentum },
          { @"AngularMomentum", PhysicalQuantities.Quantities.AngularMomentum },
          { @"Torque", PhysicalQuantities.Quantities.Torque },
          { @"Yank", PhysicalQuantities.Quantities.Yank },
          { @"Wavenumber", PhysicalQuantities.Quantities.Wavenumber },
          { @"AreaDensity", PhysicalQuantities.Quantities.AreaDensity },
          { @"Density", PhysicalQuantities.Quantities.Density },
          { @"SpecificVolume", PhysicalQuantities.Quantities.SpecificVolume },
          { @"Action", PhysicalQuantities.Quantities.Action },
          { @"HeatCapacity", PhysicalQuantities.Quantities.HeatCapacity },
          { @"NewtonianConstantOfGravitationQuantity", PhysicalQuantities.Quantities.NewtonianConstantOfGravitationQuantity },
        };

        allUnits = new Dictionary<Quantity, Dictionary<string, Unit>>(ReferenceEqualityComparer<Quantity>.Default)
        {
          { 
            PhysicalQuantities.Quantities.Dimensionless, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.Unity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.YottaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.YottaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.ZettaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.ZettaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.ExaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.ExaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.PetaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.PetaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.TeraUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.TeraUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.GigaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.GigaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.MegaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.MegaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.KiloUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.KiloUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.HectoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.HectoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.DecaUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.DecaUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.DeciUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.DeciUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.CentiUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.CentiUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.MilliUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.MilliUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.MicroUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.MicroUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.NanoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.NanoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.PicoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.PicoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.FemtoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.FemtoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.AttoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.AttoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.ZeptoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.ZeptoUnity },
              { PhysicalQuantities.UnitSystems.SI.Dimensionless.YoctoUnity.Name, PhysicalQuantities.UnitSystems.SI.Dimensionless.YoctoUnity },
            }
          },
          { 
            PhysicalQuantities.Quantities.Length, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Length.Metre.Name, PhysicalQuantities.UnitSystems.SI.Length.Metre },
              { PhysicalQuantities.UnitSystems.SI.Length.YottaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.YottaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.ZettaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.ZettaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.ExaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.ExaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.PetaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.PetaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.TeraMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.TeraMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.GigaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.GigaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.MegaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.MegaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.KiloMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.KiloMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.HectoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.HectoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.DecaMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.DecaMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.DeciMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.DeciMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.CentiMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.CentiMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.MilliMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.MilliMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.MicroMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.MicroMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.NanoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.NanoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.PicoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.PicoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.FemtoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.FemtoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.AttoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.AttoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.ZeptoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.ZeptoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.YoctoMetre.Name, PhysicalQuantities.UnitSystems.SI.Length.YoctoMetre },
              { PhysicalQuantities.UnitSystems.SI.Length.AstronomicalUnit.Name, PhysicalQuantities.UnitSystems.SI.Length.AstronomicalUnit },
              { PhysicalQuantities.UnitSystems.SI.Length.BohrRadius.Name, PhysicalQuantities.UnitSystems.SI.Length.BohrRadius },
            }
          },
          { 
            PhysicalQuantities.Quantities.Mass, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Mass.Kilogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Kilogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Gram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Gram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Yottagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Yottagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Zettagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Zettagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Exagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Exagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Petagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Petagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Teragram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Teragram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Gigagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Gigagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Megagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Megagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Hectogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Hectogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Decagram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Decagram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Decigram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Decigram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Centigram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Centigram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Milligram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Milligram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Microgram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Microgram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Nanogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Nanogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Picogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Picogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Femtogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Femtogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Attogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Attogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Zeptogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Zeptogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Yoctogram.Name, PhysicalQuantities.UnitSystems.SI.Mass.Yoctogram },
              { PhysicalQuantities.UnitSystems.SI.Mass.Tonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.Tonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.KiloTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.KiloTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.MegaTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.MegaTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.GigaTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.GigaTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.TeraTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.TeraTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.PetaTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.PetaTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.ExaTonne.Name, PhysicalQuantities.UnitSystems.SI.Mass.ExaTonne },
              { PhysicalQuantities.UnitSystems.SI.Mass.AtomicMassUnit.Name, PhysicalQuantities.UnitSystems.SI.Mass.AtomicMassUnit },
              { PhysicalQuantities.UnitSystems.SI.Mass.Dalton.Name, PhysicalQuantities.UnitSystems.SI.Mass.Dalton },
              { PhysicalQuantities.UnitSystems.SI.Mass.ElectronRestMass.Name, PhysicalQuantities.UnitSystems.SI.Mass.ElectronRestMass },
            }
          },
          { 
            PhysicalQuantities.Quantities.Time, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Time.Second.Name, PhysicalQuantities.UnitSystems.SI.Time.Second },
              { PhysicalQuantities.UnitSystems.SI.Time.YottaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.YottaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.ZettaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.ZettaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.ExaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.ExaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.PetaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.PetaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.TeraSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.TeraSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.GigaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.GigaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.MegaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.MegaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.KiloSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.KiloSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.HectoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.HectoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.DecaSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.DecaSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.DeciSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.DeciSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.CentiSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.CentiSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.MilliSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.MilliSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.MicroSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.MicroSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.NanoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.NanoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.PicoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.PicoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.FemtoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.FemtoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.AttoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.AttoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.ZeptoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.ZeptoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.YoctoSecond.Name, PhysicalQuantities.UnitSystems.SI.Time.YoctoSecond },
              { PhysicalQuantities.UnitSystems.SI.Time.Minute.Name, PhysicalQuantities.UnitSystems.SI.Time.Minute },
              { PhysicalQuantities.UnitSystems.SI.Time.Hour.Name, PhysicalQuantities.UnitSystems.SI.Time.Hour },
              { PhysicalQuantities.UnitSystems.SI.Time.Day.Name, PhysicalQuantities.UnitSystems.SI.Time.Day },
              { PhysicalQuantities.UnitSystems.SI.Time.NaturalUnitOfTime.Name, PhysicalQuantities.UnitSystems.SI.Time.NaturalUnitOfTime },
            }
          },
          { 
            PhysicalQuantities.Quantities.Temperature, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.Kelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.YottaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.YottaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.ZettaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.ZettaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.ExaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.ExaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.PetaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.PetaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.TeraKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.TeraKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.GigaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.GigaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.MegaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.MegaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.KiloKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.KiloKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.HectoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.HectoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.DecaKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.DecaKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.DeciKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.DeciKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.CentiKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.CentiKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.MilliKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.MilliKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.MicroKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.MicroKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.NanoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.NanoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.PicoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.PicoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.FemtoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.FemtoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.AttoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.AttoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.ZeptoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.ZeptoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.YoctoKelvin.Name, PhysicalQuantities.UnitSystems.SI.Temperature.YoctoKelvin },
              { PhysicalQuantities.UnitSystems.SI.Temperature.Celsius.Name, PhysicalQuantities.UnitSystems.SI.Temperature.Celsius },
            }
          },
          { 
            PhysicalQuantities.Quantities.Substance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Substance.Mole.Name, PhysicalQuantities.UnitSystems.SI.Substance.Mole },
              { PhysicalQuantities.UnitSystems.SI.Substance.YottaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.YottaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.ZettaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.ZettaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.ExaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.ExaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.PetaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.PetaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.TeraMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.TeraMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.GigaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.GigaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.MegaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.MegaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.KiloMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.KiloMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.HectoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.HectoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.DecaMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.DecaMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.DeciMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.DeciMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.CentiMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.CentiMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.MilliMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.MilliMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.MicroMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.MicroMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.NanoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.NanoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.PicoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.PicoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.FemtoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.FemtoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.AttoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.AttoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.ZeptoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.ZeptoMole },
              { PhysicalQuantities.UnitSystems.SI.Substance.YoctoMole.Name, PhysicalQuantities.UnitSystems.SI.Substance.YoctoMole },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricCurrent, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.Ampere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YottaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YottaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZettaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZettaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ExaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ExaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PetaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PetaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.TeraAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.TeraAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.GigaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.GigaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MegaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MegaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.KiloAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.KiloAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.HectoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.HectoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DecaAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DecaAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DeciAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.DeciAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.CentiAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.CentiAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MilliAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MilliAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MicroAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.MicroAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.NanoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.NanoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PicoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.PicoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.FemtoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.FemtoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.AttoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.AttoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZeptoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.ZeptoAmpere },
              { PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YoctoAmpere.Name, PhysicalQuantities.UnitSystems.SI.ElectricCurrent.YoctoAmpere },
            }
          },
          { 
            PhysicalQuantities.Quantities.LuminousIntensity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.Candela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YottaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YottaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZettaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZettaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ExaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ExaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PetaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PetaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.TeraCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.TeraCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.GigaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.GigaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MegaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MegaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.KiloCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.KiloCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.HectoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.HectoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DecaCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DecaCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DeciCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.DeciCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.CentiCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.CentiCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MilliCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MilliCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MicroCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.MicroCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.NanoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.NanoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PicoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.PicoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.FemtoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.FemtoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.AttoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.AttoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZeptoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.ZeptoCandela },
              { PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YoctoCandela.Name, PhysicalQuantities.UnitSystems.SI.LuminousIntensity.YoctoCandela },
            }
          },
          { 
            PhysicalQuantities.Quantities.Frequency, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Frequency.Hertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.Hertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.YottaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.YottaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.ZettaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.ZettaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.ExaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.ExaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.PetaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.PetaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.TeraHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.TeraHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.GigaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.GigaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.MegaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.MegaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.KiloHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.KiloHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.HectoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.HectoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.DecaHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.DecaHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.DeciHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.DeciHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.CentiHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.CentiHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.MilliHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.MilliHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.MicroHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.MicroHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.NanoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.NanoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.PicoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.PicoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.FemtoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.FemtoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.AttoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.AttoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.ZeptoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.ZeptoHertz },
              { PhysicalQuantities.UnitSystems.SI.Frequency.YoctoHertz.Name, PhysicalQuantities.UnitSystems.SI.Frequency.YoctoHertz },
            }
          },
          { 
            PhysicalQuantities.Quantities.Angle, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Angle.Radian.Name, PhysicalQuantities.UnitSystems.SI.Angle.Radian },
              { PhysicalQuantities.UnitSystems.SI.Angle.YottaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.YottaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.ZettaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.ZettaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.ExaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.ExaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.PetaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.PetaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.TeraRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.TeraRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.GigaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.GigaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.MegaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.MegaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.KiloRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.KiloRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.HectoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.HectoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.DecaRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.DecaRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.DeciRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.DeciRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.CentiRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.CentiRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.MilliRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.MilliRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.MicroRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.MicroRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.NanoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.NanoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.PicoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.PicoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.FemtoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.FemtoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.AttoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.AttoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.ZeptoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.ZeptoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.YoctoRadian.Name, PhysicalQuantities.UnitSystems.SI.Angle.YoctoRadian },
              { PhysicalQuantities.UnitSystems.SI.Angle.Degree.Name, PhysicalQuantities.UnitSystems.SI.Angle.Degree },
              { PhysicalQuantities.UnitSystems.SI.Angle.Arcminute.Name, PhysicalQuantities.UnitSystems.SI.Angle.Arcminute },
              { PhysicalQuantities.UnitSystems.SI.Angle.Arcsecond.Name, PhysicalQuantities.UnitSystems.SI.Angle.Arcsecond },
              { PhysicalQuantities.UnitSystems.SI.Angle.Milliarcsecond.Name, PhysicalQuantities.UnitSystems.SI.Angle.Milliarcsecond },
              { PhysicalQuantities.UnitSystems.SI.Angle.Microarcsecond.Name, PhysicalQuantities.UnitSystems.SI.Angle.Microarcsecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.SolidAngle, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.Steradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.YottaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.YottaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.ZettaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.ZettaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.ExaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.ExaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.PetaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.PetaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.TeraSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.TeraSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.GigaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.GigaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.MegaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.MegaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.KiloSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.KiloSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.HectoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.HectoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.DecaSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.DecaSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.DeciSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.DeciSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.CentiSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.CentiSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.MilliSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.MilliSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.MicroSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.MicroSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.NanoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.NanoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.PicoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.PicoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.FemtoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.FemtoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.AttoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.AttoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.ZeptoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.ZeptoSteradian },
              { PhysicalQuantities.UnitSystems.SI.SolidAngle.YoctoSteradian.Name, PhysicalQuantities.UnitSystems.SI.SolidAngle.YoctoSteradian },
            }
          },
          { 
            PhysicalQuantities.Quantities.Force, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Force.Newton.Name, PhysicalQuantities.UnitSystems.SI.Force.Newton },
              { PhysicalQuantities.UnitSystems.SI.Force.YottaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.YottaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.ZettaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.ZettaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.ExaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.ExaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.PetaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.PetaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.TeraNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.TeraNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.GigaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.GigaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.MegaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.MegaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.KiloNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.KiloNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.HectoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.HectoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.DecaNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.DecaNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.DeciNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.DeciNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.CentiNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.CentiNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.MilliNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.MilliNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.MicroNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.MicroNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.NanoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.NanoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.PicoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.PicoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.FemtoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.FemtoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.AttoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.AttoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.ZeptoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.ZeptoNewton },
              { PhysicalQuantities.UnitSystems.SI.Force.YoctoNewton.Name, PhysicalQuantities.UnitSystems.SI.Force.YoctoNewton },
            }
          },
          { 
            PhysicalQuantities.Quantities.Pressure, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Pressure.Pascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.Pascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.YottaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.YottaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.ZettaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.ZettaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.ExaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.ExaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.PetaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.PetaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.TeraPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.TeraPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.GigaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.GigaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.MegaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.MegaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.KiloPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.KiloPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.HectoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.HectoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.DecaPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.DecaPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.DeciPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.DeciPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.CentiPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.CentiPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.MilliPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.MilliPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.MicroPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.MicroPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.NanoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.NanoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.PicoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.PicoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.FemtoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.FemtoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.AttoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.AttoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.ZeptoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.ZeptoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.YoctoPascal.Name, PhysicalQuantities.UnitSystems.SI.Pressure.YoctoPascal },
              { PhysicalQuantities.UnitSystems.SI.Pressure.Bar.Name, PhysicalQuantities.UnitSystems.SI.Pressure.Bar },
              { PhysicalQuantities.UnitSystems.SI.Pressure.MilliBar.Name, PhysicalQuantities.UnitSystems.SI.Pressure.MilliBar },
              { PhysicalQuantities.UnitSystems.SI.Pressure.Barye.Name, PhysicalQuantities.UnitSystems.SI.Pressure.Barye },
              { PhysicalQuantities.UnitSystems.SI.Pressure.Atmosphere.Name, PhysicalQuantities.UnitSystems.SI.Pressure.Atmosphere },
              { PhysicalQuantities.UnitSystems.SI.Pressure.MillimetreOfMercury.Name, PhysicalQuantities.UnitSystems.SI.Pressure.MillimetreOfMercury },
              { PhysicalQuantities.UnitSystems.SI.Pressure.Torr.Name, PhysicalQuantities.UnitSystems.SI.Pressure.Torr },
            }
          },
          { 
            PhysicalQuantities.Quantities.Energy, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Energy.Joule.Name, PhysicalQuantities.UnitSystems.SI.Energy.Joule },
              { PhysicalQuantities.UnitSystems.SI.Energy.YottaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.YottaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.ZettaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.ZettaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.ExaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.ExaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.PetaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.PetaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.TeraJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.TeraJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.GigaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.GigaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.MegaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.MegaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.KiloJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.KiloJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.HectoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.HectoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.DecaJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.DecaJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.DeciJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.DeciJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.CentiJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.CentiJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.MilliJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.MilliJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.MicroJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.MicroJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.NanoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.NanoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.PicoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.PicoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.FemtoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.FemtoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.AttoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.AttoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.ZeptoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.ZeptoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.YoctoJoule.Name, PhysicalQuantities.UnitSystems.SI.Energy.YoctoJoule },
              { PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.Electronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.MilliElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.MilliElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.KiloElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.KiloElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.MegaElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.MegaElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.GigaElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.GigaElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.TeraElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.TeraElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.PetaElectronvolt.Name, PhysicalQuantities.UnitSystems.SI.Energy.PetaElectronvolt },
              { PhysicalQuantities.UnitSystems.SI.Energy.Bevatron.Name, PhysicalQuantities.UnitSystems.SI.Energy.Bevatron },
            }
          },
          { 
            PhysicalQuantities.Quantities.Power, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Power.Watt.Name, PhysicalQuantities.UnitSystems.SI.Power.Watt },
              { PhysicalQuantities.UnitSystems.SI.Power.YottaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.YottaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.ZettaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.ZettaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.ExaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.ExaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.PetaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.PetaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.TeraWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.TeraWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.GigaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.GigaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.MegaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.MegaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.KiloWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.KiloWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.HectoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.HectoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.DecaWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.DecaWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.DeciWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.DeciWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.CentiWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.CentiWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.MilliWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.MilliWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.MicroWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.MicroWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.NanoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.NanoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.PicoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.PicoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.FemtoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.FemtoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.AttoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.AttoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.ZeptoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.ZeptoWatt },
              { PhysicalQuantities.UnitSystems.SI.Power.YoctoWatt.Name, PhysicalQuantities.UnitSystems.SI.Power.YoctoWatt },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricCharge, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.Coulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.YottaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.YottaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZettaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZettaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.ExaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.ExaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.PetaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.PetaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.TeraCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.TeraCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.GigaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.GigaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.MegaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.MegaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.KiloCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.KiloCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.HectoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.HectoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.DecaCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.DecaCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.DeciCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.DeciCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.CentiCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.CentiCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.MilliCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.MilliCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.MicroCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.MicroCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.NanoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.NanoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.PicoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.PicoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.FemtoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.FemtoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.AttoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.AttoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZeptoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.ZeptoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.YoctoCoulomb.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.YoctoCoulomb },
              { PhysicalQuantities.UnitSystems.SI.ElectricCharge.ElementaryCharge.Name, PhysicalQuantities.UnitSystems.SI.ElectricCharge.ElementaryCharge },
            }
          },
          { 
            PhysicalQuantities.Quantities.Voltage, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Voltage.Volt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.Volt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.YottaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.YottaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.ZettaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.ZettaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.ExaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.ExaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.PetaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.PetaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.TeraVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.TeraVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.GigaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.GigaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.MegaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.MegaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.KiloVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.KiloVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.HectoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.HectoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.DecaVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.DecaVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.DeciVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.DeciVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.CentiVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.CentiVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.MilliVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.MilliVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.MicroVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.MicroVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.NanoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.NanoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.PicoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.PicoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.FemtoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.FemtoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.AttoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.AttoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.ZeptoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.ZeptoVolt },
              { PhysicalQuantities.UnitSystems.SI.Voltage.YoctoVolt.Name, PhysicalQuantities.UnitSystems.SI.Voltage.YoctoVolt },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricCapacitance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.Farad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YottaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YottaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZettaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZettaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ExaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ExaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PetaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PetaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.TeraFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.TeraFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.GigaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.GigaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MegaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MegaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.KiloFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.KiloFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.HectoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.HectoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DecaFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DecaFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DeciFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.DeciFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.CentiFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.CentiFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MilliFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MilliFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MicroFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.MicroFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.NanoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.NanoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PicoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.PicoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.FemtoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.FemtoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.AttoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.AttoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZeptoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.ZeptoFarad },
              { PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YoctoFarad.Name, PhysicalQuantities.UnitSystems.SI.ElectricCapacitance.YoctoFarad },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricResistance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.Ohm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.YottaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.YottaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZettaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZettaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.ExaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.ExaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.PetaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.PetaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.TeraOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.TeraOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.GigaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.GigaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.MegaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.MegaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.KiloOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.KiloOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.HectoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.HectoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.DecaOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.DecaOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.DeciOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.DeciOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.CentiOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.CentiOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.MilliOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.MilliOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.MicroOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.MicroOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.NanoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.NanoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.PicoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.PicoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.FemtoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.FemtoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.AttoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.AttoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZeptoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.ZeptoOhm },
              { PhysicalQuantities.UnitSystems.SI.ElectricResistance.YoctoOhm.Name, PhysicalQuantities.UnitSystems.SI.ElectricResistance.YoctoOhm },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricConductance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.Siemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.YottaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.YottaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZettaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZettaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.ExaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.ExaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.PetaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.PetaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.TeraSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.TeraSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.GigaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.GigaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.MegaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.MegaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.KiloSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.KiloSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.HectoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.HectoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.DecaSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.DecaSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.DeciSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.DeciSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.CentiSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.CentiSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.MilliSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.MilliSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.MicroSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.MicroSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.NanoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.NanoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.PicoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.PicoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.FemtoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.FemtoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.AttoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.AttoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZeptoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.ZeptoSiemens },
              { PhysicalQuantities.UnitSystems.SI.ElectricConductance.YoctoSiemens.Name, PhysicalQuantities.UnitSystems.SI.ElectricConductance.YoctoSiemens },
            }
          },
          { 
            PhysicalQuantities.Quantities.MagneticFlux, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.Weber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.YottaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.YottaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZettaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZettaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.ExaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.ExaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.PetaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.PetaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.TeraWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.TeraWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.GigaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.GigaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.MegaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.MegaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.KiloWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.KiloWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.HectoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.HectoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.DecaWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.DecaWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.DeciWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.DeciWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.CentiWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.CentiWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.MilliWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.MilliWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.MicroWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.MicroWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.NanoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.NanoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.PicoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.PicoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.FemtoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.FemtoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.AttoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.AttoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZeptoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.ZeptoWeber },
              { PhysicalQuantities.UnitSystems.SI.MagneticFlux.YoctoWeber.Name, PhysicalQuantities.UnitSystems.SI.MagneticFlux.YoctoWeber },
            }
          },
          { 
            PhysicalQuantities.Quantities.MagneticField, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.Tesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.YottaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.YottaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.ZettaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.ZettaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.ExaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.ExaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.PetaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.PetaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.TeraTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.TeraTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.GigaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.GigaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.MegaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.MegaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.KiloTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.KiloTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.HectoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.HectoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.DecaTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.DecaTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.DeciTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.DeciTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.CentiTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.CentiTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.MilliTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.MilliTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.MicroTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.MicroTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.NanoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.NanoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.PicoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.PicoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.FemtoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.FemtoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.AttoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.AttoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.ZeptoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.ZeptoTesla },
              { PhysicalQuantities.UnitSystems.SI.MagneticField.YoctoTesla.Name, PhysicalQuantities.UnitSystems.SI.MagneticField.YoctoTesla },
            }
          },
          { 
            PhysicalQuantities.Quantities.Inductance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Inductance.Henry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.Henry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.YottaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.YottaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.ZettaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.ZettaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.ExaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.ExaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.PetaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.PetaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.TeraHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.TeraHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.GigaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.GigaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.MegaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.MegaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.KiloHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.KiloHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.HectoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.HectoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.DecaHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.DecaHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.DeciHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.DeciHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.CentiHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.CentiHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.MilliHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.MilliHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.MicroHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.MicroHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.NanoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.NanoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.PicoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.PicoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.FemtoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.FemtoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.AttoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.AttoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.ZeptoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.ZeptoHenry },
              { PhysicalQuantities.UnitSystems.SI.Inductance.YoctoHenry.Name, PhysicalQuantities.UnitSystems.SI.Inductance.YoctoHenry },
            }
          },
          { 
            PhysicalQuantities.Quantities.LuminousFlux, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.Lumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.YottaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.YottaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZettaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZettaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.ExaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.ExaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.PetaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.PetaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.TeraLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.TeraLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.GigaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.GigaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.MegaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.MegaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.KiloLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.KiloLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.HectoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.HectoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.DecaLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.DecaLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.DeciLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.DeciLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.CentiLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.CentiLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.MilliLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.MilliLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.MicroLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.MicroLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.NanoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.NanoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.PicoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.PicoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.FemtoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.FemtoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.AttoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.AttoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZeptoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.ZeptoLumen },
              { PhysicalQuantities.UnitSystems.SI.LuminousFlux.YoctoLumen.Name, PhysicalQuantities.UnitSystems.SI.LuminousFlux.YoctoLumen },
            }
          },
          { 
            PhysicalQuantities.Quantities.Illuminance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Illuminance.Lux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.Lux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.YottaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.YottaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.ZettaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.ZettaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.ExaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.ExaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.PetaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.PetaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.TeraLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.TeraLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.GigaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.GigaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.MegaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.MegaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.KiloLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.KiloLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.HectoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.HectoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.DecaLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.DecaLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.DeciLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.DeciLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.CentiLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.CentiLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.MilliLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.MilliLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.MicroLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.MicroLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.NanoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.NanoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.PicoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.PicoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.FemtoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.FemtoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.AttoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.AttoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.ZeptoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.ZeptoLux },
              { PhysicalQuantities.UnitSystems.SI.Illuminance.YoctoLux.Name, PhysicalQuantities.UnitSystems.SI.Illuminance.YoctoLux },
            }
          },
          { 
            PhysicalQuantities.Quantities.RadioactiveDecay, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.Becquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YottaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YottaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZettaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZettaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ExaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ExaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PetaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PetaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.TeraBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.TeraBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.GigaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.GigaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MegaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MegaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.KiloBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.KiloBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.HectoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.HectoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DecaBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DecaBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DeciBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.DeciBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.CentiBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.CentiBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MilliBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MilliBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MicroBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.MicroBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.NanoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.NanoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PicoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.PicoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.FemtoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.FemtoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.AttoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.AttoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZeptoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.ZeptoBecquerel },
              { PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YoctoBecquerel.Name, PhysicalQuantities.UnitSystems.SI.RadioactiveDecay.YoctoBecquerel },
            }
          },
          { 
            PhysicalQuantities.Quantities.AbsorbedDose, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.Gray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YottaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YottaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZettaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZettaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ExaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ExaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PetaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PetaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.TeraGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.TeraGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.GigaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.GigaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MegaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MegaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.KiloGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.KiloGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.HectoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.HectoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DecaGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DecaGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DeciGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.DeciGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.CentiGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.CentiGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MilliGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MilliGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MicroGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.MicroGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.NanoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.NanoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PicoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.PicoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.FemtoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.FemtoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.AttoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.AttoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZeptoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.ZeptoGray },
              { PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YoctoGray.Name, PhysicalQuantities.UnitSystems.SI.AbsorbedDose.YoctoGray },
            }
          },
          { 
            PhysicalQuantities.Quantities.EquivalentDose, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.Sievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.YottaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.YottaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZettaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZettaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.ExaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.ExaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.PetaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.PetaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.TeraSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.TeraSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.GigaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.GigaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.MegaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.MegaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.KiloSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.KiloSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.HectoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.HectoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.DecaSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.DecaSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.DeciSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.DeciSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.CentiSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.CentiSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.MilliSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.MilliSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.MicroSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.MicroSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.NanoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.NanoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.PicoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.PicoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.FemtoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.FemtoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.AttoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.AttoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZeptoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.ZeptoSievert },
              { PhysicalQuantities.UnitSystems.SI.EquivalentDose.YoctoSievert.Name, PhysicalQuantities.UnitSystems.SI.EquivalentDose.YoctoSievert },
            }
          },
          { 
            PhysicalQuantities.Quantities.CatalyticActivity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.Katal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YottaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YottaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZettaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZettaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ExaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ExaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PetaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PetaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.TeraKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.TeraKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.GigaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.GigaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MegaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MegaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.KiloKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.KiloKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.HectoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.HectoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DecaKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DecaKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DeciKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.DeciKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.CentiKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.CentiKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MilliKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MilliKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MicroKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.MicroKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.NanoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.NanoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PicoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.PicoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.FemtoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.FemtoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.AttoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.AttoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZeptoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.ZeptoKatal },
              { PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YoctoKatal.Name, PhysicalQuantities.UnitSystems.SI.CatalyticActivity.YoctoKatal },
            }
          },
          { 
            PhysicalQuantities.Quantities.Area, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Area.SquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.SquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.YottaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.YottaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.ZettaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.ZettaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.ExaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.ExaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.PetaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.PetaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.TeraSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.TeraSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.GigaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.GigaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.MegaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.MegaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.KiloSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.KiloSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.HectoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.HectoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.DecaSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.DecaSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.DeciSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.DeciSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.CentiSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.CentiSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.MilliSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.MilliSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.MicroSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.MicroSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.NanoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.NanoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.PicoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.PicoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.FemtoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.FemtoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.AttoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.AttoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.ZeptoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.ZeptoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.YoctoSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.Area.YoctoSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.Area.Are.Name, PhysicalQuantities.UnitSystems.SI.Area.Are },
              { PhysicalQuantities.UnitSystems.SI.Area.Centiare.Name, PhysicalQuantities.UnitSystems.SI.Area.Centiare },
              { PhysicalQuantities.UnitSystems.SI.Area.Decare.Name, PhysicalQuantities.UnitSystems.SI.Area.Decare },
              { PhysicalQuantities.UnitSystems.SI.Area.Hectare.Name, PhysicalQuantities.UnitSystems.SI.Area.Hectare },
              { PhysicalQuantities.UnitSystems.SI.Area.SquareKilometre.Name, PhysicalQuantities.UnitSystems.SI.Area.SquareKilometre },
              { PhysicalQuantities.UnitSystems.SI.Area.SquareCentimetre.Name, PhysicalQuantities.UnitSystems.SI.Area.SquareCentimetre },
              { PhysicalQuantities.UnitSystems.SI.Area.SquareMillimetre.Name, PhysicalQuantities.UnitSystems.SI.Area.SquareMillimetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Volume, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.CubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.YottaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.YottaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.ZettaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.ZettaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.ExaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.ExaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.PetaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.PetaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.TeraCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.TeraCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.GigaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.GigaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.MegaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.MegaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.KiloCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.KiloCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.HectoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.HectoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.DecaCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.DecaCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.DeciCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.DeciCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.CentiCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.CentiCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.MilliCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.MilliCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.MicroCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.MicroCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.NanoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.NanoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.PicoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.PicoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.FemtoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.FemtoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.AttoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.AttoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.ZeptoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.ZeptoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.YoctoCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Volume.YoctoCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Volume.Litre.Name, PhysicalQuantities.UnitSystems.SI.Volume.Litre },
              { PhysicalQuantities.UnitSystems.SI.Volume.MilliLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.MilliLitre },
              { PhysicalQuantities.UnitSystems.SI.Volume.CentiLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.CentiLitre },
              { PhysicalQuantities.UnitSystems.SI.Volume.DeciLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.DeciLitre },
              { PhysicalQuantities.UnitSystems.SI.Volume.DecaLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.DecaLitre },
              { PhysicalQuantities.UnitSystems.SI.Volume.HectoLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.HectoLitre },
              { PhysicalQuantities.UnitSystems.SI.Volume.KiloLitre.Name, PhysicalQuantities.UnitSystems.SI.Volume.KiloLitre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Speed, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.MetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.YottaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.YottaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.ZettaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.ZettaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.ExaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.ExaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.PetaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.PetaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.TeraMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.TeraMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.GigaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.GigaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.MegaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.MegaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.KiloMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.KiloMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.HectoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.HectoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.DecaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.DecaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.DeciMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.DeciMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.CentiMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.CentiMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.MilliMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.MilliMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.MicroMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.MicroMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.NanoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.NanoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.PicoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.PicoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.FemtoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.FemtoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.AttoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.AttoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.ZeptoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.ZeptoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.YoctoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.Speed.YoctoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.Speed.SpeedOfLight.Name, PhysicalQuantities.UnitSystems.SI.Speed.SpeedOfLight },
            }
          },
          { 
            PhysicalQuantities.Quantities.Acceleration, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.MetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.YottaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.YottaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.ZettaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.ZettaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.ExaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.ExaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.PetaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.PetaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.TeraMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.TeraMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.GigaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.GigaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.MegaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.MegaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.KiloMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.KiloMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.HectoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.HectoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.DecaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.DecaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.DeciMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.DeciMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.CentiMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.CentiMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.MilliMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.MilliMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.MicroMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.MicroMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.NanoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.NanoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.PicoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.PicoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.FemtoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.FemtoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.AttoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.AttoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.ZeptoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.ZeptoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.SI.Acceleration.YoctoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.SI.Acceleration.YoctoMetrePerSecondSquared },
            }
          },
          { 
            PhysicalQuantities.Quantities.VolumetricFlow, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YottaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YottaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZettaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZettaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ExaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ExaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PetaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PetaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.TeraCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.TeraCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.GigaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.GigaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MegaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MegaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.KiloCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.KiloCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.HectoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.HectoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DecaCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DecaCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DeciCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.DeciCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CentiCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.CentiCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MilliCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MilliCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MicroCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.MicroCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.NanoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.NanoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PicoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.PicoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.FemtoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.FemtoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.AttoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.AttoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZeptoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.ZeptoCubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YoctoCubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.SI.VolumetricFlow.YoctoCubicMetrePerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Jerk, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.MetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.YottaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.YottaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.ZettaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.ZettaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.ExaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.ExaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.PetaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.PetaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.TeraMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.TeraMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.GigaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.GigaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.MegaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.MegaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.KiloMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.KiloMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.HectoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.HectoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.DecaMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.DecaMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.DeciMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.DeciMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.CentiMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.CentiMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.MilliMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.MilliMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.MicroMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.MicroMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.NanoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.NanoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.PicoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.PicoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.FemtoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.FemtoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.AttoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.AttoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.ZeptoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.ZeptoMetrePerSecondCubed },
              { PhysicalQuantities.UnitSystems.SI.Jerk.YoctoMetrePerSecondCubed.Name, PhysicalQuantities.UnitSystems.SI.Jerk.YoctoMetrePerSecondCubed },
            }
          },
          { 
            PhysicalQuantities.Quantities.Jounce, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.MetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.YottaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.YottaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.ZettaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.ZettaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.ExaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.ExaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.PetaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.PetaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.TeraMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.TeraMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.GigaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.GigaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.MegaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.MegaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.KiloMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.KiloMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.HectoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.HectoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.DecaMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.DecaMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.DeciMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.DeciMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.CentiMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.CentiMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.MilliMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.MilliMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.MicroMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.MicroMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.NanoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.NanoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.PicoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.PicoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.FemtoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.FemtoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.AttoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.AttoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.ZeptoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.ZeptoMetrePerQuarticSecond },
              { PhysicalQuantities.UnitSystems.SI.Jounce.YoctoMetrePerQuarticSecond.Name, PhysicalQuantities.UnitSystems.SI.Jounce.YoctoMetrePerQuarticSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.AngularVelocity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.RadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.YottaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.YottaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZettaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZettaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.ExaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.ExaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.PetaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.PetaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.TeraRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.TeraRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.GigaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.GigaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.MegaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.MegaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.KiloRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.KiloRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.HectoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.HectoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.DecaRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.DecaRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.DeciRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.DeciRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.CentiRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.CentiRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.MilliRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.MilliRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.MicroRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.MicroRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.NanoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.NanoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.PicoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.PicoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.FemtoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.FemtoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.AttoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.AttoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZeptoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.ZeptoRadianPerSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularVelocity.YoctoRadianPerSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularVelocity.YoctoRadianPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Momentum, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.NewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.YottaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.YottaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.ZettaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.ZettaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.ExaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.ExaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.PetaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.PetaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.TeraNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.TeraNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.GigaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.GigaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.MegaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.MegaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.KiloNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.KiloNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.HectoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.HectoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.DecaNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.DecaNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.DeciNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.DeciNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.CentiNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.CentiNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.MilliNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.MilliNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.MicroNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.MicroNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.NanoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.NanoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.PicoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.PicoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.FemtoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.FemtoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.AttoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.AttoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.ZeptoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.ZeptoNewtonSecond },
              { PhysicalQuantities.UnitSystems.SI.Momentum.YoctoNewtonSecond.Name, PhysicalQuantities.UnitSystems.SI.Momentum.YoctoNewtonSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.AngularMomentum, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.NewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.YottaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.YottaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZettaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZettaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.ExaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.ExaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.PetaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.PetaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.TeraNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.TeraNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.GigaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.GigaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.MegaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.MegaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.KiloNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.KiloNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.HectoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.HectoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.DecaNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.DecaNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.DeciNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.DeciNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.CentiNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.CentiNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.MilliNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.MilliNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.MicroNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.MicroNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.NanoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.NanoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.PicoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.PicoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.FemtoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.FemtoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.AttoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.AttoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZeptoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.ZeptoNewtonMetreSecond },
              { PhysicalQuantities.UnitSystems.SI.AngularMomentum.YoctoNewtonMetreSecond.Name, PhysicalQuantities.UnitSystems.SI.AngularMomentum.YoctoNewtonMetreSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Torque, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.NewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.YottaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.YottaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.ZettaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.ZettaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.ExaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.ExaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.PetaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.PetaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.TeraNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.TeraNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.GigaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.GigaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.MegaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.MegaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.KiloNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.KiloNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.HectoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.HectoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.DecaNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.DecaNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.DeciNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.DeciNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.CentiNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.CentiNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.MilliNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.MilliNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.MicroNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.MicroNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.NanoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.NanoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.PicoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.PicoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.FemtoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.FemtoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.AttoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.AttoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.ZeptoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.ZeptoNewtonMetre },
              { PhysicalQuantities.UnitSystems.SI.Torque.YoctoNewtonMetre.Name, PhysicalQuantities.UnitSystems.SI.Torque.YoctoNewtonMetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Yank, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.NewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.YottaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.YottaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.ZettaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.ZettaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.ExaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.ExaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.PetaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.PetaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.TeraNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.TeraNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.GigaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.GigaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.MegaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.MegaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.KiloNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.KiloNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.HectoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.HectoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.DecaNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.DecaNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.DeciNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.DeciNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.CentiNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.CentiNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.MilliNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.MilliNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.MicroNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.MicroNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.NanoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.NanoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.PicoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.PicoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.FemtoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.FemtoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.AttoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.AttoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.ZeptoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.ZeptoNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.SI.Yank.YoctoNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.SI.Yank.YoctoNewtonPerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Wavenumber, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.ReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.YottaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.YottaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.ZettaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.ZettaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.ExaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.ExaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.PetaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.PetaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.TeraReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.TeraReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.GigaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.GigaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.MegaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.MegaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.KiloReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.KiloReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.HectoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.HectoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.DecaReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.DecaReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.DeciReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.DeciReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.CentiReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.CentiReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.MilliReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.MilliReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.MicroReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.MicroReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.NanoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.NanoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.PicoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.PicoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.FemtoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.FemtoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.AttoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.AttoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.ZeptoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.ZeptoReciprocalMetre },
              { PhysicalQuantities.UnitSystems.SI.Wavenumber.YoctoReciprocalMetre.Name, PhysicalQuantities.UnitSystems.SI.Wavenumber.YoctoReciprocalMetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.AreaDensity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.KilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.YottaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.YottaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.ZettaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.ZettaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.ExaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.ExaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.PetaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.PetaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.TeraKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.TeraKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.GigaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.GigaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.MegaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.MegaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.KiloKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.KiloKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.HectoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.HectoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.DecaKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.DecaKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.DeciKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.DeciKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.CentiKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.CentiKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.MilliKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.MilliKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.MicroKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.MicroKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.NanoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.NanoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.PicoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.PicoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.FemtoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.FemtoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.AttoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.AttoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.ZeptoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.ZeptoKilogramPerSquareMetre },
              { PhysicalQuantities.UnitSystems.SI.AreaDensity.YoctoKilogramPerSquareMetre.Name, PhysicalQuantities.UnitSystems.SI.AreaDensity.YoctoKilogramPerSquareMetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Density, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.KilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.YottaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.YottaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.ZettaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.ZettaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.ExaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.ExaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.PetaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.PetaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.TeraKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.TeraKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.GigaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.GigaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.MegaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.MegaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.KiloKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.KiloKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.HectoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.HectoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.DecaKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.DecaKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.DeciKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.DeciKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.CentiKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.CentiKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.MilliKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.MilliKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.MicroKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.MicroKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.NanoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.NanoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.PicoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.PicoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.FemtoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.FemtoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.AttoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.AttoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.ZeptoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.ZeptoKilogramPerCubicMetre },
              { PhysicalQuantities.UnitSystems.SI.Density.YoctoKilogramPerCubicMetre.Name, PhysicalQuantities.UnitSystems.SI.Density.YoctoKilogramPerCubicMetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.SpecificVolume, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.CubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.YottaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.YottaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZettaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZettaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.ExaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.ExaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.PetaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.PetaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.TeraCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.TeraCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.GigaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.GigaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.MegaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.MegaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.KiloCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.KiloCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.HectoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.HectoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.DecaCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.DecaCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.DeciCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.DeciCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.CentiCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.CentiCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.MilliCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.MilliCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.MicroCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.MicroCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.NanoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.NanoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.PicoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.PicoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.FemtoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.FemtoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.AttoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.AttoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZeptoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.ZeptoCubicMetrePerKilogram },
              { PhysicalQuantities.UnitSystems.SI.SpecificVolume.YoctoCubicMetrePerKilogram.Name, PhysicalQuantities.UnitSystems.SI.SpecificVolume.YoctoCubicMetrePerKilogram },
            }
          },
          { 
            PhysicalQuantities.Quantities.Action, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.Action.JouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.JouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.YottaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.YottaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.ZettaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.ZettaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.ExaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.ExaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.PetaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.PetaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.TeraJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.TeraJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.GigaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.GigaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.MegaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.MegaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.KiloJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.KiloJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.HectoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.HectoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.DecaJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.DecaJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.DeciJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.DeciJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.CentiJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.CentiJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.MilliJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.MilliJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.MicroJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.MicroJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.NanoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.NanoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.PicoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.PicoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.FemtoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.FemtoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.AttoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.AttoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.ZeptoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.ZeptoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.YoctoJouleSecond.Name, PhysicalQuantities.UnitSystems.SI.Action.YoctoJouleSecond },
              { PhysicalQuantities.UnitSystems.SI.Action.PlanckConstant.Name, PhysicalQuantities.UnitSystems.SI.Action.PlanckConstant },
              { PhysicalQuantities.UnitSystems.SI.Action.ReducedPlanckConstant.Name, PhysicalQuantities.UnitSystems.SI.Action.ReducedPlanckConstant },
            }
          },
          { 
            PhysicalQuantities.Quantities.HeatCapacity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.JoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.YottaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.YottaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZettaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZettaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.ExaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.ExaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.PetaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.PetaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.TeraJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.TeraJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.GigaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.GigaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.MegaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.MegaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.KiloJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.KiloJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.HectoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.HectoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.DecaJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.DecaJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.DeciJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.DeciJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.CentiJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.CentiJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.MilliJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.MilliJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.MicroJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.MicroJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.NanoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.NanoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.PicoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.PicoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.FemtoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.FemtoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.AttoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.AttoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZeptoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.ZeptoJoulePerKelvin },
              { PhysicalQuantities.UnitSystems.SI.HeatCapacity.YoctoJoulePerKelvin.Name, PhysicalQuantities.UnitSystems.SI.HeatCapacity.YoctoJoulePerKelvin },
            }
          },
          { 
            PhysicalQuantities.Quantities.NewtonianConstantOfGravitationQuantity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.SI.NewtonianConstantOfGravitationQuantity.NewtonianConstantOfGravitationUnit.Name, PhysicalQuantities.UnitSystems.SI.NewtonianConstantOfGravitationQuantity.NewtonianConstantOfGravitationUnit },
            }
          },
        };

        return unitSystem;
      }	  

      static SI()
      {
        var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
      }
    }
  }
}
