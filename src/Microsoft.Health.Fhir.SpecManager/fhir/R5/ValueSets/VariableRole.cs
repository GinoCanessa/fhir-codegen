// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The role that the assertion variable plays.
  /// </summary>
  public static class VariableRoleCodes
  {
    /// <summary>
    /// variable represents a confounder.
    /// </summary>
    public static readonly Coding Confounder = new Coding
    {
      Code = "confounder",
      Display = "confounder",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
    /// <summary>
    /// variable represents an exposure.
    /// </summary>
    public static readonly Coding Exposure = new Coding
    {
      Code = "exposure",
      Display = "exposure",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
    /// <summary>
    /// variable represents a measured variable.
    /// </summary>
    public static readonly Coding MeasuredVariable = new Coding
    {
      Code = "measuredVariable",
      Display = "measured variable",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
    /// <summary>
    /// variable represents a population.
    /// </summary>
    public static readonly Coding Population = new Coding
    {
      Code = "population",
      Display = "population",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
    /// <summary>
    /// variable represents a reference exposure.
    /// </summary>
    public static readonly Coding ReferenceExposure = new Coding
    {
      Code = "referenceExposure",
      Display = "reference exposure",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
    /// <summary>
    /// variable represents a subpopulation.
    /// </summary>
    public static readonly Coding Subpopulation = new Coding
    {
      Code = "subpopulation",
      Display = "subpopulation",
      System = "http://terminology.hl7.org/CodeSystem/variable-role"
    };
  };
}
