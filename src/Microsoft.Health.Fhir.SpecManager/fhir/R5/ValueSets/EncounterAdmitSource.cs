// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to indicate from where the patient came in.
  /// </summary>
  public static class EncounterAdmitSourceCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding BornInHospital = new Coding
    {
      Code = "born",
      Display = "Born in hospital",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FromAccidentEmergencyDepartment = new Coding
    {
      Code = "emd",
      Display = "From accident/emergency department",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GeneralPractitionerReferral = new Coding
    {
      Code = "gp",
      Display = "General Practitioner referral",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TransferredFromOtherHospital = new Coding
    {
      Code = "hosp-trans",
      Display = "Transferred from other hospital",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding MedicalPractitionerPhysicianReferral = new Coding
    {
      Code = "mp",
      Display = "Medical Practitioner/physician referral",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FromNursingHome = new Coding
    {
      Code = "nursing",
      Display = "From nursing home",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FromOutpatientDepartment = new Coding
    {
      Code = "outp",
      Display = "From outpatient department",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FromPsychiatricHospital = new Coding
    {
      Code = "psych",
      Display = "From psychiatric hospital",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FromRehabilitationFacility = new Coding
    {
      Code = "rehab",
      Display = "From rehabilitation facility",
      System = "http://terminology.hl7.org/CodeSystem/admit-source"
    };
  };
}
