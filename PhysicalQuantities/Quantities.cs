using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicalQuantities
{
  /// <summary>
  /// Define quantities: Length, Time, Mass, Temperature, Substance, ElectricCurrent, LuminousIntensity, Dimensionless, Area, Volume, Speed, Acceleration, VolumetricFlow, Jerk, Jounce, Frequency, Angle, SolidAngle, Force, Pressure, Energy, Power, ElectricCharge, Voltage, ElectricCapacitance, ElectricResistance, ElectricConductance, MagneticFlux, MagneticField, Inductance, LuminousFlux, Illuminance, RadioactiveDecay, AbsorbedDose, EquivalentDose, CatalyticActivity, AngularVelocity, Momentum, AngularMomentum, Torque, Yank, Wavenumber, AreaDensity, Density, SpecificVolume, Action, HeatCapacity, NewtonianConstantOfGravitationQuantity
  /// </summary>
  public static partial class Quantities
  {
    #region [ Base Quantities ]
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Length
    /// </summary>
    public static readonly BaseQuantity Length;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Time
    /// </summary>
    public static readonly BaseQuantity Time;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Mass
    /// </summary>
    public static readonly BaseQuantity Mass;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Temperature
    /// </summary>
    public static readonly BaseQuantity Temperature;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Amount_of_substance
    /// </summary>
    public static readonly BaseQuantity Substance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Electric_current
    /// </summary>
    public static readonly BaseQuantity ElectricCurrent;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Luminous_intensity
    /// </summary>
    public static readonly BaseQuantity LuminousIntensity;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Dimensionless_quantity
    /// </summary>
    public static readonly BaseQuantity Dimensionless;
    #endregion [ Base Quantities ]

    #region [ Derived Quantities ]
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Area
    /// </summary>
    public static readonly DerivedQuantity Area;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Volume
    /// </summary>
    public static readonly DerivedQuantity Volume;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Speed
    /// </summary>
    public static readonly DerivedQuantity Speed;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Acceleration
    /// </summary>
    public static readonly DerivedQuantity Acceleration;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Volumetric_flow
    /// </summary>
    public static readonly DerivedQuantity VolumetricFlow;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Jerk_(physics)
    /// </summary>
    public static readonly DerivedQuantity Jerk;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Jounce
    /// </summary>
    public static readonly DerivedQuantity Jounce;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Frequency
    /// </summary>
    public static readonly DerivedQuantity Frequency;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Angle
    /// </summary>
    public static readonly DerivedQuantity Angle;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Solid_angle
    /// </summary>
    public static readonly DerivedQuantity SolidAngle;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Force
    /// </summary>
    public static readonly DerivedQuantity Force;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Pressure
    /// </summary>
    public static readonly DerivedQuantity Pressure;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Energy
    /// </summary>
    public static readonly DerivedQuantity Energy;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Power_(physics)
    /// </summary>
    public static readonly DerivedQuantity Power;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Electric_charge
    /// </summary>
    public static readonly DerivedQuantity ElectricCharge;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Voltage
    /// </summary>
    public static readonly DerivedQuantity Voltage;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Electric_capacitance
    /// </summary>
    public static readonly DerivedQuantity ElectricCapacitance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Electric_resistance
    /// </summary>
    public static readonly DerivedQuantity ElectricResistance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Electrical_conductance
    /// </summary>
    public static readonly DerivedQuantity ElectricConductance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Magnetic_flux
    /// </summary>
    public static readonly DerivedQuantity MagneticFlux;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Magnetic_field
    /// </summary>
    public static readonly DerivedQuantity MagneticField;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Inductance
    /// </summary>
    public static readonly DerivedQuantity Inductance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Luminous_flux
    /// </summary>
    public static readonly DerivedQuantity LuminousFlux;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Illuminance
    /// </summary>
    public static readonly DerivedQuantity Illuminance;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Radioactivity
    /// </summary>
    public static readonly DerivedQuantity RadioactiveDecay;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Absorbed_dose
    /// </summary>
    public static readonly DerivedQuantity AbsorbedDose;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Equivalent_dose
    /// </summary>
    public static readonly DerivedQuantity EquivalentDose;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Catalytic_activity
    /// </summary>
    public static readonly DerivedQuantity CatalyticActivity;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Angular_velocity
    /// </summary>
    public static readonly DerivedQuantity AngularVelocity;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Momentum
    /// </summary>
    public static readonly DerivedQuantity Momentum;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Angular_momentum
    /// </summary>
    public static readonly DerivedQuantity AngularMomentum;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Torque
    /// </summary>
    public static readonly DerivedQuantity Torque;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Yank_(physics)
    /// </summary>
    public static readonly DerivedQuantity Yank;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Wavenumber
    /// </summary>
    public static readonly DerivedQuantity Wavenumber;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Area_density
    /// </summary>
    public static readonly DerivedQuantity AreaDensity;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Density
    /// </summary>
    public static readonly DerivedQuantity Density;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Specific_volume
    /// </summary>
    public static readonly DerivedQuantity SpecificVolume;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Action_(physics)
    /// </summary>
    public static readonly DerivedQuantity Action;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Heat_capacity
    /// </summary>
    public static readonly DerivedQuantity HeatCapacity;
    /// <summary>
    /// Reference: http://en.wikipedia.org/wiki/Gravitational_constant
    /// </summary>
    public static readonly DerivedQuantity NewtonianConstantOfGravitationQuantity;
    #endregion [ Derived Quantities ]
	
    #region [ Lookup ]
    private static Dictionary<string, Quantity> allQuantities;
    public static Quantity GetQuantity(string quantityName)
    {
      Quantity result;
      if (allQuantities.TryGetValue(quantityName, out result))
        return result;
      return null;
    }
    public static IEnumerable<Quantity> AllQuantities
    {
      get
      {
        return allQuantities.Values;
      }
    }
    #endregion [ Lookup ]

    static Quantities()
    {
      #region [ Base Quantities ]
      Length = new BaseQuantity(@"Length", @"L") { Caption = @"Longitud" };
      Time = new BaseQuantity(@"Time", @"T") { Caption = @"Tiempo" };
      Mass = new BaseQuantity(@"Mass", @"M") { Caption = @"Masa" };
      Temperature = new BaseQuantity(@"Temperature", @"Θ") { Caption = @"Temperatura" };
      Substance = new BaseQuantity(@"Substance", @"N") { Caption = @"Substancia" };
      ElectricCurrent = new BaseQuantity(@"ElectricCurrent", @"I") { Caption = @"Corriente eléctrica" };
      LuminousIntensity = new BaseQuantity(@"LuminousIntensity", @"J") { Caption = @"Intensidad luminosa" };
      Dimensionless = new BaseQuantity(@"Dimensionless", @"1") { Caption = @"Sin dimensión" };
      #endregion [ Base Quantities ]

      #region [ Derived Quantities ]
      Area = new DerivedQuantity(@"Area", @"A", new QuantityExp(Quantities.Length, 2)) { Caption = @"Área" };
      Volume = new DerivedQuantity(@"Volume", @"V", new QuantityExp(Quantities.Length, 3)) { Caption = @"Volumen" };
      Speed = new DerivedQuantity(@"Speed", @"V", new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Velocidad" };
      Acceleration = new DerivedQuantity(@"Acceleration", @"A", new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Time, -2)) { Caption = @"Aceleración" };
      VolumetricFlow = new DerivedQuantity(@"VolumetricFlow", null, new QuantityExp(Quantities.Volume, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Ritmo de flujo volumétrico" };
      Jerk = new DerivedQuantity(@"Jerk", null, new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Time, -3)) { Caption = @"Sacudida" };
      Jounce = new DerivedQuantity(@"Jounce", null, new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Time, -4)) { Caption = @"Choque" };
      Frequency = new DerivedQuantity(@"Frequency", @"ν", new QuantityExp(Quantities.Time, -1)) { Caption = @"Frecuencia" };
      Angle = new DerivedQuantity(@"Angle", @"∠", new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Length, -1)) { Caption = @"Ángulo" };
      SolidAngle = new DerivedQuantity(@"SolidAngle", null, new QuantityExp(Quantities.Area, 1), new QuantityExp(Quantities.Area, -1)) { Caption = @"Ángulo sólido" };
      Force = new DerivedQuantity(@"Force", @"F", new QuantityExp(Quantities.Mass, 1), new QuantityExp(Quantities.Length, 1), new QuantityExp(Quantities.Time, -2)) { Caption = @"Fuerza" };
      Pressure = new DerivedQuantity(@"Pressure", @"p", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Area, -1)) { Caption = @"Presión" };
      Energy = new DerivedQuantity(@"Energy", @"W", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Length, 1)) { Caption = @"Energía" };
      Power = new DerivedQuantity(@"Power", @"P", new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Potencia" };
      ElectricCharge = new DerivedQuantity(@"ElectricCharge", @"Q", new QuantityExp(Quantities.Time, 1), new QuantityExp(Quantities.ElectricCurrent, 1)) { Caption = @"Carga eléctrica" };
      Voltage = new DerivedQuantity(@"Voltage", @"V", new QuantityExp(Quantities.Power, 1), new QuantityExp(Quantities.ElectricCurrent, -1)) { Caption = @"Voltaje" };
      ElectricCapacitance = new DerivedQuantity(@"ElectricCapacitance", @"C", new QuantityExp(Quantities.ElectricCharge, 1), new QuantityExp(Quantities.Voltage, -1)) { Caption = @"Capacidad eléctrica" };
      ElectricResistance = new DerivedQuantity(@"ElectricResistance", @"R", new QuantityExp(Quantities.Voltage, 1), new QuantityExp(Quantities.ElectricCurrent, -1)) { Caption = @"Resistencia eléctrica" };
      ElectricConductance = new DerivedQuantity(@"ElectricConductance", @"G", new QuantityExp(Quantities.ElectricResistance, -1)) { Caption = @"Conductividad eléctrica" };
      MagneticFlux = new DerivedQuantity(@"MagneticFlux", null, new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.ElectricCurrent, -1)) { Caption = @"Flujo magnético" };
      MagneticField = new DerivedQuantity(@"MagneticField", null, new QuantityExp(Quantities.Voltage, 1), new QuantityExp(Quantities.Time, 1), new QuantityExp(Quantities.Area, -1)) { Caption = @"Campo magnético" };
      Inductance = new DerivedQuantity(@"Inductance", @"L", new QuantityExp(Quantities.Voltage, 1), new QuantityExp(Quantities.Time, 1), new QuantityExp(Quantities.ElectricCurrent, -1)) { Caption = @"Inductancia" };
      LuminousFlux = new DerivedQuantity(@"LuminousFlux", @"Φv", new QuantityExp(Quantities.LuminousIntensity, 1), new QuantityExp(Quantities.SolidAngle, -1)) { Caption = @"Flujo luminoso" };
      Illuminance = new DerivedQuantity(@"Illuminance", @"Ev", new QuantityExp(Quantities.LuminousFlux, 1), new QuantityExp(Quantities.Area, -1)) { Caption = @"Iluminancia" };
      RadioactiveDecay = new DerivedQuantity(@"RadioactiveDecay", null, new QuantityExp(Quantities.Frequency, 1)) { Caption = @"Desintegración radioactiva" };
      AbsorbedDose = new DerivedQuantity(@"AbsorbedDose", @"TID", new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.Mass, -1)) { Caption = @"Dosis absorbida" };
      EquivalentDose = new DerivedQuantity(@"EquivalentDose", @"HT", new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.Mass, -1)) { Caption = @"Dosis equivalente" };
      CatalyticActivity = new DerivedQuantity(@"CatalyticActivity", null, new QuantityExp(Quantities.Substance, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Actividad catalítica" };
      AngularVelocity = new DerivedQuantity(@"AngularVelocity", null, new QuantityExp(Quantities.Angle, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Velocidad angular" };
      Momentum = new DerivedQuantity(@"Momentum", @"p", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Time, 1)) { Caption = @"Momento" };
      AngularMomentum = new DerivedQuantity(@"AngularMomentum", @"L", new QuantityExp(Quantities.Momentum, 1), new QuantityExp(Quantities.Length, 1)) { Caption = @"Momento angular" };
      Torque = new DerivedQuantity(@"Torque", @"τ", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Length, 1)) { Caption = @"Torsión" };
      Yank = new DerivedQuantity(@"Yank", @"Y", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Time, -1)) { Caption = @"Tirón" };
      Wavenumber = new DerivedQuantity(@"Wavenumber", @"σ", new QuantityExp(Quantities.Length, -1)) { Caption = @"Número de ondas" };
      AreaDensity = new DerivedQuantity(@"AreaDensity", @"ρA", new QuantityExp(Quantities.Mass, 1), new QuantityExp(Quantities.Area, -1)) { Caption = @"Densidad de área" };
      Density = new DerivedQuantity(@"Density", @"ρ", new QuantityExp(Quantities.Mass, 1), new QuantityExp(Quantities.Volume, -1)) { Caption = @"Densidad" };
      SpecificVolume = new DerivedQuantity(@"SpecificVolume", @"v", new QuantityExp(Quantities.Density, -1)) { Caption = @"Volumen específico" };
      Action = new DerivedQuantity(@"Action", @"S", new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.Time, 1)) { Caption = @"Acción" };
      HeatCapacity = new DerivedQuantity(@"HeatCapacity", @"C", new QuantityExp(Quantities.Energy, 1), new QuantityExp(Quantities.Temperature, -1)) { Caption = @"Capacidad calorífica" };
      NewtonianConstantOfGravitationQuantity = new DerivedQuantity(@"NewtonianConstantOfGravitationQuantity", @"G", new QuantityExp(Quantities.Force, 1), new QuantityExp(Quantities.Length, 2), new QuantityExp(Quantities.Mass, -2)) { Caption = @"Magnitud de constante de gravitación newtoniana" };
      #endregion [ Derived Quantities ]

      #region [ Initialize All Quantities ]
      allQuantities = new Dictionary<string, Quantity>
      {
        { Quantities.Length.Name, Quantities.Length },
        { Quantities.Time.Name, Quantities.Time },
        { Quantities.Mass.Name, Quantities.Mass },
        { Quantities.Temperature.Name, Quantities.Temperature },
        { Quantities.Substance.Name, Quantities.Substance },
        { Quantities.ElectricCurrent.Name, Quantities.ElectricCurrent },
        { Quantities.LuminousIntensity.Name, Quantities.LuminousIntensity },
        { Quantities.Dimensionless.Name, Quantities.Dimensionless },
        { Quantities.Area.Name, Quantities.Area },
        { Quantities.Volume.Name, Quantities.Volume },
        { Quantities.Speed.Name, Quantities.Speed },
        { Quantities.Acceleration.Name, Quantities.Acceleration },
        { Quantities.VolumetricFlow.Name, Quantities.VolumetricFlow },
        { Quantities.Jerk.Name, Quantities.Jerk },
        { Quantities.Jounce.Name, Quantities.Jounce },
        { Quantities.Frequency.Name, Quantities.Frequency },
        { Quantities.Angle.Name, Quantities.Angle },
        { Quantities.SolidAngle.Name, Quantities.SolidAngle },
        { Quantities.Force.Name, Quantities.Force },
        { Quantities.Pressure.Name, Quantities.Pressure },
        { Quantities.Energy.Name, Quantities.Energy },
        { Quantities.Power.Name, Quantities.Power },
        { Quantities.ElectricCharge.Name, Quantities.ElectricCharge },
        { Quantities.Voltage.Name, Quantities.Voltage },
        { Quantities.ElectricCapacitance.Name, Quantities.ElectricCapacitance },
        { Quantities.ElectricResistance.Name, Quantities.ElectricResistance },
        { Quantities.ElectricConductance.Name, Quantities.ElectricConductance },
        { Quantities.MagneticFlux.Name, Quantities.MagneticFlux },
        { Quantities.MagneticField.Name, Quantities.MagneticField },
        { Quantities.Inductance.Name, Quantities.Inductance },
        { Quantities.LuminousFlux.Name, Quantities.LuminousFlux },
        { Quantities.Illuminance.Name, Quantities.Illuminance },
        { Quantities.RadioactiveDecay.Name, Quantities.RadioactiveDecay },
        { Quantities.AbsorbedDose.Name, Quantities.AbsorbedDose },
        { Quantities.EquivalentDose.Name, Quantities.EquivalentDose },
        { Quantities.CatalyticActivity.Name, Quantities.CatalyticActivity },
        { Quantities.AngularVelocity.Name, Quantities.AngularVelocity },
        { Quantities.Momentum.Name, Quantities.Momentum },
        { Quantities.AngularMomentum.Name, Quantities.AngularMomentum },
        { Quantities.Torque.Name, Quantities.Torque },
        { Quantities.Yank.Name, Quantities.Yank },
        { Quantities.Wavenumber.Name, Quantities.Wavenumber },
        { Quantities.AreaDensity.Name, Quantities.AreaDensity },
        { Quantities.Density.Name, Quantities.Density },
        { Quantities.SpecificVolume.Name, Quantities.SpecificVolume },
        { Quantities.Action.Name, Quantities.Action },
        { Quantities.HeatCapacity.Name, Quantities.HeatCapacity },
        { Quantities.NewtonianConstantOfGravitationQuantity.Name, Quantities.NewtonianConstantOfGravitationQuantity },
      };
      #endregion [ Initialize All Quantities ]
    }
  }
}
