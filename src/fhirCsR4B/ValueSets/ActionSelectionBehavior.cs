// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Defines selection behavior of a group.
  /// </summary>
  public static class ActionSelectionBehaviorCodes
  {
    /// <summary>
    /// All the actions in the group must be selected as a single unit.
    /// </summary>
    public static readonly Coding All = new Coding
    {
      Code = "all",
      Display = "All",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };
    /// <summary>
    /// All the actions in the group are meant to be chosen as a single unit: either all must be selected by the end user, or none may be selected.
    /// </summary>
    public static readonly Coding AllOrNone = new Coding
    {
      Code = "all-or-none",
      Display = "All Or None",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };
    /// <summary>
    /// Any number of the actions in the group may be chosen, from zero to all.
    /// </summary>
    public static readonly Coding Any = new Coding
    {
      Code = "any",
      Display = "Any",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };
    /// <summary>
    /// The end user may choose zero or at most one of the actions in the group.
    /// </summary>
    public static readonly Coding AtMostOne = new Coding
    {
      Code = "at-most-one",
      Display = "At Most One",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };
    /// <summary>
    /// The end user must choose one and only one of the selectable actions in the group. The user SHALL NOT choose none of the actions in the group.
    /// </summary>
    public static readonly Coding ExactlyOne = new Coding
    {
      Code = "exactly-one",
      Display = "Exactly One",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };
    /// <summary>
    /// The end user must choose a minimum of one, and as many additional as desired.
    /// </summary>
    public static readonly Coding OneOrMore = new Coding
    {
      Code = "one-or-more",
      Display = "One Or More",
      System = "http://hl7.org/fhir/action-selection-behavior"
    };

    /// <summary>
    /// Literal for code: All
    /// </summary>
    public const string LiteralAll = "all";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorAll
    /// </summary>
    public const string LiteralActionSelectionBehaviorAll = "http://hl7.org/fhir/action-selection-behavior#all";

    /// <summary>
    /// Literal for code: AllOrNone
    /// </summary>
    public const string LiteralAllOrNone = "all-or-none";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorAllOrNone
    /// </summary>
    public const string LiteralActionSelectionBehaviorAllOrNone = "http://hl7.org/fhir/action-selection-behavior#all-or-none";

    /// <summary>
    /// Literal for code: Any
    /// </summary>
    public const string LiteralAny = "any";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorAny
    /// </summary>
    public const string LiteralActionSelectionBehaviorAny = "http://hl7.org/fhir/action-selection-behavior#any";

    /// <summary>
    /// Literal for code: AtMostOne
    /// </summary>
    public const string LiteralAtMostOne = "at-most-one";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorAtMostOne
    /// </summary>
    public const string LiteralActionSelectionBehaviorAtMostOne = "http://hl7.org/fhir/action-selection-behavior#at-most-one";

    /// <summary>
    /// Literal for code: ExactlyOne
    /// </summary>
    public const string LiteralExactlyOne = "exactly-one";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorExactlyOne
    /// </summary>
    public const string LiteralActionSelectionBehaviorExactlyOne = "http://hl7.org/fhir/action-selection-behavior#exactly-one";

    /// <summary>
    /// Literal for code: OneOrMore
    /// </summary>
    public const string LiteralOneOrMore = "one-or-more";

    /// <summary>
    /// Literal for code: ActionSelectionBehaviorOneOrMore
    /// </summary>
    public const string LiteralActionSelectionBehaviorOneOrMore = "http://hl7.org/fhir/action-selection-behavior#one-or-more";

    /// <summary>
    /// Dictionary for looking up ActionSelectionBehavior Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "all", All }, 
      { "http://hl7.org/fhir/action-selection-behavior#all", All }, 
      { "all-or-none", AllOrNone }, 
      { "http://hl7.org/fhir/action-selection-behavior#all-or-none", AllOrNone }, 
      { "any", Any }, 
      { "http://hl7.org/fhir/action-selection-behavior#any", Any }, 
      { "at-most-one", AtMostOne }, 
      { "http://hl7.org/fhir/action-selection-behavior#at-most-one", AtMostOne }, 
      { "exactly-one", ExactlyOne }, 
      { "http://hl7.org/fhir/action-selection-behavior#exactly-one", ExactlyOne }, 
      { "one-or-more", OneOrMore }, 
      { "http://hl7.org/fhir/action-selection-behavior#one-or-more", OneOrMore }, 
    };
  };
}
