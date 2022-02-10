// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Current state of the encounter.
  /// </summary>
  public static class EncounterStatusCodes
  {
    /// <summary>
    /// The Patient is present for the encounter, however is not currently meeting with a practitioner.
    /// </summary>
    public static readonly Coding Arrived = new Coding
    {
      Code = "arrived",
      Display = "Arrived",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The Encounter has ended before it has begun.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// This instance should not have been part of this patient's medical record.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The Encounter has ended.
    /// </summary>
    public static readonly Coding Finished = new Coding
    {
      Code = "finished",
      Display = "Finished",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The Encounter has begun and the patient is present / the practitioner and the patient are meeting.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The Encounter has begun, but the patient is temporarily on leave.
    /// </summary>
    public static readonly Coding OnLeave = new Coding
    {
      Code = "onleave",
      Display = "On Leave",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The Encounter has not yet started.
    /// </summary>
    public static readonly Coding Planned = new Coding
    {
      Code = "planned",
      Display = "Planned",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The patient has been assessed for the priority of their treatment based on the severity of their condition.
    /// </summary>
    public static readonly Coding Triaged = new Coding
    {
      Code = "triaged",
      Display = "Triaged",
      System = "http://hl7.org/fhir/encounter-status"
    };
    /// <summary>
    /// The encounter status is unknown. Note that "unknown" is a value of last resort and every attempt should be made to provide a meaningful value other than "unknown".
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/encounter-status"
    };

    /// <summary>
    /// Literal for code: Arrived
    /// </summary>
    public const string LiteralArrived = "arrived";

    /// <summary>
    /// Literal for code: EncounterStatusArrived
    /// </summary>
    public const string LiteralEncounterStatusArrived = "http://hl7.org/fhir/encounter-status#arrived";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: EncounterStatusCancelled
    /// </summary>
    public const string LiteralEncounterStatusCancelled = "http://hl7.org/fhir/encounter-status#cancelled";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: EncounterStatusEnteredInError
    /// </summary>
    public const string LiteralEncounterStatusEnteredInError = "http://hl7.org/fhir/encounter-status#entered-in-error";

    /// <summary>
    /// Literal for code: Finished
    /// </summary>
    public const string LiteralFinished = "finished";

    /// <summary>
    /// Literal for code: EncounterStatusFinished
    /// </summary>
    public const string LiteralEncounterStatusFinished = "http://hl7.org/fhir/encounter-status#finished";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: EncounterStatusInProgress
    /// </summary>
    public const string LiteralEncounterStatusInProgress = "http://hl7.org/fhir/encounter-status#in-progress";

    /// <summary>
    /// Literal for code: OnLeave
    /// </summary>
    public const string LiteralOnLeave = "onleave";

    /// <summary>
    /// Literal for code: EncounterStatusOnLeave
    /// </summary>
    public const string LiteralEncounterStatusOnLeave = "http://hl7.org/fhir/encounter-status#onleave";

    /// <summary>
    /// Literal for code: Planned
    /// </summary>
    public const string LiteralPlanned = "planned";

    /// <summary>
    /// Literal for code: EncounterStatusPlanned
    /// </summary>
    public const string LiteralEncounterStatusPlanned = "http://hl7.org/fhir/encounter-status#planned";

    /// <summary>
    /// Literal for code: Triaged
    /// </summary>
    public const string LiteralTriaged = "triaged";

    /// <summary>
    /// Literal for code: EncounterStatusTriaged
    /// </summary>
    public const string LiteralEncounterStatusTriaged = "http://hl7.org/fhir/encounter-status#triaged";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: EncounterStatusUnknown
    /// </summary>
    public const string LiteralEncounterStatusUnknown = "http://hl7.org/fhir/encounter-status#unknown";

    /// <summary>
    /// Dictionary for looking up EncounterStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "arrived", Arrived }, 
      { "http://hl7.org/fhir/encounter-status#arrived", Arrived }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/encounter-status#cancelled", Cancelled }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/encounter-status#entered-in-error", EnteredInError }, 
      { "finished", Finished }, 
      { "http://hl7.org/fhir/encounter-status#finished", Finished }, 
      { "in-progress", InProgress }, 
      { "http://hl7.org/fhir/encounter-status#in-progress", InProgress }, 
      { "onleave", OnLeave }, 
      { "http://hl7.org/fhir/encounter-status#onleave", OnLeave }, 
      { "planned", Planned }, 
      { "http://hl7.org/fhir/encounter-status#planned", Planned }, 
      { "triaged", Triaged }, 
      { "http://hl7.org/fhir/encounter-status#triaged", Triaged }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/encounter-status#unknown", Unknown }, 
    };
  };
}
