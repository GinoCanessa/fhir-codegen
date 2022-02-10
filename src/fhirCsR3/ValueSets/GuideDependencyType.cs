// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// How a dependency is represented when the guide is published.
  /// </summary>
  public static class GuideDependencyTypeCodes
  {
    /// <summary>
    /// The guide is embedded in this guide when published.
    /// </summary>
    public static readonly Coding Inclusion = new Coding
    {
      Code = "inclusion",
      Display = "Inclusion",
      System = "http://hl7.org/fhir/guide-dependency-type"
    };
    /// <summary>
    /// The guide is referred to by URL.
    /// </summary>
    public static readonly Coding Reference = new Coding
    {
      Code = "reference",
      Display = "Reference",
      System = "http://hl7.org/fhir/guide-dependency-type"
    };

    /// <summary>
    /// Literal for code: Inclusion
    /// </summary>
    public const string LiteralInclusion = "inclusion";

    /// <summary>
    /// Literal for code: GuideDependencyTypeInclusion
    /// </summary>
    public const string LiteralGuideDependencyTypeInclusion = "http://hl7.org/fhir/guide-dependency-type#inclusion";

    /// <summary>
    /// Literal for code: Reference
    /// </summary>
    public const string LiteralReference = "reference";

    /// <summary>
    /// Literal for code: GuideDependencyTypeReference
    /// </summary>
    public const string LiteralGuideDependencyTypeReference = "http://hl7.org/fhir/guide-dependency-type#reference";

    /// <summary>
    /// Dictionary for looking up GuideDependencyType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "inclusion", Inclusion }, 
      { "http://hl7.org/fhir/guide-dependency-type#inclusion", Inclusion }, 
      { "reference", Reference }, 
      { "http://hl7.org/fhir/guide-dependency-type#reference", Reference }, 
    };
  };
}
