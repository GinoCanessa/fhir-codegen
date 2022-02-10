// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The lifecycle status of a Value Set or Concept Map.
  /// </summary>
  public static class PublicationStatusCodes
  {
    /// <summary>
    /// This resource is ready for normal use.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/publication-status"
    };
    /// <summary>
    /// This resource is still under development and is not yet considered to be ready for normal use.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/publication-status"
    };
    /// <summary>
    /// This resource has been withdrawn or superseded and should no longer be used.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://hl7.org/fhir/publication-status"
    };
    /// <summary>
    /// The authoring system does not know which of the status values currently applies for this resource.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, it's just not known which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/publication-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: PublicationStatusActive
    /// </summary>
    public const string LiteralPublicationStatusActive = "http://hl7.org/fhir/publication-status#active";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: PublicationStatusDraft
    /// </summary>
    public const string LiteralPublicationStatusDraft = "http://hl7.org/fhir/publication-status#draft";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";

    /// <summary>
    /// Literal for code: PublicationStatusRetired
    /// </summary>
    public const string LiteralPublicationStatusRetired = "http://hl7.org/fhir/publication-status#retired";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: PublicationStatusUnknown
    /// </summary>
    public const string LiteralPublicationStatusUnknown = "http://hl7.org/fhir/publication-status#unknown";

    /// <summary>
    /// Dictionary for looking up PublicationStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/publication-status#active", Active }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/publication-status#draft", Draft }, 
      { "retired", Retired }, 
      { "http://hl7.org/fhir/publication-status#retired", Retired }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/publication-status#unknown", Unknown }, 
    };
  };
}
