// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The expectation of whether the test must pass for the system to be considered conformant with the artifact.
  /// </summary>
  public static class TestscriptScopeConformanceCodesCodes
  {
    /// <summary>
    /// All tests are expected to pass but non-pass statuses may be allowed.
    /// </summary>
    public static readonly Coding Optional = new Coding
    {
      Code = "optional",
      Display = "optional",
      System = "http://terminology.hl7.org/CodeSystem/testscript-scope-conformance-codes"
    };
    /// <summary>
    /// All tests are expected to pass. This is the default value.
    /// </summary>
    public static readonly Coding Required = new Coding
    {
      Code = "required",
      Display = "required",
      System = "http://terminology.hl7.org/CodeSystem/testscript-scope-conformance-codes"
    };
  };
}
