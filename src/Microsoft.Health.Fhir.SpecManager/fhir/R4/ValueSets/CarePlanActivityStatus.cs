// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes that reflect the current state of a care plan activity within its overall life cycle.
  /// </summary>
  public static class CarePlanActivityStatusCodes
  {
    /// <summary>
    /// The planned care plan activity has been withdrawn.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Care plan activity has been completed (more or less) as planned.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Care plan activity was entered in error and voided.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Care plan activity has been started but is not yet complete.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Care plan activity is planned but no action has yet been taken.
    /// </summary>
    public static readonly Coding NotStarted = new Coding
    {
      Code = "not-started",
      Display = "Not Started",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Care plan activity was started but has temporarily ceased with an expectation of resumption at a future time.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// Appointment or other booking has occurred but activity has not yet begun.
    /// </summary>
    public static readonly Coding Scheduled = new Coding
    {
      Code = "scheduled",
      Display = "Scheduled",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// The planned care plan activity has been ended prior to completion after the activity was started.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
    /// <summary>
    /// The current state of the care plan activity is not known.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, but the authoring/source system does not know which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/care-plan-activity-status"
    };
  };
}
