// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Set of codes indicating the type of incident or accident.
  /// </summary>
  public static class V3ActIncidentCodeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ActPatientSafetyIncidentCode = new Coding
    {
      Code = "_ActPatientSafetyIncidentCode",
      Display = "ActPatientSafetyIncidentCode",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding MotorVehicleAccident = new Coding
    {
      Code = "MVA",
      Display = "Motor vehicle accident",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SchoolAccident = new Coding
    {
      Code = "SCHOOL",
      Display = "School Accident",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SportingAccident = new Coding
    {
      Code = "SPT",
      Display = "Sporting Accident",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WorkplaceAccident = new Coding
    {
      Code = "WPA",
      Display = "Workplace accident",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
  };
}
