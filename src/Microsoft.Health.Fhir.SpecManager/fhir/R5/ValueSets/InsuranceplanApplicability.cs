// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Whether the cost applies to in-network or out-of-network providers.
  /// </summary>
  public static class InsuranceplanApplicabilityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InNetwork = new Coding
    {
      Code = "in-network",
      Display = "In Network",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutOfNetwork = new Coding
    {
      Code = "out-of-network",
      Display = "Out of Network",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };
  };
}
