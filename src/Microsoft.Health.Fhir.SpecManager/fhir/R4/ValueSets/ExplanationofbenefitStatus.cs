// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A code specifying the state of the resource instance.
  /// </summary>
  public static class ExplanationofbenefitStatusCodes
  {
    /// <summary>
    /// The resource instance is currently in-force.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/explanationofbenefit-status"
    };
    /// <summary>
    /// The resource instance is withdrawn, rescinded or reversed.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/explanationofbenefit-status"
    };
    /// <summary>
    /// A new resource instance the contents of which is not complete.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/explanationofbenefit-status"
    };
    /// <summary>
    /// The resource instance was entered in error.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/explanationofbenefit-status"
    };
  };
}
