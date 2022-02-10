// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// DeviceDispense Status Codes
  /// </summary>
  public static class DevicedispenseStatusCodes
  {
    /// <summary>
    /// The dispensed product was not and will never be picked up by the patient.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The dispensed product has been picked up.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The dispense was declined and not performed.
    /// </summary>
    public static readonly Coding Declined = new Coding
    {
      Code = "declined",
      Display = "Declined",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The dispense was entered in error and therefore nullified.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The dispensed product is ready for pickup.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The dispense process is paused while waiting for an external event to reactivate the dispense.  For example, new stock has arrived or the prescriber has called.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The core event has not started yet, but some staging activities have begun (e.g. initial preparing of the device. Preparation stages may be tracked e.g. for planning, supply or billing purposes.
    /// </summary>
    public static readonly Coding Preparation = new Coding
    {
      Code = "preparation",
      Display = "Preparation",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// Actions implied by the dispense have been permanently halted, before all of them occurred.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };
    /// <summary>
    /// The authoring system does not know which of the status values applies for this dispense.  Note: this concept is not to be used for other - one of the listed statuses is presumed to apply, it's just now known which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/devicedispense-status"
    };

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: DevicedispenseStatusCancelled
    /// </summary>
    public const string LiteralDevicedispenseStatusCancelled = "http://terminology.hl7.org/CodeSystem/devicedispense-status#cancelled";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: DevicedispenseStatusCompleted
    /// </summary>
    public const string LiteralDevicedispenseStatusCompleted = "http://terminology.hl7.org/CodeSystem/devicedispense-status#completed";

    /// <summary>
    /// Literal for code: Declined
    /// </summary>
    public const string LiteralDeclined = "declined";

    /// <summary>
    /// Literal for code: DevicedispenseStatusDeclined
    /// </summary>
    public const string LiteralDevicedispenseStatusDeclined = "http://terminology.hl7.org/CodeSystem/devicedispense-status#declined";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: DevicedispenseStatusEnteredInError
    /// </summary>
    public const string LiteralDevicedispenseStatusEnteredInError = "http://terminology.hl7.org/CodeSystem/devicedispense-status#entered-in-error";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: DevicedispenseStatusInProgress
    /// </summary>
    public const string LiteralDevicedispenseStatusInProgress = "http://terminology.hl7.org/CodeSystem/devicedispense-status#in-progress";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: DevicedispenseStatusOnHold
    /// </summary>
    public const string LiteralDevicedispenseStatusOnHold = "http://terminology.hl7.org/CodeSystem/devicedispense-status#on-hold";

    /// <summary>
    /// Literal for code: Preparation
    /// </summary>
    public const string LiteralPreparation = "preparation";

    /// <summary>
    /// Literal for code: DevicedispenseStatusPreparation
    /// </summary>
    public const string LiteralDevicedispenseStatusPreparation = "http://terminology.hl7.org/CodeSystem/devicedispense-status#preparation";

    /// <summary>
    /// Literal for code: Stopped
    /// </summary>
    public const string LiteralStopped = "stopped";

    /// <summary>
    /// Literal for code: DevicedispenseStatusStopped
    /// </summary>
    public const string LiteralDevicedispenseStatusStopped = "http://terminology.hl7.org/CodeSystem/devicedispense-status#stopped";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: DevicedispenseStatusUnknown
    /// </summary>
    public const string LiteralDevicedispenseStatusUnknown = "http://terminology.hl7.org/CodeSystem/devicedispense-status#unknown";

    /// <summary>
    /// Dictionary for looking up DevicedispenseStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "cancelled", Cancelled }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#cancelled", Cancelled }, 
      { "completed", Completed }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#completed", Completed }, 
      { "declined", Declined }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#declined", Declined }, 
      { "entered-in-error", EnteredInError }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#entered-in-error", EnteredInError }, 
      { "in-progress", InProgress }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#in-progress", InProgress }, 
      { "on-hold", OnHold }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#on-hold", OnHold }, 
      { "preparation", Preparation }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#preparation", Preparation }, 
      { "stopped", Stopped }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#stopped", Stopped }, 
      { "unknown", Unknown }, 
      { "http://terminology.hl7.org/CodeSystem/devicedispense-status#unknown", Unknown }, 
    };
  };
}
