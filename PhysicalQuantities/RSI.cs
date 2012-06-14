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
    public static partial class RSI
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
        var unitSystem = new UnitSystem(@"RSI", ConversionTable);

        Dimensionless.Initialize(unitSystem);
        Length.Initialize(unitSystem);
        Mass.Initialize(unitSystem);
        Time.Initialize(unitSystem);
        Temperature.Initialize(unitSystem);
        ElectricCurrent.Initialize(unitSystem);
        LuminousIntensity.Initialize(unitSystem);
        Frequency.Initialize(unitSystem);
        Angle.Initialize(unitSystem);
        Force.Initialize(unitSystem);
        Pressure.Initialize(unitSystem);
        Energy.Initialize(unitSystem);
        Power.Initialize(unitSystem);
        Voltage.Initialize(unitSystem);
        ElectricCapacitance.Initialize(unitSystem);
        ElectricResistance.Initialize(unitSystem);
        ElectricConductance.Initialize(unitSystem);
        MagneticFlux.Initialize(unitSystem);
        MagneticField.Initialize(unitSystem);
        LuminousFlux.Initialize(unitSystem);
        Illuminance.Initialize(unitSystem);
        Area.Initialize(unitSystem);
        Volume.Initialize(unitSystem);
        Speed.Initialize(unitSystem);
        Acceleration.Initialize(unitSystem);
        VolumetricFlow.Initialize(unitSystem);
        Momentum.Initialize(unitSystem);

        allQuantities = new Dictionary<string, Quantity>
        {
          { @"Dimensionless", PhysicalQuantities.Quantities.Dimensionless },
          { @"Length", PhysicalQuantities.Quantities.Length },
          { @"Mass", PhysicalQuantities.Quantities.Mass },
          { @"Time", PhysicalQuantities.Quantities.Time },
          { @"Temperature", PhysicalQuantities.Quantities.Temperature },
          { @"ElectricCurrent", PhysicalQuantities.Quantities.ElectricCurrent },
          { @"LuminousIntensity", PhysicalQuantities.Quantities.LuminousIntensity },
          { @"Frequency", PhysicalQuantities.Quantities.Frequency },
          { @"Angle", PhysicalQuantities.Quantities.Angle },
          { @"Force", PhysicalQuantities.Quantities.Force },
          { @"Pressure", PhysicalQuantities.Quantities.Pressure },
          { @"Energy", PhysicalQuantities.Quantities.Energy },
          { @"Power", PhysicalQuantities.Quantities.Power },
          { @"Voltage", PhysicalQuantities.Quantities.Voltage },
          { @"ElectricCapacitance", PhysicalQuantities.Quantities.ElectricCapacitance },
          { @"ElectricResistance", PhysicalQuantities.Quantities.ElectricResistance },
          { @"ElectricConductance", PhysicalQuantities.Quantities.ElectricConductance },
          { @"MagneticFlux", PhysicalQuantities.Quantities.MagneticFlux },
          { @"MagneticField", PhysicalQuantities.Quantities.MagneticField },
          { @"LuminousFlux", PhysicalQuantities.Quantities.LuminousFlux },
          { @"Illuminance", PhysicalQuantities.Quantities.Illuminance },
          { @"Area", PhysicalQuantities.Quantities.Area },
          { @"Volume", PhysicalQuantities.Quantities.Volume },
          { @"Speed", PhysicalQuantities.Quantities.Speed },
          { @"Acceleration", PhysicalQuantities.Quantities.Acceleration },
          { @"VolumetricFlow", PhysicalQuantities.Quantities.VolumetricFlow },
          { @"Momentum", PhysicalQuantities.Quantities.Momentum },
        };

        allUnits = new Dictionary<Quantity, Dictionary<string, Unit>>(ReferenceEqualityComparer<Quantity>.Default)
        {
          { 
            PhysicalQuantities.Quantities.Dimensionless, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.Unity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.GigaUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.GigaUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.MegaUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.MegaUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.KiloUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.KiloUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.HectoUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.HectoUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.DecaUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.DecaUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.DeciUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.DeciUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.CentiUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.CentiUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.MilliUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.MilliUnity },
              { PhysicalQuantities.UnitSystems.RSI.Dimensionless.MicroUnity.Name, PhysicalQuantities.UnitSystems.RSI.Dimensionless.MicroUnity },
            }
          },
          { 
            PhysicalQuantities.Quantities.Length, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Length.Metre.Name, PhysicalQuantities.UnitSystems.RSI.Length.Metre },
              { PhysicalQuantities.UnitSystems.RSI.Length.GigaMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.GigaMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.MegaMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.MegaMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.KiloMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.KiloMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.HectoMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.HectoMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.DecaMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.DecaMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.DeciMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.DeciMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.CentiMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.CentiMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.MilliMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.MilliMetre },
              { PhysicalQuantities.UnitSystems.RSI.Length.MicroMetre.Name, PhysicalQuantities.UnitSystems.RSI.Length.MicroMetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Mass, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Mass.Kilogram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Kilogram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Gram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Gram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Hectogram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Hectogram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Decagram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Decagram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Decigram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Decigram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Centigram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Centigram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Milligram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Milligram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Microgram.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Microgram },
              { PhysicalQuantities.UnitSystems.RSI.Mass.Tonne.Name, PhysicalQuantities.UnitSystems.RSI.Mass.Tonne },
            }
          },
          { 
            PhysicalQuantities.Quantities.Time, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Time.Second.Name, PhysicalQuantities.UnitSystems.RSI.Time.Second },
              { PhysicalQuantities.UnitSystems.RSI.Time.MilliSecond.Name, PhysicalQuantities.UnitSystems.RSI.Time.MilliSecond },
              { PhysicalQuantities.UnitSystems.RSI.Time.MicroSecond.Name, PhysicalQuantities.UnitSystems.RSI.Time.MicroSecond },
              { PhysicalQuantities.UnitSystems.RSI.Time.Minute.Name, PhysicalQuantities.UnitSystems.RSI.Time.Minute },
              { PhysicalQuantities.UnitSystems.RSI.Time.Hour.Name, PhysicalQuantities.UnitSystems.RSI.Time.Hour },
              { PhysicalQuantities.UnitSystems.RSI.Time.Day.Name, PhysicalQuantities.UnitSystems.RSI.Time.Day },
            }
          },
          { 
            PhysicalQuantities.Quantities.Temperature, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Temperature.Kelvin.Name, PhysicalQuantities.UnitSystems.RSI.Temperature.Kelvin },
              { PhysicalQuantities.UnitSystems.RSI.Temperature.Celsius.Name, PhysicalQuantities.UnitSystems.RSI.Temperature.Celsius },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricCurrent, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.Ampere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.GigaAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.GigaAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MegaAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MegaAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.KiloAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.KiloAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.HectoAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.HectoAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DecaAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DecaAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DeciAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.DeciAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.CentiAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.CentiAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MilliAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MilliAmpere },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MicroAmpere.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCurrent.MicroAmpere },
            }
          },
          { 
            PhysicalQuantities.Quantities.LuminousIntensity, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.Candela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.KiloCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.KiloCandela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.HectoCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.HectoCandela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DecaCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DecaCandela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DeciCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.DeciCandela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.CentiCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.CentiCandela },
              { PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.MilliCandela.Name, PhysicalQuantities.UnitSystems.RSI.LuminousIntensity.MilliCandela },
            }
          },
          { 
            PhysicalQuantities.Quantities.Frequency, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.Hertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.GigaHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.GigaHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.MegaHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.MegaHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.KiloHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.KiloHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.HectoHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.HectoHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.DecaHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.DecaHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.DeciHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.DeciHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.CentiHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.CentiHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.MilliHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.MilliHertz },
              { PhysicalQuantities.UnitSystems.RSI.Frequency.MicroHertz.Name, PhysicalQuantities.UnitSystems.RSI.Frequency.MicroHertz },
            }
          },
          { 
            PhysicalQuantities.Quantities.Angle, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Angle.Radian.Name, PhysicalQuantities.UnitSystems.RSI.Angle.Radian },
              { PhysicalQuantities.UnitSystems.RSI.Angle.Degree.Name, PhysicalQuantities.UnitSystems.RSI.Angle.Degree },
            }
          },
          { 
            PhysicalQuantities.Quantities.Force, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Force.Newton.Name, PhysicalQuantities.UnitSystems.RSI.Force.Newton },
              { PhysicalQuantities.UnitSystems.RSI.Force.KiloNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.KiloNewton },
              { PhysicalQuantities.UnitSystems.RSI.Force.HectoNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.HectoNewton },
              { PhysicalQuantities.UnitSystems.RSI.Force.DecaNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.DecaNewton },
              { PhysicalQuantities.UnitSystems.RSI.Force.DeciNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.DeciNewton },
              { PhysicalQuantities.UnitSystems.RSI.Force.CentiNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.CentiNewton },
              { PhysicalQuantities.UnitSystems.RSI.Force.MilliNewton.Name, PhysicalQuantities.UnitSystems.RSI.Force.MilliNewton },
            }
          },
          { 
            PhysicalQuantities.Quantities.Pressure, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.Pascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.GigaPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.GigaPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.MegaPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.MegaPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.KiloPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.KiloPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.HectoPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.HectoPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.DecaPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.DecaPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.DeciPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.DeciPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.CentiPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.CentiPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.MilliPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.MilliPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.MicroPascal.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.MicroPascal },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.Bar.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.Bar },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.MilliBar.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.MilliBar },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.Atmosphere.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.Atmosphere },
              { PhysicalQuantities.UnitSystems.RSI.Pressure.MillimetreOfMercury.Name, PhysicalQuantities.UnitSystems.RSI.Pressure.MillimetreOfMercury },
            }
          },
          { 
            PhysicalQuantities.Quantities.Energy, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Energy.Joule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.Joule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.GigaJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.GigaJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.MegaJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.MegaJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.KiloJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.KiloJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.HectoJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.HectoJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.DecaJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.DecaJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.DeciJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.DeciJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.CentiJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.CentiJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.MilliJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.MilliJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.MicroJoule.Name, PhysicalQuantities.UnitSystems.RSI.Energy.MicroJoule },
              { PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt.Name, PhysicalQuantities.UnitSystems.RSI.Energy.Electronvolt },
              { PhysicalQuantities.UnitSystems.RSI.Energy.MilliElectronvolt.Name, PhysicalQuantities.UnitSystems.RSI.Energy.MilliElectronvolt },
              { PhysicalQuantities.UnitSystems.RSI.Energy.KiloElectronvolt.Name, PhysicalQuantities.UnitSystems.RSI.Energy.KiloElectronvolt },
              { PhysicalQuantities.UnitSystems.RSI.Energy.MegaElectronvolt.Name, PhysicalQuantities.UnitSystems.RSI.Energy.MegaElectronvolt },
            }
          },
          { 
            PhysicalQuantities.Quantities.Power, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Power.Watt.Name, PhysicalQuantities.UnitSystems.RSI.Power.Watt },
              { PhysicalQuantities.UnitSystems.RSI.Power.GigaWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.GigaWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.MegaWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.MegaWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.KiloWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.KiloWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.HectoWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.HectoWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.DecaWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.DecaWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.DeciWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.DeciWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.CentiWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.CentiWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.MilliWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.MilliWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.MicroWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.MicroWatt },
              { PhysicalQuantities.UnitSystems.RSI.Power.TeraWatt.Name, PhysicalQuantities.UnitSystems.RSI.Power.TeraWatt },
            }
          },
          { 
            PhysicalQuantities.Quantities.Voltage, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Voltage.Volt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.Volt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.GigaVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.GigaVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.MegaVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.MegaVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.KiloVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.KiloVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.HectoVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.HectoVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.DecaVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.DecaVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.DeciVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.DeciVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.CentiVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.CentiVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.MilliVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.MilliVolt },
              { PhysicalQuantities.UnitSystems.RSI.Voltage.MicroVolt.Name, PhysicalQuantities.UnitSystems.RSI.Voltage.MicroVolt },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricCapacitance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.Farad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.GigaFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.GigaFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MegaFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MegaFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.KiloFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.KiloFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.HectoFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.HectoFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DecaFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DecaFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DeciFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.DeciFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.CentiFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.CentiFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MilliFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MilliFarad },
              { PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MicroFarad.Name, PhysicalQuantities.UnitSystems.RSI.ElectricCapacitance.MicroFarad },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricResistance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.Ohm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.GigaOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.GigaOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MegaOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MegaOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.KiloOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.KiloOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.HectoOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.HectoOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DecaOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DecaOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DeciOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.DeciOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.CentiOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.CentiOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MilliOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MilliOhm },
              { PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MicroOhm.Name, PhysicalQuantities.UnitSystems.RSI.ElectricResistance.MicroOhm },
            }
          },
          { 
            PhysicalQuantities.Quantities.ElectricConductance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.ElectricConductance.Siemens.Name, PhysicalQuantities.UnitSystems.RSI.ElectricConductance.Siemens },
              { PhysicalQuantities.UnitSystems.RSI.ElectricConductance.MilliSiemens.Name, PhysicalQuantities.UnitSystems.RSI.ElectricConductance.MilliSiemens },
              { PhysicalQuantities.UnitSystems.RSI.ElectricConductance.MicroSiemens.Name, PhysicalQuantities.UnitSystems.RSI.ElectricConductance.MicroSiemens },
            }
          },
          { 
            PhysicalQuantities.Quantities.MagneticFlux, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.Weber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.GigaWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.GigaWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MegaWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MegaWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.KiloWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.KiloWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.HectoWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.HectoWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DecaWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DecaWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DeciWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.DeciWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.CentiWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.CentiWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MilliWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MilliWeber },
              { PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MicroWeber.Name, PhysicalQuantities.UnitSystems.RSI.MagneticFlux.MicroWeber },
            }
          },
          { 
            PhysicalQuantities.Quantities.MagneticField, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.MagneticField.Tesla.Name, PhysicalQuantities.UnitSystems.RSI.MagneticField.Tesla },
              { PhysicalQuantities.UnitSystems.RSI.MagneticField.MilliTesla.Name, PhysicalQuantities.UnitSystems.RSI.MagneticField.MilliTesla },
              { PhysicalQuantities.UnitSystems.RSI.MagneticField.MicroTesla.Name, PhysicalQuantities.UnitSystems.RSI.MagneticField.MicroTesla },
            }
          },
          { 
            PhysicalQuantities.Quantities.LuminousFlux, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.Lumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.KiloLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.KiloLumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.HectoLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.HectoLumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DecaLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DecaLumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DeciLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.DeciLumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.CentiLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.CentiLumen },
              { PhysicalQuantities.UnitSystems.RSI.LuminousFlux.MilliLumen.Name, PhysicalQuantities.UnitSystems.RSI.LuminousFlux.MilliLumen },
            }
          },
          { 
            PhysicalQuantities.Quantities.Illuminance, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.Lux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.KiloLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.KiloLux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.HectoLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.HectoLux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.DecaLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.DecaLux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.DeciLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.DeciLux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.CentiLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.CentiLux },
              { PhysicalQuantities.UnitSystems.RSI.Illuminance.MilliLux.Name, PhysicalQuantities.UnitSystems.RSI.Illuminance.MilliLux },
            }
          },
          { 
            PhysicalQuantities.Quantities.Area, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre.Name, PhysicalQuantities.UnitSystems.RSI.Area.SquareMetre },
              { PhysicalQuantities.UnitSystems.RSI.Area.Are.Name, PhysicalQuantities.UnitSystems.RSI.Area.Are },
              { PhysicalQuantities.UnitSystems.RSI.Area.Centiare.Name, PhysicalQuantities.UnitSystems.RSI.Area.Centiare },
              { PhysicalQuantities.UnitSystems.RSI.Area.Decare.Name, PhysicalQuantities.UnitSystems.RSI.Area.Decare },
              { PhysicalQuantities.UnitSystems.RSI.Area.Hectare.Name, PhysicalQuantities.UnitSystems.RSI.Area.Hectare },
              { PhysicalQuantities.UnitSystems.RSI.Area.SquareKilometre.Name, PhysicalQuantities.UnitSystems.RSI.Area.SquareKilometre },
              { PhysicalQuantities.UnitSystems.RSI.Area.SquareCentimetre.Name, PhysicalQuantities.UnitSystems.RSI.Area.SquareCentimetre },
              { PhysicalQuantities.UnitSystems.RSI.Area.SquareMillimetre.Name, PhysicalQuantities.UnitSystems.RSI.Area.SquareMillimetre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Volume, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicKiloMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicKiloMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicHectoMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicHectoMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicDecaMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicDecaMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicDeciMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicDeciMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicCentiMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicCentiMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CubicMilliMetre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CubicMilliMetre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.Litre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.Litre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.MilliLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.MilliLitre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.CentiLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.CentiLitre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.DeciLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.DeciLitre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.DecaLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.DecaLitre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.HectoLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.HectoLitre },
              { PhysicalQuantities.UnitSystems.RSI.Volume.KiloLitre.Name, PhysicalQuantities.UnitSystems.RSI.Volume.KiloLitre },
            }
          },
          { 
            PhysicalQuantities.Quantities.Speed, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.MetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.KiloMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.KiloMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.HectoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.HectoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.DecaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.DecaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.DeciMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.DeciMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.CentiMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.CentiMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Speed.MilliMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Speed.MilliMetrePerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Acceleration, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.MetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.KiloMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.KiloMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.HectoMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.HectoMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.DecaMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.DecaMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.DeciMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.DeciMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.CentiMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.CentiMetrePerSecondSquared },
              { PhysicalQuantities.UnitSystems.RSI.Acceleration.MilliMetrePerSecondSquared.Name, PhysicalQuantities.UnitSystems.RSI.Acceleration.MilliMetrePerSecondSquared },
            }
          },
          { 
            PhysicalQuantities.Quantities.VolumetricFlow, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicKiloMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicKiloMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicHectoMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicHectoMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDecaMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDecaMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDeciMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicDeciMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicCentiMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicCentiMetrePerSecond },
              { PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMilliMetrePerSecond.Name, PhysicalQuantities.UnitSystems.RSI.VolumetricFlow.CubicMilliMetrePerSecond },
            }
          },
          { 
            PhysicalQuantities.Quantities.Momentum, 
            new Dictionary<string, Unit>
            {
              { PhysicalQuantities.UnitSystems.RSI.Momentum.NewtonSecond.Name, PhysicalQuantities.UnitSystems.RSI.Momentum.NewtonSecond },
              { PhysicalQuantities.UnitSystems.RSI.Momentum.KiloNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Momentum.KiloNewtonPerSecond },
              { PhysicalQuantities.UnitSystems.RSI.Momentum.MilliNewtonPerSecond.Name, PhysicalQuantities.UnitSystems.RSI.Momentum.MilliNewtonPerSecond },
            }
          },
        };

        return unitSystem;
      }	  

      static RSI()
      {
        var temp = PhysicalQuantities.UnitSystems.StaticLoadField;
      }
    }
  }
}
