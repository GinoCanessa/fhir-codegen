// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Defines behavior for an action or a group for how many times that item may be repeated.
  /// </summary>
  public static class ActionCardinalityBehaviorCodes
  {
    /// <summary>
    /// The action may be selected multiple times.
    /// </summary>
    public static readonly Coding Multiple = new Coding
    {
      Code = "multiple",
      Display = "Multiple",
      System = "http://hl7.org/fhir/action-cardinality-behavior"
    };
    /// <summary>
    /// The action may only be selected one time.
    /// </summary>
    public static readonly Coding Single = new Coding
    {
      Code = "single",
      Display = "Single",
      System = "http://hl7.org/fhir/action-cardinality-behavior"
    };

    /// <summary>
    /// Literal for code: Multiple
    /// </summary>
    public const string LiteralMultiple = "multiple";

    /// <summary>
    /// Literal for code: ActionCardinalityBehaviorMultiple
    /// </summary>
    public const string LiteralActionCardinalityBehaviorMultiple = "http://hl7.org/fhir/action-cardinality-behavior#multiple";

    /// <summary>
    /// Literal for code: Single
    /// </summary>
    public const string LiteralSingle = "single";

    /// <summary>
    /// Literal for code: ActionCardinalityBehaviorSingle
    /// </summary>
    public const string LiteralActionCardinalityBehaviorSingle = "http://hl7.org/fhir/action-cardinality-behavior#single";

    /// <summary>
    /// Dictionary for looking up ActionCardinalityBehavior Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "multiple", Multiple }, 
      { "http://hl7.org/fhir/action-cardinality-behavior#multiple", Multiple }, 
      { "single", Single }, 
      { "http://hl7.org/fhir/action-cardinality-behavior#single", Single }, 
    };
  };
}
