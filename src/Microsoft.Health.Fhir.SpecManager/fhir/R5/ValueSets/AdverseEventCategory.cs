// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Overall categorization of the event, e.g. product-related or situational.
  /// </summary>
  public static class AdverseEventCategoryCodes
  {
    /// <summary>
    /// The adverse event pertains to a device.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to a hospital acquired infection.
    /// </summary>
    public static readonly Coding HospitalAcquiredInfection = new Coding
    {
      Code = "hospital-aquired-infection",
      Display = "Hospital Acquired Infection",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to a medication mishap, such as wrong dose, route, rate, or duration of administration.
    /// </summary>
    public static readonly Coding MedicationMishap = new Coding
    {
      Code = "medication-mishap",
      Display = "Medication Mishap",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to a procedure mishap.
    /// </summary>
    public static readonly Coding ProcedureMishap = new Coding
    {
      Code = "procedure-mishap",
      Display = "Procedure Mishap",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to an unsafe physical environment.
    /// </summary>
    public static readonly Coding UnsafePhysicalEnvironment = new Coding
    {
      Code = "unsafe-physical-environment",
      Display = "Unsafe Physical Environment",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to the wrong body site.
    /// </summary>
    public static readonly Coding WrongBodySite = new Coding
    {
      Code = "wrong-body-site",
      Display = "Wrong Body Site",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
    /// <summary>
    /// The adverse event pertains to an event involving the wrong patient, who was not the intended subject.
    /// </summary>
    public static readonly Coding WrongPatient = new Coding
    {
      Code = "wrong-patient",
      Display = "Wrong Patient",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-category"
    };
  };
}
