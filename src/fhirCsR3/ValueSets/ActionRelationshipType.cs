// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Defines the types of relationships between actions
  /// </summary>
  public static class ActionRelationshipTypeCodes
  {
    /// <summary>
    /// The action must be performed after the related action
    /// </summary>
    public static readonly Coding After = new Coding
    {
      Code = "after",
      Display = "After",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the end of the related action
    /// </summary>
    public static readonly Coding AfterEnd = new Coding
    {
      Code = "after-end",
      Display = "After End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the start of the related action
    /// </summary>
    public static readonly Coding AfterStart = new Coding
    {
      Code = "after-start",
      Display = "After Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the related action
    /// </summary>
    public static readonly Coding Before = new Coding
    {
      Code = "before",
      Display = "Before",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the end of the related action
    /// </summary>
    public static readonly Coding BeforeEnd = new Coding
    {
      Code = "before-end",
      Display = "Before End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the start of the related action
    /// </summary>
    public static readonly Coding BeforeStart = new Coding
    {
      Code = "before-start",
      Display = "Before Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the related action
    /// </summary>
    public static readonly Coding Concurrent = new Coding
    {
      Code = "concurrent",
      Display = "Concurrent",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the end of the related action
    /// </summary>
    public static readonly Coding ConcurrentWithEnd = new Coding
    {
      Code = "concurrent-with-end",
      Display = "Concurrent With End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the start of the related action
    /// </summary>
    public static readonly Coding ConcurrentWithStart = new Coding
    {
      Code = "concurrent-with-start",
      Display = "Concurrent With Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };

    /// <summary>
    /// Literal for code: After
    /// </summary>
    public const string LiteralAfter = "after";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeAfter
    /// </summary>
    public const string LiteralActionRelationshipTypeAfter = "http://hl7.org/fhir/action-relationship-type#after";

    /// <summary>
    /// Literal for code: AfterEnd
    /// </summary>
    public const string LiteralAfterEnd = "after-end";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeAfterEnd
    /// </summary>
    public const string LiteralActionRelationshipTypeAfterEnd = "http://hl7.org/fhir/action-relationship-type#after-end";

    /// <summary>
    /// Literal for code: AfterStart
    /// </summary>
    public const string LiteralAfterStart = "after-start";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeAfterStart
    /// </summary>
    public const string LiteralActionRelationshipTypeAfterStart = "http://hl7.org/fhir/action-relationship-type#after-start";

    /// <summary>
    /// Literal for code: Before
    /// </summary>
    public const string LiteralBefore = "before";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeBefore
    /// </summary>
    public const string LiteralActionRelationshipTypeBefore = "http://hl7.org/fhir/action-relationship-type#before";

    /// <summary>
    /// Literal for code: BeforeEnd
    /// </summary>
    public const string LiteralBeforeEnd = "before-end";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeBeforeEnd
    /// </summary>
    public const string LiteralActionRelationshipTypeBeforeEnd = "http://hl7.org/fhir/action-relationship-type#before-end";

    /// <summary>
    /// Literal for code: BeforeStart
    /// </summary>
    public const string LiteralBeforeStart = "before-start";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeBeforeStart
    /// </summary>
    public const string LiteralActionRelationshipTypeBeforeStart = "http://hl7.org/fhir/action-relationship-type#before-start";

    /// <summary>
    /// Literal for code: Concurrent
    /// </summary>
    public const string LiteralConcurrent = "concurrent";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeConcurrent
    /// </summary>
    public const string LiteralActionRelationshipTypeConcurrent = "http://hl7.org/fhir/action-relationship-type#concurrent";

    /// <summary>
    /// Literal for code: ConcurrentWithEnd
    /// </summary>
    public const string LiteralConcurrentWithEnd = "concurrent-with-end";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeConcurrentWithEnd
    /// </summary>
    public const string LiteralActionRelationshipTypeConcurrentWithEnd = "http://hl7.org/fhir/action-relationship-type#concurrent-with-end";

    /// <summary>
    /// Literal for code: ConcurrentWithStart
    /// </summary>
    public const string LiteralConcurrentWithStart = "concurrent-with-start";

    /// <summary>
    /// Literal for code: ActionRelationshipTypeConcurrentWithStart
    /// </summary>
    public const string LiteralActionRelationshipTypeConcurrentWithStart = "http://hl7.org/fhir/action-relationship-type#concurrent-with-start";

    /// <summary>
    /// Dictionary for looking up ActionRelationshipType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "after", After }, 
      { "http://hl7.org/fhir/action-relationship-type#after", After }, 
      { "after-end", AfterEnd }, 
      { "http://hl7.org/fhir/action-relationship-type#after-end", AfterEnd }, 
      { "after-start", AfterStart }, 
      { "http://hl7.org/fhir/action-relationship-type#after-start", AfterStart }, 
      { "before", Before }, 
      { "http://hl7.org/fhir/action-relationship-type#before", Before }, 
      { "before-end", BeforeEnd }, 
      { "http://hl7.org/fhir/action-relationship-type#before-end", BeforeEnd }, 
      { "before-start", BeforeStart }, 
      { "http://hl7.org/fhir/action-relationship-type#before-start", BeforeStart }, 
      { "concurrent", Concurrent }, 
      { "http://hl7.org/fhir/action-relationship-type#concurrent", Concurrent }, 
      { "concurrent-with-end", ConcurrentWithEnd }, 
      { "http://hl7.org/fhir/action-relationship-type#concurrent-with-end", ConcurrentWithEnd }, 
      { "concurrent-with-start", ConcurrentWithStart }, 
      { "http://hl7.org/fhir/action-relationship-type#concurrent-with-start", ConcurrentWithStart }, 
    };
  };
}
