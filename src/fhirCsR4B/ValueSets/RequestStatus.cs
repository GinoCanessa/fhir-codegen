// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of a request.
  /// </summary>
  public static class RequestStatusCodes
  {
    /// <summary>
    /// The request is in force and ready to be acted upon.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The activity described by the request has been fully performed.  No further activity will occur.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request has been created but is not yet complete or ready for action.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// This request should never have existed and should be considered 'void'.  (It is possible that real-world decisions were based on it.  If real-world activity has occurred, the status should be "revoked" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request (and any implicit authorization to act) has been temporarily withdrawn but is expected to resume in the future.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request (and any implicit authorization to act) has been terminated prior to the known full completion of the intended actions.  No further activity should occur.
    /// </summary>
    public static readonly Coding Revoked = new Coding
    {
      Code = "revoked",
      Display = "Revoked",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this request.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply,  but the authoring/source system does not know which.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/request-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: RequestStatusActive
    /// </summary>
    public const string LiteralRequestStatusActive = "http://hl7.org/fhir/request-status#active";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: RequestStatusCompleted
    /// </summary>
    public const string LiteralRequestStatusCompleted = "http://hl7.org/fhir/request-status#completed";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: RequestStatusDraft
    /// </summary>
    public const string LiteralRequestStatusDraft = "http://hl7.org/fhir/request-status#draft";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: RequestStatusEnteredInError
    /// </summary>
    public const string LiteralRequestStatusEnteredInError = "http://hl7.org/fhir/request-status#entered-in-error";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: RequestStatusOnHold
    /// </summary>
    public const string LiteralRequestStatusOnHold = "http://hl7.org/fhir/request-status#on-hold";

    /// <summary>
    /// Literal for code: Revoked
    /// </summary>
    public const string LiteralRevoked = "revoked";

    /// <summary>
    /// Literal for code: RequestStatusRevoked
    /// </summary>
    public const string LiteralRequestStatusRevoked = "http://hl7.org/fhir/request-status#revoked";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: RequestStatusUnknown
    /// </summary>
    public const string LiteralRequestStatusUnknown = "http://hl7.org/fhir/request-status#unknown";

    /// <summary>
    /// Dictionary for looking up RequestStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/request-status#active", Active }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/request-status#completed", Completed }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/request-status#draft", Draft }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/request-status#entered-in-error", EnteredInError }, 
      { "on-hold", OnHold }, 
      { "http://hl7.org/fhir/request-status#on-hold", OnHold }, 
      { "revoked", Revoked }, 
      { "http://hl7.org/fhir/request-status#revoked", Revoked }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/request-status#unknown", Unknown }, 
    };
  };
}
