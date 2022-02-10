// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// TODO (and should this be required?)
  /// </summary>
  public static class AdverseEventOutcomeCodes
  {
    /// <summary>
    /// Fatal
    /// </summary>
    public static readonly Coding Fatal = new Coding
    {
      Code = "fatal",
      Display = "Fatal",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };
    /// <summary>
    /// Ongoing
    /// </summary>
    public static readonly Coding Ongoing = new Coding
    {
      Code = "ongoing",
      Display = "Ongoing",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };
    /// <summary>
    /// Recovering
    /// </summary>
    public static readonly Coding Recovering = new Coding
    {
      Code = "recovering",
      Display = "Recovering",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };
    /// <summary>
    /// Resolved
    /// </summary>
    public static readonly Coding Resolved = new Coding
    {
      Code = "resolved",
      Display = "Resolved",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };
    /// <summary>
    /// Resolved with Sequelae
    /// </summary>
    public static readonly Coding ResolvedWithSequelae = new Coding
    {
      Code = "resolvedWithSequelae",
      Display = "Resolved with Sequelae",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };
    /// <summary>
    /// Unknown
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/adverse-event-outcome"
    };

    /// <summary>
    /// Literal for code: Fatal
    /// </summary>
    public const string LiteralFatal = "fatal";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeFatal
    /// </summary>
    public const string LiteralAdverseEventOutcomeFatal = "http://hl7.org/fhir/adverse-event-outcome#fatal";

    /// <summary>
    /// Literal for code: Ongoing
    /// </summary>
    public const string LiteralOngoing = "ongoing";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeOngoing
    /// </summary>
    public const string LiteralAdverseEventOutcomeOngoing = "http://hl7.org/fhir/adverse-event-outcome#ongoing";

    /// <summary>
    /// Literal for code: Recovering
    /// </summary>
    public const string LiteralRecovering = "recovering";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeRecovering
    /// </summary>
    public const string LiteralAdverseEventOutcomeRecovering = "http://hl7.org/fhir/adverse-event-outcome#recovering";

    /// <summary>
    /// Literal for code: Resolved
    /// </summary>
    public const string LiteralResolved = "resolved";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeResolved
    /// </summary>
    public const string LiteralAdverseEventOutcomeResolved = "http://hl7.org/fhir/adverse-event-outcome#resolved";

    /// <summary>
    /// Literal for code: ResolvedWithSequelae
    /// </summary>
    public const string LiteralResolvedWithSequelae = "resolvedWithSequelae";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeResolvedWithSequelae
    /// </summary>
    public const string LiteralAdverseEventOutcomeResolvedWithSequelae = "http://hl7.org/fhir/adverse-event-outcome#resolvedWithSequelae";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: AdverseEventOutcomeUnknown
    /// </summary>
    public const string LiteralAdverseEventOutcomeUnknown = "http://hl7.org/fhir/adverse-event-outcome#unknown";

    /// <summary>
    /// Dictionary for looking up AdverseEventOutcome Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "fatal", Fatal }, 
      { "http://hl7.org/fhir/adverse-event-outcome#fatal", Fatal }, 
      { "ongoing", Ongoing }, 
      { "http://hl7.org/fhir/adverse-event-outcome#ongoing", Ongoing }, 
      { "recovering", Recovering }, 
      { "http://hl7.org/fhir/adverse-event-outcome#recovering", Recovering }, 
      { "resolved", Resolved }, 
      { "http://hl7.org/fhir/adverse-event-outcome#resolved", Resolved }, 
      { "resolvedWithSequelae", ResolvedWithSequelae }, 
      { "http://hl7.org/fhir/adverse-event-outcome#resolvedWithSequelae", ResolvedWithSequelae }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/adverse-event-outcome#unknown", Unknown }, 
    };
  };
}
