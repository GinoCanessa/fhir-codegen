// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Actor Role codes.
  /// </summary>
  public static class ContractActorroleCodes
  {
    /// <summary>
    /// A receiver, human or animal, of health care related goods and services.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "patient",
      Display = "Patient",
      System = "http://terminology.hl7.org/CodeSystem/contractactorrole"
    };
    /// <summary>
    /// Someone who provides health care related services to people or animals including both clinical and support services.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://terminology.hl7.org/CodeSystem/contractactorrole"
    };
  };
}
